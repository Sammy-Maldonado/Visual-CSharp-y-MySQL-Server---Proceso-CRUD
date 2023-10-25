namespace conexion_BD
{
    partial class Frm_articulos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_articulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Dgv_articulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_descripcion_ar = new System.Windows.Forms.TextBox();
            this.Txt_marca_ar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_descripcion_um = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_lupa_um = new System.Windows.Forms.Button();
            this.Btn_lupa_ca = new System.Windows.Forms.Button();
            this.Txt_descripcion_ca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_stock_actual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pnl_um = new System.Windows.Forms.Panel();
            this.Btn_retornar_um = new System.Windows.Forms.Button();
            this.Dgv_um = new System.Windows.Forms.DataGridView();
            this.Pnl_ca = new System.Windows.Forms.Panel();
            this.Btn_retornar_ca = new System.Windows.Forms.Button();
            this.Dgv_ca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).BeginInit();
            this.Pnl_um.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_um)).BeginInit();
            this.Pnl_ca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ca)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.Location = new System.Drawing.Point(262, 139);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(92, 28);
            this.Btn_cancelar.TabIndex = 0;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(111)))), ((int)(((byte)(219)))));
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(388, 139);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(92, 28);
            this.Btn_guardar.TabIndex = 1;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Dgv_articulos
            // 
            this.Dgv_articulos.AllowUserToAddRows = false;
            this.Dgv_articulos.AllowUserToDeleteRows = false;
            this.Dgv_articulos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_articulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_articulos.ColumnHeadersHeight = 35;
            this.Dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_articulos.Location = new System.Drawing.Point(26, 224);
            this.Dgv_articulos.Name = "Dgv_articulos";
            this.Dgv_articulos.ReadOnly = true;
            this.Dgv_articulos.Size = new System.Drawing.Size(901, 224);
            this.Dgv_articulos.TabIndex = 2;
            this.Dgv_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_articulos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artículo:";
            // 
            // Txt_descripcion_ar
            // 
            this.Txt_descripcion_ar.Location = new System.Drawing.Point(105, 59);
            this.Txt_descripcion_ar.Name = "Txt_descripcion_ar";
            this.Txt_descripcion_ar.ReadOnly = true;
            this.Txt_descripcion_ar.Size = new System.Drawing.Size(219, 20);
            this.Txt_descripcion_ar.TabIndex = 4;
            // 
            // Txt_marca_ar
            // 
            this.Txt_marca_ar.Location = new System.Drawing.Point(416, 59);
            this.Txt_marca_ar.Name = "Txt_marca_ar";
            this.Txt_marca_ar.ReadOnly = true;
            this.Txt_marca_ar.Size = new System.Drawing.Size(182, 20);
            this.Txt_marca_ar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marca:";
            // 
            // Txt_descripcion_um
            // 
            this.Txt_descripcion_um.Location = new System.Drawing.Point(105, 85);
            this.Txt_descripcion_um.Name = "Txt_descripcion_um";
            this.Txt_descripcion_um.ReadOnly = true;
            this.Txt_descripcion_um.Size = new System.Drawing.Size(184, 20);
            this.Txt_descripcion_um.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medida:";
            // 
            // Btn_lupa_um
            // 
            this.Btn_lupa_um.Enabled = false;
            this.Btn_lupa_um.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_lupa_um.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_lupa_um.Location = new System.Drawing.Point(295, 85);
            this.Btn_lupa_um.Name = "Btn_lupa_um";
            this.Btn_lupa_um.Size = new System.Drawing.Size(29, 20);
            this.Btn_lupa_um.TabIndex = 9;
            this.Btn_lupa_um.Text = ":::";
            this.Btn_lupa_um.UseVisualStyleBackColor = true;
            this.Btn_lupa_um.Click += new System.EventHandler(this.Btn_lupa_um_Click);
            // 
            // Btn_lupa_ca
            // 
            this.Btn_lupa_ca.Enabled = false;
            this.Btn_lupa_ca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_lupa_ca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_lupa_ca.Location = new System.Drawing.Point(571, 85);
            this.Btn_lupa_ca.Name = "Btn_lupa_ca";
            this.Btn_lupa_ca.Size = new System.Drawing.Size(27, 20);
            this.Btn_lupa_ca.TabIndex = 12;
            this.Btn_lupa_ca.Text = ":::";
            this.Btn_lupa_ca.UseVisualStyleBackColor = true;
            this.Btn_lupa_ca.Click += new System.EventHandler(this.Btn_lupa_ca_Click);
            // 
            // Txt_descripcion_ca
            // 
            this.Txt_descripcion_ca.Location = new System.Drawing.Point(416, 85);
            this.Txt_descripcion_ca.Name = "Txt_descripcion_ca";
            this.Txt_descripcion_ca.ReadOnly = true;
            this.Txt_descripcion_ca.Size = new System.Drawing.Size(149, 20);
            this.Txt_descripcion_ca.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categoría:";
            // 
            // Txt_stock_actual
            // 
            this.Txt_stock_actual.Location = new System.Drawing.Point(105, 111);
            this.Txt_stock_actual.Name = "Txt_stock_actual";
            this.Txt_stock_actual.ReadOnly = true;
            this.Txt_stock_actual.Size = new System.Drawing.Size(100, 20);
            this.Txt_stock_actual.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock actual:";
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ImageKey = "nuevo.png";
            this.Btn_nuevo.ImageList = this.imageList1;
            this.Btn_nuevo.Location = new System.Drawing.Point(943, 59);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(85, 73);
            this.Btn_nuevo.TabIndex = 15;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo.png");
            this.imageList1.Images.SetKeyName(1, "cerrar.png");
            this.imageList1.Images.SetKeyName(2, "crear.png");
            this.imageList1.Images.SetKeyName(3, "delete.png");
            this.imageList1.Images.SetKeyName(4, "report.png");
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.ImageKey = "crear.png";
            this.Btn_actualizar.ImageList = this.imageList1;
            this.Btn_actualizar.Location = new System.Drawing.Point(943, 138);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(85, 73);
            this.Btn_actualizar.TabIndex = 16;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ImageKey = "delete.png";
            this.Btn_eliminar.ImageList = this.imageList1;
            this.Btn_eliminar.Location = new System.Drawing.Point(943, 217);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(85, 73);
            this.Btn_eliminar.TabIndex = 17;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.ImageKey = "report.png";
            this.Btn_reporte.ImageList = this.imageList1;
            this.Btn_reporte.Location = new System.Drawing.Point(943, 296);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(85, 73);
            this.Btn_reporte.TabIndex = 18;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageKey = "cerrar.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(943, 375);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(85, 73);
            this.Btn_salir.TabIndex = 19;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Location = new System.Drawing.Point(262, 184);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(27, 20);
            this.Btn_buscar.TabIndex = 22;
            this.Btn_buscar.Text = ":::";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(72, 184);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(184, 20);
            this.Txt_buscar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar:";
            // 
            // Pnl_um
            // 
            this.Pnl_um.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_um.Controls.Add(this.Btn_retornar_um);
            this.Pnl_um.Controls.Add(this.Dgv_um);
            this.Pnl_um.Location = new System.Drawing.Point(446, 197);
            this.Pnl_um.Name = "Pnl_um";
            this.Pnl_um.Size = new System.Drawing.Size(209, 196);
            this.Pnl_um.TabIndex = 23;
            this.Pnl_um.Visible = false;
            // 
            // Btn_retornar_um
            // 
            this.Btn_retornar_um.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_retornar_um.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_retornar_um.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar_um.Location = new System.Drawing.Point(3, 159);
            this.Btn_retornar_um.Name = "Btn_retornar_um";
            this.Btn_retornar_um.Size = new System.Drawing.Size(202, 28);
            this.Btn_retornar_um.TabIndex = 24;
            this.Btn_retornar_um.Text = "Retornar";
            this.Btn_retornar_um.UseVisualStyleBackColor = false;
            this.Btn_retornar_um.Click += new System.EventHandler(this.Btn_retornar_um_Click);
            // 
            // Dgv_um
            // 
            this.Dgv_um.AllowUserToAddRows = false;
            this.Dgv_um.AllowUserToDeleteRows = false;
            this.Dgv_um.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_um.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_um.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_um.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_um.ColumnHeadersHeight = 35;
            this.Dgv_um.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_um.Location = new System.Drawing.Point(3, 3);
            this.Dgv_um.Name = "Dgv_um";
            this.Dgv_um.ReadOnly = true;
            this.Dgv_um.Size = new System.Drawing.Size(202, 150);
            this.Dgv_um.TabIndex = 24;
            this.Dgv_um.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_um_CellDoubleClick);
            // 
            // Pnl_ca
            // 
            this.Pnl_ca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_ca.Controls.Add(this.Btn_retornar_ca);
            this.Pnl_ca.Controls.Add(this.Dgv_ca);
            this.Pnl_ca.Location = new System.Drawing.Point(671, 197);
            this.Pnl_ca.Name = "Pnl_ca";
            this.Pnl_ca.Size = new System.Drawing.Size(209, 196);
            this.Pnl_ca.TabIndex = 25;
            this.Pnl_ca.Visible = false;
            // 
            // Btn_retornar_ca
            // 
            this.Btn_retornar_ca.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_retornar_ca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Btn_retornar_ca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar_ca.Location = new System.Drawing.Point(2, 159);
            this.Btn_retornar_ca.Name = "Btn_retornar_ca";
            this.Btn_retornar_ca.Size = new System.Drawing.Size(202, 28);
            this.Btn_retornar_ca.TabIndex = 24;
            this.Btn_retornar_ca.Text = "Retornar";
            this.Btn_retornar_ca.UseVisualStyleBackColor = false;
            this.Btn_retornar_ca.Click += new System.EventHandler(this.Btn_retornar_ca_Click);
            // 
            // Dgv_ca
            // 
            this.Dgv_ca.AllowUserToAddRows = false;
            this.Dgv_ca.AllowUserToDeleteRows = false;
            this.Dgv_ca.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_ca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_ca.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_ca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_ca.ColumnHeadersHeight = 35;
            this.Dgv_ca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_ca.Location = new System.Drawing.Point(2, 3);
            this.Dgv_ca.Name = "Dgv_ca";
            this.Dgv_ca.ReadOnly = true;
            this.Dgv_ca.Size = new System.Drawing.Size(202, 150);
            this.Dgv_ca.TabIndex = 24;
            this.Dgv_ca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ca_CellDoubleClick);
            // 
            // Frm_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 464);
            this.Controls.Add(this.Pnl_ca);
            this.Controls.Add(this.Pnl_um);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Txt_stock_actual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_lupa_ca);
            this.Controls.Add(this.Txt_descripcion_ca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_lupa_um);
            this.Controls.Add(this.Txt_descripcion_um);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_marca_ar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_descripcion_ar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_articulos);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_cancelar);
            this.Name = "Frm_articulos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_articulos)).EndInit();
            this.Pnl_um.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_um)).EndInit();
            this.Pnl_ca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.DataGridView Dgv_articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_descripcion_ar;
        private System.Windows.Forms.TextBox Txt_marca_ar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_descripcion_um;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_lupa_um;
        private System.Windows.Forms.Button Btn_lupa_ca;
        private System.Windows.Forms.TextBox Txt_descripcion_ca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_stock_actual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_um;
        private System.Windows.Forms.DataGridView Dgv_um;
        private System.Windows.Forms.Button Btn_retornar_um;
        private System.Windows.Forms.Panel Pnl_ca;
        private System.Windows.Forms.Button Btn_retornar_ca;
        private System.Windows.Forms.DataGridView Dgv_ca;
    }
}

