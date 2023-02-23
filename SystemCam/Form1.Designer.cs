
namespace SystemCam
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Agregar_btn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Nombre_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modificar_btn = new System.Windows.Forms.Button();
            this.Eliminar_btn = new System.Windows.Forms.Button();
            this.Nuevo_btn = new System.Windows.Forms.Button();
            this.Precio_Unidad_Venta_txt = new System.Windows.Forms.TextBox();
            this.Precio_Unidad_Compra_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Precioventapormayor_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOCOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOVENTAPORMAYORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemCamDataSet1 = new SystemCam.SystemCamDataSet1();
            this.Salir_btn = new System.Windows.Forms.Button();
            this.Contar_btn = new System.Windows.Forms.Button();
            this.Contar_txt = new System.Windows.Forms.Label();
            this.systemCamDataSet = new SystemCam.SystemCamDataSet();
            this.systemCamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new SystemCam.SystemCamDataSet1TableAdapters.ProductosTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemCamDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemCamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemCamDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar_btn
            // 
            this.Agregar_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_btn.Location = new System.Drawing.Point(97, 390);
            this.Agregar_btn.Name = "Agregar_btn";
            this.Agregar_btn.Size = new System.Drawing.Size(132, 40);
            this.Agregar_btn.TabIndex = 0;
            this.Agregar_btn.Text = "Agregar";
            this.Agregar_btn.UseVisualStyleBackColor = true;
            this.Agregar_btn.Click += new System.EventHandler(this.Agregar_btn_Click);
            // 
            // Title
            // 
            this.Title.AllowDrop = true;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(472, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(249, 48);
            this.Title.TabIndex = 1;
            this.Title.Text = "SYSTEMCAM";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_txt.Location = new System.Drawing.Point(65, 102);
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(164, 28);
            this.Nombre_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "CODIGO";
            // 
            // Codigo_txt
            // 
            this.Codigo_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_txt.Location = new System.Drawing.Point(65, 48);
            this.Codigo_txt.Name = "Codigo_txt";
            this.Codigo_txt.Size = new System.Drawing.Size(164, 29);
            this.Codigo_txt.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(54, 447);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1151, 187);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modificar_btn
            // 
            this.Modificar_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_btn.Location = new System.Drawing.Point(250, 390);
            this.Modificar_btn.Name = "Modificar_btn";
            this.Modificar_btn.Size = new System.Drawing.Size(132, 40);
            this.Modificar_btn.TabIndex = 7;
            this.Modificar_btn.Text = "Modificar";
            this.Modificar_btn.UseVisualStyleBackColor = true;
            this.Modificar_btn.Click += new System.EventHandler(this.Modificar_btn_Click);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_btn.Location = new System.Drawing.Point(409, 390);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(132, 40);
            this.Eliminar_btn.TabIndex = 8;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.UseVisualStyleBackColor = true;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // Nuevo_btn
            // 
            this.Nuevo_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_btn.Location = new System.Drawing.Point(571, 390);
            this.Nuevo_btn.Name = "Nuevo_btn";
            this.Nuevo_btn.Size = new System.Drawing.Size(132, 40);
            this.Nuevo_btn.TabIndex = 9;
            this.Nuevo_btn.Text = "Nuevo";
            this.Nuevo_btn.UseVisualStyleBackColor = true;
            this.Nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // Precio_Unidad_Venta_txt
            // 
            this.Precio_Unidad_Venta_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_Unidad_Venta_txt.Location = new System.Drawing.Point(65, 157);
            this.Precio_Unidad_Venta_txt.Name = "Precio_Unidad_Venta_txt";
            this.Precio_Unidad_Venta_txt.Size = new System.Drawing.Size(164, 28);
            this.Precio_Unidad_Venta_txt.TabIndex = 10;
            // 
            // Precio_Unidad_Compra_txt
            // 
            this.Precio_Unidad_Compra_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_Unidad_Compra_txt.Location = new System.Drawing.Point(65, 212);
            this.Precio_Unidad_Compra_txt.Name = "Precio_Unidad_Compra_txt";
            this.Precio_Unidad_Compra_txt.Size = new System.Drawing.Size(164, 28);
            this.Precio_Unidad_Compra_txt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "PRECIO UNIDAD VENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "PRECIO UNIDAD COMPRA";
            // 
            // Precioventapormayor_txt
            // 
            this.Precioventapormayor_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precioventapormayor_txt.Location = new System.Drawing.Point(65, 267);
            this.Precioventapormayor_txt.Name = "Precioventapormayor_txt";
            this.Precioventapormayor_txt.Size = new System.Drawing.Size(164, 28);
            this.Precioventapormayor_txt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "PRECIO CAJA VENTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(790, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Busqueda";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(551, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 32);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CODIGO",
            "NOMBRE",
            "PRECIO"});
            this.comboBox1.Location = new System.Drawing.Point(1131, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.pRECIOCOMPRADataGridViewTextBoxColumn,
            this.pRECIOVENTAPORMAYORDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(551, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(701, 150);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            // 
            // pRECIOCOMPRADataGridViewTextBoxColumn
            // 
            this.pRECIOCOMPRADataGridViewTextBoxColumn.DataPropertyName = "PRECIO_COMPRA";
            this.pRECIOCOMPRADataGridViewTextBoxColumn.HeaderText = "PRECIO_COMPRA";
            this.pRECIOCOMPRADataGridViewTextBoxColumn.Name = "pRECIOCOMPRADataGridViewTextBoxColumn";
            // 
            // pRECIOVENTAPORMAYORDataGridViewTextBoxColumn
            // 
            this.pRECIOVENTAPORMAYORDataGridViewTextBoxColumn.DataPropertyName = "PRECIO_VENTA_POR_MAYOR";
            this.pRECIOVENTAPORMAYORDataGridViewTextBoxColumn.HeaderText = "PRECIO_VENTA_POR_MAYOR";
            this.pRECIOVENTAPORMAYORDataGridViewTextBoxColumn.Name = "pRECIOVENTAPORMAYORDataGridViewTextBoxColumn";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.systemCamDataSet1;
            // 
            // systemCamDataSet1
            // 
            this.systemCamDataSet1.DataSetName = "SystemCamDataSet1";
            this.systemCamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Salir_btn
            // 
            this.Salir_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir_btn.Location = new System.Drawing.Point(1120, 390);
            this.Salir_btn.Name = "Salir_btn";
            this.Salir_btn.Size = new System.Drawing.Size(132, 40);
            this.Salir_btn.TabIndex = 20;
            this.Salir_btn.Text = "Salir";
            this.Salir_btn.UseVisualStyleBackColor = true;
            this.Salir_btn.Click += new System.EventHandler(this.Salir_btn_Click);
            // 
            // Contar_btn
            // 
            this.Contar_btn.BackColor = System.Drawing.Color.Lime;
            this.Contar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Contar_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contar_btn.Location = new System.Drawing.Point(835, 639);
            this.Contar_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Contar_btn.Name = "Contar_btn";
            this.Contar_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Contar_btn.Size = new System.Drawing.Size(125, 33);
            this.Contar_btn.TabIndex = 21;
            this.Contar_btn.Text = "Contar";
            this.Contar_btn.UseVisualStyleBackColor = false;
            this.Contar_btn.Click += new System.EventHandler(this.Contar_btn_Click);
            // 
            // Contar_txt
            // 
            this.Contar_txt.AutoSize = true;
            this.Contar_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contar_txt.Location = new System.Drawing.Point(986, 642);
            this.Contar_txt.Name = "Contar_txt";
            this.Contar_txt.Size = new System.Drawing.Size(89, 30);
            this.Contar_txt.TabIndex = 22;
            this.Contar_txt.Text = "Cantidad";
            this.Contar_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Contar_txt.UseCompatibleTextRendering = true;
            this.Contar_txt.UseWaitCursor = true;
            // 
            // systemCamDataSet
            // 
            this.systemCamDataSet.DataSetName = "SystemCamDataSet";
            this.systemCamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemCamDataSetBindingSource
            // 
            this.systemCamDataSetBindingSource.DataSource = this.systemCamDataSet;
            this.systemCamDataSetBindingSource.Position = 0;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Enabled = false;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(0, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Caheve Developer 2023";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(65, 325);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 28);
            this.textBox2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "PRECIO CAJA COMPRA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Contar_txt);
            this.Controls.Add(this.Contar_btn);
            this.Controls.Add(this.Salir_btn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Precioventapormayor_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Precio_Unidad_Compra_txt);
            this.Controls.Add(this.Precio_Unidad_Venta_txt);
            this.Controls.Add(this.Nuevo_btn);
            this.Controls.Add(this.Eliminar_btn);
            this.Controls.Add(this.Modificar_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Codigo_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Agregar_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemCam";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemCamDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemCamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemCamDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar_btn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Nombre_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Codigo_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Modificar_btn;
        private System.Windows.Forms.Button Eliminar_btn;
        private System.Windows.Forms.Button Nuevo_btn;
        private System.Windows.Forms.TextBox Precio_Unidad_Venta_txt;
        private System.Windows.Forms.TextBox Precio_Unidad_Compra_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Precioventapormayor_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Salir_btn;
        private System.Windows.Forms.BindingSource systemCamDataSetBindingSource;
        private SystemCamDataSet systemCamDataSet;
        private SystemCamDataSet1 systemCamDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private SystemCamDataSet1TableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOCOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOVENTAPORMAYORDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Contar_btn;
        private System.Windows.Forms.Label Contar_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
    }
}

