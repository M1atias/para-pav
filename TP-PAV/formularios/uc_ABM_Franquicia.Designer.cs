﻿namespace TP_PAV.formularios
{
    partial class uc_ABM_Franquicia
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
            this.btn_modificarFranquicia = new System.Windows.Forms.Button();
            this.btn_cancelarModificaciones = new System.Windows.Forms.Button();
            this.btn_cancelarGuardado = new System.Windows.Forms.Button();
            this.btn_eliminarFranquicia = new System.Windows.Forms.Button();
            this.btn_habilitarModificarFranquicia = new System.Windows.Forms.Button();
            this.btn_habilitarAñadirFranquicia = new System.Windows.Forms.Button();
            this.txt_legajoVendedor = new System.Windows.Forms.TextBox();
            this.txt_nroCalle = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_apellidoResponsable = new System.Windows.Forms.TextBox();
            this.txt_nombreResponsable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_barrio = new System.Windows.Forms.Label();
            this.lbl_nro_calle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardarNuevaFranquicia = new System.Windows.Forms.Button();
            this.cmb_tipoFranquicia = new System.Windows.Forms.ComboBox();
            this.cmb_barrio = new System.Windows.Forms.ComboBox();
            this.btn_agregarTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_agregarBarrio = new System.Windows.Forms.Button();
            this.txt_buscarFranquicia = new System.Windows.Forms.TextBox();
            this.btn_buscarFranquicia = new System.Windows.Forms.Button();
            this.dgv_franquicias = new System.Windows.Forms.DataGridView();
            this.id_franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipo_franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_franquicias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Franquicias";
            // 
            // btn_modificarFranquicia
            // 
            this.btn_modificarFranquicia.Enabled = false;
            this.btn_modificarFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarFranquicia.Location = new System.Drawing.Point(780, 513);
            this.btn_modificarFranquicia.Name = "btn_modificarFranquicia";
            this.btn_modificarFranquicia.Size = new System.Drawing.Size(169, 37);
            this.btn_modificarFranquicia.TabIndex = 50;
            this.btn_modificarFranquicia.Text = "Guardar modificaciones";
            this.btn_modificarFranquicia.UseVisualStyleBackColor = true;
            this.btn_modificarFranquicia.Visible = false;
            this.btn_modificarFranquicia.Click += new System.EventHandler(this.btn_modificarFranquicia_Click);
            // 
            // btn_cancelarModificaciones
            // 
            this.btn_cancelarModificaciones.Enabled = false;
            this.btn_cancelarModificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarModificaciones.Location = new System.Drawing.Point(1067, 513);
            this.btn_cancelarModificaciones.Name = "btn_cancelarModificaciones";
            this.btn_cancelarModificaciones.Size = new System.Drawing.Size(98, 37);
            this.btn_cancelarModificaciones.TabIndex = 49;
            this.btn_cancelarModificaciones.Text = "Cancelar";
            this.btn_cancelarModificaciones.UseVisualStyleBackColor = true;
            this.btn_cancelarModificaciones.Visible = false;
            this.btn_cancelarModificaciones.Click += new System.EventHandler(this.btn_cancelarModificaciones_Click);
            // 
            // btn_cancelarGuardado
            // 
            this.btn_cancelarGuardado.Enabled = false;
            this.btn_cancelarGuardado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarGuardado.Location = new System.Drawing.Point(1067, 513);
            this.btn_cancelarGuardado.Name = "btn_cancelarGuardado";
            this.btn_cancelarGuardado.Size = new System.Drawing.Size(98, 37);
            this.btn_cancelarGuardado.TabIndex = 48;
            this.btn_cancelarGuardado.Text = "Cancelar";
            this.btn_cancelarGuardado.UseVisualStyleBackColor = true;
            this.btn_cancelarGuardado.Visible = false;
            this.btn_cancelarGuardado.Click += new System.EventHandler(this.btn_cancelarGuardado_Click);
            // 
            // btn_eliminarFranquicia
            // 
            this.btn_eliminarFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarFranquicia.Location = new System.Drawing.Point(567, 79);
            this.btn_eliminarFranquicia.Name = "btn_eliminarFranquicia";
            this.btn_eliminarFranquicia.Size = new System.Drawing.Size(148, 30);
            this.btn_eliminarFranquicia.TabIndex = 47;
            this.btn_eliminarFranquicia.Text = "Eliminar Franquicia";
            this.btn_eliminarFranquicia.UseVisualStyleBackColor = true;
            this.btn_eliminarFranquicia.Click += new System.EventHandler(this.btn_eliminarFranquicia_Click);
            // 
            // btn_habilitarModificarFranquicia
            // 
            this.btn_habilitarModificarFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitarModificarFranquicia.Location = new System.Drawing.Point(301, 79);
            this.btn_habilitarModificarFranquicia.Name = "btn_habilitarModificarFranquicia";
            this.btn_habilitarModificarFranquicia.Size = new System.Drawing.Size(139, 30);
            this.btn_habilitarModificarFranquicia.TabIndex = 46;
            this.btn_habilitarModificarFranquicia.Text = "Modificar Franquicia";
            this.btn_habilitarModificarFranquicia.UseVisualStyleBackColor = true;
            this.btn_habilitarModificarFranquicia.Click += new System.EventHandler(this.btn_habilitarModificarFranquicia_Click);
            // 
            // btn_habilitarAñadirFranquicia
            // 
            this.btn_habilitarAñadirFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitarAñadirFranquicia.Location = new System.Drawing.Point(15, 79);
            this.btn_habilitarAñadirFranquicia.Name = "btn_habilitarAñadirFranquicia";
            this.btn_habilitarAñadirFranquicia.Size = new System.Drawing.Size(162, 30);
            this.btn_habilitarAñadirFranquicia.TabIndex = 45;
            this.btn_habilitarAñadirFranquicia.Text = "Añadir Nueva Franquicia";
            this.btn_habilitarAñadirFranquicia.UseVisualStyleBackColor = true;
            this.btn_habilitarAñadirFranquicia.Click += new System.EventHandler(this.btn_habilitarAñadirFranquicia_Click);
            // 
            // txt_legajoVendedor
            // 
            this.txt_legajoVendedor.Enabled = false;
            this.txt_legajoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajoVendedor.Location = new System.Drawing.Point(939, 442);
            this.txt_legajoVendedor.Name = "txt_legajoVendedor";
            this.txt_legajoVendedor.Size = new System.Drawing.Size(181, 21);
            this.txt_legajoVendedor.TabIndex = 42;
            // 
            // txt_nroCalle
            // 
            this.txt_nroCalle.Enabled = false;
            this.txt_nroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroCalle.Location = new System.Drawing.Point(939, 280);
            this.txt_nroCalle.Name = "txt_nroCalle";
            this.txt_nroCalle.Size = new System.Drawing.Size(181, 21);
            this.txt_nroCalle.TabIndex = 40;
            // 
            // txt_calle
            // 
            this.txt_calle.Enabled = false;
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle.Location = new System.Drawing.Point(939, 227);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(181, 21);
            this.txt_calle.TabIndex = 39;
            // 
            // txt_apellidoResponsable
            // 
            this.txt_apellidoResponsable.Enabled = false;
            this.txt_apellidoResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoResponsable.Location = new System.Drawing.Point(939, 180);
            this.txt_apellidoResponsable.Name = "txt_apellidoResponsable";
            this.txt_apellidoResponsable.Size = new System.Drawing.Size(181, 21);
            this.txt_apellidoResponsable.TabIndex = 38;
            // 
            // txt_nombreResponsable
            // 
            this.txt_nombreResponsable.Enabled = false;
            this.txt_nombreResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreResponsable.Location = new System.Drawing.Point(939, 132);
            this.txt_nombreResponsable.Name = "txt_nombreResponsable";
            this.txt_nombreResponsable.Size = new System.Drawing.Size(181, 21);
            this.txt_nombreResponsable.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(775, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Legajo del Vendedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(775, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tipo de Franquicia";
            // 
            // lbl_barrio
            // 
            this.lbl_barrio.AutoSize = true;
            this.lbl_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barrio.Location = new System.Drawing.Point(775, 332);
            this.lbl_barrio.Name = "lbl_barrio";
            this.lbl_barrio.Size = new System.Drawing.Size(40, 15);
            this.lbl_barrio.TabIndex = 33;
            this.lbl_barrio.Text = "Barrio";
            // 
            // lbl_nro_calle
            // 
            this.lbl_nro_calle.AutoSize = true;
            this.lbl_nro_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_calle.Location = new System.Drawing.Point(776, 280);
            this.lbl_nro_calle.Name = "lbl_nro_calle";
            this.lbl_nro_calle.Size = new System.Drawing.Size(100, 15);
            this.lbl_nro_calle.TabIndex = 32;
            this.lbl_nro_calle.Text = "Numero de Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Calle: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(777, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Apellido Responsable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre Responsable: ";
            // 
            // btn_guardarNuevaFranquicia
            // 
            this.btn_guardarNuevaFranquicia.Enabled = false;
            this.btn_guardarNuevaFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarNuevaFranquicia.Location = new System.Drawing.Point(780, 513);
            this.btn_guardarNuevaFranquicia.Name = "btn_guardarNuevaFranquicia";
            this.btn_guardarNuevaFranquicia.Size = new System.Drawing.Size(167, 37);
            this.btn_guardarNuevaFranquicia.TabIndex = 28;
            this.btn_guardarNuevaFranquicia.Text = "Guardar Nueva Franquicia";
            this.btn_guardarNuevaFranquicia.UseVisualStyleBackColor = true;
            this.btn_guardarNuevaFranquicia.Visible = false;
            this.btn_guardarNuevaFranquicia.Click += new System.EventHandler(this.btn_guardarNuevaFranquicia_Click);
            // 
            // cmb_tipoFranquicia
            // 
            this.cmb_tipoFranquicia.Enabled = false;
            this.cmb_tipoFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoFranquicia.FormattingEnabled = true;
            this.cmb_tipoFranquicia.Location = new System.Drawing.Point(939, 384);
            this.cmb_tipoFranquicia.Name = "cmb_tipoFranquicia";
            this.cmb_tipoFranquicia.Size = new System.Drawing.Size(181, 23);
            this.cmb_tipoFranquicia.TabIndex = 27;
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.Enabled = false;
            this.cmb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(939, 328);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Size = new System.Drawing.Size(181, 23);
            this.cmb_barrio.TabIndex = 26;
            // 
            // btn_agregarTipoFranquicia
            // 
            this.btn_agregarTipoFranquicia.Enabled = false;
            this.btn_agregarTipoFranquicia.Location = new System.Drawing.Point(1128, 383);
            this.btn_agregarTipoFranquicia.Name = "btn_agregarTipoFranquicia";
            this.btn_agregarTipoFranquicia.Size = new System.Drawing.Size(37, 23);
            this.btn_agregarTipoFranquicia.TabIndex = 51;
            this.btn_agregarTipoFranquicia.Text = "+";
            this.btn_agregarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_agregarTipoFranquicia.Click += new System.EventHandler(this.btn_agregarTipoFranquicia_click);
            // 
            // btn_agregarBarrio
            // 
            this.btn_agregarBarrio.Enabled = false;
            this.btn_agregarBarrio.Location = new System.Drawing.Point(1128, 328);
            this.btn_agregarBarrio.Name = "btn_agregarBarrio";
            this.btn_agregarBarrio.Size = new System.Drawing.Size(37, 23);
            this.btn_agregarBarrio.TabIndex = 52;
            this.btn_agregarBarrio.Text = "+";
            this.btn_agregarBarrio.UseVisualStyleBackColor = true;
            this.btn_agregarBarrio.Click += new System.EventHandler(this.btn_agregarBarrio_Click);
            // 
            // txt_buscarFranquicia
            // 
            this.txt_buscarFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarFranquicia.Location = new System.Drawing.Point(15, 148);
            this.txt_buscarFranquicia.Name = "txt_buscarFranquicia";
            this.txt_buscarFranquicia.Size = new System.Drawing.Size(596, 21);
            this.txt_buscarFranquicia.TabIndex = 53;
            this.txt_buscarFranquicia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscarFranquicia_KeyUp);
            // 
            // btn_buscarFranquicia
            // 
            this.btn_buscarFranquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarFranquicia.Location = new System.Drawing.Point(617, 144);
            this.btn_buscarFranquicia.Name = "btn_buscarFranquicia";
            this.btn_buscarFranquicia.Size = new System.Drawing.Size(98, 29);
            this.btn_buscarFranquicia.TabIndex = 54;
            this.btn_buscarFranquicia.Text = "Buscar";
            this.btn_buscarFranquicia.UseVisualStyleBackColor = true;
            this.btn_buscarFranquicia.Click += new System.EventHandler(this.btn_buscarFranquicia_Click);
            // 
            // dgv_franquicias
            // 
            this.dgv_franquicias.AllowUserToAddRows = false;
            this.dgv_franquicias.AllowUserToDeleteRows = false;
            this.dgv_franquicias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_franquicias.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_franquicias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_franquicias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_franquicias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_franquicias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_franquicias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_franquicia,
            this.nombre_responsable,
            this.apellido_responsable,
            this.calle,
            this.nro_calle,
            this.nombre_barrio,
            this.nombre_tipo_franquicia,
            this.nombre_vendedor,
            this.apellido_vendedor,
            this.legajo_vendedor,
            this.id_tipo_franquicia,
            this.id_barrio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_franquicias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_franquicias.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_franquicias.Location = new System.Drawing.Point(15, 200);
            this.dgv_franquicias.Name = "dgv_franquicias";
            this.dgv_franquicias.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_franquicias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_franquicias.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_franquicias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_franquicias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_franquicias.Size = new System.Drawing.Size(700, 350);
            this.dgv_franquicias.TabIndex = 55;
            // 
            // id_franquicia
            // 
            this.id_franquicia.DataPropertyName = "id_franquicia";
            this.id_franquicia.HeaderText = "ID Franquicia";
            this.id_franquicia.Name = "id_franquicia";
            this.id_franquicia.ReadOnly = true;
            this.id_franquicia.Width = 96;
            // 
            // nombre_responsable
            // 
            this.nombre_responsable.DataPropertyName = "nombre_responsable";
            this.nombre_responsable.HeaderText = "Nombre del Responsable";
            this.nombre_responsable.Name = "nombre_responsable";
            this.nombre_responsable.ReadOnly = true;
            this.nombre_responsable.Width = 158;
            // 
            // apellido_responsable
            // 
            this.apellido_responsable.DataPropertyName = "apellido_responsable";
            this.apellido_responsable.HeaderText = "Apellido del Responsable";
            this.apellido_responsable.Name = "apellido_responsable";
            this.apellido_responsable.ReadOnly = true;
            this.apellido_responsable.Width = 157;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 60;
            // 
            // nro_calle
            // 
            this.nro_calle.DataPropertyName = "nro_calle";
            this.nro_calle.HeaderText = "Nro Calle";
            this.nro_calle.Name = "nro_calle";
            this.nro_calle.ReadOnly = true;
            this.nro_calle.Width = 77;
            // 
            // nombre_barrio
            // 
            this.nombre_barrio.DataPropertyName = "nombre_barrio";
            this.nombre_barrio.HeaderText = "Barrio";
            this.nombre_barrio.Name = "nombre_barrio";
            this.nombre_barrio.ReadOnly = true;
            this.nombre_barrio.Width = 65;
            // 
            // nombre_tipo_franquicia
            // 
            this.nombre_tipo_franquicia.DataPropertyName = "nombre_tipo_franquicia";
            this.nombre_tipo_franquicia.HeaderText = "Tipo de Franquicia";
            this.nombre_tipo_franquicia.Name = "nombre_tipo_franquicia";
            this.nombre_tipo_franquicia.ReadOnly = true;
            this.nombre_tipo_franquicia.Width = 123;
            // 
            // nombre_vendedor
            // 
            this.nombre_vendedor.DataPropertyName = "nombre_vendedor";
            this.nombre_vendedor.HeaderText = "Nombre del Vendedor";
            this.nombre_vendedor.Name = "nombre_vendedor";
            this.nombre_vendedor.ReadOnly = true;
            this.nombre_vendedor.Width = 92;
            // 
            // apellido_vendedor
            // 
            this.apellido_vendedor.DataPropertyName = "apellido_vendedor";
            this.apellido_vendedor.HeaderText = "Apellido del Vendedor";
            this.apellido_vendedor.Name = "apellido_vendedor";
            this.apellido_vendedor.ReadOnly = true;
            this.apellido_vendedor.Width = 91;
            // 
            // legajo_vendedor
            // 
            this.legajo_vendedor.DataPropertyName = "legajo_vendedor";
            this.legajo_vendedor.HeaderText = "Legajo del Vendedor";
            this.legajo_vendedor.Name = "legajo_vendedor";
            this.legajo_vendedor.ReadOnly = true;
            this.legajo_vendedor.Width = 86;
            // 
            // id_tipo_franquicia
            // 
            this.id_tipo_franquicia.DataPropertyName = "id_tipo_franquicia";
            this.id_tipo_franquicia.HeaderText = "ID Tipo Franquicia";
            this.id_tipo_franquicia.Name = "id_tipo_franquicia";
            this.id_tipo_franquicia.ReadOnly = true;
            this.id_tipo_franquicia.Visible = false;
            // 
            // id_barrio
            // 
            this.id_barrio.DataPropertyName = "id_barrio";
            this.id_barrio.HeaderText = "ID Barrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Visible = false;
            // 
            // uc_ABM_Franquicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_franquicias);
            this.Controls.Add(this.btn_buscarFranquicia);
            this.Controls.Add(this.txt_buscarFranquicia);
            this.Controls.Add(this.btn_agregarBarrio);
            this.Controls.Add(this.btn_agregarTipoFranquicia);
            this.Controls.Add(this.btn_modificarFranquicia);
            this.Controls.Add(this.btn_cancelarModificaciones);
            this.Controls.Add(this.btn_cancelarGuardado);
            this.Controls.Add(this.btn_eliminarFranquicia);
            this.Controls.Add(this.btn_habilitarModificarFranquicia);
            this.Controls.Add(this.btn_habilitarAñadirFranquicia);
            this.Controls.Add(this.txt_legajoVendedor);
            this.Controls.Add(this.txt_nroCalle);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_apellidoResponsable);
            this.Controls.Add(this.txt_nombreResponsable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_barrio);
            this.Controls.Add(this.lbl_nro_calle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_guardarNuevaFranquicia);
            this.Controls.Add(this.cmb_tipoFranquicia);
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_ABM_Franquicia";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.uc_ABM_Franquicia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_franquicias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modificarFranquicia;
        private System.Windows.Forms.Button btn_cancelarModificaciones;
        private System.Windows.Forms.Button btn_cancelarGuardado;
        private System.Windows.Forms.Button btn_eliminarFranquicia;
        private System.Windows.Forms.Button btn_habilitarModificarFranquicia;
        private System.Windows.Forms.Button btn_habilitarAñadirFranquicia;
        private System.Windows.Forms.TextBox txt_legajoVendedor;
        private System.Windows.Forms.TextBox txt_nroCalle;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_apellidoResponsable;
        private System.Windows.Forms.TextBox txt_nombreResponsable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_barrio;
        private System.Windows.Forms.Label lbl_nro_calle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardarNuevaFranquicia;
        private System.Windows.Forms.ComboBox cmb_tipoFranquicia;
        private System.Windows.Forms.ComboBox cmb_barrio;
        private System.Windows.Forms.Button btn_agregarTipoFranquicia;
        private System.Windows.Forms.Button btn_agregarBarrio;
        private System.Windows.Forms.TextBox txt_buscarFranquicia;
        private System.Windows.Forms.Button btn_buscarFranquicia;
        private System.Windows.Forms.DataGridView dgv_franquicias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipo_franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
    }
}
