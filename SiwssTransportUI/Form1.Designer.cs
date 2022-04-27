namespace SiwssTransportUI
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
            this.placeholderBoxVon = new PlaceholderTextBox.PlaceholderTextBox();
            this.placeholderBoxBis = new PlaceholderTextBox.PlaceholderTextBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeholderBoxVon
            // 
            this.placeholderBoxVon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placeholderBoxVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.placeholderBoxVon.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeholderBoxVon.ForeColor = System.Drawing.Color.Silver;
            this.placeholderBoxVon.Location = new System.Drawing.Point(12, 12);
            this.placeholderBoxVon.Name = "placeholderBoxVon";
            this.placeholderBoxVon.PlaceholderText = "Von";
            this.placeholderBoxVon.Size = new System.Drawing.Size(381, 70);
            this.placeholderBoxVon.TabIndex = 1;
            this.placeholderBoxVon.TextChanged += new System.EventHandler(this.placeholderTextBox1_TextChanged);
            // 
            // placeholderBoxBis
            // 
            this.placeholderBoxBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.placeholderBoxBis.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeholderBoxBis.ForeColor = System.Drawing.Color.Silver;
            this.placeholderBoxBis.Location = new System.Drawing.Point(407, 12);
            this.placeholderBoxBis.Name = "placeholderBoxBis";
            this.placeholderBoxBis.PlaceholderText = "Bis";
            this.placeholderBoxBis.Size = new System.Drawing.Size(381, 70);
            this.placeholderBoxBis.TabIndex = 2;
            this.placeholderBoxBis.TextChanged += new System.EventHandler(this.placeholderBoxBis_TextChanged);
            // 
            // btnSuchen
            // 
            this.btnSuchen.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSuchen.Location = new System.Drawing.Point(12, 88);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(776, 35);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.placeholderBoxBis);
            this.Controls.Add(this.placeholderBoxVon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlaceholderTextBox.PlaceholderTextBox placeholderBoxVon;
        private PlaceholderTextBox.PlaceholderTextBox placeholderBoxBis;
        private Button btnSuchen;
    }
}