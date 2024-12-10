using System;
using MySqlConnector;
using System.Data;

using System.Windows.Forms;

namespace Tierheimverwaltung.Kennzeichnung
{
    public class DBKennzeichnung
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
        
        //READ 
        
        
        public static DataSet ReadAllGrid()
        {
            string sql = "CALL ReadTierkennzeichnungGrid();"; //Parameter sind ggfs schon drn außerdem Sicherheit!!
        
        
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


        public static Kennzeichnung ReadOneID()
        {
        
            string sql = "SELECT * FROM tierkennzeichnung WHERE stammtierdaten_id=@id;";
            
            try
            {
                Verbinden();
                 command = new MySqlCommand(sql, connection);
                 command.Parameters.AddWithValue("@id", GlobalVariables.idStammtier);//globale variable
                //adapter = new MySqlDataAdapter(command);
                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int stammtierdaten_id = Convert.ToInt32(reader["stammtierdaten_id"]);
                    //int tierkennzeichnungID = Convert.ToInt32(reader["tierkennzeichnung_id"]);
                    int chipNr = Convert.ToInt32(reader["chipNr"]);
                    int tatooNr = Convert.ToInt32(reader["tatooNr"]);
                    int ringNr = Convert.ToInt32(reader["ringNr"]);
                    int ausweisNr = Convert.ToInt32(reader["ausweisNr"]);


                    Kennzeichnung aktuelleKennzeichnung = new Kennzeichnung(stammtierdaten_id, chipNr, tatooNr, ringNr, ausweisNr);

                    return aktuelleKennzeichnung;
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
        
        
            
            public static void Create(Kennzeichnung kennzeichnung)
        {

            try
            {
                Verbinden();


                string sql = "CALL CreateKennzeichnung(@stammtierdaten_id, @chipNr, @tatooNr, @ringNr, @ausweisNr);";

                MySqlCommand command = new MySqlCommand(sql, connection);
                
                
                
                command.Parameters.AddWithValue("@stammtierdaten_id", kennzeichnung.Stammtierdaten_id);
                command.Parameters.AddWithValue("@chipNr", kennzeichnung.ChipNr);
                command.Parameters.AddWithValue("@tatooNr", kennzeichnung.TatooNr);
                command.Parameters.AddWithValue("@ringNr", kennzeichnung.RingNr);
                command.Parameters.AddWithValue("@ausweisNr", kennzeichnung.AusweisNr);
                
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

        public static void UpdateKennz(Kennzeichnung kennzeichnung)
        {
            try
            {
                Verbinden();
                string sql =
                    "CALL UpdateKennz (@stammtierdaten_id, @chipNr, @tatooNr, @ringNr, @ausweisNr);";
                MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("@stammtierdaten_id", kennzeichnung.Stammtierdaten_id);
                command.Parameters.AddWithValue("@chipNr", kennzeichnung.ChipNr);
                command.Parameters.AddWithValue("@tatooNr", kennzeichnung.TatooNr);
                command.Parameters.AddWithValue("@ringNr", kennzeichnung.RingNr);
                command.Parameters.AddWithValue("@ausweisNr", kennzeichnung.AusweisNr);
                

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

                string sql = "CALL DeleteKennzViaID(@stammtierdaten_id);";
            
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