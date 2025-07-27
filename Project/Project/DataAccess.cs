using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            try
            {
                this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-V13ADAT;Initial Catalog=ProjectDB;Integrated Security=True;Encrypt=False;");
                Sqlcon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while connecting to the database: " + ex.Message);
            }
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ExecuteQuery: " + ex.Message);
                return null;
            }
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ExecuteQueryTable: " + ex.Message);
                return null;
            }
        }

        public int ExecuteDMLQuery(string sql)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
                int u = this.Sqlcom.ExecuteNonQuery();
                return u;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ExecuteDMLQuery: " + ex.Message);
                return -1; 
            }
        }
    }
}
