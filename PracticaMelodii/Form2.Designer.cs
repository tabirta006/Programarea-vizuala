namespace PracticaMelodii
{
    partial class Form2
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
            label1 = new Label();
            comboBoxFavoriteMelody = new ComboBox();
            label2 = new Label();
            textConcursID = new TextBox();
            textMelodieID = new TextBox();
            textIntervievatID = new TextBox();
            textRating = new TextBox();
            buttonSubmit = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(966, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // comboBoxFavoriteMelody
            // 
            comboBoxFavoriteMelody.FormattingEnabled = true;
            comboBoxFavoriteMelody.Location = new Point(512, 409);
            comboBoxFavoriteMelody.Name = "comboBoxFavoriteMelody";
            comboBoxFavoriteMelody.Size = new Size(175, 23);
            comboBoxFavoriteMelody.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(404, 30);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 3;
            label2.Text = "Concurs-Sondaj";
            // 
            // textConcursID
            // 
            textConcursID.Location = new Point(512, 131);
            textConcursID.Name = "textConcursID";
            textConcursID.Size = new Size(175, 23);
            textConcursID.TabIndex = 4;
            // 
            // textMelodieID
            // 
            textMelodieID.Location = new Point(512, 210);
            textMelodieID.Name = "textMelodieID";
            textMelodieID.Size = new Size(175, 23);
            textMelodieID.TabIndex = 5;
            // 
            // textIntervievatID
            // 
            textIntervievatID.Location = new Point(512, 274);
            textIntervievatID.Name = "textIntervievatID";
            textIntervievatID.Size = new Size(175, 23);
            textIntervievatID.TabIndex = 6;
            // 
            // textRating
            // 
            textRating.Location = new Point(512, 338);
            textRating.Name = "textRating";
            textRating.Size = new Size(175, 23);
            textRating.TabIndex = 7;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.GradientActiveCaption;
            buttonSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.ForeColor = Color.Brown;
            buttonSubmit.Location = new Point(770, 364);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(164, 68);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Trimite sondajul";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 131);
            label3.Name = "label3";
            label3.Size = new Size(329, 25);
            label3.TabIndex = 9;
            label3.Text = "Introduceți codul de concurs al dvs.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(161, 210);
            label4.Name = "label4";
            label4.Size = new Size(248, 25);
            label4.TabIndex = 10;
            label4.Text = "Introduceți codul melodiei";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(161, 274);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 11;
            label5.Text = "Introduceți codul dvs.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(161, 338);
            label6.Name = "label6";
            label6.Size = new Size(223, 25);
            label6.TabIndex = 12;
            label6.Text = "Apreciază melodia (1-5)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(161, 409);
            label7.Name = "label7";
            label7.Size = new Size(212, 25);
            label7.TabIndex = 13;
            label7.Text = "Alege melodia favorită";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(28, 462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(738, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(662, 502);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(61, 49);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1008, 651);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonSubmit);
            Controls.Add(textRating);
            Controls.Add(textIntervievatID);
            Controls.Add(textMelodieID);
            Controls.Add(textConcursID);
            Controls.Add(label2);
            Controls.Add(comboBoxFavoriteMelody);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxFavoriteMelody;
        private Label label2;
        private TextBox textConcursID;
        private TextBox textMelodieID;
        private TextBox textIntervievatID;
        private TextBox textRating;
        private Button buttonSubmit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}