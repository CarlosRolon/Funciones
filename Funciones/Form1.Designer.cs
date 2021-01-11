namespace Funciones
{
    partial class frmMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.lbFuncion = new System.Windows.Forms.Label();
            this.nupDimension = new System.Windows.Forms.NumericUpDown();
            this.lbDimension = new System.Windows.Forms.Label();
            this.lbIteraciones = new System.Windows.Forms.Label();
            this.nupIteraciones = new System.Windows.Forms.NumericUpDown();
            this.lbPbMutacion = new System.Windows.Forms.Label();
            this.nupProbMutacion = new System.Windows.Forms.NumericUpDown();
            this.lbPbCruz = new System.Windows.Forms.Label();
            this.nupProbCruzamiento = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.lbMetCruzamiento = new System.Windows.Forms.Label();
            this.cmbMetSeleccion = new System.Windows.Forms.ComboBox();
            this.cmbMetCruzamiento = new System.Windows.Forms.ComboBox();
            this.lbMetSeleccion = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbMetReemplazo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.dataGridResultados = new System.Windows.Forms.DataGridView();
            this.FuncionGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MejorGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeorGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedianaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesviacionGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridTiempo = new System.Windows.Forms.DataGridView();
            this.FuncionGridTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MejorGridTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeorGridTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioGridTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedianaGridTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesviacionGridTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lbEvaluaciones = new System.Windows.Forms.Label();
            this.nupEvaluaciones = new System.Windows.Forms.NumericUpDown();
            this.cmbMetMutacion = new System.Windows.Forms.ComboBox();
            this.lbMetMutacion = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProbMutacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProbCruzamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEvaluaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Items.AddRange(new object[] {
            "Función 1 - Alpine",
            "Función 2 - Dixon & Price",
            "Función 3 - Quintic",
            "Función 4 - Schwefel",
            "Función 5 - Streched V Sine",
            "Función 6 - Suma de Cuadrados"});
            this.cmbFuncion.Location = new System.Drawing.Point(230, 31);
            this.cmbFuncion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(311, 33);
            this.cmbFuncion.TabIndex = 0;
            // 
            // lbFuncion
            // 
            this.lbFuncion.AutoSize = true;
            this.lbFuncion.Location = new System.Drawing.Point(123, 31);
            this.lbFuncion.Name = "lbFuncion";
            this.lbFuncion.Size = new System.Drawing.Size(82, 25);
            this.lbFuncion.TabIndex = 1;
            this.lbFuncion.Text = "Función";
            // 
            // nupDimension
            // 
            this.nupDimension.Location = new System.Drawing.Point(230, 81);
            this.nupDimension.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupDimension.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDimension.Name = "nupDimension";
            this.nupDimension.Size = new System.Drawing.Size(120, 30);
            this.nupDimension.TabIndex = 2;
            this.nupDimension.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbDimension
            // 
            this.lbDimension.AutoSize = true;
            this.lbDimension.Location = new System.Drawing.Point(101, 83);
            this.lbDimension.Name = "lbDimension";
            this.lbDimension.Size = new System.Drawing.Size(104, 25);
            this.lbDimension.TabIndex = 3;
            this.lbDimension.Text = "Dimensión";
            // 
            // lbIteraciones
            // 
            this.lbIteraciones.AutoSize = true;
            this.lbIteraciones.Location = new System.Drawing.Point(101, 130);
            this.lbIteraciones.Name = "lbIteraciones";
            this.lbIteraciones.Size = new System.Drawing.Size(107, 25);
            this.lbIteraciones.TabIndex = 5;
            this.lbIteraciones.Text = "Iteraciones";
            // 
            // nupIteraciones
            // 
            this.nupIteraciones.Location = new System.Drawing.Point(230, 128);
            this.nupIteraciones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupIteraciones.Name = "nupIteraciones";
            this.nupIteraciones.Size = new System.Drawing.Size(120, 30);
            this.nupIteraciones.TabIndex = 4;
            this.nupIteraciones.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lbPbMutacion
            // 
            this.lbPbMutacion.AutoSize = true;
            this.lbPbMutacion.Location = new System.Drawing.Point(640, 121);
            this.lbPbMutacion.Name = "lbPbMutacion";
            this.lbPbMutacion.Size = new System.Drawing.Size(143, 25);
            this.lbPbMutacion.TabIndex = 9;
            this.lbPbMutacion.Text = "Prob. Mutación";
            // 
            // nupProbMutacion
            // 
            this.nupProbMutacion.DecimalPlaces = 4;
            this.nupProbMutacion.Location = new System.Drawing.Point(796, 119);
            this.nupProbMutacion.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupProbMutacion.Name = "nupProbMutacion";
            this.nupProbMutacion.Size = new System.Drawing.Size(120, 30);
            this.nupProbMutacion.TabIndex = 8;
            this.nupProbMutacion.Value = new decimal(new int[] {
            8,
            0,
            0,
            196608});
            // 
            // lbPbCruz
            // 
            this.lbPbCruz.AutoSize = true;
            this.lbPbCruz.Location = new System.Drawing.Point(609, 36);
            this.lbPbCruz.Name = "lbPbCruz";
            this.lbPbCruz.Size = new System.Drawing.Size(174, 25);
            this.lbPbCruz.TabIndex = 7;
            this.lbPbCruz.Text = "Prob. Cruzamiento";
            // 
            // nupProbCruzamiento
            // 
            this.nupProbCruzamiento.DecimalPlaces = 4;
            this.nupProbCruzamiento.Location = new System.Drawing.Point(796, 34);
            this.nupProbCruzamiento.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupProbCruzamiento.Name = "nupProbCruzamiento";
            this.nupProbCruzamiento.Size = new System.Drawing.Size(120, 30);
            this.nupProbCruzamiento.TabIndex = 6;
            this.nupProbCruzamiento.Value = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Versión";
            // 
            // cmbVersion
            // 
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Items.AddRange(new object[] {
            "Estacionario",
            "Generacional"});
            this.cmbVersion.Location = new System.Drawing.Point(230, 217);
            this.cmbVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(226, 33);
            this.cmbVersion.TabIndex = 10;
            // 
            // lbMetCruzamiento
            // 
            this.lbMetCruzamiento.AutoSize = true;
            this.lbMetCruzamiento.Location = new System.Drawing.Point(588, 83);
            this.lbMetCruzamiento.Name = "lbMetCruzamiento";
            this.lbMetCruzamiento.Size = new System.Drawing.Size(194, 25);
            this.lbMetCruzamiento.TabIndex = 12;
            this.lbMetCruzamiento.Text = "Método Cruzamiento";
            // 
            // cmbMetSeleccion
            // 
            this.cmbMetSeleccion.FormattingEnabled = true;
            this.cmbMetSeleccion.Items.AddRange(new object[] {
            "Proporcional",
            "NPM",
            "Torneo"});
            this.cmbMetSeleccion.Location = new System.Drawing.Point(795, 214);
            this.cmbMetSeleccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetSeleccion.Name = "cmbMetSeleccion";
            this.cmbMetSeleccion.Size = new System.Drawing.Size(226, 33);
            this.cmbMetSeleccion.TabIndex = 13;
            // 
            // cmbMetCruzamiento
            // 
            this.cmbMetCruzamiento.FormattingEnabled = true;
            this.cmbMetCruzamiento.Items.AddRange(new object[] {
            "Aritmético",
            "Plano"});
            this.cmbMetCruzamiento.Location = new System.Drawing.Point(795, 75);
            this.cmbMetCruzamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetCruzamiento.Name = "cmbMetCruzamiento";
            this.cmbMetCruzamiento.Size = new System.Drawing.Size(226, 33);
            this.cmbMetCruzamiento.TabIndex = 15;
            // 
            // lbMetSeleccion
            // 
            this.lbMetSeleccion.AutoSize = true;
            this.lbMetSeleccion.Location = new System.Drawing.Point(613, 214);
            this.lbMetSeleccion.Name = "lbMetSeleccion";
            this.lbMetSeleccion.Size = new System.Drawing.Size(169, 25);
            this.lbMetSeleccion.TabIndex = 14;
            this.lbMetSeleccion.Text = "Método Selección";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Purple;
            this.btnCalcular.Location = new System.Drawing.Point(645, 256);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(164, 42);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbMetReemplazo
            // 
            this.cmbMetReemplazo.FormattingEnabled = true;
            this.cmbMetReemplazo.Items.AddRange(new object[] {
            "Fitness",
            "Aleatorio"});
            this.cmbMetReemplazo.Location = new System.Drawing.Point(230, 267);
            this.cmbMetReemplazo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetReemplazo.Name = "cmbMetReemplazo";
            this.cmbMetReemplazo.Size = new System.Drawing.Size(226, 33);
            this.cmbMetReemplazo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Método Reemplazo";
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(32, 316);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(989, 210);
            this.rtbResultado.TabIndex = 19;
            this.rtbResultado.Text = "";
            // 
            // dataGridResultados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionGrid,
            this.MejorGrid,
            this.PeorGrid,
            this.PromedioGrid,
            this.MedianaGrid,
            this.DesviacionGrid});
            this.dataGridResultados.Location = new System.Drawing.Point(1066, 12);
            this.dataGridResultados.Name = "dataGridResultados";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridResultados.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridResultados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridResultados.RowTemplate.Height = 28;
            this.dataGridResultados.Size = new System.Drawing.Size(964, 285);
            this.dataGridResultados.TabIndex = 20;
            // 
            // FuncionGrid
            // 
            this.FuncionGrid.HeaderText = "Funcion";
            this.FuncionGrid.MinimumWidth = 8;
            this.FuncionGrid.Name = "FuncionGrid";
            this.FuncionGrid.Width = 150;
            // 
            // MejorGrid
            // 
            this.MejorGrid.HeaderText = "Mejor";
            this.MejorGrid.MinimumWidth = 8;
            this.MejorGrid.Name = "MejorGrid";
            this.MejorGrid.Width = 150;
            // 
            // PeorGrid
            // 
            this.PeorGrid.HeaderText = "Peor";
            this.PeorGrid.MinimumWidth = 8;
            this.PeorGrid.Name = "PeorGrid";
            this.PeorGrid.Width = 150;
            // 
            // PromedioGrid
            // 
            this.PromedioGrid.HeaderText = "Promedio";
            this.PromedioGrid.MinimumWidth = 8;
            this.PromedioGrid.Name = "PromedioGrid";
            this.PromedioGrid.Width = 150;
            // 
            // MedianaGrid
            // 
            this.MedianaGrid.HeaderText = "Mediana";
            this.MedianaGrid.MinimumWidth = 8;
            this.MedianaGrid.Name = "MedianaGrid";
            this.MedianaGrid.Width = 150;
            // 
            // DesviacionGrid
            // 
            this.DesviacionGrid.HeaderText = "Desviación";
            this.DesviacionGrid.MinimumWidth = 8;
            this.DesviacionGrid.Name = "DesviacionGrid";
            this.DesviacionGrid.Width = 150;
            // 
            // dataGridTiempo
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridTiempo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridTiempo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTiempo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionGridTiempo,
            this.MejorGridTiempo,
            this.PeorGridTiempo,
            this.PromedioGridTiempo,
            this.MedianaGridTiempo,
            this.DesviacionGridTiempo});
            this.dataGridTiempo.Location = new System.Drawing.Point(1066, 316);
            this.dataGridTiempo.Name = "dataGridTiempo";
            this.dataGridTiempo.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dataGridTiempo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTiempo.RowTemplate.Height = 28;
            this.dataGridTiempo.Size = new System.Drawing.Size(964, 226);
            this.dataGridTiempo.TabIndex = 21;
            // 
            // FuncionGridTiempo
            // 
            this.FuncionGridTiempo.HeaderText = "Funcion";
            this.FuncionGridTiempo.MinimumWidth = 8;
            this.FuncionGridTiempo.Name = "FuncionGridTiempo";
            this.FuncionGridTiempo.Width = 150;
            // 
            // MejorGridTiempo
            // 
            this.MejorGridTiempo.HeaderText = "Mejor";
            this.MejorGridTiempo.MinimumWidth = 8;
            this.MejorGridTiempo.Name = "MejorGridTiempo";
            this.MejorGridTiempo.Width = 150;
            // 
            // PeorGridTiempo
            // 
            this.PeorGridTiempo.HeaderText = "Peor";
            this.PeorGridTiempo.MinimumWidth = 8;
            this.PeorGridTiempo.Name = "PeorGridTiempo";
            this.PeorGridTiempo.Width = 150;
            // 
            // PromedioGridTiempo
            // 
            this.PromedioGridTiempo.HeaderText = "Promedio";
            this.PromedioGridTiempo.MinimumWidth = 8;
            this.PromedioGridTiempo.Name = "PromedioGridTiempo";
            this.PromedioGridTiempo.Width = 150;
            // 
            // MedianaGridTiempo
            // 
            this.MedianaGridTiempo.HeaderText = "Mediana";
            this.MedianaGridTiempo.MinimumWidth = 8;
            this.MedianaGridTiempo.Name = "MedianaGridTiempo";
            this.MedianaGridTiempo.Width = 150;
            // 
            // DesviacionGridTiempo
            // 
            this.DesviacionGridTiempo.HeaderText = "Desviacion";
            this.DesviacionGridTiempo.MinimumWidth = 8;
            this.DesviacionGridTiempo.Name = "DesviacionGridTiempo";
            this.DesviacionGridTiempo.Width = 150;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1837, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEvaluaciones
            // 
            this.lbEvaluaciones.AutoSize = true;
            this.lbEvaluaciones.Location = new System.Drawing.Point(79, 174);
            this.lbEvaluaciones.Name = "lbEvaluaciones";
            this.lbEvaluaciones.Size = new System.Drawing.Size(129, 25);
            this.lbEvaluaciones.TabIndex = 24;
            this.lbEvaluaciones.Text = "Evaluaciones";
            // 
            // nupEvaluaciones
            // 
            this.nupEvaluaciones.Location = new System.Drawing.Point(230, 172);
            this.nupEvaluaciones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupEvaluaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupEvaluaciones.Name = "nupEvaluaciones";
            this.nupEvaluaciones.Size = new System.Drawing.Size(120, 30);
            this.nupEvaluaciones.TabIndex = 23;
            this.nupEvaluaciones.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // cmbMetMutacion
            // 
            this.cmbMetMutacion.FormattingEnabled = true;
            this.cmbMetMutacion.Items.AddRange(new object[] {
            "Optimo",
            "Aleatorio"});
            this.cmbMetMutacion.Location = new System.Drawing.Point(795, 166);
            this.cmbMetMutacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetMutacion.Name = "cmbMetMutacion";
            this.cmbMetMutacion.Size = new System.Drawing.Size(226, 33);
            this.cmbMetMutacion.TabIndex = 26;
            // 
            // lbMetMutacion
            // 
            this.lbMetMutacion.AutoSize = true;
            this.lbMetMutacion.Location = new System.Drawing.Point(619, 169);
            this.lbMetMutacion.Name = "lbMetMutacion";
            this.lbMetMutacion.Size = new System.Drawing.Size(163, 25);
            this.lbMetMutacion.TabIndex = 25;
            this.lbMetMutacion.Text = "Método Mutación";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Purple;
            this.btnDelete.Location = new System.Drawing.Point(833, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 42);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(2059, 680);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbMetMutacion);
            this.Controls.Add(this.lbMetMutacion);
            this.Controls.Add(this.lbEvaluaciones);
            this.Controls.Add(this.nupEvaluaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridTiempo);
            this.Controls.Add(this.dataGridResultados);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.cmbMetReemplazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbMetCruzamiento);
            this.Controls.Add(this.lbMetSeleccion);
            this.Controls.Add(this.cmbMetSeleccion);
            this.Controls.Add(this.lbMetCruzamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVersion);
            this.Controls.Add(this.lbPbMutacion);
            this.Controls.Add(this.nupProbMutacion);
            this.Controls.Add(this.lbPbCruz);
            this.Controls.Add(this.nupProbCruzamiento);
            this.Controls.Add(this.lbIteraciones);
            this.Controls.Add(this.nupIteraciones);
            this.Controls.Add(this.lbDimension);
            this.Controls.Add(this.nupDimension);
            this.Controls.Add(this.lbFuncion);
            this.Controls.Add(this.cmbFuncion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solucion de problemas mediante GA";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProbMutacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProbCruzamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEvaluaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Label lbFuncion;
        private System.Windows.Forms.NumericUpDown nupDimension;
        private System.Windows.Forms.Label lbDimension;
        private System.Windows.Forms.Label lbIteraciones;
        private System.Windows.Forms.NumericUpDown nupIteraciones;
        private System.Windows.Forms.Label lbPbMutacion;
        private System.Windows.Forms.NumericUpDown nupProbMutacion;
        private System.Windows.Forms.Label lbPbCruz;
        private System.Windows.Forms.NumericUpDown nupProbCruzamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.Label lbMetCruzamiento;
        private System.Windows.Forms.ComboBox cmbMetSeleccion;
        private System.Windows.Forms.ComboBox cmbMetCruzamiento;
        private System.Windows.Forms.Label lbMetSeleccion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbMetReemplazo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.DataGridView dataGridResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MejorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedianaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesviacionGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionGridTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MejorGridTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeorGridTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioGridTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedianaGridTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesviacionGridTiempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbEvaluaciones;
        private System.Windows.Forms.NumericUpDown nupEvaluaciones;
        private System.Windows.Forms.ComboBox cmbMetMutacion;
        private System.Windows.Forms.Label lbMetMutacion;
        private System.Windows.Forms.Button btnDelete;
    }
}

