namespace PracticaMelodii
{
    partial class Form6
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
            dataGridViewTopParticipanti = new DataGridView();
            buttonAfiseazaTop5 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopParticipanti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(910, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 49);
            label2.Name = "label2";
            label2.Size = new Size(539, 30);
            label2.TabIndex = 1;
            label2.Text = "Persoanele care au ocupat primele 5 locuri la concurs";
            // 
            // dataGridViewTopParticipanti
            // 
            dataGridViewTopParticipanti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTopParticipanti.Location = new Point(204, 130);
            dataGridViewTopParticipanti.Name = "dataGridViewTopParticipanti";
            dataGridViewTopParticipanti.Size = new Size(544, 310);
            dataGridViewTopParticipanti.TabIndex = 2;
            // 
            // buttonAfiseazaTop5
            // 
            buttonAfiseazaTop5.BackColor = SystemColors.GradientActiveCaption;
            buttonAfiseazaTop5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonAfiseazaTop5.ForeColor = Color.Brown;
            buttonAfiseazaTop5.Location = new Point(393, 486);
            buttonAfiseazaTop5.Name = "buttonAfiseazaTop5";
            buttonAfiseazaTop5.Size = new Size(162, 60);
            buttonAfiseazaTop5.TabIndex = 3;
            buttonAfiseazaTop5.Text = "Afișează";
            buttonAfiseazaTop5.UseVisualStyleBackColor = false;
            buttonAfiseazaTop5.Click += buttonAfiseazaTop5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(49, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(40, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(819, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(840, 412);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(952, 635);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAfiseazaTop5);
            Controls.Add(dataGridViewTopParticipanti);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopParticipanti).EndInit();
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
        private DataGridView dataGridViewTopParticipanti;
        private Button buttonAfiseazaTop5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}