namespace WinForm
{
    partial class RegistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.Registration_feild_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(255, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration field";
            // 
            // textBox_1
            // 
            this.textBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox_1.Location = new System.Drawing.Point(271, 198);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(260, 31);
            this.textBox_1.TabIndex = 0;
            this.textBox_1.Enter += new System.EventHandler(this.textBox_1_Enter);
            this.textBox_1.Leave += new System.EventHandler(this.textBox_1_Leave);
            // 
            // Registration_feild_2
            // 
            this.Registration_feild_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Registration_feild_2.Location = new System.Drawing.Point(271, 266);
            this.Registration_feild_2.Name = "Registration_feild_2";
            this.Registration_feild_2.Size = new System.Drawing.Size(260, 31);
            this.Registration_feild_2.TabIndex = 1;
            this.Registration_feild_2.Enter += new System.EventHandler(this.textBox_2_Enter);
            this.Registration_feild_2.Leave += new System.EventHandler(this.textBox_2_Leave);
            this.Registration_feild_2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Registration_feild_2_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(336, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Register";
            this.label2.Click += new System.EventHandler(this.input_method);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration_feild_2);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistForm";
            this.Text = "Registration field";
            this.Load += new System.EventHandler(this.RegistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox Registration_feild_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}