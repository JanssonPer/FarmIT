using FarmITApp.DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmITApp.EntityFramework;

namespace FarmITApp.View
{
    public partial class FarmITDesktopApp : Form
    {
        Dal dal = new Dal();

        public FarmITDesktopApp()
        {
            InitializeComponent();
            
            chart_Food.Series["Food"].Points.AddXY("Powerfeed", 1000);
            chart_Food.Series["Food"].Points.AddXY("Hay", 900);
            chart_Food.Series["Food"].Points.AddXY("Oats", 1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FarmITDesktopApp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmITDataSet.Buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.farmITDataSet.Buildings);
            // TODO: This line of code loads data into the 'farmITDataSet.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.farmITDataSet.Foods);
            // TODO: This line of code loads data into the 'farmITDataSet.Animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.farmITDataSet.Animals);

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalsTableAdapter.Find_Type(this.farmITDataSet.Animals, combo_FindType.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalsTableAdapter.FindById(this.farmITDataSet.Animals, ((long)(System.Convert.ChangeType(textBox_FindById.Text, typeof(long)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void box_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (textBox_Type.Text.Equals("Horse"))
            {
                food.Text = "Powerfeed";
                foodTwo.Text = "Hay";
                foodTwo.Show();
                textBox_FoodTwo.Show();
            }
            else if (textBox_Type.Text.Equals("Hen"))
            {
                food.Text = "Oats";
                foodTwo.Hide();
                textBox_FoodTwo.Hide();
            }
            else
            {
                food.Text = "Powerfeed";
                textBox_FoodTwo.Hide();
                foodTwo.Hide();
            }
        }

        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.animalsTableAdapter.Reset(this.farmITDataSet.Animals);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void resetToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.animalsTableAdapter.Reset(this.farmITDataSet.Animals);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            
           Animals a= dal.GetAnimal(((long)(System.Convert.ChangeType(textBox_FindById.Text, typeof(long)))));
           Console.WriteLine(a.Name);
        }

        private void dataGridView_Animals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dataGridView_Animals.Rows[e.RowIndex];
                textBox_FindById.Text = row.Cells[0].Value.ToString();
                
            }


        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Do you really want to delete an animal?", "Delete", MessageBoxButtons.YesNo);
            if(remove== DialogResult.Yes)
            {
                textBox_Message.Text = "You just deleted an animal";
                textBox_Message.Show();
            }
            else if(remove == DialogResult.No) {
                textBox_Message.Text = "No Animal deleted "; 
                textBox_Message.Show();
            }
        }
        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Food.Text = "";
            textBox_FoodTwo.Text = "";
            textBox_Name.Text = "";
            textBox_Age.Text = "";
        }
    }
}
