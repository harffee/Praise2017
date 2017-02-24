using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Praise2017.Models
{
    public class SqlDB

    {

        protected SqlConnection conn;

        
        //打开连接

        public bool OpenConnection()

        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EFDbContext"].ConnectionString);
            
            try

            {

                bool result = true;

                if (conn.State.ToString() != "Open")

                {

                    conn.Open();

                }

                return result;

            }

            catch (SqlException ex)

            {

                return false;

            }

        }


        //关闭连接

        public bool CloseConnection()

        {

            try

            {

                conn.Close();

                return true;

            }

            catch (Exception ex)

            {


                return false;

            }

        }

    }


}