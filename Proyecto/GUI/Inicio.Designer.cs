namespace Proyecto.GUI
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.groupBox_opciones = new System.Windows.Forms.GroupBox();
            this.radioButton_personalizado = new System.Windows.Forms.RadioButton();
            this.radioButton_afilar = new System.Windows.Forms.RadioButton();
            this.radioButton_difuminado = new System.Windows.Forms.RadioButton();
            this.radioButton_sobelInferior = new System.Windows.Forms.RadioButton();
            this.radioButton_sobelIzquierdo = new System.Windows.Forms.RadioButton();
            this.radioButton_contorno = new System.Windows.Forms.RadioButton();
            this.radioButton_sobelDerecho = new System.Windows.Forms.RadioButton();
            this.radioButton_sobelSuperior = new System.Windows.Forms.RadioButton();
            this.radioButton_original = new System.Windows.Forms.RadioButton();
            this.radioButton_realzar = new System.Windows.Forms.RadioButton();
            this.groupBox_matrizPersonalizada = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_i = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_g = new System.Windows.Forms.TextBox();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.button_cargar = new System.Windows.Forms.Button();
            this.button_aplicar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_opciones.SuspendLayout();
            this.groupBox_matrizPersonalizada.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección de Imagen";
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(181, 31);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(339, 27);
            this.textBox_direccion.TabIndex = 1;
            // 
            // groupBox_opciones
            // 
            this.groupBox_opciones.Controls.Add(this.radioButton_personalizado);
            this.groupBox_opciones.Controls.Add(this.radioButton_afilar);
            this.groupBox_opciones.Controls.Add(this.radioButton_difuminado);
            this.groupBox_opciones.Controls.Add(this.radioButton_sobelInferior);
            this.groupBox_opciones.Controls.Add(this.radioButton_sobelIzquierdo);
            this.groupBox_opciones.Controls.Add(this.radioButton_contorno);
            this.groupBox_opciones.Controls.Add(this.radioButton_sobelDerecho);
            this.groupBox_opciones.Controls.Add(this.radioButton_sobelSuperior);
            this.groupBox_opciones.Controls.Add(this.radioButton_original);
            this.groupBox_opciones.Controls.Add(this.radioButton_realzar);
            this.groupBox_opciones.Location = new System.Drawing.Point(11, 79);
            this.groupBox_opciones.Name = "groupBox_opciones";
            this.groupBox_opciones.Size = new System.Drawing.Size(345, 303);
            this.groupBox_opciones.TabIndex = 2;
            this.groupBox_opciones.TabStop = false;
            this.groupBox_opciones.Text = "Opciones";
            this.groupBox_opciones.Enter += new System.EventHandler(this.groupBox_opciones_Enter);
            // 
            // radioButton_personalizado
            // 
            this.radioButton_personalizado.AutoSize = true;
            this.radioButton_personalizado.Location = new System.Drawing.Point(178, 251);
            this.radioButton_personalizado.Name = "radioButton_personalizado";
            this.radioButton_personalizado.Size = new System.Drawing.Size(121, 24);
            this.radioButton_personalizado.TabIndex = 0;
            this.radioButton_personalizado.TabStop = true;
            this.radioButton_personalizado.Text = "Personalisado";
            this.radioButton_personalizado.UseVisualStyleBackColor = true;
            this.radioButton_personalizado.CheckedChanged += new System.EventHandler(this.radioButton_personalizado_CheckedChanged);
            // 
            // radioButton_afilar
            // 
            this.radioButton_afilar.AutoSize = true;
            this.radioButton_afilar.Location = new System.Drawing.Point(178, 201);
            this.radioButton_afilar.Name = "radioButton_afilar";
            this.radioButton_afilar.Size = new System.Drawing.Size(66, 24);
            this.radioButton_afilar.TabIndex = 10;
            this.radioButton_afilar.TabStop = true;
            this.radioButton_afilar.Text = "Afilar";
            this.radioButton_afilar.UseVisualStyleBackColor = true;
            // 
            // radioButton_difuminado
            // 
            this.radioButton_difuminado.AutoSize = true;
            this.radioButton_difuminado.Location = new System.Drawing.Point(6, 48);
            this.radioButton_difuminado.Name = "radioButton_difuminado";
            this.radioButton_difuminado.Size = new System.Drawing.Size(109, 24);
            this.radioButton_difuminado.TabIndex = 9;
            this.radioButton_difuminado.TabStop = true;
            this.radioButton_difuminado.Text = "Difuminado";
            this.radioButton_difuminado.UseVisualStyleBackColor = true;
            // 
            // radioButton_sobelInferior
            // 
            this.radioButton_sobelInferior.AutoSize = true;
            this.radioButton_sobelInferior.Location = new System.Drawing.Point(6, 100);
            this.radioButton_sobelInferior.Name = "radioButton_sobelInferior";
            this.radioButton_sobelInferior.Size = new System.Drawing.Size(120, 24);
            this.radioButton_sobelInferior.TabIndex = 7;
            this.radioButton_sobelInferior.TabStop = true;
            this.radioButton_sobelInferior.Text = "Sobel Inferior";
            this.radioButton_sobelInferior.UseVisualStyleBackColor = true;
            // 
            // radioButton_sobelIzquierdo
            // 
            this.radioButton_sobelIzquierdo.AutoSize = true;
            this.radioButton_sobelIzquierdo.Location = new System.Drawing.Point(6, 148);
            this.radioButton_sobelIzquierdo.Name = "radioButton_sobelIzquierdo";
            this.radioButton_sobelIzquierdo.Size = new System.Drawing.Size(135, 24);
            this.radioButton_sobelIzquierdo.TabIndex = 6;
            this.radioButton_sobelIzquierdo.TabStop = true;
            this.radioButton_sobelIzquierdo.Text = "Sobel Izquierdo";
            this.radioButton_sobelIzquierdo.UseVisualStyleBackColor = true;
            // 
            // radioButton_contorno
            // 
            this.radioButton_contorno.AutoSize = true;
            this.radioButton_contorno.Location = new System.Drawing.Point(6, 201);
            this.radioButton_contorno.Name = "radioButton_contorno";
            this.radioButton_contorno.Size = new System.Drawing.Size(92, 24);
            this.radioButton_contorno.TabIndex = 5;
            this.radioButton_contorno.TabStop = true;
            this.radioButton_contorno.Text = "Contorno";
            this.radioButton_contorno.UseVisualStyleBackColor = true;
            // 
            // radioButton_sobelDerecho
            // 
            this.radioButton_sobelDerecho.AutoSize = true;
            this.radioButton_sobelDerecho.Location = new System.Drawing.Point(178, 148);
            this.radioButton_sobelDerecho.Name = "radioButton_sobelDerecho";
            this.radioButton_sobelDerecho.Size = new System.Drawing.Size(128, 24);
            this.radioButton_sobelDerecho.TabIndex = 1;
            this.radioButton_sobelDerecho.TabStop = true;
            this.radioButton_sobelDerecho.Text = "Sobel Derecho";
            this.radioButton_sobelDerecho.UseVisualStyleBackColor = true;
            // 
            // radioButton_sobelSuperior
            // 
            this.radioButton_sobelSuperior.AutoSize = true;
            this.radioButton_sobelSuperior.Location = new System.Drawing.Point(178, 100);
            this.radioButton_sobelSuperior.Name = "radioButton_sobelSuperior";
            this.radioButton_sobelSuperior.Size = new System.Drawing.Size(128, 24);
            this.radioButton_sobelSuperior.TabIndex = 0;
            this.radioButton_sobelSuperior.TabStop = true;
            this.radioButton_sobelSuperior.Text = "Sobel Superior";
            this.radioButton_sobelSuperior.UseVisualStyleBackColor = true;
            // 
            // radioButton_original
            // 
            this.radioButton_original.AutoSize = true;
            this.radioButton_original.Location = new System.Drawing.Point(6, 251);
            this.radioButton_original.Name = "radioButton_original";
            this.radioButton_original.Size = new System.Drawing.Size(83, 24);
            this.radioButton_original.TabIndex = 4;
            this.radioButton_original.TabStop = true;
            this.radioButton_original.Text = "Original";
            this.radioButton_original.UseVisualStyleBackColor = true;
            // 
            // radioButton_realzar
            // 
            this.radioButton_realzar.AutoSize = true;
            this.radioButton_realzar.Location = new System.Drawing.Point(178, 48);
            this.radioButton_realzar.Name = "radioButton_realzar";
            this.radioButton_realzar.Size = new System.Drawing.Size(79, 24);
            this.radioButton_realzar.TabIndex = 3;
            this.radioButton_realzar.TabStop = true;
            this.radioButton_realzar.Text = "Realzar";
            this.radioButton_realzar.UseVisualStyleBackColor = true;
            // 
            // groupBox_matrizPersonalizada
            // 
            this.groupBox_matrizPersonalizada.Controls.Add(this.button1);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label10);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label9);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label8);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label7);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label6);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label5);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label4);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label3);
            this.groupBox_matrizPersonalizada.Controls.Add(this.label2);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_e);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_i);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_h);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_g);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_f);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_d);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_b);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_a);
            this.groupBox_matrizPersonalizada.Controls.Add(this.textBox_c);
            this.groupBox_matrizPersonalizada.Location = new System.Drawing.Point(382, 79);
            this.groupBox_matrizPersonalizada.Name = "groupBox_matrizPersonalizada";
            this.groupBox_matrizPersonalizada.Size = new System.Drawing.Size(250, 303);
            this.groupBox_matrizPersonalizada.TabIndex = 0;
            this.groupBox_matrizPersonalizada.TabStop = false;
            this.groupBox_matrizPersonalizada.Text = "Matriz Personalizada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "i";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "g";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "f";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "e";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(96, 148);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(58, 27);
            this.textBox_e.TabIndex = 0;
            // 
            // textBox_i
            // 
            this.textBox_i.Location = new System.Drawing.Point(186, 229);
            this.textBox_i.Name = "textBox_i";
            this.textBox_i.Size = new System.Drawing.Size(58, 27);
            this.textBox_i.TabIndex = 0;
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(96, 229);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(58, 27);
            this.textBox_h.TabIndex = 0;
            // 
            // textBox_g
            // 
            this.textBox_g.Location = new System.Drawing.Point(6, 229);
            this.textBox_g.Name = "textBox_g";
            this.textBox_g.Size = new System.Drawing.Size(58, 27);
            this.textBox_g.TabIndex = 0;
            // 
            // textBox_f
            // 
            this.textBox_f.Location = new System.Drawing.Point(186, 145);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(58, 27);
            this.textBox_f.TabIndex = 0;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(6, 148);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(58, 27);
            this.textBox_d.TabIndex = 0;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(96, 64);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(58, 27);
            this.textBox_b.TabIndex = 0;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(6, 64);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(58, 27);
            this.textBox_a.TabIndex = 0;
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_a_TextChanged);
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(186, 64);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(58, 27);
            this.textBox_c.TabIndex = 0;
            // 
            // button_cargar
            // 
            this.button_cargar.Location = new System.Drawing.Point(538, 31);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(94, 31);
            this.button_cargar.TabIndex = 3;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = true;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // button_aplicar
            // 
            this.button_aplicar.Location = new System.Drawing.Point(279, 409);
            this.button_aplicar.Name = "button_aplicar";
            this.button_aplicar.Size = new System.Drawing.Size(94, 29);
            this.button_aplicar.TabIndex = 4;
            this.button_aplicar.Text = "Aplicar";
            this.button_aplicar.UseVisualStyleBackColor = true;
            this.button_aplicar.Click += new System.EventHandler(this.button_aplicar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 451);
            this.Controls.Add(this.button_aplicar);
            this.Controls.Add(this.button_cargar);
            this.Controls.Add(this.groupBox_matrizPersonalizada);
            this.Controls.Add(this.groupBox_opciones);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.groupBox_opciones.ResumeLayout(false);
            this.groupBox_opciones.PerformLayout();
            this.groupBox_matrizPersonalizada.ResumeLayout(false);
            this.groupBox_matrizPersonalizada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.GroupBox groupBox_opciones;
        private System.Windows.Forms.RadioButton radioButton_difuminado;
        private System.Windows.Forms.GroupBox groupBox_matrizPersonalizada;
        private System.Windows.Forms.RadioButton radioButton_sobelSuperior;
        private System.Windows.Forms.RadioButton radioButton_sobelDerecho;
        private System.Windows.Forms.RadioButton radioButton_realzar;
        private System.Windows.Forms.RadioButton radioButton_original;
        private System.Windows.Forms.RadioButton radioButton_contorno;
        private System.Windows.Forms.RadioButton radioButton_sobelIzquierdo;
        private System.Windows.Forms.RadioButton radioButton_sobelInferior;
        private System.Windows.Forms.RadioButton radioButton_personalizado;
        private System.Windows.Forms.RadioButton radioButton_afilar;
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.Button button_aplicar;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_g;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.TextBox textBox_i;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Button button1;
    }
}