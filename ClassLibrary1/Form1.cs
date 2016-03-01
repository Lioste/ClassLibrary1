using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void B_Modifier_Click(object sender, EventArgs e)
        {
            ClientDAO repo;
            repo = new ClientDAO("server=(local);database=Fil_Rouge;Integrated Security = True");

            // ListBox Windows Form
            listBox1.DisplayMember = "NomClient";
            listBox1.DataSource = repo.Liste();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
