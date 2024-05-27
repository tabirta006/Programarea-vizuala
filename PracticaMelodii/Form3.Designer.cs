namespace PracticaMelodii
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textID = new TextBox();
            textNume = new TextBox();
            textArtist = new TextBox();
            textAn = new TextBox();
            textGen = new TextBox();
            buttonInsertMelodie = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            buttonInsertIntervievat = new Button();
            textIntervievatID = new TextBox();
            textNumeIntervievat = new TextBox();
            textPrenumeIntervievat = new TextBox();
            textVarsta = new TextBox();
            textOras = new TextBox();
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
            label1.Location = new Point(943, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(72, 62);
            label2.Name = "label2";
            label2.Size = new Size(244, 30);
            label2.TabIndex = 2;
            label2.Text = "Înregistrează o melodie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(537, 62);
            label3.Name = "label3";
            label3.Size = new Size(286, 30);
            label3.TabIndex = 3;
            label3.Text = "Înregistrează un intervievat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(72, 167);
            label4.Name = "label4";
            label4.Size = new Size(27, 21);
            label4.TabIndex = 4;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(72, 230);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 5;
            label5.Text = "Nume";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(72, 291);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 6;
            label6.Text = "Artist";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(72, 356);
            label7.Name = "label7";
            label7.Size = new Size(31, 21);
            label7.TabIndex = 7;
            label7.Text = "An";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(72, 423);
            label8.Name = "label8";
            label8.Size = new Size(40, 21);
            label8.TabIndex = 8;
            label8.Text = "Gen";
            // 
            // textID
            // 
            textID.Location = new Point(142, 169);
            textID.Name = "textID";
            textID.Size = new Size(160, 23);
            textID.TabIndex = 9;
            // 
            // textNume
            // 
            textNume.Location = new Point(142, 232);
            textNume.Name = "textNume";
            textNume.Size = new Size(160, 23);
            textNume.TabIndex = 10;
            // 
            // textArtist
            // 
            textArtist.Location = new Point(142, 291);
            textArtist.Name = "textArtist";
            textArtist.Size = new Size(160, 23);
            textArtist.TabIndex = 11;
            // 
            // textAn
            // 
            textAn.Location = new Point(142, 358);
            textAn.Name = "textAn";
            textAn.Size = new Size(160, 23);
            textAn.TabIndex = 12;
            // 
            // textGen
            // 
            textGen.Location = new Point(142, 425);
            textGen.Name = "textGen";
            textGen.Size = new Size(160, 23);
            textGen.TabIndex = 13;
            // 
            // buttonInsertMelodie
            // 
            buttonInsertMelodie.BackColor = Color.Crimson;
            buttonInsertMelodie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertMelodie.ForeColor = SystemColors.ControlText;
            buttonInsertMelodie.Location = new Point(142, 497);
            buttonInsertMelodie.Name = "buttonInsertMelodie";
            buttonInsertMelodie.Size = new Size(160, 53);
            buttonInsertMelodie.TabIndex = 14;
            buttonInsertMelodie.Text = "Înregistrează melodia";
            buttonInsertMelodie.UseVisualStyleBackColor = false;
            buttonInsertMelodie.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(521, 171);
            label9.Name = "label9";
            label9.Size = new Size(27, 21);
            label9.TabIndex = 15;
            label9.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(521, 230);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 16;
            label10.Text = "Nume";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(521, 289);
            label11.Name = "label11";
            label11.Size = new Size(79, 21);
            label11.TabIndex = 17;
            label11.Text = "Prenume";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(521, 360);
            label12.Name = "label12";
            label12.Size = new Size(57, 21);
            label12.TabIndex = 18;
            label12.Text = "Varsta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(521, 423);
            label13.Name = "label13";
            label13.Size = new Size(44, 21);
            label13.TabIndex = 19;
            label13.Text = "Oras";
            // 
            // buttonInsertIntervievat
            // 
            buttonInsertIntervievat.BackColor = Color.Crimson;
            buttonInsertIntervievat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsertIntervievat.ForeColor = SystemColors.ControlText;
            buttonInsertIntervievat.Location = new Point(610, 497);
            buttonInsertIntervievat.Name = "buttonInsertIntervievat";
            buttonInsertIntervievat.Size = new Size(160, 53);
            buttonInsertIntervievat.TabIndex = 20;
            buttonInsertIntervievat.Text = "Înregistrează intervievatul";
            buttonInsertIntervievat.UseVisualStyleBackColor = false;
            buttonInsertIntervievat.Click += buttonInsertIntervievat_Click;
            // 
            // textIntervievatID
            // 
            textIntervievatID.Location = new Point(610, 173);
            textIntervievatID.Name = "textIntervievatID";
            textIntervievatID.Size = new Size(160, 23);
            textIntervievatID.TabIndex = 21;
            // 
            // textNumeIntervievat
            // 
            textNumeIntervievat.Location = new Point(610, 232);
            textNumeIntervievat.Name = "textNumeIntervievat";
            textNumeIntervievat.Size = new Size(160, 23);
            textNumeIntervievat.TabIndex = 22;
            // 
            // textPrenumeIntervievat
            // 
            textPrenumeIntervievat.Location = new Point(610, 293);
            textPrenumeIntervievat.Name = "textPrenumeIntervievat";
            textPrenumeIntervievat.Size = new Size(160, 23);
            textPrenumeIntervievat.TabIndex = 23;
            // 
            // textVarsta
            // 
            textVarsta.Location = new Point(610, 362);
            textVarsta.Name = "textVarsta";
            textVarsta.Size = new Size(160, 23);
            textVarsta.TabIndex = 24;
            // 
            // textOras
            // 
            textOras.Location = new Point(610, 425);
            textOras.Name = "textOras";
            textOras.Size = new Size(160, 23);
            textOras.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(859, 379);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(371, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(859, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(383, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(985, 606);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textOras);
            Controls.Add(textVarsta);
            Controls.Add(textPrenumeIntervievat);
            Controls.Add(textNumeIntervievat);
            Controls.Add(textIntervievatID);
            Controls.Add(buttonInsertIntervievat);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(buttonInsertMelodie);
            Controls.Add(textGen);
            Controls.Add(textAn);
            Controls.Add(textArtist);
            Controls.Add(textNume);
            Controls.Add(textID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textID;
        private TextBox textNume;
        private TextBox textArtist;
        private TextBox textAn;
        private TextBox textGen;
        private Button buttonInsertMelodie;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button buttonInsertIntervievat;
        private TextBox textIntervievatID;
        private TextBox textNumeIntervievat;
        private TextBox textPrenumeIntervievat;
        private TextBox textVarsta;
        private TextBox textOras;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}