namespace Addbook
{
    partial class Actualizar
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
            this.idlibro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidlibro = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idlibro
            // 
            this.idlibro.AutoSize = true;
            this.idlibro.Location = new System.Drawing.Point(39, 64);
            this.idlibro.Name = "idlibro";
            this.idlibro.Size = new System.Drawing.Size(34, 13);
            this.idlibro.TabIndex = 0;
            this.idlibro.Text = "idlibro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtidlibro
            // 
            this.txtidlibro.Location = new System.Drawing.Point(126, 61);
            this.txtidlibro.Name = "txtidlibro";
            this.txtidlibro.Size = new System.Drawing.Size(100, 20);
            this.txtidlibro.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(126, 117);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidlibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idlibro);
            this.MaximumSize = new System.Drawing.Size(325, 298);
            this.MinimumSize = new System.Drawing.Size(325, 298);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidlibro;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button button1;
    }
}