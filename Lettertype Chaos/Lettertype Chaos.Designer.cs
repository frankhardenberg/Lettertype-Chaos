﻿namespace Lettertype_Chaos
{
    partial class LettertypeChaos
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
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(776, 154);
            this.Input.TabIndex = 0;
            this.Input.Text = "";
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(12, 284);
            this.Output.MaximumSize = new System.Drawing.Size(776, 154);
            this.Output.MinimumSize = new System.Drawing.Size(776, 154);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(776, 154);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Convert
            // 
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(12, 172);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(776, 106);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // LettertypeChaos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.MaximizeBox = false;
            this.Name = "LettertypeChaos";
            this.Text = "Lettertype Chaos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Convert;
    }
}
