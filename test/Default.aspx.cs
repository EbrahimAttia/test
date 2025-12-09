using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient; // **Needed for MySQL commands**
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnTest_Click(object sender, EventArgs e)
        {
            // 1. Get the connection string from Web.config
            // This pulls the string we named "TicketingDb"
            string connString = ConfigurationManager.ConnectionStrings["TicketingDb"].ConnectionString;

            // 2. Create the connection object and ensure it is properly disposed (using statement)
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    // 3. Try to open the connection
                    conn.Open();

                    // Connection was successful!
                    lblResult.Text = "Success! Connected to MySQL. XAMPP is running and the database details are correct.";
                    lblResult.ForeColor = System.Drawing.Color.Green;

                    // ---- RUN A QUERY HERE ----
                    string query = "SELECT * FROM utente ";
                    // Replace your_table_name with any table that exists in your MySQL DB

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind to GridView
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    // Connection failed. Show the specific error message.
                    lblResult.Text = "Error connecting to MySQL: " + ex.Message;
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}


        
    


