namespace WhatToCookForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bool_fiber = new System.Windows.Forms.CheckBox();
            this.bool_lactose = new System.Windows.Forms.CheckBox();
            this.bool_simpleSugar = new System.Windows.Forms.CheckBox();
            this.bool_transFat = new System.Windows.Forms.CheckBox();
            this.bool_vegeterian = new System.Windows.Forms.CheckBox();
            this.bool_vegan = new System.Windows.Forms.CheckBox();
            this.bool_gluten = new System.Windows.Forms.CheckBox();
            this.txt_ingName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoIngAll = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.findClear = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.checkBoxGluten = new System.Windows.Forms.CheckBox();
            this.checkBoxLose = new System.Windows.Forms.CheckBox();
            this.checkBoxGain = new System.Windows.Forms.CheckBox();
            this.checkBoxLactose = new System.Windows.Forms.CheckBox();
            this.checkBoxVegeterian = new System.Windows.Forms.CheckBox();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bool_fiber);
            this.groupBox1.Controls.Add(this.bool_lactose);
            this.groupBox1.Controls.Add(this.bool_simpleSugar);
            this.groupBox1.Controls.Add(this.bool_transFat);
            this.groupBox1.Controls.Add(this.bool_vegeterian);
            this.groupBox1.Controls.Add(this.bool_vegan);
            this.groupBox1.Controls.Add(this.bool_gluten);
            this.groupBox1.Controls.Add(this.txt_ingName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 217);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ingredient";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bool_fiber
            // 
            this.bool_fiber.AutoSize = true;
            this.bool_fiber.Location = new System.Drawing.Point(6, 195);
            this.bool_fiber.Name = "bool_fiber";
            this.bool_fiber.Size = new System.Drawing.Size(52, 19);
            this.bool_fiber.TabIndex = 15;
            this.bool_fiber.Text = "Fiber";
            this.bool_fiber.UseVisualStyleBackColor = true;
            // 
            // bool_lactose
            // 
            this.bool_lactose.AutoSize = true;
            this.bool_lactose.Location = new System.Drawing.Point(6, 170);
            this.bool_lactose.Name = "bool_lactose";
            this.bool_lactose.Size = new System.Drawing.Size(66, 19);
            this.bool_lactose.TabIndex = 14;
            this.bool_lactose.Text = "Lactose";
            this.bool_lactose.UseVisualStyleBackColor = true;
            this.bool_lactose.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // bool_simpleSugar
            // 
            this.bool_simpleSugar.AutoSize = true;
            this.bool_simpleSugar.Location = new System.Drawing.Point(6, 145);
            this.bool_simpleSugar.Name = "bool_simpleSugar";
            this.bool_simpleSugar.Size = new System.Drawing.Size(95, 19);
            this.bool_simpleSugar.TabIndex = 13;
            this.bool_simpleSugar.Text = "Simple Sugar";
            this.bool_simpleSugar.UseVisualStyleBackColor = true;
            // 
            // bool_transFat
            // 
            this.bool_transFat.AutoSize = true;
            this.bool_transFat.Location = new System.Drawing.Point(6, 120);
            this.bool_transFat.Name = "bool_transFat";
            this.bool_transFat.Size = new System.Drawing.Size(72, 19);
            this.bool_transFat.TabIndex = 12;
            this.bool_transFat.Text = "Trans Fat";
            this.bool_transFat.UseVisualStyleBackColor = true;
            // 
            // bool_vegeterian
            // 
            this.bool_vegeterian.AutoSize = true;
            this.bool_vegeterian.Location = new System.Drawing.Point(6, 95);
            this.bool_vegeterian.Name = "bool_vegeterian";
            this.bool_vegeterian.Size = new System.Drawing.Size(81, 19);
            this.bool_vegeterian.TabIndex = 11;
            this.bool_vegeterian.Text = "Vegeterian";
            this.bool_vegeterian.UseVisualStyleBackColor = true;
            // 
            // bool_vegan
            // 
            this.bool_vegan.AutoSize = true;
            this.bool_vegan.Location = new System.Drawing.Point(6, 70);
            this.bool_vegan.Name = "bool_vegan";
            this.bool_vegan.Size = new System.Drawing.Size(58, 19);
            this.bool_vegan.TabIndex = 10;
            this.bool_vegan.Text = "Vegan";
            this.bool_vegan.UseVisualStyleBackColor = true;
            this.bool_vegan.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // bool_gluten
            // 
            this.bool_gluten.AutoSize = true;
            this.bool_gluten.Location = new System.Drawing.Point(6, 45);
            this.bool_gluten.Name = "bool_gluten";
            this.bool_gluten.Size = new System.Drawing.Size(61, 19);
            this.bool_gluten.TabIndex = 9;
            this.bool_gluten.Text = "Gluten";
            this.bool_gluten.UseVisualStyleBackColor = true;
            // 
            // txt_ingName
            // 
            this.txt_ingName.Location = new System.Drawing.Point(52, 21);
            this.txt_ingName.Name = "txt_ingName";
            this.txt_ingName.Size = new System.Drawing.Size(124, 23);
            this.txt_ingName.TabIndex = 8;
            this.txt_ingName.TextChanged += new System.EventHandler(this.txt_ingName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoIngAll);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDishName);
            this.groupBox2.Location = new System.Drawing.Point(195, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 214);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Recipe";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cBoIngAll
            // 
            this.cBoIngAll.FormattingEnabled = true;
            this.cBoIngAll.Location = new System.Drawing.Point(73, 46);
            this.cBoIngAll.Name = "cBoIngAll";
            this.cBoIngAll.Size = new System.Drawing.Size(111, 23);
            this.cBoIngAll.TabIndex = 7;
            this.cBoIngAll.SelectedIndexChanged += new System.EventHandler(this.cBoIngAll_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Added Ingredients";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(7, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 94);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(73, 16);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(111, 23);
            this.txtDishName.TabIndex = 0;
            this.txtDishName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WhatToCookForm.Form1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.findClear);
            this.groupBox3.Controls.Add(this.buttonFind);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.checkBoxGluten);
            this.groupBox3.Controls.Add(this.checkBoxLose);
            this.groupBox3.Controls.Add(this.checkBoxGain);
            this.groupBox3.Controls.Add(this.checkBoxLactose);
            this.groupBox3.Controls.Add(this.checkBoxVegeterian);
            this.groupBox3.Controls.Add(this.checkBoxVegan);
            this.groupBox3.Location = new System.Drawing.Point(391, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 217);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find What To Cook";
            // 
            // findClear
            // 
            this.findClear.Location = new System.Drawing.Point(76, 189);
            this.findClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findClear.Name = "findClear";
            this.findClear.Size = new System.Drawing.Size(55, 21);
            this.findClear.TabIndex = 11;
            this.findClear.Text = "Clear";
            this.findClear.UseVisualStyleBackColor = true;
            this.findClear.Click += new System.EventHandler(this.findClear_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(6, 189);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(60, 22);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(137, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(132, 184);
            this.listBox2.TabIndex = 6;
            // 
            // checkBoxGluten
            // 
            this.checkBoxGluten.AutoSize = true;
            this.checkBoxGluten.Location = new System.Drawing.Point(3, 92);
            this.checkBoxGluten.Name = "checkBoxGluten";
            this.checkBoxGluten.Size = new System.Drawing.Size(101, 19);
            this.checkBoxGluten.TabIndex = 5;
            this.checkBoxGluten.Text = "Gluten Allergy";
            this.checkBoxGluten.UseVisualStyleBackColor = true;
            // 
            // checkBoxLose
            // 
            this.checkBoxLose.AutoSize = true;
            this.checkBoxLose.Location = new System.Drawing.Point(3, 142);
            this.checkBoxLose.Name = "checkBoxLose";
            this.checkBoxLose.Size = new System.Drawing.Size(91, 19);
            this.checkBoxLose.TabIndex = 4;
            this.checkBoxLose.Text = "Lose Weight";
            this.checkBoxLose.UseVisualStyleBackColor = true;
            // 
            // checkBoxGain
            // 
            this.checkBoxGain.AutoSize = true;
            this.checkBoxGain.Location = new System.Drawing.Point(3, 117);
            this.checkBoxGain.Name = "checkBoxGain";
            this.checkBoxGain.Size = new System.Drawing.Size(91, 19);
            this.checkBoxGain.TabIndex = 3;
            this.checkBoxGain.Text = "Gain Weight";
            this.checkBoxGain.UseVisualStyleBackColor = true;
            // 
            // checkBoxLactose
            // 
            this.checkBoxLactose.AutoSize = true;
            this.checkBoxLactose.Location = new System.Drawing.Point(3, 69);
            this.checkBoxLactose.Name = "checkBoxLactose";
            this.checkBoxLactose.Size = new System.Drawing.Size(128, 19);
            this.checkBoxLactose.TabIndex = 2;
            this.checkBoxLactose.Text = "Lactose Intolerance";
            this.checkBoxLactose.UseVisualStyleBackColor = true;
            // 
            // checkBoxVegeterian
            // 
            this.checkBoxVegeterian.AutoSize = true;
            this.checkBoxVegeterian.Location = new System.Drawing.Point(3, 44);
            this.checkBoxVegeterian.Name = "checkBoxVegeterian";
            this.checkBoxVegeterian.Size = new System.Drawing.Size(81, 19);
            this.checkBoxVegeterian.TabIndex = 1;
            this.checkBoxVegeterian.Text = "Vegeterian";
            this.checkBoxVegeterian.UseVisualStyleBackColor = true;
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.Location = new System.Drawing.Point(3, 19);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(58, 19);
            this.checkBoxVegan.TabIndex = 0;
            this.checkBoxVegan.Text = "Vegan";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            this.checkBoxVegan.CheckedChanged += new System.EventHandler(this.checkBoxVegan_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 236);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "What To Cook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox bool_vegan;
        private CheckBox bool_gluten;
        private TextBox txt_ingName;
        private CheckBox bool_lactose;
        private CheckBox bool_simpleSugar;
        private CheckBox bool_transFat;
        private CheckBox bool_vegeterian;
        private CheckBox bool_fiber;
        private Button button2;
        private GroupBox groupBox2;
        private Button button1;
        private Label label4;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
        private TextBox txtDishName;
        private BindingSource form1BindingSource;
        private ComboBox cBoIngAll;
        private GroupBox groupBox3;
        private Button buttonFind;
        private ListBox listBox2;
        private CheckBox checkBoxGluten;
        private CheckBox checkBoxLose;
        private CheckBox checkBoxGain;
        private CheckBox checkBoxLactose;
        private CheckBox checkBoxVegeterian;
        private CheckBox checkBoxVegan;
        private Button findClear;
    }
}