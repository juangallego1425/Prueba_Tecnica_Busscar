namespace URNA_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            botonCarroceria1 = new Button();
            botonCarroceria2 = new Button();
            botonCarroceria3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(252, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 0;
            label1.Text = "URNA BUSSCAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Carroceria 1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 96);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Carroceria 2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 133);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Carroceria 3";
            label4.Click += label4_Click;
            // 
            // etiquetaVotosCarroceria1
            // 
           
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 133);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 96);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // botonCarroceria1
            // 
            botonCarroceria1.BackgroundImageLayout = ImageLayout.None;
            botonCarroceria1.Location = new Point(231, 224);
            botonCarroceria1.Name = "botonCarroceria1";
            botonCarroceria1.Size = new Size(177, 32);
            botonCarroceria1.TabIndex = 7;
            botonCarroceria1.Text = "VOTA CARROCERIA 1";
            botonCarroceria1.UseVisualStyleBackColor = true;
            botonCarroceria1.Click += button1_Click;
            // 
            // botonCarroceria2
            // 
            botonCarroceria2.Location = new Point(231, 251);
            botonCarroceria2.Name = "botonCarroceria2";
            botonCarroceria2.Size = new Size(177, 32);
            botonCarroceria2.TabIndex = 8;
            botonCarroceria2.Text = "VOTAR CARROCERIA 2";
            botonCarroceria2.UseVisualStyleBackColor = true;
            botonCarroceria2.Click += button2_Click;
            // 
            // botonCarroceria3
            // 
            botonCarroceria3.Location = new Point(231, 278);
            botonCarroceria3.Name = "botonCarroceria3";
            botonCarroceria3.Size = new Size(177, 32);
            botonCarroceria3.TabIndex = 9;
            botonCarroceria3.Text = "VOTAR CARROCERIA 3";
            botonCarroceria3.UseVisualStyleBackColor = true;
            botonCarroceria3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 323);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonCarroceria3);
            Controls.Add(botonCarroceria2);
            Controls.Add(botonCarroceria1);
            Controls.Add(label7);
            Controls.Add(label6);
            
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button botonCarroceria1;
        private Button botonCarroceria2;
        private Button botonCarroceria3;
        private int votosCarroceria1 = 0;
        private int votosCarroceria2 = 0;
        private int votosCarroceria3 = 0;
        private int totalVotos = 0;
        private PictureBox pictureBox1;
    }
}