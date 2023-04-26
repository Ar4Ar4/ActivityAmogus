namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1butt = new System.Windows.Forms.Button();
            this.panel2butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Out1 = new System.Windows.Forms.TextBox();
            this.Out2 = new System.Windows.Forms.TextBox();
            this.userControl11 = new WindowsFormsApplication1.UserControl1();
            this.panel11 = new WindowsFormsApplication1.panel1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2butt);
            this.panel1.Controls.Add(this.panel1butt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 373);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.Out2);
            this.panel2.Controls.Add(this.Out1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(491, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 373);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1butt
            // 
            this.panel1butt.Location = new System.Drawing.Point(29, 99);
            this.panel1butt.Name = "panel1butt";
            this.panel1butt.Size = new System.Drawing.Size(75, 23);
            this.panel1butt.TabIndex = 1;
            this.panel1butt.Text = "Panel One";
            this.panel1butt.UseVisualStyleBackColor = true;
            this.panel1butt.Click += new System.EventHandler(this.panel1butt_Click);
            // 
            // panel2butt
            // 
            this.panel2butt.Location = new System.Drawing.Point(29, 128);
            this.panel2butt.Name = "panel2butt";
            this.panel2butt.Size = new System.Drawing.Size(75, 23);
            this.panel2butt.TabIndex = 2;
            this.panel2butt.Text = "Panel Two";
            this.panel2butt.UseVisualStyleBackColor = true;
            this.panel2butt.Click += new System.EventHandler(this.panel2butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Control Panel Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input One:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input Two";
            // 
            // Out1
            // 
            this.Out1.Location = new System.Drawing.Point(22, 96);
            this.Out1.Name = "Out1";
            this.Out1.Size = new System.Drawing.Size(100, 20);
            this.Out1.TabIndex = 3;
            // 
            // Out2
            // 
            this.Out2.Location = new System.Drawing.Point(22, 154);
            this.Out2.Name = "Out2";
            this.Out2.Size = new System.Drawing.Size(100, 20);
            this.Out2.TabIndex = 4;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Silver;
            this.userControl11.Location = new System.Drawing.Point(161, 59);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(302, 270);
            this.userControl11.TabIndex = 4;
            this.userControl11.Visible = false;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.PeachPuff;
            this.panel11.Location = new System.Drawing.Point(161, 59);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(302, 270);
            this.panel11.TabIndex = 3;
            this.panel11.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(621, 373);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button panel2butt;
        private System.Windows.Forms.Button panel1butt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private panel1 panel11;
        private UserControl1 userControl11;
        private System.Windows.Forms.TextBox Out1;
        private System.Windows.Forms.TextBox Out2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

