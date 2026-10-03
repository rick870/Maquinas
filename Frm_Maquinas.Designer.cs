namespace Maquinas
{
    partial class Frm_Maquinas
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
            this.txtserie = new System.Windows.Forms.TextBox();
            this.Txtfabricante = new System.Windows.Forms.TextBox();
            this.Txtdescripcion = new System.Windows.Forms.TextBox();
            this.Txtpeso = new System.Windows.Forms.TextBox();
            this.Txtlargo = new System.Windows.Forms.TextBox();
            this.Txtancho = new System.Windows.Forms.TextBox();
            this.Txttipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(173, 61);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(157, 20);
            this.txtserie.TabIndex = 0;
            // 
            // Txtfabricante
            // 
            this.Txtfabricante.Location = new System.Drawing.Point(173, 126);
            this.Txtfabricante.Name = "Txtfabricante";
            this.Txtfabricante.Size = new System.Drawing.Size(157, 20);
            this.Txtfabricante.TabIndex = 1;
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.Location = new System.Drawing.Point(520, 198);
            this.Txtdescripcion.Multiline = true;
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(248, 175);
            this.Txtdescripcion.TabIndex = 2;
            // 
            // Txtpeso
            // 
            this.Txtpeso.Location = new System.Drawing.Point(173, 262);
            this.Txtpeso.Name = "Txtpeso";
            this.Txtpeso.Size = new System.Drawing.Size(157, 20);
            this.Txtpeso.TabIndex = 3;
            // 
            // Txtlargo
            // 
            this.Txtlargo.Location = new System.Drawing.Point(520, 126);
            this.Txtlargo.Name = "Txtlargo";
            this.Txtlargo.Size = new System.Drawing.Size(144, 20);
            this.Txtlargo.TabIndex = 5;
            // 
            // Txtancho
            // 
            this.Txtancho.Location = new System.Drawing.Point(520, 61);
            this.Txtancho.Name = "Txtancho";
            this.Txtancho.Size = new System.Drawing.Size(144, 20);
            this.Txtancho.TabIndex = 6;
            // 
            // Txttipo
            // 
            this.Txttipo.Location = new System.Drawing.Point(173, 195);
            this.Txttipo.Name = "Txttipo";
            this.Txttipo.Size = new System.Drawing.Size(157, 20);
            this.Txttipo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "N° SERIE :";
            // 
            // Btnguardar
            // 
            this.Btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnguardar.Location = new System.Drawing.Point(123, 350);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(99, 31);
            this.Btnguardar.TabIndex = 16;
            this.Btnguardar.Text = "GUARDAR";
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Btncancelar
            // 
            this.Btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncancelar.Location = new System.Drawing.Point(290, 350);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(95, 31);
            this.Btncancelar.TabIndex = 17;
            this.Btncancelar.Text = "CANCELAR";
            this.Btncancelar.UseVisualStyleBackColor = true;
            this.Btncancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "FABRICANTE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "PESO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "TIPO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ANCHO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "LARGO :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "DESCRIPCION:";
            // 
            // Frm_Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txttipo);
            this.Controls.Add(this.Txtancho);
            this.Controls.Add(this.Txtlargo);
            this.Controls.Add(this.Txtpeso);
            this.Controls.Add(this.Txtdescripcion);
            this.Controls.Add(this.Txtfabricante);
            this.Controls.Add(this.txtserie);
            this.Name = "Frm_Maquinas";
            this.Text = "Frm_Maquinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.TextBox Txtfabricante;
        private System.Windows.Forms.TextBox Txtdescripcion;
        private System.Windows.Forms.TextBox Txtpeso;
        private System.Windows.Forms.TextBox Txtlargo;
        private System.Windows.Forms.TextBox Txtancho;
        private System.Windows.Forms.TextBox Txttipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}