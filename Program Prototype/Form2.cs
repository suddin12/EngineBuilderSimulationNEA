using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //This opens up a new form, which runs the program once the user presses the Run button
        private void RunButton_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
            this.Close();
        }

        //Opens up a new form, displaying the instructions on how to use the program
        private void HelpButton_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void NoOfCylinders_TextChanged(object sender, EventArgs e)
        {
            int numberOfCylinders = Convert.ToInt32(NoOfCylinders.Text);
        }
    }
}
