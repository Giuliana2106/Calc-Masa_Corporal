
namespace Aplicación_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdCalc = new System.Windows.Forms.Button();
            this.txtvP = new System.Windows.Forms.TextBox();
            this.txtvEst = new System.Windows.Forms.TextBox();
            this.lblEst = new System.Windows.Forms.Label();
            this.PctPIdeal = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cbxIMC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctPIdeal)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCalc
            // 
            this.cmdCalc.Location = new System.Drawing.Point(344, 32);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(126, 28);
            this.cmdCalc.TabIndex = 0;
            this.cmdCalc.Text = "Calcular";
            this.cmdCalc.UseVisualStyleBackColor = true;
            this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
            // 
            // txtvP
            // 
            this.txtvP.Location = new System.Drawing.Point(193, 32);
            this.txtvP.Name = "txtvP";
            this.txtvP.Size = new System.Drawing.Size(100, 20);
            this.txtvP.TabIndex = 1;
            // 
            // txtvEst
            // 
            this.txtvEst.Location = new System.Drawing.Point(193, 68);
            this.txtvEst.Name = "txtvEst";
            this.txtvEst.Size = new System.Drawing.Size(100, 20);
            this.txtvEst.TabIndex = 2;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(86, 71);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(87, 13);
            this.lblEst.TabIndex = 3;
            this.lblEst.Text = "Estatura (Metros)";
            // 
            // PctPIdeal
            // 
            this.PctPIdeal.Image = ((System.Drawing.Image)(resources.GetObject("PctPIdeal.Image")));
            this.PctPIdeal.Location = new System.Drawing.Point(78, 196);
            this.PctPIdeal.Name = "PctPIdeal";
            this.PctPIdeal.Size = new System.Drawing.Size(374, 242);
            this.PctPIdeal.TabIndex = 5;
            this.PctPIdeal.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(125, 105);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "0";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(86, 35);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(91, 13);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso (Kilogramos)";
            this.lblPeso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPeso_MouseMove);
            // 
            // cbxIMC
            // 
            this.cbxIMC.FormattingEnabled = true;
            this.cbxIMC.Items.AddRange(new object[] {
            "18.5 - 24.9",
            "25.0 - 29.9",
            "30.0 - 39.9",
            "Más de 40"});
            this.cbxIMC.Location = new System.Drawing.Point(299, 135);
            this.cbxIMC.Name = "cbxIMC";
            this.cbxIMC.Size = new System.Drawing.Size(121, 21);
            this.cbxIMC.TabIndex = 8;
            this.cbxIMC.SelectedIndexChanged += new System.EventHandler(this.cbxIMC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elija una opción, con base en el resultado ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxIMC);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.PctPIdeal);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.txtvEst);
            this.Controls.Add(this.txtvP);
            this.Controls.Add(this.cmdCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PctPIdeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCalc;
        private System.Windows.Forms.TextBox txtvP;
        private System.Windows.Forms.TextBox txtvEst;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.PictureBox PctPIdeal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cbxIMC;
        private System.Windows.Forms.Label label1;
    }
}

