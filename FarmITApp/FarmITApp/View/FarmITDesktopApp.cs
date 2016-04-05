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
        Dal controller = new Dal();

        public FarmITDesktopApp()
        {
            InitializeComponent();
            try
            {
                combo_FindType.Text = "Cow";
                List<Foods> listFoods = controller
                Foods pf = controller.GetFood(1);
                Console.WriteLine(pf.Amount);
            }
            catch
            {
                Console.WriteLine("ej funnit");
            }
           
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
            try
            {
                Animals a = controller.GetAnimal(((long)(System.Convert.ChangeType(textBox_FindById.Text, typeof(long)))));
                a.Age = textBox_UAge.Text;
                a.Name = textBox_UName.Text;
                a.TypeAnimal = textBox_UType.Text;
                a.StatusAnimal = textBox_UStatus.Text;
                a.IdBox = textBox_UBox.Text;
                if (a.TypeAnimal.Equals("Horse"))
                {
                    a.AmountOfPowerFeed = int.Parse(textBox_UFood.Text);
                    a.AmountOfHay = int.Parse(textBox_UFoodTwo.Text);
                }
                else if (a.TypeAnimal.Equals("Hen"))
                {
                    a.AmountOfOats = int.Parse(textBox_UFood.Text);
                }
                else
                {
                    a.AmountOfPowerFeed = int.Parse(textBox_UFood.Text);
                }

                controller.UpdateAnimal(a);
                try
                {
                    this.animalsTableAdapter.Reset(this.farmITDataSet.Animals);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            catch
            {

            }

        }

        private void dataGridView_Animals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button_Update.Show();
                DataGridViewRow row = dataGridView_Animals.Rows[e.RowIndex];
                textBox_UId.Text = row.Cells[0].Value.ToString();
                textBox_UType.Text = row.Cells[1].Value.ToString();
                textBox_UAge.Text = row.Cells[2].Value.ToString();
                textBox_UName.Text = row.Cells[3].Value.ToString();
                textBox_UStatus.Text = row.Cells[4].Value.ToString();
                textBox_UBox.Text = row.Cells[8].Value.ToString();
                if (textBox_UType.Text.Equals("Horse"))
                {
                    textBox_UFood.Text = row.Cells[5].Value.ToString();
                    textBox_UFoodTwo.Text = row.Cells[6].Value.ToString();
                    food.Text = "Powerfeed";
                    UFoodTwo.Text = "Hay";
                    UFoodTwo.Show();
                    textBox_UFoodTwo.Show();
                }
                else if (textBox_UType.Text.Equals("Hen"))
                {
                    textBox_UFood.Text = row.Cells[7].Value.ToString();
                    UFood.Text = "Oats";
                    UFoodTwo.Hide();
                    textBox_UFoodTwo.Hide();
                }
                else
                {
                    textBox_UFood.Text = row.Cells[5].Value.ToString();
                    UFood.Text = "Powerfeed";
                    textBox_UFoodTwo.Hide();
                    UFoodTwo.Hide();
                }

            }


        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Do you really want to delete an animal?", "Delete", MessageBoxButtons.YesNo);
            if (remove == DialogResult.Yes)
            {

                textBox_Message.Text = "You just deleted an animal";
                textBox_Message.Show();
                Animals a = controller.GetAnimal(long.Parse(textBox_UId.Text));
                controller.RemoveAnimal(a);
                try
                {
                    this.animalsTableAdapter.Reset(this.farmITDataSet.Animals);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
            else if (remove == DialogResult.No)
            {
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

        private void combo_FindType_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}