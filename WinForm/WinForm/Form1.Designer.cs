namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.animation_feild = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(717, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Not registered?";
            this.label2.Click += new System.EventHandler(this.register_method);
            // 
            // textBox_1
            // 
            this.textBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_1.Location = new System.Drawing.Point(303, 332);
            this.textBox_1.MaxLength = 15;
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(297, 31);
            this.textBox_1.TabIndex = 3;
            this.textBox_1.Enter += new System.EventHandler(this.textBox_1_Enter);
            this.textBox_1.Leave += new System.EventHandler(this.textBox_1_Leave);
            // 
            // textBox_2
            // 
            this.textBox_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_2.Location = new System.Drawing.Point(303, 387);
            this.textBox_2.MaxLength = 15;
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(297, 31);
            this.textBox_2.TabIndex = 4;
            this.textBox_2.Enter += new System.EventHandler(this.textBox_2_Enter);
            this.textBox_2.Leave += new System.EventHandler(this.textBox_2_Leave);
            this.textBox_2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox_2_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(390, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign in";
            this.label3.Click += new System.EventHandler(this.input_method);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(319, 133);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(240, 171);
            this.label4.TabIndex = 8;
            // 
            // animation_feild
            // 
            this.animation_feild.BackColor = System.Drawing.Color.Transparent;
            this.animation_feild.Font = new System.Drawing.Font("Microsoft Uighur", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animation_feild.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.animation_feild.Location = new System.Drawing.Point(782, 9);
            this.animation_feild.Name = "animation_feild";
            this.animation_feild.Size = new System.Drawing.Size(80, 86);
            this.animation_feild.TabIndex = 9;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 631);
            this.Controls.Add(this.animation_feild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Authorization field";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label animation_feild;
    }
}

