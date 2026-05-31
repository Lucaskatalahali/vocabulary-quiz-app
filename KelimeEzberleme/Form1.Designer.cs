namespace KelimeEzberleme
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
            comboBoxSozluk = new ComboBox();
            buttonYukle = new Button();
            buttonBaslat = new Button();
            buttonCikis = new Button();
            groupBoxSozluk = new GroupBox();
            groupBoxSozluk.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxSozluk
            // 
            comboBoxSozluk.AccessibleDescription = "";
            comboBoxSozluk.AccessibleName = "";
            comboBoxSozluk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSozluk.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSozluk.Font = new Font("Calibri", 12F);
            comboBoxSozluk.FormattingEnabled = true;
            comboBoxSozluk.Location = new Point(24, 48);
            comboBoxSozluk.Name = "comboBoxSozluk";
            comboBoxSozluk.Size = new Size(683, 37);
            comboBoxSozluk.TabIndex = 0;
            comboBoxSozluk.Tag = "";
            comboBoxSozluk.SelectedIndexChanged += comboBoxSozluk_SelectedIndexChanged;
            // 
            // buttonYukle
            // 
            buttonYukle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonYukle.Font = new Font("Calibri", 12F);
            buttonYukle.Location = new Point(349, 184);
            buttonYukle.Name = "buttonYukle";
            buttonYukle.Size = new Size(112, 45);
            buttonYukle.TabIndex = 1;
            buttonYukle.Text = "Yükle";
            buttonYukle.UseVisualStyleBackColor = true;
            buttonYukle.Click += buttonYukle_Click;
            // 
            // buttonBaslat
            // 
            buttonBaslat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonBaslat.Enabled = false;
            buttonBaslat.Font = new Font("Calibri", 12F);
            buttonBaslat.Location = new Point(497, 184);
            buttonBaslat.Name = "buttonBaslat";
            buttonBaslat.Size = new Size(112, 45);
            buttonBaslat.TabIndex = 2;
            buttonBaslat.Text = "Başlat";
            buttonBaslat.UseVisualStyleBackColor = true;
            buttonBaslat.Click += buttonBaslat_Click;
            // 
            // buttonCikis
            // 
            buttonCikis.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCikis.Font = new Font("Calibri", 12F);
            buttonCikis.Location = new Point(654, 184);
            buttonCikis.Name = "buttonCikis";
            buttonCikis.Size = new Size(112, 45);
            buttonCikis.TabIndex = 3;
            buttonCikis.Text = "Çıkış";
            buttonCikis.UseVisualStyleBackColor = true;
            buttonCikis.Click += buttonCikis_Click;
            // 
            // groupBoxSozluk
            // 
            groupBoxSozluk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSozluk.Controls.Add(comboBoxSozluk);
            groupBoxSozluk.Font = new Font("Calibri", 12F);
            groupBoxSozluk.Location = new Point(45, 12);
            groupBoxSozluk.Name = "groupBoxSozluk";
            groupBoxSozluk.Size = new Size(721, 117);
            groupBoxSozluk.TabIndex = 4;
            groupBoxSozluk.TabStop = false;
            groupBoxSozluk.Text = "Sözlük";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 263);
            Controls.Add(groupBoxSozluk);
            Controls.Add(buttonCikis);
            Controls.Add(buttonBaslat);
            Controls.Add(buttonYukle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelime Ezber";
            Load += Form1_Load;
            groupBoxSozluk.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxSozluk;
        private Button buttonYukle;
        private Button buttonBaslat;
        private Button buttonCikis;
        private GroupBox groupBoxSozluk;
    }
}
