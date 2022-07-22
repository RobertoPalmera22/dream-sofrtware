namespace Proyecto_Dulcilandia
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt1.Location = new System.Drawing.Point(12, 165);
            this.txt1.Name = "txt1";
            this.txt1.PlaceholderText = "Usuario";
            this.txt1.Size = new System.Drawing.Size(408, 40);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt2.Location = new System.Drawing.Point(12, 228);
            this.txt2.Name = "txt2";
            this.txt2.PlaceholderText = "Contraseña";
            this.txt2.Size = new System.Drawing.Size(408, 40);
            this.txt2.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 329);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(408, 45);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Acceder";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.InitialImage = null;
            this.pic1.Location = new System.Drawing.Point(108, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(206, 132);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private Button btn1;
        private PictureBox pic1;
    }
}