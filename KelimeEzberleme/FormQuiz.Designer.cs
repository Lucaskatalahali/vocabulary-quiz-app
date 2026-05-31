namespace KelimeEzberleme
{
    partial class FormQuiz
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
            tableLayoutPanelInfo = new TableLayoutPanel();
            labelProgress = new Label();
            labelScore = new Label();
            buttonOpsyon1 = new Button();
            buttonOpsyon2 = new Button();
            buttonOpsyon3 = new Button();
            buttonOpsyon4 = new Button();
            labelSoru = new Label();
            tableLayoutPanelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelInfo
            // 
            tableLayoutPanelInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelInfo.BackColor = Color.Teal;
            tableLayoutPanelInfo.ColumnCount = 2;
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.Controls.Add(labelProgress, 0, 0);
            tableLayoutPanelInfo.Controls.Add(labelScore, 1, 0);
            tableLayoutPanelInfo.Location = new Point(13, 0);
            tableLayoutPanelInfo.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            tableLayoutPanelInfo.RowCount = 1;
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelInfo.Size = new Size(992, 88);
            tableLayoutPanelInfo.TabIndex = 0;
            // 
            // labelProgress
            // 
            labelProgress.Anchor = AnchorStyles.Left;
            labelProgress.AutoSize = true;
            labelProgress.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            labelProgress.ForeColor = Color.White;
            labelProgress.Location = new Point(4, 24);
            labelProgress.Margin = new Padding(4, 0, 4, 0);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(112, 40);
            labelProgress.TabIndex = 0;
            labelProgress.Text = "1/999";
            labelProgress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelScore
            // 
            labelScore.Anchor = AnchorStyles.Right;
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            labelScore.ForeColor = Color.White;
            labelScore.Location = new Point(950, 24);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(38, 40);
            labelScore.TabIndex = 1;
            labelScore.Text = "0";
            labelScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonOpsyon1
            // 
            buttonOpsyon1.ForeColor = Color.FromArgb(30, 30, 30);
            buttonOpsyon1.Location = new Point(14, 266);
            buttonOpsyon1.Margin = new Padding(4, 3, 4, 3);
            buttonOpsyon1.Name = "buttonOpsyon1";
            buttonOpsyon1.Size = new Size(481, 126);
            buttonOpsyon1.TabIndex = 2;
            buttonOpsyon1.Text = "button1";
            buttonOpsyon1.UseVisualStyleBackColor = true;
            buttonOpsyon1.Click += cevapKontrol;
            // 
            // buttonOpsyon2
            // 
            buttonOpsyon2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpsyon2.ForeColor = Color.FromArgb(30, 30, 30);
            buttonOpsyon2.Location = new Point(523, 266);
            buttonOpsyon2.Margin = new Padding(4, 3, 4, 3);
            buttonOpsyon2.Name = "buttonOpsyon2";
            buttonOpsyon2.Size = new Size(481, 126);
            buttonOpsyon2.TabIndex = 9;
            buttonOpsyon2.Text = "button2";
            buttonOpsyon2.UseVisualStyleBackColor = true;
            buttonOpsyon2.Click += cevapKontrol;
            // 
            // buttonOpsyon3
            // 
            buttonOpsyon3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOpsyon3.ForeColor = Color.FromArgb(30, 30, 30);
            buttonOpsyon3.Location = new Point(14, 413);
            buttonOpsyon3.Margin = new Padding(4, 3, 4, 3);
            buttonOpsyon3.Name = "buttonOpsyon3";
            buttonOpsyon3.Size = new Size(481, 126);
            buttonOpsyon3.TabIndex = 10;
            buttonOpsyon3.Text = "button3";
            buttonOpsyon3.UseVisualStyleBackColor = true;
            buttonOpsyon3.Click += cevapKontrol;
            // 
            // buttonOpsyon4
            // 
            buttonOpsyon4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOpsyon4.ForeColor = Color.FromArgb(30, 30, 30);
            buttonOpsyon4.Location = new Point(522, 413);
            buttonOpsyon4.Margin = new Padding(4, 3, 4, 3);
            buttonOpsyon4.Name = "buttonOpsyon4";
            buttonOpsyon4.Size = new Size(481, 126);
            buttonOpsyon4.TabIndex = 11;
            buttonOpsyon4.Text = "button4";
            buttonOpsyon4.UseVisualStyleBackColor = true;
            buttonOpsyon4.Click += cevapKontrol;
            // 
            // labelSoru
            // 
            labelSoru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSoru.BackColor = Color.SteelBlue;
            labelSoru.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSoru.ForeColor = Color.White;
            labelSoru.Location = new Point(14, 100);
            labelSoru.Margin = new Padding(4, 0, 4, 0);
            labelSoru.Name = "labelSoru";
            labelSoru.Size = new Size(992, 150);
            labelSoru.TabIndex = 1;
            labelSoru.Text = "Soru";
            labelSoru.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormQuiz
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 553);
            Controls.Add(buttonOpsyon4);
            Controls.Add(buttonOpsyon3);
            Controls.Add(buttonOpsyon2);
            Controls.Add(buttonOpsyon1);
            Controls.Add(labelSoru);
            Controls.Add(tableLayoutPanelInfo);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çoktan Seçmeli Sorular";
            tableLayoutPanelInfo.ResumeLayout(false);
            tableLayoutPanelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelInfo;
        private Label labelProgress;
        private Label labelScore;
        private Button buttonOpsyon1;
        private Button buttonOpsyon2;
        private Button buttonOpsyon3;
        private Button buttonOpsyon4;
        private Label labelSoru;
    }
}