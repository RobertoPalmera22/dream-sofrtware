namespace Proyecto_Dulcilandia
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.btninv = new System.Windows.Forms.Button();
            this.btncal = new System.Windows.Forms.Button();
            this.btninf = new System.Windows.Forms.Button();
            this.btncof = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(154, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 500);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnreg
            // 
            this.btnreg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnreg.Location = new System.Drawing.Point(12, 12);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(130, 50);
            this.btnreg.TabIndex = 2;
            this.btnreg.Text = "Registro";
            this.btnreg.UseVisualStyleBackColor = true;
            // 
            // btninv
            // 
            this.btninv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btninv.Location = new System.Drawing.Point(12, 68);
            this.btninv.Name = "btninv";
            this.btninv.Size = new System.Drawing.Size(130, 50);
            this.btninv.TabIndex = 3;
            this.btninv.Text = "Inventario";
            this.btninv.UseVisualStyleBackColor = true;
            // 
            // btncal
            // 
            this.btncal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncal.Location = new System.Drawing.Point(12, 124);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(130, 50);
            this.btncal.TabIndex = 4;
            this.btncal.Text = "Calcular costo";
            this.btncal.UseVisualStyleBackColor = true;
            // 
            // btninf
            // 
            this.btninf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btninf.Location = new System.Drawing.Point(12, 180);
            this.btninf.Name = "btninf";
            this.btninf.Size = new System.Drawing.Size(130, 50);
            this.btninf.TabIndex = 5;
            this.btninf.Text = "Ver ganancias";
            this.btninf.UseVisualStyleBackColor = true;
            // 
            // btncof
            // 
            this.btncof.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncof.Location = new System.Drawing.Point(12, 462);
            this.btncof.Name = "btncof";
            this.btncof.Size = new System.Drawing.Size(130, 50);
            this.btncof.TabIndex = 6;
            this.btncof.Text = "Configuración";
            this.btncof.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Versión 1.0";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncof);
            this.Controls.Add(this.btninf);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.btninv);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnreg;
        private Button btninv;
        private Button btncal;
        private Button btninf;
        private Button btncof;
        private Label label1;
    }
}