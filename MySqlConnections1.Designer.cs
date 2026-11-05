using MySql.Data.MySqlClient;
using System.Data;

namespace SqlConnectionsPrj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root; database=wishlist; ";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string query = "select * from item";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;
        }
    }
}
