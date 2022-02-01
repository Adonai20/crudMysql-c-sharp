using System.Text;
using MySql.Data.MySqlClient;
using capaEntidad;
using System.Data;

namespace capaDatos

{
    public class datos_Cliente
    {
        //Connection
        string stringConnection = "Server= localhost;User =Jarod; Password=123;Port=3306;database = crud_c#;";

        public void connectionMysql()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(stringConnection);

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectaser" + ex.Message);
                return;
            }
            mySqlConnection.Close();
            MessageBox.Show("Conectado");   
        }
        //Instrucction SQL and execute SQL
        public void createRegister(entidad_Cliente CE)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(stringConnection);
            mySqlConnection.Open();
            string query = "INSERT INTO `productos`(`name`,`last_name`,`photo`) VALUES ('" + CE.name + "','" + CE.lastname + "','" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(CE.photo) + "');"; 
            MySqlCommand mysqlCommand = new MySqlCommand(query,mySqlConnection);
            mysqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("New Record Succesfully ");
        }

        public DataSet userRead()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(stringConnection);
            mySqlConnection.Open();
            string query = "SELECT * FROM `productos` LIMIT 1000;";
            MySqlDataAdapter adapter;
            DataSet set = new DataSet();
            adapter = new MySqlDataAdapter(query, mySqlConnection);
            adapter.Fill(set, "tbl");
            return set;

        }

        public void  userUpdate (entidad_Cliente CE)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(stringConnection);
            mySqlConnection.Open();
            string query = "UPDATE `productos` SET `name` = '" + CE.name + "', `last_name` = '" + CE.lastname + "', `photo` = '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(CE.photo) + "' WHERE `productos`.`id` = "+CE.id+";";
            MySqlCommand mysqlCommand = new MySqlCommand(query, mySqlConnection);
            mysqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Record Update!");
        }   

        public void userDelete(entidad_Cliente CE)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(stringConnection);
            mySqlConnection.Open();
            string query = "DELETE FROM `productos` WHERE `productos`.`id` = '"+CE.id+"';"; 
            MySqlCommand mysqlCommand = new MySqlCommand(query, mySqlConnection);
            mysqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Record Delete!"); 
        }
    }
}