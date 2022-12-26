using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace LibraryManagementSystem
{
    internal static class SqlHelper
    {

        static SqlHelper()
        {
            connection = new SqlConnection("Data Source=LAPTOP-625QG29P;" +
            "Initial Catalog=Library;Trusted_Connection=yes");
        }

        public static string ConditionMake(string key,string value)
        {
            return " where " + key + "='" + value + "'";
        }

        public static string ConditionMake(string[] key, string[] value)
        {
            string condition = "where " + key[0] + "='" + value[0]+"'";
            for(int i = 1; i < key.Length; i++)
            {
                condition += " and " + key[i] + "='" + value[i] + "' ";
            }

            return condition;
        }

        public static bool Contain(string table, string condition)
        {
            DataRowCollection drc = SelectRows(table, condition);
            if (drc == null || drc.Count == 0)
            {
                return false;
            }
            return true;
        }

        public static DataRowCollection SelectRows(string table, string condition)
        {
            DataTable dt = Select(table, condition);
            return dt.Rows;
        }

        public static void SqlInsert(string table, object[] values)
        {
            try
            {
                connection.Open();
                string sql = "insert into " + table + " values(";
                for(int i=0;i<values.Length;i++)
                {
                    sql += "'"+values[i]+"'";
                    if (i == values.Length - 1)
                    {
                        sql += ")";
                    }
                    else
                    {
                        sql += ",";
                    }
                }
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void SqlDelete(string table, string condition)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("delete from " + table + " " + condition, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void SqlModify(string table,List<string>names, object[] values,string condition)
        {
            try
            {
                connection.Open();
                string sql = "update " + table + " set ";
                for(int i = 0; i < names.Count; i++)
                {
                    sql += names[i] + "='" + values[i] + "'";
                    if (i == names.Count - 1) continue;
                    sql += ",";
                }
                sql += condition;
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable Select(string table, string condition="",string selected = "*")
        {
            try
            {
                connection.Open();
                SqlDataAdapter sda;
                DataSet ds = new DataSet();
                DataTable dt;
                string sql = "select"+ " " + selected +" "+ "from"+ " " + table + " " +  condition;
                command = new SqlCommand(sql, connection);
                sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                ds = new DataSet();
                dt = new DataTable();
                sda.Fill(ds, table);
                dt = ds.Tables[table];
                return dt;
               

            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
            
        }

        public static void Insert(string table,object []values)
        {
            try
            {
                connection.Open();
                SqlDataAdapter sda;
                DataSet ds = new DataSet();
                DataTable dt;
                sda = new SqlDataAdapter(new SqlCommand("select * from " + table, connection));
                sda.Fill(ds, table);
                dt = ds.Tables[table];
                Debug.WriteLine(table + "行数:" + ds.Tables[table].Rows.Count);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                dt.Rows.Add(values);
                sda.Update(dt);
                Debug.WriteLine(table + "行数:" + ds.Tables[table].Rows.Count);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public static void Delete(string table, object key)
        {
            try
            {
                connection.Open();
                SqlDataAdapter sda;
                DataSet ds = new DataSet();
                DataTable dt;
                sda = new SqlDataAdapter(new SqlCommand("select * from " + table, connection));
                sda.Fill(ds, table);
                dt = ds.Tables[table];
                Debug.WriteLine(table + "行数:" + dt.Rows.Count);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((string)dt.Rows[i][0]==(string)key)
                    {
                        dt.Rows.RemoveAt(i);
                        Debug.WriteLine("delete key" + key);
                        break;
                    }
                }
                sda.Update(dt);
                Debug.WriteLine(table + "行数:" + dt.Rows.Count);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private static SqlCommand command;
        private static SqlConnection connection;
    }

}
