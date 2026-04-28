namespace AutoMorgue
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnParts = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoMorgue.Properties.Resources.BK_Auto_logo;
            this.pictureBox1.Location = new System.Drawing.Point(76, -167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(138, 397);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(182, 23);
            this.btnCars.TabIndex = 1;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnParts
            // 
            this.btnParts.Location = new System.Drawing.Point(326, 397);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(182, 23);
            this.btnParts.TabIndex = 1;
            this.btnParts.Text = "Parts";
            this.btnParts.UseVisualStyleBackColor = true;
            this.btnParts.Click += new System.EventHandler(this.btnParts_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(514, 397);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(182, 23);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnReference
            // 
            this.btnReference.Location = new System.Drawing.Point(326, 426);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(182, 23);
            this.btnReference.TabIndex = 1;
            this.btnReference.Text = "Reference";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(691, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.btnParts);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnCars);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Car Morgue";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnParts;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnClose;
    }
}

