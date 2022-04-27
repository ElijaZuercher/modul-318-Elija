namespace SiwssTransportUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lbl4Verbindungen = new System.Windows.Forms.Label();
            this.listbox4Verbindungen = new System.Windows.Forms.ListBox();
            this.lblAbfahrt = new System.Windows.Forms.Label();
            this.listBoxAbfahrt = new System.Windows.Forms.ListBox();
            this.cmbBoxStart = new System.Windows.Forms.ComboBox();
            this.cmbBoxEnde = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuchen.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuchen.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSuchen.Location = new System.Drawing.Point(12, 88);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(778, 57);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // lbl4Verbindungen
            // 
            this.lbl4Verbindungen.AutoSize = true;
            this.lbl4Verbindungen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4Verbindungen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl4Verbindungen.Location = new System.Drawing.Point(8, 149);
            this.lbl4Verbindungen.Name = "lbl4Verbindungen";
            this.lbl4Verbindungen.Size = new System.Drawing.Size(266, 31);
            this.lbl4Verbindungen.TabIndex = 4;
            this.lbl4Verbindungen.Text = "Nächste 4 Verbindungen";
            this.lbl4Verbindungen.Click += new System.EventHandler(this.label1_Click);
            // 
            // listbox4Verbindungen
            // 
            this.listbox4Verbindungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listbox4Verbindungen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listbox4Verbindungen.ForeColor = System.Drawing.Color.Silver;
            this.listbox4Verbindungen.FormattingEnabled = true;
            this.listbox4Verbindungen.ItemHeight = 31;
            this.listbox4Verbindungen.Location = new System.Drawing.Point(12, 183);
            this.listbox4Verbindungen.Name = "listbox4Verbindungen";
            this.listbox4Verbindungen.Size = new System.Drawing.Size(776, 190);
            this.listbox4Verbindungen.TabIndex = 5;
            // 
            // lblAbfahrt
            // 
            this.lblAbfahrt.AutoSize = true;
            this.lblAbfahrt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbfahrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAbfahrt.Location = new System.Drawing.Point(8, 376);
            this.lblAbfahrt.Name = "lblAbfahrt";
            this.lblAbfahrt.Size = new System.Drawing.Size(153, 31);
            this.lblAbfahrt.TabIndex = 6;
            this.lblAbfahrt.Text = "Abfahrts Tafel";
            this.lblAbfahrt.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxAbfahrt
            // 
            this.listBoxAbfahrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxAbfahrt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxAbfahrt.ForeColor = System.Drawing.Color.Silver;
            this.listBoxAbfahrt.FormattingEnabled = true;
            this.listBoxAbfahrt.ItemHeight = 31;
            this.listBoxAbfahrt.Location = new System.Drawing.Point(12, 410);
            this.listBoxAbfahrt.Name = "listBoxAbfahrt";
            this.listBoxAbfahrt.Size = new System.Drawing.Size(776, 128);
            this.listBoxAbfahrt.TabIndex = 7;
            // 
            // cmbBoxStart
            // 
            this.cmbBoxStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbBoxStart.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxStart.ForeColor = System.Drawing.Color.Silver;
            this.cmbBoxStart.FormattingEnabled = true;
            this.cmbBoxStart.Location = new System.Drawing.Point(12, 12);
            this.cmbBoxStart.Name = "cmbBoxStart";
            this.cmbBoxStart.Size = new System.Drawing.Size(382, 70);
            this.cmbBoxStart.TabIndex = 9;
            // 
            // cmbBoxEnde
            // 
            this.cmbBoxEnde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbBoxEnde.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxEnde.ForeColor = System.Drawing.Color.Silver;
            this.cmbBoxEnde.FormattingEnabled = true;
            this.cmbBoxEnde.Location = new System.Drawing.Point(408, 12);
            this.cmbBoxEnde.Name = "cmbBoxEnde";
            this.cmbBoxEnde.Size = new System.Drawing.Size(382, 70);
            this.cmbBoxEnde.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.cmbBoxEnde);
            this.Controls.Add(this.cmbBoxStart);
            this.Controls.Add(this.listBoxAbfahrt);
            this.Controls.Add(this.lblAbfahrt);
            this.Controls.Add(this.listbox4Verbindungen);
            this.Controls.Add(this.lbl4Verbindungen);
            this.Controls.Add(this.btnSuchen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SwissTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSuchen;
        private Label lbl4Verbindungen;
        private ListBox listbox4Verbindungen;
        private Label lblAbfahrt;
        private ListBox listBoxAbfahrt;
        private ComboBox cmbBoxStart;
        private ComboBox cmbBoxEnde;
    }
}