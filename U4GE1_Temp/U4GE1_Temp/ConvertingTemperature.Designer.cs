namespace U4GE1_Temp
{
    partial class ConvertingTemperature
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
            this.prompt = new System.Windows.Forms.Label();
            this.tempInput = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.farenheitOutput = new System.Windows.Forms.Label();
            this.celsiusOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.Location = new System.Drawing.Point(48, 59);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(240, 20);
            this.prompt.TabIndex = 0;
            this.prompt.Text = "Enter Temperature in Fahrenheit";
            // 
            // tempInput
            // 
            this.tempInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempInput.Location = new System.Drawing.Point(52, 82);
            this.tempInput.Name = "tempInput";
            this.tempInput.Size = new System.Drawing.Size(172, 26);
            this.tempInput.TabIndex = 1;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(236, 82);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 26);
            this.convert.TabIndex = 2;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // farenheitOutput
            // 
            this.farenheitOutput.AutoSize = true;
            this.farenheitOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farenheitOutput.Location = new System.Drawing.Point(48, 124);
            this.farenheitOutput.Name = "farenheitOutput";
            this.farenheitOutput.Size = new System.Drawing.Size(0, 13);
            this.farenheitOutput.TabIndex = 3;
            // 
            // celsiusOutput
            // 
            this.celsiusOutput.AutoSize = true;
            this.celsiusOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celsiusOutput.Location = new System.Drawing.Point(48, 144);
            this.celsiusOutput.Name = "celsiusOutput";
            this.celsiusOutput.Size = new System.Drawing.Size(0, 20);
            this.celsiusOutput.TabIndex = 4;
            // 
            // ConvertingTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(427, 283);
            this.Controls.Add(this.celsiusOutput);
            this.Controls.Add(this.farenheitOutput);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.tempInput);
            this.Controls.Add(this.prompt);
            this.Name = "ConvertingTemperature";
            this.Text = "Converting Temperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.TextBox tempInput;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label farenheitOutput;
        private System.Windows.Forms.Label celsiusOutput;
    }
}

