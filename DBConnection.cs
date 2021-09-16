using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql.Data.MySqlClient

{
    class DBConnection
    {
        static public DataTable dtUsers = new DataTable();
        static string connectionString = @"Database = Test; Data Source = localhost; 
        UserID = root; Password = qwerty ";
        static MySqlConnection msConnect;
        static MySqlCommand msCommand;
        static public MySqlDataAdapter msDataAdapter;
        static public bool Connect()
        {
            try
            {
                msConnect = new MySqlConnection(connectionString);
                msConnect.Open(); 
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            } 	
            catch (Exception ex)
            {
                //вывод сообщения 
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
                return false;
            } 
        }

            //отключение соединения с БД 
            static public void Close()
        {
            msConnect.Close();
        }
        static public string User; //логин авторизованного пользователя 
       

        static public void Authorization(string login, string password)
        {
            try
            {
                string sql = "SELECT Id FROM agents WHERE FirstName = '" + login + "' AND Id = '" + password + "' ;";
                msCommand.CommandText = sql;
                Object result = msCommand.ExecuteScalar();
                if (result != null)
                {
                    User = login;
                }
                else
                {
                    User = null;
                }
            }
            catch (Exception ex)      //при возникновении ошибки 
            {
                User = null; //обнуляем значения полей 
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        static public void AuthorizationADM(string login, string password)
        {
            try
            {
                string sqlADM = "SELECT Id FROM agents WHERE FirstName = '" + login + "' AND Id = '" + password + "' ;";
                msCommand.CommandText = sqlADM;
                Object result = msCommand.ExecuteScalar();
                if (result != null)
                {
                    User = login;
                }
                else
                {
                    User = null;
                }
            }
            catch (Exception ex)      //при возникновении ошибки 
            {
                User = null; //обнуляем значения полей 
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
      
        }

        static public void GetUserListAgents()
        {
            msCommand.CommandText = "SELECT * FROM agents";
            dtUsers.Clear();
            msDataAdapter.Fill(dtUsers);
        }
        static public void GetUserListClients()
        {
            msCommand.CommandText = "SELECT * FROM clients";
            dtUsers.Clear();
            msDataAdapter.Fill(dtUsers);

        }
        static public void addUser(string login, string pass)
        {
            msCommand.CommandText = $"InSERT into  clients (MiddleName, Id) Values ('{login}', '{pass}');";
            msCommand.ExecuteScalar();
            msCommand.CommandText = $"SELECT * from clients";
            msCommand.ExecuteScalar();
            dtUsers.Clear(); 
            msDataAdapter.Fill(dtUsers);

        }
     /*     static public void editUser(string login)
        {
            msCommand.CommandText = $"InSERT into  clients (MiddleName, Id) Values ('{login}', '{pass}');";
            msCommand.ExecuteScalar();
            msCommand.CommandText = $"SELECT * from clients";
            msCommand.ExecuteScalar();
            dtUsers.Clear();
            msDataAdapter.Fill(dtUsers);

        }*/
    }


}

