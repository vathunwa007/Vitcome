using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using netcore.Models;

namespace netcore.Models
{
    public class Connectdb
    {
        private MySqlConnection objConn;
        private MySqlCommand objCmd;
        private MySqlTransaction Trans;
        private String strConnString;

        public string ConnectionString { get; set; }

        public Connectdb(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Techer> GetAllTecher()
        {
            List<Techer> list = new List<Techer>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM techer", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Techer()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Skill = reader.GetString("Skill"),
                            Status = reader.GetInt32("Status")
                        });
                    }
                }
            }

            return list;
        }
     
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public void Register(Register regis) {

            String strSQL;
            MySqlConnection conn = GetConnection();
            MySqlCommand objCmd = new MySqlCommand();

            strSQL = "INSERT INTO `student`(`idstudent`,`password`,`username`,`lastname`,`year`,`email`,`telephone`) VALUES ('" + regis.idstudent+"','"+regis.password + "','"+ regis.name + "','"+regis.suranme + "','"+regis.year + "','"+regis.email + "','"+regis.telnumber+"');";

            conn.Open();
            objCmd.Connection = conn;
            objCmd.CommandText = strSQL;
            objCmd.CommandType = CommandType.Text;

            try
            {
                objCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

               throw e;
            }

            conn.Close();

        }
       public void Savecs1(FormCs1Model result)
        {

            String strSQL;
            MySqlConnection conn = GetConnection();
            MySqlCommand objCmd = new MySqlCommand();

            strSQL = "INSERT INTO `savecs1`(`name`,`lastname`,`idstudent`,`sector`,`title`,`titleEng`,`importance`,`objective`,`reasoning`,`timeimage`,`scope`,`studentid`) VALUES" +
                " ('" + result.name + "','" + result.lastname + "','" + result.idstudent + "','" + result.sector + "','" + result.title+ "','" + result.titleEng + "','" + result.importance + "','"+ result.objective+"','"+ result.reasoning+"','"+ result.timeimage+"','"+ result.scope+ "','32'); ";

            conn.Open();
            objCmd.Connection = conn;
            objCmd.CommandText = strSQL;
            objCmd.CommandType = CommandType.Text;

            try
            {
                objCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw e;
            }

            conn.Close();

        }
        public string login(string idstudent,string password) {
            string check = "login";
            String strSQL;
            MySqlConnection conn = GetConnection();
            MySqlCommand objCmd = new MySqlCommand();

            strSQL = "SELECT * FROM `student` WHERE `idstudent` = '" + idstudent + "'";

            conn.Open();
            objCmd.Connection = conn;
            objCmd.CommandText = strSQL;
            objCmd.CommandType = CommandType.Text;
            //MySqlDataReader reader = objCmd.ExecuteReader();
            objCmd.ExecuteReader();


            try
            {
                objCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw e;
            }

            return null;
        }

        //------------------//

        public void Addformteacher(Addfromteacher result)
        {

            String strSQL;
            MySqlConnection conn = GetConnection();
            MySqlCommand objCmd = new MySqlCommand();

            strSQL = "INSERT INTO `sendform`(`Name`,`Form`) VALUES" +
                " ('" + result.Name + "','" + result.Form + "'); ";

            conn.Open();
            objCmd.Connection = conn;
            objCmd.CommandText = strSQL;
            objCmd.CommandType = CommandType.Text;

            try
            {
                objCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw e;
            }

            conn.Close();

        }



        internal class Models
        {
        }
        //-------------------------------------------------------------------------------------------
        public MySqlDataReader QueryDataReader(String strSQL)
        {
            MySqlDataReader dtReader;
            objConn = new MySqlConnection();
            objConn.ConnectionString = ConnectionString;
            objConn.Open();

            objCmd = new MySqlCommand(strSQL, objConn);
            dtReader = objCmd.ExecuteReader();
            return dtReader; //*** Return DataReader ***//
        }

        public DataSet QueryDataSet(String strSQL)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter dtAdapter = new MySqlDataAdapter();
            objConn = new MySqlConnection();
            objConn.ConnectionString = ConnectionString;
            objConn.Open();

            objCmd = new MySqlCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = strSQL;
            objCmd.CommandType = CommandType.Text;

            dtAdapter.SelectCommand = objCmd;
            dtAdapter.Fill(ds);
            return ds;   //*** Return DataSet ***//
        }

        public DataTable QueryDataTable(String strSQL)
        {
            MySqlDataAdapter dtAdapter;
            DataTable dt = new DataTable();
            objConn = new MySqlConnection();
            objConn.ConnectionString = ConnectionString;
            objConn.Open();

            dtAdapter = new MySqlDataAdapter(strSQL, objConn);
            dtAdapter.Fill(dt);
            return dt; //*** Return DataTable ***//
        }

        public Boolean QueryExecuteNonQuery(String strSQL)
        {
            objConn = new MySqlConnection();
            objConn.ConnectionString = ConnectionString;
            objConn.Open();

            try
            {
                objCmd = new MySqlCommand();
                objCmd.Connection = objConn;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = strSQL;

                objCmd.ExecuteNonQuery();
                return true; //*** Return True ***//
            }
            catch (Exception)
            {
                return false; //*** Return False ***//
            }
        }


        public Object QueryExecuteScalar(String strSQL)
        {
            Object obj;
            objConn = new MySqlConnection();
            objConn.ConnectionString = ConnectionString;
            objConn.Open();

            try
            {
                objCmd = new MySqlCommand();
                objCmd.Connection = objConn;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = strSQL;

                obj = objCmd.ExecuteScalar();  //*** Return Scalar ***//
                return obj;
            }
            catch (Exception)
            {
                return null; //*** Return Nothing ***//
            }
        }

        public void TransStart()
        {
            objConn = new MySqlConnection();
            objConn.ConnectionString = ConnectionString;
            objConn.Open();
            Trans = objConn.BeginTransaction(IsolationLevel.ReadCommitted);
        }


        public void TransExecute(String strSQL)
        {
            objCmd = new MySqlCommand();
            objCmd.Connection = objConn;
            objCmd.Transaction = Trans;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = strSQL;
            objCmd.ExecuteNonQuery();
        }


        public void TransRollBack()
        {
            Trans.Rollback();
        }

        public void TransCommit()
        {
            Trans.Commit();
        }

        public void Close()
        {
            objConn.Close();
            objConn = null;
        }
    }

}
