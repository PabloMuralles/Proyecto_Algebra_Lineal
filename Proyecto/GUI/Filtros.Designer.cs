namespace Proyecto.GUI
{
    partial class Filtros
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
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.pictureBox_filtro = new System.Windows.Forms.PictureBox();
            this.button_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_filtro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(423, 427);
            this.pictureBox_original.TabIndex = 0;
            this.pictureBox_original.TabStop = false;
            // 
            // pictureBox_filtro
            // 
            this.pictureBox_filtro.Location = new System.Drawing.Point(460, 12);
            this.pictureBox_filtro.Name = "pictureBox_filtro";
            this.pictureBox_filtro.Size = new System.Drawing.Size(442, 427);
            this.pictureBox_filtro.TabIndex = 1;
            this.pictureBox_filtro.TabStop = false;
            // 
            // button_regresar
            // 
            this.button_regresar.Location = new System.Drawing.Point(401, 475);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(94, 29);
            this.button_regresar.TabIndex = 2;
            this.button_regresar.Text = "Atras";
            this.button_regresar.UseVisualStyleBackColor = true;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // Filtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 516);
            this.Controls.Add(this.button_regresar);
            this.Controls.Add(this.pictureBox_filtro);
            this.Controls.Add(this.pictureBox_original);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Filtros";
            this.Text = "Filtros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_filtro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.PictureBox pictureBox_filtro;
        private System.Windows.Forms.Button button_regresar;
    }
}