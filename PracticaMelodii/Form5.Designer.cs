namespace PracticaMelodii
{
    partial class Form5
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
            buttonAfiseazaTop3 = new Button();
            dataGridViewTopMelodii = new DataGridView();
            label3 = new Label();
            buttonAfiseazaParticipanti = new Button();
            dataGridViewParticipanti = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopMelodii).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipanti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(923, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(436, 25);
            label2.TabIndex = 1;
            label2.Text = "Lista primelor 3 melodii în ordinea popularității";
            // 
            // buttonAfiseazaTop3
            // 
            buttonAfiseazaTop3.BackColor = SystemColors.GradientActiveCaption;
            buttonAfiseazaTop3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonAfiseazaTop3.ForeColor = Color.Brown;
            buttonAfiseazaTop3.Location = new Point(136, 484);
            buttonAfiseazaTop3.Name = "buttonAfiseazaTop3";
            buttonAfiseazaTop3.Size = new Size(157, 57);
            buttonAfiseazaTop3.TabIndex = 2;
            buttonAfiseazaTop3.Text = "Afișează";
            buttonAfiseazaTop3.UseVisualStyleBackColor = false;
            buttonAfiseazaTop3.Click += buttonAfiseazaTop3_Click;
            // 
            // dataGridViewTopMelodii
            // 
            dataGridViewTopMelodii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTopMelodii.Location = new Point(12, 125);
            dataGridViewTopMelodii.Name = "dataGridViewTopMelodii";
            dataGridViewTopMelodii.Size = new Size(436, 321);
            dataGridViewTopMelodii.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(482, 67);
            label3.Name = "label3";
            label3.Size = new Size(468, 25);
            label3.TabIndex = 4;
            label3.Text = "Participanţii la concurs în ordinea locurilor ocupate\r\n";
            // 
            // buttonAfiseazaParticipanti
            // 
            buttonAfiseazaParticipanti.BackColor = SystemColors.GradientActiveCaption;
            buttonAfiseazaParticipanti.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonAfiseazaParticipanti.ForeColor = Color.Brown;
            buttonAfiseazaParticipanti.Location = new Point(647, 484);
            buttonAfiseazaParticipanti.Name = "buttonAfiseazaParticipanti";
            buttonAfiseazaParticipanti.Size = new Size(157, 57);
            buttonAfiseazaParticipanti.TabIndex = 5;
            buttonAfiseazaParticipanti.Text = "Afișează";
            buttonAfiseazaParticipanti.UseVisualStyleBackColor = false;
            buttonAfiseazaParticipanti.Click += buttonAfiseazaParticipanti_Click;
            // 
            // dataGridViewParticipanti
            // 
            dataGridViewParticipanti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParticipanti.Location = new Point(499, 125);
            dataGridViewParticipanti.Name = "dataGridViewParticipanti";
            dataGridViewParticipanti.Size = new Size(436, 321);
            dataGridViewParticipanti.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(124, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(780, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources._4;
            pictureBox3.Location = new Point(461, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(965, 629);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewParticipanti);
            Controls.Add(buttonAfiseazaParticipanti);
            Controls.Add(label3);
            Controls.Add(dataGridViewTopMelodii);
            Controls.Add(buttonAfiseazaTop3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopMelodii).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipanti).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonAfiseazaTop3;
        private DataGridView dataGridViewTopMelodii;
        private Label label3;
        private Button buttonAfiseazaParticipanti;
        private DataGridView dataGridViewParticipanti;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}