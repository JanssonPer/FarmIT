using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmITApp.DatabaseAccessLayer;
using FarmITApp.EntityFramework;

namespace FarmITApp
{
    public partial class Form1 : Form
    {
        Dal dal = new Dal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Animals> list = dal.GetAllAnimals();
            foreach(Animals a in list)
            {
                Console.WriteLine(a.Name);
            }
            
        }
    }
}
