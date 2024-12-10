using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace Tierheimverwaltung.VerVer
{
    public class DBVerVer
    {
        
        //Achtung: Tablle heißt in DB "vertaeglichkeit ohne r und muss noch geändert weden"
        
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
            string sql = "CALL ReadVerVerGrid();"; 
        
        
            try
            {
                Verbinden();
                command = new MySqlCommand(sql, connection);
        
        
                adapter = new MySqlDataAdapter(command);
                dataset = new DataSet();
                adapter.Fill(dataset);
                return dataset;
                
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
        
        
        public static VerVer ReadOneID()
        {
        
            string sql = "SELECT * FROM verhalten_vertaeglichkeit WHERE stammtierdaten_id=@stammtierdaten_id;";
            
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
                    
                    string verhalten_notizen = reader["verhalten_notizen"].ToString();
                    string vertraeglichkeit_notizen = reader["verhalten_notizen"].ToString();
                    int zustPerson_id = Convert.ToInt32(reader["zustPerson_id"]);
                    string pate = reader["pate"].ToString();
                   
                    
                    VerVer aktuellesVerVer = new VerVer(stammtierdaten_id, verhalten_notizen, vertraeglichkeit_notizen,
                        zustPerson_id, pate);
                    
                    return aktuellesVerVer;
        
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

        public static void Create(VerVer verVer)
        {

            try
            {
                Verbinden();


                string sql = "CALL CreateVerVer(@stammtierdaten_id, @verhalten_notizen, @vertraeglichkeit_notizen, @zustPerson_id , @Pate);";
                MySqlCommand command = new MySqlCommand(sql, connection);
                
                
                
                command.Parameters.AddWithValue("@stammtierdaten_id", verVer.Stammtierdaten_id);
                command.Parameters.AddWithValue("@verhalten_notizen", verVer.VerhaltenNo);
                command.Parameters.AddWithValue("@vertraeglichkeit_notizen", verVer.VertraeglichkeitNo);
                command.Parameters.AddWithValue("@zustPerson_id ", verVer.ZustPerson_id );
                command.Parameters.AddWithValue("@Pate", verVer.Pate1);
               
                
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

        public static void UpdateVerVer(VerVer verVer)
        {
            try
            {
                Verbinden();
                string sql =
                    "CALL UpdateVerVer(@stammtierdaten_id, @verhalten_notizen, @vertraeglichkeit_notizen, @zustPerson_id , @Pate);";
                MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("@stammtierdaten_id", verVer.Stammtierdaten_id);
                command.Parameters.AddWithValue("@verhalten_notizen", verVer.VerhaltenNo);
                command.Parameters.AddWithValue("@vertraeglichkeit_notizen", verVer.VertraeglichkeitNo);
                command.Parameters.AddWithValue("@zustPerson_id", verVer.ZustPerson_id );
                command.Parameters.AddWithValue("@Pate", verVer.Pate1);

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

                string sql = "CALL DeleteVerVerViaID(@stammtierdaten_id);";
            
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