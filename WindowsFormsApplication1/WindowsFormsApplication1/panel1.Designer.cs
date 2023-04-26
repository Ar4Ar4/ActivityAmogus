namespace WindowsFormsApplication1
{
    partial class panel1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pan1sub = new System.Windows.Forms.Button();
            this.pan1input1 = new System.Windows.Forms.TextBox();
            this.pan1input2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel One!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input one:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input two:";
            // 
            // pan1sub
            // 
            this.pan1sub.Location = new System.Drawing.Point(91, 196);
            this.pan1sub.Name = "pan1sub";
            this.pan1sub.Size = new System.Drawing.Size(75, 23);
            this.pan1sub.TabIndex = 3;
            this.pan1sub.Text = "Submit";
            this.pan1sub.UseVisualStyleBackColor = true;
            this.pan1sub.Click += new System.EventHandler(this.pan1sub_Click);
            // 
            // pan1input1
            // 
            this.pan1input1.Location = new System.Drawing.Point(66, 85);
            this.pan1input1.Name = "pan1input1";
            this.pan1input1.Size = new System.Drawing.Size(100, 20);
            this.pan1input1.TabIndex = 4;
            // 
            // pan1input2
            // 
            this.pan1input2.Location = new System.Drawing.Point(66, 145);
            this.pan1input2.Name = "pan1input2";
            this.pan1input2.Size = new System.Drawing.Size(100, 20);
            this.pan1input2.TabIndex = 5;
            // 
            // panel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.pan1input2);
            this.Controls.Add(this.pan1input1);
            this.Controls.Add(this.pan1sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(296, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pan1sub;
        private System.Windows.Forms.TextBox pan1input1;
        private System.Windows.Forms.TextBox pan1input2;
    }
}
