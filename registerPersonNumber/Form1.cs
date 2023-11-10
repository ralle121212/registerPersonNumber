using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registerPersonNumber
{
    public partial class Form1 : Form
    {
        private Person person = new Person();
        private string txtFirstName;
        private string txtLastName;
        private string txtSocialSecurityNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void firstName_Text_Changed(object sender, EventArgs e)
        {
            string txtFirstName = textBox1.Text;
        }


        private void lastName_TextBox_Changed(object sender, EventArgs e)
        {
            string txtLastName = textBox2.Text;
        }
        private void SSH_Text_Changed(object sender, EventArgs e)
        {
            string txtSocialSecurityNumber = textBox3.Text; 

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            person.FirstName = txtFirstName;
            person.LastName = txtLastName;
            person.SocialSecurityNumber = txtSocialSecurityNumber;

        }

      
    }

}


