namespace Ejercicio55.Windows
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textNroIngresado = new TextBox();
            btnok = new Button();
            groupBox1 = new GroupBox();
            textLimiteSuperior = new TextBox();
            label3 = new Label();
            textLimiteInferior = new TextBox();
            label2 = new Label();
            lstMultiplos = new ListBox();
            label4 = new Label();
            btncancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnReset = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 5);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese numero";
            // 
            // textNroIngresado
            // 
            textNroIngresado.Location = new Point(109, 2);
            textNroIngresado.Name = "textNroIngresado";
            textNroIngresado.Size = new Size(27, 23);
            textNroIngresado.TabIndex = 1;
            // 
            // btnok
            // 
            btnok.Location = new Point(251, 45);
            btnok.Name = "btnok";
            btnok.Size = new Size(109, 27);
            btnok.TabIndex = 2;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textLimiteSuperior);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textLimiteInferior);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(5, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 123);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Limites de Intervalo";
            // 
            // textLimiteSuperior
            // 
            textLimiteSuperior.Location = new Point(105, 75);
            textLimiteSuperior.Name = "textLimiteSuperior";
            textLimiteSuperior.Size = new Size(26, 23);
            textLimiteSuperior.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 8;
            label3.Text = "Limite Superior";
            // 
            // textLimiteInferior
            // 
            textLimiteInferior.Location = new Point(105, 35);
            textLimiteInferior.Name = "textLimiteInferior";
            textLimiteInferior.Size = new Size(26, 23);
            textLimiteInferior.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "Limite Inferior";
            // 
            // lstMultiplos
            // 
            lstMultiplos.FormattingEnabled = true;
            lstMultiplos.ItemHeight = 15;
            lstMultiplos.Location = new Point(157, 45);
            lstMultiplos.Name = "lstMultiplos";
            lstMultiplos.Size = new Size(88, 124);
            lstMultiplos.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 27);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 5;
            label4.Text = "List Multiplos";
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(251, 77);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(109, 26);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(251, 110);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(109, 26);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(251, 142);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(109, 26);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 193);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btncancelar);
            Controls.Add(label4);
            Controls.Add(lstMultiplos);
            Controls.Add(groupBox1);
            Controls.Add(btnok);
            Controls.Add(textNroIngresado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNroIngresado;
        private Button btnok;
        private GroupBox groupBox1;
        private TextBox textLimiteSuperior;
        private Label label3;
        private TextBox textLimiteInferior;
        private Label label2;
        private ListBox lstMultiplos;
        private Label label4;
        private Button btncancelar;
        private ErrorProvider errorProvider1;
        private Button btnSalir;
        private Button btnReset;
    }
}