using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsoul_Click(object sender, EventArgs e)
        {
            //lokar glugganum
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogi_Click(object sender, EventArgs e)
        {
            try
            {
                //Gögnin till að komast í serverinn
                string connection = "server=tsuts.tskoli.is; database=0501983759_gru_11;user=0501983759; password=mypassword;";
                MySqlConnection conn = new MySqlConnection(connection);
                //Að segja hverning á að sækja gögnin
                MySqlCommand SelectComand = new MySqlCommand("select * from admins where Username='" + txtuserlog.Text + "' and Password='" + txtpasslog.Text + "' ;", conn);
                MySqlDataReader sdr;

                //Opna tenginguna til serverinns
                conn.Open();

                sdr = SelectComand.ExecuteReader();

                int count = 0;

                while (sdr.Read())
                {
                    //það bætir við 1 við hvert password sem er til
                    count = count + 1;
                }

                if (count == 1)
                {
                    //ef count er = 1 það þýðir að það er bara eitt þanning lykilorð
                    MessageBox.Show("You have logged in.");

                    //opnar nýa gluggan
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                }

                else if (count > 1)
                {
                    //ef count er meiri en 1 þýðir að það er meira en eitt svona lykilorð
                    MessageBox.Show("Duplicate username and/or password, please try again.");
                }

                else
                {
                    //annars er lykilorðið rangt
                    MessageBox.Show("Password or username incorrect, please try again.");
                }
                //lokar tenginguni
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
