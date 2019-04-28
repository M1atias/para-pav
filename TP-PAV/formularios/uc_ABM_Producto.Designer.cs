﻿namespace TP_PAV.formularios
{
    partial class uc_ABM_Producto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_IdProducto = new System.Windows.Forms.Label();
            this.lbl_NomProducto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_unidadMedida = new System.Windows.Forms.Label();
            this.lbl_estadoProducto = new System.Windows.Forms.Label();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.cmb_unidadMedida = new System.Windows.Forms.ComboBox();
            this.txt_descripcionProducto = new System.Windows.Forms.TextBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.cmb_estadoProducto = new System.Windows.Forms.ComboBox();
            this.btn_agregarUdeMedida = new System.Windows.Forms.Button();
            this.btn_agregarTipo = new System.Windows.Forms.Button();
            this.btn_cancelarModProducto = new System.Windows.Forms.Button();
            this.cmb_tipoProducto = new System.Windows.Forms.ComboBox();
            this.lbl_tipoProducto = new System.Windows.Forms.Label();
            this.btn_guardarModProducto = new System.Windows.Forms.Button();
            this.btn_busquedaAvanzadaProducto = new System.Windows.Forms.Button();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_buscarProducto = new System.Windows.Forms.Label();
            this.btn_registrarProducto = new System.Windows.Forms.Button();
            this.btn_modificarProducto = new System.Windows.Forms.Button();
            this.dgv_vendedores = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // lbl_IdProducto
            // 
            this.lbl_IdProducto.AutoSize = true;
            this.lbl_IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdProducto.Location = new System.Drawing.Point(770, 121);
            this.lbl_IdProducto.Name = "lbl_IdProducto";
            this.lbl_IdProducto.Size = new System.Drawing.Size(78, 16);
            this.lbl_IdProducto.TabIndex = 2;
            this.lbl_IdProducto.Text = "ID Producto";
            // 
            // lbl_NomProducto
            // 
            this.lbl_NomProducto.AutoSize = true;
            this.lbl_NomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomProducto.Location = new System.Drawing.Point(770, 166);
            this.lbl_NomProducto.Name = "lbl_NomProducto";
            this.lbl_NomProducto.Size = new System.Drawing.Size(133, 16);
            this.lbl_NomProducto.TabIndex = 3;
            this.lbl_NomProducto.Text = "Nombre de Producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(770, 211);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(62, 16);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioUnitario.Location = new System.Drawing.Point(770, 391);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(96, 16);
            this.lbl_precioUnitario.TabIndex = 5;
            this.lbl_precioUnitario.Text = "Precio Unitario";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(770, 301);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(80, 16);
            this.lbl_descripcion.TabIndex = 6;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_unidadMedida
            // 
            this.lbl_unidadMedida.AutoSize = true;
            this.lbl_unidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidadMedida.Location = new System.Drawing.Point(770, 256);
            this.lbl_unidadMedida.Name = "lbl_unidadMedida";
            this.lbl_unidadMedida.Size = new System.Drawing.Size(120, 16);
            this.lbl_unidadMedida.TabIndex = 7;
            this.lbl_unidadMedida.Text = "Unidad de Medida";
            // 
            // lbl_estadoProducto
            // 
            this.lbl_estadoProducto.AutoSize = true;
            this.lbl_estadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoProducto.Location = new System.Drawing.Point(770, 436);
            this.lbl_estadoProducto.Name = "lbl_estadoProducto";
            this.lbl_estadoProducto.Size = new System.Drawing.Size(130, 16);
            this.lbl_estadoProducto.TabIndex = 8;
            this.lbl_estadoProducto.Text = "Estado del Producto";
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Enabled = false;
            this.txt_IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProducto.Location = new System.Drawing.Point(978, 121);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(143, 21);
            this.txt_IdProducto.TabIndex = 9;
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Enabled = false;
            this.txt_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProducto.Location = new System.Drawing.Point(978, 163);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(143, 21);
            this.txt_NombreProducto.TabIndex = 10;
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Enabled = false;
            this.txt_cantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadProducto.Location = new System.Drawing.Point(978, 208);
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(143, 21);
            this.txt_cantidadProducto.TabIndex = 11;
            // 
            // cmb_unidadMedida
            // 
            this.cmb_unidadMedida.Enabled = false;
            this.cmb_unidadMedida.FormattingEnabled = true;
            this.cmb_unidadMedida.Location = new System.Drawing.Point(978, 256);
            this.cmb_unidadMedida.Name = "cmb_unidadMedida";
            this.cmb_unidadMedida.Size = new System.Drawing.Size(143, 21);
            this.cmb_unidadMedida.TabIndex = 12;
            // 
            // txt_descripcionProducto
            // 
            this.txt_descripcionProducto.Enabled = false;
            this.txt_descripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionProducto.Location = new System.Drawing.Point(978, 301);
            this.txt_descripcionProducto.Name = "txt_descripcionProducto";
            this.txt_descripcionProducto.Size = new System.Drawing.Size(143, 21);
            this.txt_descripcionProducto.TabIndex = 13;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Enabled = false;
            this.txt_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioUnitario.Location = new System.Drawing.Point(978, 391);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(143, 21);
            this.txt_precioUnitario.TabIndex = 14;
            // 
            // cmb_estadoProducto
            // 
            this.cmb_estadoProducto.Enabled = false;
            this.cmb_estadoProducto.FormattingEnabled = true;
            this.cmb_estadoProducto.Location = new System.Drawing.Point(978, 431);
            this.cmb_estadoProducto.Name = "cmb_estadoProducto";
            this.cmb_estadoProducto.Size = new System.Drawing.Size(143, 21);
            this.cmb_estadoProducto.TabIndex = 15;
            // 
            // btn_agregarUdeMedida
            // 
            this.btn_agregarUdeMedida.Enabled = false;
            this.btn_agregarUdeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarUdeMedida.Location = new System.Drawing.Point(1140, 251);
            this.btn_agregarUdeMedida.Name = "btn_agregarUdeMedida";
            this.btn_agregarUdeMedida.Size = new System.Drawing.Size(33, 26);
            this.btn_agregarUdeMedida.TabIndex = 16;
            this.btn_agregarUdeMedida.Text = "+";
            this.btn_agregarUdeMedida.UseVisualStyleBackColor = true;
            this.btn_agregarUdeMedida.Click += new System.EventHandler(this.btn_agregarUdeMedida_Click);
            // 
            // btn_agregarTipo
            // 
            this.btn_agregarTipo.Enabled = false;
            this.btn_agregarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarTipo.Location = new System.Drawing.Point(1140, 340);
            this.btn_agregarTipo.Name = "btn_agregarTipo";
            this.btn_agregarTipo.Size = new System.Drawing.Size(33, 26);
            this.btn_agregarTipo.TabIndex = 17;
            this.btn_agregarTipo.Text = "+";
            this.btn_agregarTipo.UseVisualStyleBackColor = true;
            this.btn_agregarTipo.Click += new System.EventHandler(this.btn_agregarTipo_Click);
            // 
            // btn_cancelarModProducto
            // 
            this.btn_cancelarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarModProducto.Location = new System.Drawing.Point(1000, 529);
            this.btn_cancelarModProducto.Name = "btn_cancelarModProducto";
            this.btn_cancelarModProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_cancelarModProducto.TabIndex = 50;
            this.btn_cancelarModProducto.Text = "Cancelar Modificaciones";
            this.btn_cancelarModProducto.UseVisualStyleBackColor = true;
            this.btn_cancelarModProducto.Visible = false;
            // 
            // cmb_tipoProducto
            // 
            this.cmb_tipoProducto.Enabled = false;
            this.cmb_tipoProducto.FormattingEnabled = true;
            this.cmb_tipoProducto.Location = new System.Drawing.Point(978, 345);
            this.cmb_tipoProducto.Name = "cmb_tipoProducto";
            this.cmb_tipoProducto.Size = new System.Drawing.Size(143, 21);
            this.cmb_tipoProducto.TabIndex = 59;
            this.cmb_tipoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_tipoProducto
            // 
            this.lbl_tipoProducto.AutoSize = true;
            this.lbl_tipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoProducto.Location = new System.Drawing.Point(770, 346);
            this.lbl_tipoProducto.Name = "lbl_tipoProducto";
            this.lbl_tipoProducto.Size = new System.Drawing.Size(112, 16);
            this.lbl_tipoProducto.TabIndex = 58;
            this.lbl_tipoProducto.Text = "Tipo de Producto";
            // 
            // btn_guardarModProducto
            // 
            this.btn_guardarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarModProducto.Location = new System.Drawing.Point(773, 529);
            this.btn_guardarModProducto.Name = "btn_guardarModProducto";
            this.btn_guardarModProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_guardarModProducto.TabIndex = 49;
            this.btn_guardarModProducto.Text = "Guardar Modificaciones";
            this.btn_guardarModProducto.UseVisualStyleBackColor = true;
            this.btn_guardarModProducto.Visible = false;
            this.btn_guardarModProducto.Click += new System.EventHandler(this.btn_guardarModProducto_Click);
            // 
            // btn_busquedaAvanzadaProducto
            // 
            this.btn_busquedaAvanzadaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedaAvanzadaProducto.Location = new System.Drawing.Point(507, 56);
            this.btn_busquedaAvanzadaProducto.Name = "btn_busquedaAvanzadaProducto";
            this.btn_busquedaAvanzadaProducto.Size = new System.Drawing.Size(146, 30);
            this.btn_busquedaAvanzadaProducto.TabIndex = 65;
            this.btn_busquedaAvanzadaProducto.Text = "Busqueda avanzada";
            this.btn_busquedaAvanzadaProducto.UseVisualStyleBackColor = true;
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarProducto.Location = new System.Drawing.Point(414, 56);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(67, 30);
            this.btn_buscarProducto.TabIndex = 64;
            this.btn_buscarProducto.Text = "Buscar";
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(130, 60);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(260, 22);
            this.txt_busqueda.TabIndex = 63;
            // 
            // lbl_buscarProducto
            // 
            this.lbl_buscarProducto.AutoSize = true;
            this.lbl_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscarProducto.Location = new System.Drawing.Point(61, 63);
            this.lbl_buscarProducto.Name = "lbl_buscarProducto";
            this.lbl_buscarProducto.Size = new System.Drawing.Size(53, 16);
            this.lbl_buscarProducto.TabIndex = 62;
            this.lbl_buscarProducto.Text = "Buscar:";
            // 
            // btn_registrarProducto
            // 
            this.btn_registrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarProducto.Location = new System.Drawing.Point(149, 121);
            this.btn_registrarProducto.Name = "btn_registrarProducto";
            this.btn_registrarProducto.Size = new System.Drawing.Size(109, 49);
            this.btn_registrarProducto.TabIndex = 61;
            this.btn_registrarProducto.Text = "Nuevo Producto\r\n";
            this.btn_registrarProducto.UseVisualStyleBackColor = true;
            // 
            // btn_modificarProducto
            // 
            this.btn_modificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarProducto.Location = new System.Drawing.Point(293, 121);
            this.btn_modificarProducto.Name = "btn_modificarProducto";
            this.btn_modificarProducto.Size = new System.Drawing.Size(109, 49);
            this.btn_modificarProducto.TabIndex = 60;
            this.btn_modificarProducto.Text = "Modificar";
            this.btn_modificarProducto.UseVisualStyleBackColor = true;
            // 
            // dgv_vendedores
            // 
            this.dgv_vendedores.AllowUserToAddRows = false;
            this.dgv_vendedores.AllowUserToDeleteRows = false;
            this.dgv_vendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vendedores.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_vendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vendedores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_producto,
            this.cantidad_u_medida,
            this.id_u_medida,
            this.descripcion,
            this.id_tipo_producto,
            this.precio_unitario,
            this.estado_producto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vendedores.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_vendedores.Location = new System.Drawing.Point(15, 200);
            this.dgv_vendedores.MultiSelect = false;
            this.dgv_vendedores.Name = "dgv_vendedores";
            this.dgv_vendedores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_vendedores.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_vendedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendedores.Size = new System.Drawing.Size(700, 350);
            this.dgv_vendedores.TabIndex = 66;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // cantidad_u_medida
            // 
            this.cantidad_u_medida.HeaderText = "Cantidad";
            this.cantidad_u_medida.Name = "cantidad_u_medida";
            this.cantidad_u_medida.ReadOnly = true;
            // 
            // id_u_medida
            // 
            this.id_u_medida.HeaderText = "Unidad de Medida";
            this.id_u_medida.Name = "id_u_medida";
            this.id_u_medida.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // id_tipo_producto
            // 
            this.id_tipo_producto.HeaderText = "Tipo";
            this.id_tipo_producto.Name = "id_tipo_producto";
            this.id_tipo_producto.ReadOnly = true;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            // 
            // estado_producto
            // 
            this.estado_producto.HeaderText = "Estado";
            this.estado_producto.Name = "estado_producto";
            this.estado_producto.ReadOnly = true;
            // 
            // uc_ABM_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_vendedores);
            this.Controls.Add(this.btn_busquedaAvanzadaProducto);
            this.Controls.Add(this.btn_buscarProducto);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.lbl_buscarProducto);
            this.Controls.Add(this.btn_registrarProducto);
            this.Controls.Add(this.btn_modificarProducto);
            this.Controls.Add(this.cmb_tipoProducto);
            this.Controls.Add(this.lbl_tipoProducto);
            this.Controls.Add(this.btn_cancelarModProducto);
            this.Controls.Add(this.btn_guardarModProducto);
            this.Controls.Add(this.btn_agregarTipo);
            this.Controls.Add(this.btn_agregarUdeMedida);
            this.Controls.Add(this.cmb_estadoProducto);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.txt_descripcionProducto);
            this.Controls.Add(this.cmb_unidadMedida);
            this.Controls.Add(this.txt_cantidadProducto);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.lbl_estadoProducto);
            this.Controls.Add(this.lbl_unidadMedida);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_precioUnitario);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_NomProducto);
            this.Controls.Add(this.lbl_IdProducto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_ABM_Producto";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.uc_ABM_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_IdProducto;
        private System.Windows.Forms.Label lbl_NomProducto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_unidadMedida;
        private System.Windows.Forms.Label lbl_estadoProducto;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.TextBox txt_cantidadProducto;
        private System.Windows.Forms.ComboBox cmb_unidadMedida;
        private System.Windows.Forms.TextBox txt_descripcionProducto;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.ComboBox cmb_estadoProducto;
        private System.Windows.Forms.Button btn_agregarUdeMedida;
        private System.Windows.Forms.Button btn_agregarTipo;
        private System.Windows.Forms.Button btn_cancelarModProducto;
        private System.Windows.Forms.ComboBox cmb_tipoProducto;
        private System.Windows.Forms.Label lbl_tipoProducto;
        private System.Windows.Forms.Button btn_guardarModProducto;
        private System.Windows.Forms.Button btn_busquedaAvanzadaProducto;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_buscarProducto;
        private System.Windows.Forms.Button btn_registrarProducto;
        private System.Windows.Forms.Button btn_modificarProducto;
        private System.Windows.Forms.DataGridView dgv_vendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_producto;
    }
}
