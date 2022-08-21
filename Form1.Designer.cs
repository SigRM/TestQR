namespace PruebaQR
{
    partial class frmMainTest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBarCode = new System.Windows.Forms.Button();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.lblNoProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(203, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnBarCode
            // 
            this.btnBarCode.BackColor = System.Drawing.Color.LightCoral;
            this.btnBarCode.Location = new System.Drawing.Point(256, 258);
            this.btnBarCode.Name = "btnBarCode";
            this.btnBarCode.Size = new System.Drawing.Size(110, 35);
            this.btnBarCode.TabIndex = 2;
            this.btnBarCode.Text = "BarCode";
            this.btnBarCode.UseVisualStyleBackColor = false;
            this.btnBarCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.BackColor = System.Drawing.Color.LightCoral;
            this.btnQRCode.Location = new System.Drawing.Point(386, 258);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(110, 35);
            this.btnQRCode.TabIndex = 3;
            this.btnQRCode.Text = "QR Code";
            this.btnQRCode.UseVisualStyleBackColor = false;
            this.btnQRCode.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNoProduct
            // 
            this.lblNoProduct.AutoSize = true;
            this.lblNoProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoProduct.Location = new System.Drawing.Point(203, 234);
            this.lblNoProduct.Name = "lblNoProduct";
            this.lblNoProduct.Size = new System.Drawing.Size(145, 21);
            this.lblNoProduct.TabIndex = 4;
            this.lblNoProduct.Text = "Enter Product No";
            // 
            // frmMainTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PruebaQR.Properties.Resources.Donadona;
            this.ClientSize = new System.Drawing.Size(765, 435);
            this.Controls.Add(this.lblNoProduct);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.btnBarCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMainTest";
            this.Text = "TestQR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnBarCode;
        private Button btnQRCode;
        private Label lblNoProduct;
    }
}