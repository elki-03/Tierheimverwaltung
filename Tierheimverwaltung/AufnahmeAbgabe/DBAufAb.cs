using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace Tierheimverwaltung.AufnahmeAbgabe
{
    public class DBAufAb
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
            string sql = "CALL AufAbGrid();"; 
        
        
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
        
        
        public static AufAb ReadOneID()
        {
        
            string sql = "SELECT * FROM aufnahme_abgabe WHERE stammtierdaten_id=@stammtierdaten_id;";
            
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
                    int aufnahmePerson_id = Convert.ToInt32(reader["aufnahmePerson_id"]);
                    bool vorbesitzer = Convert.ToBoolean(reader["vorbesitzer"]);
                    bool fundtier = Convert.ToBoolean(reader["fundtier"]);
                    string aufnahmeort = reader["aufnahmeort"].ToString();
                    string aufnahmedatum = reader["aufnahmedatum"].ToString();
                    string aufnahmegrund = reader["aufnahmegrund"].ToString();
                    string aufnahmenotizen = reader["aufnahmenotizen"].ToString();
                    string abgabedatum = reader["abgabedatum"].ToString();
                    int abgabePerson_id = Convert.ToInt32(reader["abgabePerson_id"]);
                    string abgabePersonVorkontrolle = reader["abgabePersonVorkontrolle"].ToString();
                    string abgabePersonNachkontrolle = reader["abgabePersonNachkontrolle"].ToString();
                    string abgabeNotizen = reader["abgabeNotizen"].ToString();
                 
                   
                    
                    AufAb aktuelleAufAb = new AufAb(stammtierdaten_id, aufnahmePerson_id, vorbesitzer,
                        fundtier, aufnahmeort, aufnahmedatum, aufnahmegrund, aufnahmenotizen, abgabedatum, abgabePerson_id, abgabePersonVorkontrolle, abgabePersonNachkontrolle, abgabeNotizen);
                    
                    return aktuelleAufAb;
        
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

        public static void Create(AufAb aufAb)
        {

            try
            {
                Verbinden();


                string sql = "CALL CreateAufAb(@stammtierdaten_id, @aufnahmePerson_ID, @vorbesitzer, @fundtier , @aufnahmeort, @aufnahmedatum, @aufnehmegrund, @aufnahmenotizen, @abgabedatum, @abgabePerson_id, @abgabePersonVorkontrolle, @abgabePersonNachkontrolle, @abgabeNotizen);";
                MySqlCommand command = new MySqlCommand(sql, connection);
                
                
                
                command.Parameters.AddWithValue("@stammtierdaten_id", aufAb.Stammtierdaten_id);
                command.Parameters.AddWithValue("@aufnahmePerson_ID", aufAb.AufnahmePerson_id);
                command.Parameters.AddWithValue("@vorbesitzer", aufAb.Vorbesitzer);
                command.Parameters.AddWithValue("@fundtier", aufAb.Fundtier);
                command.Parameters.AddWithValue("@aufnahmeort", aufAb.Aufnahmeort);
                command.Parameters.AddWithValue("@aufnahmedatum", aufAb.Aufnahmedatum);
                command.Parameters.AddWithValue("@aufnehmegrund", aufAb.Aufnahmedatum);
                command.Parameters.AddWithValue("@aufnahmenotizen", aufAb.Aufnahmenotizen);
                command.Parameters.AddWithValue("@abgabedatum", aufAb.Abgabedatum);
                command.Parameters.AddWithValue("@abgabePerson_id", aufAb.AbgabePerson_id);
                command.Parameters.AddWithValue("@abgabePersonVorkontrolle", aufAb.AbgabePersonVorkontrolle);
                command.Parameters.AddWithValue("@abgabePersonNachkontrolle", aufAb.AbgabePersonNachkontrolle);
                command.Parameters.AddWithValue("@abgabeNotizen", aufAb.AbgabeNotizen);
                
                command.ExecuteNonQuery();
                MessageBox.Show("Daten wurden eingefügt!");

            }
            catch (MySqlException e)
            {
               // MessageBox.Show("Produkt konnte nicht eingefügt werden");
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //UPDATE

        public static void UpdateAufAb(AufAb aufAb)
        {
            try
            {
                Verbinden();
                string sql =
                    "CALL UpdateAufAb(@stammtierdaten_id, @aufnahmePerson_id, @vorbesitzer, @fundtier , @aufnahmeort, @aufnahmedatum, @aufnehmegrund, @aufnahmenotizen, @abgabedatum, @abgabePerson_id, @abgabePersonVorkontrolle, @abgabePersonNachkontrolle, @abgabeNotizen);";

                MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("@stammtierdaten_id", aufAb.Stammtierdaten_id);
                command.Parameters.AddWithValue("@aufnahmePerson_id", aufAb.AufnahmePerson_id);
                command.Parameters.AddWithValue("@vorbesitzer", aufAb.Vorbesitzer);
                command.Parameters.AddWithValue("@fundtier", aufAb.Fundtier);
                command.Parameters.AddWithValue("@aufnahmeort", aufAb.Aufnahmeort);
                command.Parameters.AddWithValue("@aufnahmedatum", aufAb.Aufnahmedatum);
                command.Parameters.AddWithValue("@aufnehmegrund", aufAb.Aufnahmedatum);
                command.Parameters.AddWithValue("@aufnahmenotizen", aufAb.Aufnahmenotizen);
                command.Parameters.AddWithValue("@abgabedatum", aufAb.Abgabedatum);
                command.Parameters.AddWithValue("@abgabePerson_id", aufAb.AbgabePerson_id);
                command.Parameters.AddWithValue("@abgabePersonVorkontrolle", aufAb.AbgabePersonVorkontrolle);
                command.Parameters.AddWithValue("@abgabePersonNachkontrolle", aufAb.AbgabePersonNachkontrolle);
                command.Parameters.AddWithValue("@abgabeNotizen", aufAb.AbgabeNotizen);

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

                string sql = "CALL DeleteAufAbViaID(@stammtierdaten_id);";
            
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