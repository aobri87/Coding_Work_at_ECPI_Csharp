
namespace GradeBook
{
    partial class Grade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(192, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(282, 26);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(192, 81);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(282, 26);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(192, 125);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(282, 26);
            this.idTextBox.TabIndex = 7;
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(192, 167);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(282, 26);
            this.courseTextBox.TabIndex = 8;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(192, 209);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(282, 26);
            this.gradeTextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(19, 272);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 33);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save As";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(141, 272);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(116, 33);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Enabled = false;
            this.enterButton.Location = new System.Drawing.Point(263, 272);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(116, 33);
            this.enterButton.TabIndex = 12;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 327);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(395, 287);
            this.textBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Grades";
            // 
            // exitButton
            // 
            this.exitButton.Enabled = false;
            this.exitButton.Location = new System.Drawing.Point(385, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 33);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 639);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Grade";
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exitButton;
    }
}

