namespace Gestor_de_Remitos.Vistas
{
    partial class Nuevo_Remito
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
            this.txt_senor = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.group_datos_cli = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_cliente = new System.Windows.Forms.Button();
            this.btn_carga_autom = new System.Windows.Forms.Button();
            this.group_datos_remito = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_remito = new System.Windows.Forms.Button();
            this.txt_factura_numero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quitar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_datos_servicios = new System.Windows.Forms.GroupBox();
            this.btn_limpiar_servicio = new System.Windows.Forms.Button();
            this.btn_anadir = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_generar_remito = new System.Windows.Forms.Button();
            this.btn_editar_mis_datos = new System.Windows.Forms.Button();
            this.group_datos_cli.SuspendLayout();
            this.group_datos_remito.SuspendLayout();
            this.group_datos_servicios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Señor/es";
            // 
            // txt_senor
            // 
            this.txt_senor.Location = new System.Drawing.Point(63, 22);
            this.txt_senor.Name = "txt_senor";
            this.txt_senor.Size = new System.Drawing.Size(143, 20);
            this.txt_senor.TabIndex = 1;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(64, 55);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(143, 20);
            this.txt_direccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            // 
            // txt_localidad
            // 
            this.txt_localidad.Location = new System.Drawing.Point(65, 88);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(143, 20);
            this.txt_localidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localidad";
            // 
            // txt_cuit
            // 
            this.txt_cuit.Location = new System.Drawing.Point(65, 121);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(143, 20);
            this.txt_cuit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "C.U.I.T.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "I.V.A.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // group_datos_cli
            // 
            this.group_datos_cli.Controls.Add(this.btn_limpiar_cliente);
            this.group_datos_cli.Controls.Add(this.btn_carga_autom);
            this.group_datos_cli.Controls.Add(this.label2);
            this.group_datos_cli.Controls.Add(this.comboBox1);
            this.group_datos_cli.Controls.Add(this.label1);
            this.group_datos_cli.Controls.Add(this.label5);
            this.group_datos_cli.Controls.Add(this.txt_senor);
            this.group_datos_cli.Controls.Add(this.txt_cuit);
            this.group_datos_cli.Controls.Add(this.txt_direccion);
            this.group_datos_cli.Controls.Add(this.label4);
            this.group_datos_cli.Controls.Add(this.label3);
            this.group_datos_cli.Controls.Add(this.txt_localidad);
            this.group_datos_cli.Location = new System.Drawing.Point(12, 12);
            this.group_datos_cli.Name = "group_datos_cli";
            this.group_datos_cli.Size = new System.Drawing.Size(235, 252);
            this.group_datos_cli.TabIndex = 10;
            this.group_datos_cli.TabStop = false;
            this.group_datos_cli.Text = "Datos del Cliente";
            // 
            // btn_limpiar_cliente
            // 
            this.btn_limpiar_cliente.Location = new System.Drawing.Point(133, 203);
            this.btn_limpiar_cliente.Name = "btn_limpiar_cliente";
            this.btn_limpiar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar_cliente.TabIndex = 12;
            this.btn_limpiar_cliente.Text = "Limpiar";
            this.btn_limpiar_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_carga_autom
            // 
            this.btn_carga_autom.Location = new System.Drawing.Point(9, 203);
            this.btn_carga_autom.Name = "btn_carga_autom";
            this.btn_carga_autom.Size = new System.Drawing.Size(100, 23);
            this.btn_carga_autom.TabIndex = 11;
            this.btn_carga_autom.Text = "Carga Automática";
            this.btn_carga_autom.UseVisualStyleBackColor = true;
            // 
            // group_datos_remito
            // 
            this.group_datos_remito.Controls.Add(this.btn_limpiar_remito);
            this.group_datos_remito.Controls.Add(this.txt_factura_numero);
            this.group_datos_remito.Controls.Add(this.label7);
            this.group_datos_remito.Controls.Add(this.dtp_fecha);
            this.group_datos_remito.Controls.Add(this.label6);
            this.group_datos_remito.Location = new System.Drawing.Point(12, 302);
            this.group_datos_remito.Name = "group_datos_remito";
            this.group_datos_remito.Size = new System.Drawing.Size(235, 133);
            this.group_datos_remito.TabIndex = 11;
            this.group_datos_remito.TabStop = false;
            this.group_datos_remito.Text = "Datos del Remito";
            // 
            // btn_limpiar_remito
            // 
            this.btn_limpiar_remito.Location = new System.Drawing.Point(80, 99);
            this.btn_limpiar_remito.Name = "btn_limpiar_remito";
            this.btn_limpiar_remito.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar_remito.TabIndex = 13;
            this.btn_limpiar_remito.Text = "Limpiar";
            this.btn_limpiar_remito.UseVisualStyleBackColor = true;
            // 
            // txt_factura_numero
            // 
            this.txt_factura_numero.Location = new System.Drawing.Point(70, 63);
            this.txt_factura_numero.Name = "txt_factura_numero";
            this.txt_factura_numero.Size = new System.Drawing.Size(143, 20);
            this.txt_factura_numero.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Factura N°";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(70, 30);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(143, 20);
            this.dtp_fecha.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_descripcion,
            this.col_precio,
            this.col_quitar});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 293);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // col_descripcion
            // 
            this.col_descripcion.Tag = "";
            this.col_descripcion.Text = "Descripcion";
            this.col_descripcion.Width = 303;
            // 
            // col_precio
            // 
            this.col_precio.Text = "Precio";
            this.col_precio.Width = 143;
            // 
            // col_quitar
            // 
            this.col_quitar.Text = "Quitar";
            this.col_quitar.Width = 68;
            // 
            // group_datos_servicios
            // 
            this.group_datos_servicios.Controls.Add(this.btn_limpiar_servicio);
            this.group_datos_servicios.Controls.Add(this.btn_anadir);
            this.group_datos_servicios.Controls.Add(this.listView1);
            this.group_datos_servicios.Controls.Add(this.txt_precio);
            this.group_datos_servicios.Controls.Add(this.txt_descripcion);
            this.group_datos_servicios.Controls.Add(this.label9);
            this.group_datos_servicios.Controls.Add(this.label8);
            this.group_datos_servicios.Location = new System.Drawing.Point(268, 12);
            this.group_datos_servicios.Name = "group_datos_servicios";
            this.group_datos_servicios.Size = new System.Drawing.Size(534, 423);
            this.group_datos_servicios.TabIndex = 13;
            this.group_datos_servicios.TabStop = false;
            this.group_datos_servicios.Text = "Datos de Servicio";
            // 
            // btn_limpiar_servicio
            // 
            this.btn_limpiar_servicio.Location = new System.Drawing.Point(439, 36);
            this.btn_limpiar_servicio.Name = "btn_limpiar_servicio";
            this.btn_limpiar_servicio.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar_servicio.TabIndex = 5;
            this.btn_limpiar_servicio.Text = "Limpiar";
            this.btn_limpiar_servicio.UseVisualStyleBackColor = true;
            // 
            // btn_anadir
            // 
            this.btn_anadir.Location = new System.Drawing.Point(321, 36);
            this.btn_anadir.Name = "btn_anadir";
            this.btn_anadir.Size = new System.Drawing.Size(75, 23);
            this.btn_anadir.TabIndex = 4;
            this.btn_anadir.Text = "Añadir";
            this.btn_anadir.UseVisualStyleBackColor = true;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(76, 55);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(202, 20);
            this.txt_precio.TabIndex = 3;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(76, 22);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(202, 20);
            this.txt_descripcion.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descripcion";
            // 
            // btn_generar_remito
            // 
            this.btn_generar_remito.BackColor = System.Drawing.Color.Cyan;
            this.btn_generar_remito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_generar_remito.Location = new System.Drawing.Point(422, 441);
            this.btn_generar_remito.Name = "btn_generar_remito";
            this.btn_generar_remito.Size = new System.Drawing.Size(227, 34);
            this.btn_generar_remito.TabIndex = 14;
            this.btn_generar_remito.Text = "Generar Remito";
            this.btn_generar_remito.UseVisualStyleBackColor = false;
            // 
            // btn_editar_mis_datos
            // 
            this.btn_editar_mis_datos.Location = new System.Drawing.Point(75, 441);
            this.btn_editar_mis_datos.Name = "btn_editar_mis_datos";
            this.btn_editar_mis_datos.Size = new System.Drawing.Size(110, 23);
            this.btn_editar_mis_datos.TabIndex = 15;
            this.btn_editar_mis_datos.Text = "Editar mis Datos";
            this.btn_editar_mis_datos.UseVisualStyleBackColor = true;
            this.btn_editar_mis_datos.Click += new System.EventHandler(this.btn_editar_mis_datos_Click);
            // 
            // Nuevo_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 487);
            this.Controls.Add(this.btn_editar_mis_datos);
            this.Controls.Add(this.btn_generar_remito);
            this.Controls.Add(this.group_datos_servicios);
            this.Controls.Add(this.group_datos_remito);
            this.Controls.Add(this.group_datos_cli);
            this.Name = "Nuevo_Remito";
            this.Text = "Nuevo Remito";
            this.group_datos_cli.ResumeLayout(false);
            this.group_datos_cli.PerformLayout();
            this.group_datos_remito.ResumeLayout(false);
            this.group_datos_remito.PerformLayout();
            this.group_datos_servicios.ResumeLayout(false);
            this.group_datos_servicios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senor;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox group_datos_cli;
        private System.Windows.Forms.Button btn_carga_autom;
        private System.Windows.Forms.Button btn_limpiar_cliente;
        private System.Windows.Forms.GroupBox group_datos_remito;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_factura_numero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_limpiar_remito;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_descripcion;
        private System.Windows.Forms.ColumnHeader col_precio;
        private System.Windows.Forms.GroupBox group_datos_servicios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_limpiar_servicio;
        private System.Windows.Forms.Button btn_anadir;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ColumnHeader col_quitar;
        private System.Windows.Forms.Button btn_generar_remito;
        private System.Windows.Forms.Button btn_editar_mis_datos;
    }
}