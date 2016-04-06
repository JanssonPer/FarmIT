﻿namespace FarmITApp.View
{
    partial class FarmITDesktopApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_Reset = new System.Windows.Forms.Button();
            this.foodTwo = new System.Windows.Forms.Label();
            this.textBox_FoodTwo = new System.Windows.Forms.TextBox();
            this.food = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Food = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.ComboBox();
            this.textBox_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.textBox_Message = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage_Info = new System.Windows.Forms.TabPage();
            this.label_Oats = new System.Windows.Forms.Label();
            this.label_Powerfeed = new System.Windows.Forms.Label();
            this.label_Hay = new System.Windows.Forms.Label();
            this.button_FeedAnimals = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chart_Food = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_Find = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid_Animal = new System.Windows.Forms.DataGridView();
            this.button_ResetFilter = new System.Windows.Forms.Button();
            this.textBox_UStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_UBox = new System.Windows.Forms.TextBox();
            this.textBox_UFoodTwo = new System.Windows.Forms.TextBox();
            this.textBox_UFood = new System.Windows.Forms.TextBox();
            this.textBox_UAge = new System.Windows.Forms.TextBox();
            this.textBox_UName = new System.Windows.Forms.TextBox();
            this.textBox_UType = new System.Windows.Forms.TextBox();
            this.textBox_UId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UFoodTwo = new System.Windows.Forms.Label();
            this.UFood = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_FindById = new System.Windows.Forms.TextBox();
            this.combo_FindType = new System.Windows.Forms.ComboBox();
            this.dataGridView_Animals = new System.Windows.Forms.DataGridView();
            this.idAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfPowerfeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfHayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfOatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmITDataSet = new FarmITApp.DatabaseAccessLayer.FarmITDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage_Create = new System.Windows.Forms.TabPage();
            this.button_Create = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_BoxId = new System.Windows.Forms.TextBox();
            this.animalTableAdapter = new FarmITApp.DatabaseAccessLayer.FarmITDataSetTableAdapters.AnimalTableAdapter();
            this.foodTableAdapter = new FarmITApp.DatabaseAccessLayer.FarmITDataSetTableAdapters.FoodTableAdapter();
            this.tabMenu.SuspendLayout();
            this.tabPage_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Food)).BeginInit();
            this.tabPage_Find.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Animal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Animals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmITDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage_Create.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(381, 377);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 16;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // foodTwo
            // 
            this.foodTwo.AutoSize = true;
            this.foodTwo.Location = new System.Drawing.Point(378, 348);
            this.foodTwo.Name = "foodTwo";
            this.foodTwo.Size = new System.Drawing.Size(52, 13);
            this.foodTwo.TabIndex = 14;
            this.foodTwo.Text = "FoodTwo";
            this.foodTwo.Visible = false;
            // 
            // textBox_FoodTwo
            // 
            this.textBox_FoodTwo.Location = new System.Drawing.Point(439, 345);
            this.textBox_FoodTwo.Name = "textBox_FoodTwo";
            this.textBox_FoodTwo.Size = new System.Drawing.Size(121, 20);
            this.textBox_FoodTwo.TabIndex = 8;
            this.textBox_FoodTwo.Visible = false;
            // 
            // food
            // 
            this.food.AutoSize = true;
            this.food.Location = new System.Drawing.Point(378, 312);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(31, 13);
            this.food.TabIndex = 12;
            this.food.Text = "Food";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(439, 201);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(121, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(439, 239);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(121, 20);
            this.textBox_Age.TabIndex = 5;
            // 
            // textBox_Food
            // 
            this.textBox_Food.Location = new System.Drawing.Point(439, 309);
            this.textBox_Food.Name = "textBox_Food";
            this.textBox_Food.Size = new System.Drawing.Size(121, 20);
            this.textBox_Food.TabIndex = 7;
            // 
            // textBox_Status
            // 
            this.textBox_Status.BackColor = System.Drawing.Color.White;
            this.textBox_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox_Status.FormattingEnabled = true;
            this.textBox_Status.Items.AddRange(new object[] {
            "Healthy",
            "Sick",
            "Gluefactory"});
            this.textBox_Status.Location = new System.Drawing.Point(439, 123);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(121, 21);
            this.textBox_Status.TabIndex = 2;
            // 
            // textBox_Type
            // 
            this.textBox_Type.BackColor = System.Drawing.Color.White;
            this.textBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox_Type.FormattingEnabled = true;
            this.textBox_Type.Items.AddRange(new object[] {
            "Cow",
            "Pig",
            "Horse",
            "Hen"});
            this.textBox_Type.Location = new System.Drawing.Point(439, 83);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(121, 21);
            this.textBox_Type.TabIndex = 1;
            this.textBox_Type.SelectedIndexChanged += new System.EventHandler(this.box_Type_SelectedIndexChanged);
            // 
            // textBox_Id
            // 
            this.textBox_Id.BackColor = System.Drawing.Color.White;
            this.textBox_Id.Enabled = false;
            this.textBox_Id.Location = new System.Drawing.Point(439, 163);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(121, 20);
            this.textBox_Id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Animal";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(378, 86);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 0;
            this.type.Text = "Type";
            // 
            // textBox_Message
            // 
            this.textBox_Message.AutoSize = true;
            this.textBox_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Message.Location = new System.Drawing.Point(449, 536);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(74, 20);
            this.textBox_Message.TabIndex = 1;
            this.textBox_Message.Text = "Message";
            this.textBox_Message.Visible = false;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage_Info);
            this.tabMenu.Controls.Add(this.tabPage_Find);
            this.tabMenu.Controls.Add(this.tabPage_Create);
            this.tabMenu.Location = new System.Drawing.Point(12, 12);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1024, 502);
            this.tabMenu.TabIndex = 2;
            // 
            // tabPage_Info
            // 
            this.tabPage_Info.BackColor = System.Drawing.Color.White;
            this.tabPage_Info.Controls.Add(this.label_Oats);
            this.tabPage_Info.Controls.Add(this.label_Powerfeed);
            this.tabPage_Info.Controls.Add(this.label_Hay);
            this.tabPage_Info.Controls.Add(this.button_FeedAnimals);
            this.tabPage_Info.Controls.Add(this.label8);
            this.tabPage_Info.Controls.Add(this.chart_Food);
            this.tabPage_Info.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Info.Name = "tabPage_Info";
            this.tabPage_Info.Size = new System.Drawing.Size(1016, 476);
            this.tabPage_Info.TabIndex = 2;
            this.tabPage_Info.Text = "Information";
            // 
            // label_Oats
            // 
            this.label_Oats.AutoSize = true;
            this.label_Oats.Location = new System.Drawing.Point(418, 377);
            this.label_Oats.Name = "label_Oats";
            this.label_Oats.Size = new System.Drawing.Size(29, 13);
            this.label_Oats.TabIndex = 5;
            this.label_Oats.Text = "Oats";
            // 
            // label_Powerfeed
            // 
            this.label_Powerfeed.AutoSize = true;
            this.label_Powerfeed.Location = new System.Drawing.Point(345, 377);
            this.label_Powerfeed.Name = "label_Powerfeed";
            this.label_Powerfeed.Size = new System.Drawing.Size(58, 13);
            this.label_Powerfeed.TabIndex = 4;
            this.label_Powerfeed.Text = "Powerfeed";
            // 
            // label_Hay
            // 
            this.label_Hay.AutoSize = true;
            this.label_Hay.Location = new System.Drawing.Point(489, 377);
            this.label_Hay.Name = "label_Hay";
            this.label_Hay.Size = new System.Drawing.Size(26, 13);
            this.label_Hay.TabIndex = 3;
            this.label_Hay.Text = "Hay";
            // 
            // button_FeedAnimals
            // 
            this.button_FeedAnimals.Location = new System.Drawing.Point(405, 424);
            this.button_FeedAnimals.Name = "button_FeedAnimals";
            this.button_FeedAnimals.Size = new System.Drawing.Size(134, 23);
            this.button_FeedAnimals.TabIndex = 2;
            this.button_FeedAnimals.Text = "Feed Animals";
            this.button_FeedAnimals.UseVisualStyleBackColor = true;
            this.button_FeedAnimals.Click += new System.EventHandler(this.button_FeedAnimals_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(400, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Food Storage";
            // 
            // chart_Food
            // 
            this.chart_Food.BackColor = System.Drawing.Color.Transparent;
            this.chart_Food.BorderlineColor = System.Drawing.Color.Violet;
            this.chart_Food.BorderSkin.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.chart_Food.BorderSkin.PageColor = System.Drawing.Color.Violet;
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea2.Area3DStyle.Inclination = 20;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Rotation = 20;
            chartArea2.Area3DStyle.WallWidth = 1;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Maximum = 1000D;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.BurlyWood;
            chartArea2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea2.BackSecondaryColor = System.Drawing.Color.CornflowerBlue;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            this.chart_Food.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Food.Legends.Add(legend2);
            this.chart_Food.Location = new System.Drawing.Point(224, 77);
            this.chart_Food.Name = "chart_Food";
            this.chart_Food.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_Food.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DarkSeaGreen};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Food Storage";
            this.chart_Food.Series.Add(series2);
            this.chart_Food.Size = new System.Drawing.Size(501, 310);
            this.chart_Food.TabIndex = 0;
            this.chart_Food.Text = "chart_Food";
            // 
            // tabPage_Find
            // 
            this.tabPage_Find.BackColor = System.Drawing.Color.White;
            this.tabPage_Find.Controls.Add(this.label7);
            this.tabPage_Find.Controls.Add(this.tabControl1);
            this.tabPage_Find.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Find.Name = "tabPage_Find";
            this.tabPage_Find.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Find.Size = new System.Drawing.Size(1016, 476);
            this.tabPage_Find.TabIndex = 0;
            this.tabPage_Find.Text = "Find";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(470, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Find";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 443);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataGrid_Animal);
            this.tabPage1.Controls.Add(this.button_ResetFilter);
            this.tabPage1.Controls.Add(this.textBox_UStatus);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox_UBox);
            this.tabPage1.Controls.Add(this.textBox_UFoodTwo);
            this.tabPage1.Controls.Add(this.textBox_UFood);
            this.tabPage1.Controls.Add(this.textBox_UAge);
            this.tabPage1.Controls.Add(this.textBox_UName);
            this.tabPage1.Controls.Add(this.textBox_UType);
            this.tabPage1.Controls.Add(this.textBox_UId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.UFoodTwo);
            this.tabPage1.Controls.Add(this.UFood);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.button_Remove);
            this.tabPage1.Controls.Add(this.button_Update);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.textBox_FindById);
            this.tabPage1.Controls.Add(this.combo_FindType);
            this.tabPage1.Controls.Add(this.dataGridView_Animals);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Animals";
            // 
            // dataGrid_Animal
            // 
            this.dataGrid_Animal.AllowUserToAddRows = false;
            this.dataGrid_Animal.AllowUserToDeleteRows = false;
            this.dataGrid_Animal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Animal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Animal.Location = new System.Drawing.Point(9, 171);
            this.dataGrid_Animal.Name = "dataGrid_Animal";
            this.dataGrid_Animal.ReadOnly = true;
            this.dataGrid_Animal.Size = new System.Drawing.Size(674, 169);
            this.dataGrid_Animal.TabIndex = 33;
            this.dataGrid_Animal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Animal_CellClick);
            // 
            // button_ResetFilter
            // 
            this.button_ResetFilter.Location = new System.Drawing.Point(9, 371);
            this.button_ResetFilter.Name = "button_ResetFilter";
            this.button_ResetFilter.Size = new System.Drawing.Size(74, 25);
            this.button_ResetFilter.TabIndex = 32;
            this.button_ResetFilter.Text = "Reset filter";
            this.button_ResetFilter.UseVisualStyleBackColor = true;
            this.button_ResetFilter.Click += new System.EventHandler(this.button_ResetFilter_Click);
            // 
            // textBox_UStatus
            // 
            this.textBox_UStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox_UStatus.FormattingEnabled = true;
            this.textBox_UStatus.Items.AddRange(new object[] {
            "Gluefactory",
            "Healthy",
            "Sick"});
            this.textBox_UStatus.Location = new System.Drawing.Point(786, 109);
            this.textBox_UStatus.Name = "textBox_UStatus";
            this.textBox_UStatus.Size = new System.Drawing.Size(100, 21);
            this.textBox_UStatus.Sorted = true;
            this.textBox_UStatus.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(700, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "IdBox";
            // 
            // textBox_UBox
            // 
            this.textBox_UBox.Location = new System.Drawing.Point(786, 263);
            this.textBox_UBox.Name = "textBox_UBox";
            this.textBox_UBox.Size = new System.Drawing.Size(100, 20);
            this.textBox_UBox.TabIndex = 29;
            // 
            // textBox_UFoodTwo
            // 
            this.textBox_UFoodTwo.Location = new System.Drawing.Point(786, 340);
            this.textBox_UFoodTwo.Name = "textBox_UFoodTwo";
            this.textBox_UFoodTwo.Size = new System.Drawing.Size(100, 20);
            this.textBox_UFoodTwo.TabIndex = 28;
            this.textBox_UFoodTwo.Visible = false;
            // 
            // textBox_UFood
            // 
            this.textBox_UFood.Location = new System.Drawing.Point(786, 301);
            this.textBox_UFood.Name = "textBox_UFood";
            this.textBox_UFood.Size = new System.Drawing.Size(100, 20);
            this.textBox_UFood.TabIndex = 27;
            // 
            // textBox_UAge
            // 
            this.textBox_UAge.Location = new System.Drawing.Point(786, 227);
            this.textBox_UAge.Name = "textBox_UAge";
            this.textBox_UAge.Size = new System.Drawing.Size(100, 20);
            this.textBox_UAge.TabIndex = 26;
            // 
            // textBox_UName
            // 
            this.textBox_UName.Location = new System.Drawing.Point(786, 187);
            this.textBox_UName.Name = "textBox_UName";
            this.textBox_UName.Size = new System.Drawing.Size(100, 20);
            this.textBox_UName.TabIndex = 25;
            // 
            // textBox_UType
            // 
            this.textBox_UType.Enabled = false;
            this.textBox_UType.Location = new System.Drawing.Point(786, 149);
            this.textBox_UType.Name = "textBox_UType";
            this.textBox_UType.Size = new System.Drawing.Size(100, 20);
            this.textBox_UType.TabIndex = 24;
            // 
            // textBox_UId
            // 
            this.textBox_UId.Enabled = false;
            this.textBox_UId.Location = new System.Drawing.Point(786, 70);
            this.textBox_UId.Name = "textBox_UId";
            this.textBox_UId.Size = new System.Drawing.Size(100, 20);
            this.textBox_UId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type";
            // 
            // UFoodTwo
            // 
            this.UFoodTwo.AutoSize = true;
            this.UFoodTwo.Location = new System.Drawing.Point(700, 343);
            this.UFoodTwo.Name = "UFoodTwo";
            this.UFoodTwo.Size = new System.Drawing.Size(52, 13);
            this.UFoodTwo.TabIndex = 21;
            this.UFoodTwo.Text = "FoodTwo";
            this.UFoodTwo.Visible = false;
            // 
            // UFood
            // 
            this.UFood.AutoSize = true;
            this.UFood.Location = new System.Drawing.Point(700, 304);
            this.UFood.Name = "UFood";
            this.UFood.Size = new System.Drawing.Size(31, 13);
            this.UFood.TabIndex = 20;
            this.UFood.Text = "Food";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(700, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Age";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(700, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(700, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(700, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Status";
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(581, 371);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(74, 25);
            this.button_Remove.TabIndex = 9;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(892, 371);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 25);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Visible = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 7;
            this.button4.Text = "Search Id";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_FindById
            // 
            this.textBox_FindById.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_FindById.Location = new System.Drawing.Point(9, 8);
            this.textBox_FindById.Name = "textBox_FindById";
            this.textBox_FindById.Size = new System.Drawing.Size(97, 20);
            this.textBox_FindById.TabIndex = 6;
            // 
            // combo_FindType
            // 
            this.combo_FindType.DisplayMember = "Cow";
            this.combo_FindType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_FindType.FormattingEnabled = true;
            this.combo_FindType.Items.AddRange(new object[] {
            "Cow",
            "Pig",
            "Horse",
            "Hen"});
            this.combo_FindType.Location = new System.Drawing.Point(9, 43);
            this.combo_FindType.Name = "combo_FindType";
            this.combo_FindType.Size = new System.Drawing.Size(97, 21);
            this.combo_FindType.TabIndex = 5;
            this.combo_FindType.SelectedIndexChanged += new System.EventHandler(this.combo_FindType_SelectedIndexChanged);
            // 
            // dataGridView_Animals
            // 
            this.dataGridView_Animals.AllowUserToAddRows = false;
            this.dataGridView_Animals.AllowUserToDeleteRows = false;
            this.dataGridView_Animals.AutoGenerateColumns = false;
            this.dataGridView_Animals.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_Animals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Animals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnimalDataGridViewTextBoxColumn,
            this.typeAnimalDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusAnimalDataGridViewTextBoxColumn,
            this.amountOfPowerfeedDataGridViewTextBoxColumn,
            this.amountOfHayDataGridViewTextBoxColumn,
            this.amountOfOatsDataGridViewTextBoxColumn,
            this.idBoxDataGridViewTextBoxColumn});
            this.dataGridView_Animals.DataSource = this.animalBindingSource;
            this.dataGridView_Animals.Location = new System.Drawing.Point(9, 70);
            this.dataGridView_Animals.Name = "dataGridView_Animals";
            this.dataGridView_Animals.ReadOnly = true;
            this.dataGridView_Animals.Size = new System.Drawing.Size(615, 95);
            this.dataGridView_Animals.TabIndex = 0;
            this.dataGridView_Animals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Animals_CellClick);
            // 
            // idAnimalDataGridViewTextBoxColumn
            // 
            this.idAnimalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idAnimalDataGridViewTextBoxColumn.DataPropertyName = "IdAnimal";
            this.idAnimalDataGridViewTextBoxColumn.HeaderText = "IdAnimal";
            this.idAnimalDataGridViewTextBoxColumn.Name = "idAnimalDataGridViewTextBoxColumn";
            this.idAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeAnimalDataGridViewTextBoxColumn
            // 
            this.typeAnimalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeAnimalDataGridViewTextBoxColumn.DataPropertyName = "TypeAnimal";
            this.typeAnimalDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeAnimalDataGridViewTextBoxColumn.Name = "typeAnimalDataGridViewTextBoxColumn";
            this.typeAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusAnimalDataGridViewTextBoxColumn
            // 
            this.statusAnimalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusAnimalDataGridViewTextBoxColumn.DataPropertyName = "StatusAnimal";
            this.statusAnimalDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusAnimalDataGridViewTextBoxColumn.Name = "statusAnimalDataGridViewTextBoxColumn";
            this.statusAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOfPowerfeedDataGridViewTextBoxColumn
            // 
            this.amountOfPowerfeedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountOfPowerfeedDataGridViewTextBoxColumn.DataPropertyName = "AmountOfPowerfeed";
            this.amountOfPowerfeedDataGridViewTextBoxColumn.HeaderText = "Powerfeed";
            this.amountOfPowerfeedDataGridViewTextBoxColumn.Name = "amountOfPowerfeedDataGridViewTextBoxColumn";
            this.amountOfPowerfeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOfHayDataGridViewTextBoxColumn
            // 
            this.amountOfHayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountOfHayDataGridViewTextBoxColumn.DataPropertyName = "AmountOfHay";
            this.amountOfHayDataGridViewTextBoxColumn.HeaderText = "Hay";
            this.amountOfHayDataGridViewTextBoxColumn.Name = "amountOfHayDataGridViewTextBoxColumn";
            this.amountOfHayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOfOatsDataGridViewTextBoxColumn
            // 
            this.amountOfOatsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountOfOatsDataGridViewTextBoxColumn.DataPropertyName = "AmountOfOats";
            this.amountOfOatsDataGridViewTextBoxColumn.HeaderText = "Oats";
            this.amountOfOatsDataGridViewTextBoxColumn.Name = "amountOfOatsDataGridViewTextBoxColumn";
            this.amountOfOatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idBoxDataGridViewTextBoxColumn
            // 
            this.idBoxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idBoxDataGridViewTextBoxColumn.DataPropertyName = "IdBox";
            this.idBoxDataGridViewTextBoxColumn.HeaderText = "IdBox";
            this.idBoxDataGridViewTextBoxColumn.Name = "idBoxDataGridViewTextBoxColumn";
            this.idBoxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.farmITDataSet;
            // 
            // farmITDataSet
            // 
            this.farmITDataSet.DataSetName = "FarmITDataSet";
            this.farmITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(991, 417);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Food";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFoodDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.typeFoodDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.foodBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(576, 290);
            this.dataGridView2.TabIndex = 0;
            // 
            // idFoodDataGridViewTextBoxColumn
            // 
            this.idFoodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idFoodDataGridViewTextBoxColumn.DataPropertyName = "IdFood";
            this.idFoodDataGridViewTextBoxColumn.HeaderText = "IdFood";
            this.idFoodDataGridViewTextBoxColumn.Name = "idFoodDataGridViewTextBoxColumn";
            this.idFoodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeFoodDataGridViewTextBoxColumn
            // 
            this.typeFoodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeFoodDataGridViewTextBoxColumn.DataPropertyName = "TypeFood";
            this.typeFoodDataGridViewTextBoxColumn.HeaderText = "TypeFood";
            this.typeFoodDataGridViewTextBoxColumn.Name = "typeFoodDataGridViewTextBoxColumn";
            this.typeFoodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.farmITDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(991, 417);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Buildings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(526, 249);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(991, 417);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Boxes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage_Create
            // 
            this.tabPage_Create.AllowDrop = true;
            this.tabPage_Create.BackColor = System.Drawing.Color.White;
            this.tabPage_Create.Controls.Add(this.button_Create);
            this.tabPage_Create.Controls.Add(this.label10);
            this.tabPage_Create.Controls.Add(this.textBox_BoxId);
            this.tabPage_Create.Controls.Add(this.button_Reset);
            this.tabPage_Create.Controls.Add(this.textBox_Id);
            this.tabPage_Create.Controls.Add(this.type);
            this.tabPage_Create.Controls.Add(this.foodTwo);
            this.tabPage_Create.Controls.Add(this.label2);
            this.tabPage_Create.Controls.Add(this.textBox_FoodTwo);
            this.tabPage_Create.Controls.Add(this.textBox_Type);
            this.tabPage_Create.Controls.Add(this.food);
            this.tabPage_Create.Controls.Add(this.textBox_Status);
            this.tabPage_Create.Controls.Add(this.label6);
            this.tabPage_Create.Controls.Add(this.textBox_Food);
            this.tabPage_Create.Controls.Add(this.label5);
            this.tabPage_Create.Controls.Add(this.textBox_Age);
            this.tabPage_Create.Controls.Add(this.label4);
            this.tabPage_Create.Controls.Add(this.textBox_Name);
            this.tabPage_Create.Controls.Add(this.label3);
            this.tabPage_Create.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Create.Name = "tabPage_Create";
            this.tabPage_Create.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Create.Size = new System.Drawing.Size(1016, 476);
            this.tabPage_Create.TabIndex = 1;
            this.tabPage_Create.Text = "Create";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(485, 377);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 9;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "IdBox";
            // 
            // textBox_BoxId
            // 
            this.textBox_BoxId.Location = new System.Drawing.Point(439, 274);
            this.textBox_BoxId.Name = "textBox_BoxId";
            this.textBox_BoxId.Size = new System.Drawing.Size(121, 20);
            this.textBox_BoxId.TabIndex = 6;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // FarmITDesktopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 573);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.textBox_Message);
            this.Name = "FarmITDesktopApp";
            this.Text = "FarmITDesktopApp";
            this.Load += new System.EventHandler(this.FarmITDesktopApp_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabPage_Info.ResumeLayout(false);
            this.tabPage_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Food)).EndInit();
            this.tabPage_Find.ResumeLayout(false);
            this.tabPage_Find.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Animal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Animals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmITDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage_Create.ResumeLayout(false);
            this.tabPage_Create.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label food;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_Food;
        private System.Windows.Forms.ComboBox textBox_Status;
        private System.Windows.Forms.Label foodTwo;
        private System.Windows.Forms.TextBox textBox_FoodTwo;
        private System.Windows.Forms.Label textBox_Message;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage_Find;
        private System.Windows.Forms.TabPage tabPage_Create;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView_Animals;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox combo_FindType;
        private System.Windows.Forms.TextBox textBox_FindById;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage_Info;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Food;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UFoodTwo;
        private System.Windows.Forms.Label UFood;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_UFoodTwo;
        private System.Windows.Forms.TextBox textBox_UFood;
        private System.Windows.Forms.TextBox textBox_UAge;
        private System.Windows.Forms.TextBox textBox_UName;
        private System.Windows.Forms.TextBox textBox_UType;
        private System.Windows.Forms.TextBox textBox_UId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_UBox;
        private System.Windows.Forms.ComboBox textBox_UStatus;
        private DatabaseAccessLayer.FarmITDataSet farmITDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private DatabaseAccessLayer.FarmITDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private DatabaseAccessLayer.FarmITDataSetTableAdapters.FoodTableAdapter foodTableAdapter;
        private System.Windows.Forms.Button button_ResetFilter;
        private System.Windows.Forms.Button button_FeedAnimals;
        private System.Windows.Forms.Label label_Oats;
        private System.Windows.Forms.Label label_Powerfeed;
        private System.Windows.Forms.Label label_Hay;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_BoxId;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfPowerfeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfHayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfOatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGrid_Animal;
    }
}