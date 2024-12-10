using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace Tierheimverwaltung.MedAkte
{
    public class DBMedAkte
    {
        
        
        //Attribute

        public static string connectionString = "Server = 127.0.0.1; Database=tierheim; User=root; Password=;";

        public static MySqlConnection connection;
        public static MySqlCommand command;
        public static DataSet dataset;
        public static MySqlDataAdapter adapter;
        
        
        public static void Verbinden()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Verbindung hat geklappt, yayyy!!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Verbindung hat nicht geklappt, oh nooooo!!");
                throw;
            }
          

        }
        
        
        //CRUD Operationen
        
        //READ --->> ändern in MedAkte
        
        
        public static DataSet ReadAllGrid()
        {
            string sql = "CALL ReadMedAkteGrid();"; 
        
        
            try
            {
                Verbinden();
                command = new MySqlCommand(sql, connection);
        
        
                adapter = new MySqlDataAdapter(command);
                dataset = new DataSet();
                adapter.Fill(dataset);
                return dataset;
        
                //dataGridView1.DataSource = dataset.Tables[0]; //von hier -->
                //MessageBox.Show("Verbindung erfolgreich");
            }
        
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } finally
            {
                connection.Close();
            }
           
        
            return null;
        }
        
        
        
        
        
        public static MedAkte ReadOneID()
        {
        
            string sql = "SELECT * FROM medizinische_akte WHERE stammtierdaten_id=@stammtierdaten_id;";
            
            try
            {
                Verbinden();
                 command = new MySqlCommand(sql, connection);
                 command.Parameters.AddWithValue("@stammtierdaten_id", GlobalVariables.idStammtier);//globale variable
                //adapter = new MySqlDataAdapter(command);
                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   
        
                    int stammtierdaten_id = Convert.ToInt32(reader["stammtierdaten_id"]);
                    //string medizinische_akteID = reader["medizinische_aktID"].ToString();
                    string diagnose = reader["diagnose"].ToString();
                    string behandlungen = reader["behandlungen"].ToString();
                    string behandlungenLangFr= reader["behandlungenLangFr"].ToString();
                    string impfungen = reader["impfungen"].ToString();
                    string medikamente = reader["medikamente"].ToString();
                    double gewichtsverlauf = Convert.ToDouble(reader["gewichtsverlauf"]);
                    string dokumente = reader["dokumente"].ToString(); //pfad
        
                    
                    MedAkte aktuelleMedAkte = new MedAkte(stammtierdaten_id, diagnose, behandlungen,
                        behandlungenLangFr, impfungen, medikamente, gewichtsverlauf, dokumente);
        
                    
                    
                    return aktuelleMedAkte;
        
                }
        
               
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } finally
            {
                connection.Close();
            }
        
            return null;
        }

        //CREATE

        public static void Create(MedAkte medAkte)
        {

            try
            {
                Verbinden();


                string sql = "CALL CreateMedAkte(@stammtierdaten_id, @diagnose, @behandlungen, @behandlungenLangFr, @impfungen, @medikamente, @gewichtsverlauf, @dokumente);";
                MySqlCommand command = new MySqlCommand(sql, connection);
                
                
                
                command.Parameters.AddWithValue("@stammtierdaten_id", medAkte.Stammtierdaten_id);
                command.Parameters.AddWithValue("@diagnose", medAkte.Diagnose);
                command.Parameters.AddWithValue("@behandlungen", medAkte.Behandlungen);
                command.Parameters.AddWithValue("@behandlungenLangFr", medAkte.BehandlungLangFr);//
                command.Parameters.AddWithValue("@impfungen", medAkte.Impfungen);
                command.Parameters.AddWithValue("@medikamente", medAkte.Medikamente);
                command.Parameters.AddWithValue("@gewichtsverlauf", medAkte.Gewichtsverlauf);
                command.Parameters.AddWithValue("@dokumente", medAkte.Dokumente);
                
                command.ExecuteNonQuery();
                MessageBox.Show("Daten wurden eingefügt!");

            }
            catch (Exception e)
            {
                MessageBox.Show("Produkt konnte nicht eingefügt werden");
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //UPDATE

        public static void UpdateMedAkte(MedAkte medAkte)
        {
            try
            {
                Verbinden();
                string sql =
                    "CALL UpdateMedAkte(@stammtierdaten_id, @diagnose, @behandlungen, @behandlungenLangFr, @impfungen, @medikamente, @gewichtsverlauf, @dokumente);";
                MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("@stammtierdaten_id", medAkte.Stammtierdaten_id);
                command.Parameters.AddWithValue("@diagnose", medAkte.Diagnose);
                command.Parameters.AddWithValue("@behandlungen", medAkte.Behandlungen);
                command.Parameters.AddWithValue("@behandlungenLangFr", medAkte.BehandlungLangFr);
                command.Parameters.AddWithValue("@impfungen", medAkte.Impfungen);
                command.Parameters.AddWithValue("@medikamente", medAkte.Medikamente);
                command.Parameters.AddWithValue("@gewichtsverlauf", medAkte.Gewichtsverlauf);
                command.Parameters.AddWithValue("@dokumente", medAkte.Dokumente);
                //command.Parameters.AddWithValue("@stammtierdatenID", Stammtierdaten.stammtierdaten.StammtierdatenID);
                //mit oder ohne?
                




                command.ExecuteNonQuery();
                MessageBox.Show("Daten wurden verändert!");

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        
        
        //DELETE


        public static void Delete(int id)
        {
            try
            {
                Verbinden();

                string sql = "CALL DeleteMedAkteViaID(@stammtierdaten_id);";
            
                MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("@stammtierdaten_id", id);
                
                command.ExecuteNonQuery();
                MessageBox.Show("Daten wurden gelöscht");
                
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        
        
        
    }
}