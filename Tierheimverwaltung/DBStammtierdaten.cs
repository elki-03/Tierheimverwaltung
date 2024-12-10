using System;
using MySqlConnector;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace Tierheimverwaltung
{
    public class DBStammtierdaten
    {
        
        //Attribute

        public static string connectionString = "Server = 127.0.0.1; Database=tierheim; User=root; Password=;";

        public static MySqlConnection connection;
        public static MySqlCommand command;
        public static DataSet dataset;
        public static MySqlDataAdapter adapter;
        public int stammtierdatenID;
        
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
            string sql = "CALL ReadStammtierdatenGrid();"; //Parameter sind ggfs schon drn außerdem Sicherheit!!
        
        
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
        
        
        
        
        
        public static Stammtierdaten ReadOneID()
        {

            string sql = "SELECT * FROM stammtierdaten WHERE stammtierdatenID=@id;";
            
            try
            {
                Verbinden();
                 command = new MySqlCommand(sql, connection);
                 command.Parameters.AddWithValue("@id", GlobalVariables.idStammtier);//globale variable
                //adapter = new MySqlDataAdapter(command);
                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   

                    int stammtierdatenID = Convert.ToInt32(reader["stammtierdatenID"]);
                    string tiername = reader["tiername"].ToString();
                    string tierart = reader["tierart"].ToString();
                    string rasse = reader["rasse"].ToString();
                    string beschreibung = reader["beschreibung"].ToString();
                    string geschlecht = reader["geschlecht"].ToString();
                    bool kastriert = Convert.ToBoolean(reader["kastriert"]);
                    double groesse = Convert.ToDouble(reader["groesse"]);
                    double gewicht = Convert.ToDouble(reader["gewicht"]);
                    string geburtstag = reader["geburtstag"].ToString();
                    string geburtsort = reader["geburtsort"].ToString();
                    string todestag = reader["todestag"].ToString();
                    string todesursache = reader["todesursache"].ToString();
                    string ort = reader["ort"].ToString();
                    string notizen = reader["notizenStammtierdaten"].ToString();

                    
                    Stammtierdaten aktuelleStammtierdaten = new Stammtierdaten(stammtierdatenID, tiername, tierart,
                        rasse, beschreibung, geschlecht, kastriert, groesse, gewicht, geburtstag, geburtsort, todestag,
                        todesursache, ort, notizen);

                    
                    
                    return aktuelleStammtierdaten;

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

        public static void Create(Stammtierdaten stammtierdaten)
        {

            try
            {
                Verbinden();


                string sql = "CALL `CreateStammtier`(@tiername, @tierart, @rasse, @beschreibung, @geschlecht, @kastriert, @groesse, @gewicht, @geburtstag, @geburtsort, @todestag, @todesursache, @ort, @notizenStammtierdaten, @stammtierdatenID);";
                
                // string sql = "INSERT INTO stammtierdaten(" +
                //              "tiername, tierart, rasse, beschreibung, geschlecht, kastriert, groesse, gewicht, geburtstag, geburtsort, todestag, todesursache, ort, notizenStammtierdaten) " +
                //              "VALUES (@tiername, @tierart, @rasse, @beschreibung, @geschlecht, @kastriert, @groesse, @gewicht, @geburtstag, @geburtsort, @todestag, @todesursache, @ort, @notizen, @stammtierdatenID);";
                //
                
                //To-Do: als Prozedur anlegen Begin end immer, untere parameter@brauchen wir leider trotzdem
                    
                    
                MySqlCommand command = new MySqlCommand(sql, connection);
                
                
                
                command.Parameters.AddWithValue("@tiername", stammtierdaten.Tiername);
                command.Parameters.AddWithValue("@tierart", stammtierdaten.Tierart);
                command.Parameters.AddWithValue("@rasse", stammtierdaten.Rasse);
                command.Parameters.AddWithValue("@beschreibung", stammtierdaten.Beschreibung);
                command.Parameters.AddWithValue("@geschlecht", stammtierdaten.Geschlecht);
                command.Parameters.AddWithValue("@kastriert", stammtierdaten.Kastriert);
                command.Parameters.AddWithValue("@groesse", stammtierdaten.Groesse);
                command.Parameters.AddWithValue("@gewicht", stammtierdaten.Gewicht);
                command.Parameters.AddWithValue("@geburtstag", stammtierdaten.Geburtstag);
                command.Parameters.AddWithValue("@geburtsort", stammtierdaten.Geburtsort);
                command.Parameters.AddWithValue("@todestag", stammtierdaten.Todestag);
                command.Parameters.AddWithValue("@todesursache", stammtierdaten.Todesursache);
                command.Parameters.AddWithValue("@ort", stammtierdaten.Ort);
                command.Parameters.AddWithValue("@notizenStammtierdaten", stammtierdaten.Notizen);
                command.Parameters.AddWithValue("@stammtierdatenID", stammtierdaten.StammtierdatenId);
                
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

        public static void UpdateStammtier(Stammtierdaten stammtierdaten)
        {
            try
            {
                Verbinden();
                string sql =
                    "CALL UpdateStammtier (@tiername, @tierart, @rasse, @beschreibung, @geschlecht,@kastriert, @groesse, @gewicht, @geburtstag, @geburtsort, @todestag, @todesursache, @ort, @notizen, @stammtierdatenID);";
                MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("@stammtierdatenID", stammtierdaten.StammtierdatenId);
                command.Parameters.AddWithValue("@tiername", stammtierdaten.Tiername);
                command.Parameters.AddWithValue("@tierart", stammtierdaten.Tierart);
                command.Parameters.AddWithValue("@rasse", stammtierdaten.Rasse);
                command.Parameters.AddWithValue("@beschreibung", stammtierdaten.Beschreibung);
                command.Parameters.AddWithValue("@geschlecht", stammtierdaten.Geschlecht);
                command.Parameters.AddWithValue("@kastriert", stammtierdaten.Kastriert);
                command.Parameters.AddWithValue("@groesse", stammtierdaten.Groesse);
                command.Parameters.AddWithValue("@gewicht", stammtierdaten.Gewicht);
                command.Parameters.AddWithValue("@geburtstag", stammtierdaten.Geburtstag);
                command.Parameters.AddWithValue("@geburtsort", stammtierdaten.Geburtsort);
                command.Parameters.AddWithValue("@todestag", stammtierdaten.Todestag);
                command.Parameters.AddWithValue("@todesursache", stammtierdaten.Todesursache);
                command.Parameters.AddWithValue("@ort", stammtierdaten.Ort);
                command.Parameters.AddWithValue("@notizen", stammtierdaten.Notizen);




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

                string sql = "CALL DeleteStammtierViaID(@stammtierdatenID);";
            
                MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("@stammtierdatenID", id);
                
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