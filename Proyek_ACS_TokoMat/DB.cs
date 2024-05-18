using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_ACS_TokoMat
{
    internal class DB
    {
        private static string connString = "";
        public static SqlConnection conn = null;
        const string NAMADB = "db_tokomat";
        public static DataRow logged;
        public DB(string username, string password)
        {
            try
            {
                connString = $"Data Source=.;Initial Catalog={NAMADB};Integrated Security=True";
                //connString = $"Data Source=.;Initial Catalog={NAMADB};User ID={username};Password={password}"; 

                conn = new SqlConnection(connString);
            }
            catch (Exception exc)
            {
                throw new Exception("Konfigurasi gagal, " + exc.Message.ToString());
            }
        }

        public static void openConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }
        public static void closeConnection()
        {
            conn.Close();
        }

        public static void notifByRole(string role, string t, string c, SqlTransaction tr)
        {
            DataTable detail = DB.getTr($"SELECT * FROM USERS WHERE ROLE = '{role}';", tr);
            foreach (DataRow dr in detail.Rows)
            {
                string id = DB.generateIdTr("NOTIF", tr);
                string title = t;
                string content = c;
                string status = "Unread";
                string recipient = dr.Field<string>("ID");
                DateTime now = DateTime.Now;
                DB.execTr($"INSERT INTO NOTIF VALUES('{id}','{title}','{content}','{status}','{recipient}', '{now}')", tr);
            }

        }

        public static bool cekTuhan()
        {
            try
            {
                DB.openConnection();
                string adaKah = getScalar($"SELECT COUNT(*) FROM USERS WHERE ID = 'Tuhan';");
                if (adaKah == "0")
                {
                    DB.exec($"INSERT INTO USERS VALUES('Tuhan','','','Tuhan', 'Tuhan Menyertaimu');");
                }
                DB.closeConnection();
                return true;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message, exc.ToString()); ;
                return false;
            }
        }
        public static bool setLogged(string nama, string password)
        {
            try
            {
                DB.openConnection();
                DataTable dt = get($"SELECT * FROM USERS WHERE NAMA = '{nama}' AND PASSWORD = '{password}' AND STATUS != 'Non-Aktif'");
                DataRow user = dt.Rows[0];
                logged = user;
                DB.closeConnection();
                return true;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message, exc.ToString()); ;
                return false;
            }

        }
        public static string generateId(string table)
        {
            DataTable max = DB.get($"SELECT COUNT(*)+1 AS MAX FROM {table}");
            DataRow r = max.Rows[0];
            string urut = r.Field<int>("MAX").ToString();
            while (urut.Length < 3)
            {
                urut = "0" + urut;
            }
            return table.Substring(0, 2) + urut;
        }

        public static string generateIdTr(string table, SqlTransaction transaction)
        {
            DataTable max = DB.getTr($"SELECT COUNT(*)+1 AS MAX FROM {table}", transaction);
            DataRow r = max.Rows[0];
            string urut = r.Field<int>("MAX").ToString();
            while (urut.Length < 3)
            {
                urut = "0" + urut;
            }
            return table.Substring(0, 2) + urut;
        }

        public static bool cekNamaKembar(string table, string nama)
        {
            DataTable max = DB.get($"SELECT COUNT(NAMA) AS MAX FROM {table} WHERE NAMA = '{nama}'");
            DataRow r = max.Rows[0];
            int count = r.Field<int>("MAX");
            bool value = count > 0;
            return value;
        }

        public static DataTable get(string query)
        {
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public static DataTable getTr(string query, SqlTransaction transaction)
        {
            SqlCommand cmd = new SqlCommand(query, DB.conn, transaction);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public static string getScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            DB.openConnection();
            string res = cmd.ExecuteScalar().ToString();
            DB.closeConnection();
            return res;
        }

        public static string getScalarTr(string query, SqlTransaction transaction)
        {
            SqlCommand cmd = new SqlCommand(query, DB.conn, transaction);
            string res = cmd.ExecuteScalar().ToString();
            return res;
        }

        public static void exec(string query)
        {
            try
            {
                DB.openConnection();
                string cmdStringHeader = query;
                SqlCommand cmdHeader = new SqlCommand(cmdStringHeader, DB.conn);
                cmdHeader.ExecuteNonQuery();
                DB.closeConnection();
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.ToString());
            }
        }

        public static void execTr(string query, SqlTransaction tr)
        {
            try
            {
                string cmdStringHeader = query;
                SqlCommand cmdHeader = new SqlCommand(cmdStringHeader, DB.conn, tr);
                cmdHeader.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.ToString());
            }
        }

        public static List<String> getList(string query, string rowname)
        {
            DataTable d = DB.get(query);
            List<String> data = new List<string>();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                DataRow dr = d.Rows[i];
                data.Add(dr.Field<string>(rowname));
            }
            return data;
        }
    }
}
}
