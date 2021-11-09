
namespace _5._8_Final_Exam_Part_2
{
    partial class studentPoll
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
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.txtbxResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer result (1-10) and press Enter:";
            // 
            // inputTxt
            // 
            this.inputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTxt.Location = new System.Drawing.Point(103, 136);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(214, 35);
            this.inputTxt.TabIndex = 1;
            this.inputTxt.TextChanged += new System.EventHandler(this.inputTxt_TextChanged);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(377, 131);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(142, 39);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnResults
            // 
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.Location = new System.Drawing.Point(164, 197);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(317, 61);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "View Survey Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // txtbxResults
            // 
            this.txtbxResults.Location = new System.Drawing.Point(119, 292);
            this.txtbxResults.Multiline = true;
            this.txtbxResults.Name = "txtbxResults";
            this.txtbxResults.ReadOnly = true;
            this.txtbxResults.Size = new System.Drawing.Size(431, 573);
            this.txtbxResults.TabIndex = 4;
            // 
            // studentPoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 910);
            this.Controls.Add(this.txtbxResults);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.label1);
            this.Name = "studentPoll";
            this.Text = "Student Poll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txtbxResults;
    }
}

