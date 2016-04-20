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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        

        private void btnchngpass_Click(object sender, EventArgs e)
        {
            try
            {
                //Gögnin till að komast í serverinn
                string connection = "server=tsuts.tskoli.is; database=0501983759_gru_11;user=0501983759; password=mypassword;";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlDataReader sdr;
                MySqlCommand mcd;
                string s;


                //Opna tenginguna til serverinns
                conn.Open();

                s = "UPDATE Users SET Password='" + txtchngnewpass.Text + "' WHERE Password = '" + txtchngcurpass.Text + "' AND Name = '" + txtchnguser.Text + "'";

                mcd = new MySqlCommand(s, conn);
                mcd.ExecuteNonQuery();
                sdr = mcd.ExecuteReader();

                if (sdr.Read())
                {
                    //lol idk
                    MessageBox.Show("password was *probably* not updated.");
                }
                else
                {
                    //shit's broken yo
                    MessageBox.Show("Your password has *probably* been changed.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabusermng_Click(object sender, EventArgs e)
        {

        }

       
    }
}
