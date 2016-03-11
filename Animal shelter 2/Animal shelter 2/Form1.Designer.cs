namespace Animal_shelter_2
{
    partial class Form1
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
            this.btnStream = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbNotReserved = new System.Windows.Forms.ListBox();
            this.lbReserved = new System.Windows.Forms.ListBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGedrag = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.animalGenderComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(3, 172);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(75, 23);
            this.btnStream.TabIndex = 46;
            this.btnStream.Text = "Stream";
            this.btnStream.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(376, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNotReserved
            // 
            this.lbNotReserved.FormattingEnabled = true;
            this.lbNotReserved.Location = new System.Drawing.Point(415, 44);
            this.lbNotReserved.Name = "lbNotReserved";
            this.lbNotReserved.Size = new System.Drawing.Size(171, 264);
            this.lbNotReserved.TabIndex = 44;
            // 
            // lbReserved
            // 
            this.lbReserved.FormattingEnabled = true;
            this.lbReserved.Location = new System.Drawing.Point(236, 45);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(173, 264);
            this.lbReserved.TabIndex = 43;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(306, 15);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(64, 23);
            this.btnReserve.TabIndex = 42;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(189, 120);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(38, 20);
            this.tbYear.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Jaar";
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(131, 120);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(19, 20);
            this.tbMonth.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Maand";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(60, 120);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(19, 20);
            this.tbDay.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Dag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Gedrag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "geslacht";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Soort";
            // 
            // tbGedrag
            // 
            this.tbGedrag.Location = new System.Drawing.Point(60, 97);
            this.tbGedrag.Name = "tbGedrag";
            this.tbGedrag.Size = new System.Drawing.Size(100, 20);
            this.tbGedrag.TabIndex = 31;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(60, 71);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 30;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(441, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(511, 15);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 26;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(166, 16);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 25;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(60, 18);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.animalTypeComboBox.TabIndex = 24;
            // 
            // animalGenderComboBox
            // 
            this.animalGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalGenderComboBox.FormattingEnabled = true;
            this.animalGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.animalGenderComboBox.Location = new System.Drawing.Point(60, 44);
            this.animalGenderComboBox.Name = "animalGenderComboBox";
            this.animalGenderComboBox.Size = new System.Drawing.Size(100, 21);
            this.animalGenderComboBox.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 462);
            this.Controls.Add(this.animalGenderComboBox);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbNotReserved);
            this.Controls.Add(this.lbReserved);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGedrag);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbNotReserved;
        private System.Windows.Forms.ListBox lbReserved;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGedrag;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.ComboBox animalGenderComboBox;

    }
}

