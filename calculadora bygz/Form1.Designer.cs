namespace calculadora_bygz
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
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnElevadoados = new System.Windows.Forms.Button();
            this.btnRiazcuadrada = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.bTNPunto = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textResultado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(9, 41);
            this.textResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textResultado.MaxLength = 12;
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(236, 55);
            this.textResultado.TabIndex = 0;
            this.textResultado.Text = "\r\n";
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUno.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(16, 312);
            this.btnUno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(34, 37);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(64, 312);
            this.btnDos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(34, 37);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(110, 312);
            this.btnTres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(34, 37);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(110, 262);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(34, 37);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(64, 262);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(34, 37);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCuatro.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(16, 262);
            this.btnCuatro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(34, 37);
            this.btnCuatro.TabIndex = 4;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(110, 163);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(34, 37);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "<-";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(64, 163);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(34, 37);
            this.btnBorrarTodo.TabIndex = 11;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(16, 163);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(34, 37);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "CE\r\n";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNueve.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(110, 213);
            this.btnNueve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(34, 37);
            this.btnNueve.TabIndex = 9;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOcho.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(64, 213);
            this.btnOcho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(34, 37);
            this.btnOcho.TabIndex = 8;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(16, 213);
            this.btnSiete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(34, 37);
            this.btnSiete.TabIndex = 7;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnElevadoados
            // 
            this.btnElevadoados.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnElevadoados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevadoados.Location = new System.Drawing.Point(62, 115);
            this.btnElevadoados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElevadoados.Name = "btnElevadoados";
            this.btnElevadoados.Size = new System.Drawing.Size(34, 37);
            this.btnElevadoados.TabIndex = 14;
            this.btnElevadoados.Tag = "²";
            this.btnElevadoados.Text = "x²";
            this.btnElevadoados.UseVisualStyleBackColor = false;
            this.btnElevadoados.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnRiazcuadrada
            // 
            this.btnRiazcuadrada.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRiazcuadrada.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiazcuadrada.Location = new System.Drawing.Point(16, 115);
            this.btnRiazcuadrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRiazcuadrada.Name = "btnRiazcuadrada";
            this.btnRiazcuadrada.Size = new System.Drawing.Size(34, 37);
            this.btnRiazcuadrada.TabIndex = 13;
            this.btnRiazcuadrada.Text = "√";
            this.btnRiazcuadrada.UseVisualStyleBackColor = false;
            this.btnRiazcuadrada.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDivision.Location = new System.Drawing.Point(182, 163);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(34, 37);
            this.btnDivision.TabIndex = 18;
            this.btnDivision.Tag = "÷";
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMultiplicacion.Location = new System.Drawing.Point(182, 213);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(34, 37);
            this.btnMultiplicacion.TabIndex = 17;
            this.btnMultiplicacion.Tag = "×";
            this.btnMultiplicacion.Text = "×";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnMas
            // 
            this.btnMas.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMas.Location = new System.Drawing.Point(182, 262);
            this.btnMas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(34, 37);
            this.btnMas.TabIndex = 16;
            this.btnMas.Tag = "+";
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMenos.Location = new System.Drawing.Point(182, 312);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(34, 37);
            this.btnMenos.TabIndex = 15;
            this.btnMenos.Tag = "-";
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnIgual.Location = new System.Drawing.Point(110, 366);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(106, 37);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCero.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(16, 366);
            this.btnCero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(34, 37);
            this.btnCero.TabIndex = 20;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // bTNPunto
            // 
            this.bTNPunto.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTNPunto.Location = new System.Drawing.Point(62, 366);
            this.bTNPunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bTNPunto.Name = "bTNPunto";
            this.bTNPunto.Size = new System.Drawing.Size(34, 37);
            this.bTNPunto.TabIndex = 21;
            this.bTNPunto.Text = ".";
            this.bTNPunto.UseVisualStyleBackColor = true;
            // 
            // btnSigno
            // 
            this.btnSigno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSigno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigno.Location = new System.Drawing.Point(110, 115);
            this.btnSigno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(34, 37);
            this.btnSigno.TabIndex = 22;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(254, 413);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.bTNPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnElevadoados);
            this.Controls.Add(this.btnRiazcuadrada);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.textResultado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculadora byGZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnElevadoados;
        private System.Windows.Forms.Button btnRiazcuadrada;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button bTNPunto;
        private System.Windows.Forms.Button btnSigno;
    }
}

