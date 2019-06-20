namespace BlurImage
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
            this.picBoxBig = new System.Windows.Forms.PictureBox();
            this.picBoxSmall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MakeItBlur = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBig
            // 
            this.picBoxBig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxBig.Location = new System.Drawing.Point(371, 22);
            this.picBoxBig.Name = "picBoxBig";
            this.picBoxBig.Size = new System.Drawing.Size(299, 369);
            this.picBoxBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBig.TabIndex = 0;
            this.picBoxBig.TabStop = false;
            this.picBoxBig.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.picBoxBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picBoxBig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.picBoxBig.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // picBoxSmall
            // 
            this.picBoxSmall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxSmall.Location = new System.Drawing.Point(129, 22);
            this.picBoxSmall.Name = "picBoxSmall";
            this.picBoxSmall.Size = new System.Drawing.Size(100, 138);
            this.picBoxSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSmall.TabIndex = 1;
            this.picBoxSmall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blur Intensity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add Picture";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(529, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(77, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MakeItBlur
            // 
            this.MakeItBlur.Location = new System.Drawing.Point(401, 419);
            this.MakeItBlur.Name = "MakeItBlur";
            this.MakeItBlur.Size = new System.Drawing.Size(75, 30);
            this.MakeItBlur.TabIndex = 13;
            this.MakeItBlur.Text = "Blur";
            this.MakeItBlur.UseVisualStyleBackColor = true;
            this.MakeItBlur.Click += new System.EventHandler(this.MakeItBlur_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(125, 222);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.updateBlur);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(23, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 143);
            this.label2.TabIndex = 15;
            this.label2.Text = "1-) Add the picture that you want to blur\r\n2-)Choice the area that you want to bl" +
    "ur\r\n3-)Click the blur button\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.MakeItBlur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxSmall);
            this.Controls.Add(this.picBoxBig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBig;
        private System.Windows.Forms.PictureBox picBoxSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MakeItBlur;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}

