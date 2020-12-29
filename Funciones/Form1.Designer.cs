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
            ((System.ComponentModel.ISupportInitialize)(this.nupDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProbMutacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProbCruzamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Items.AddRange(new object[] {
            "Función 1 -",
            "Función 2 -",
            "Función 3 -",
            "Función 4 -",
            "Función 5 -",
            "Función 6 -"});
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
            this.nupDimension.Location = new System.Drawing.Point(230, 88);
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
            this.lbDimension.Location = new System.Drawing.Point(101, 90);
            this.lbDimension.Name = "lbDimension";
            this.lbDimension.Size = new System.Drawing.Size(104, 25);
            this.lbDimension.TabIndex = 3;
            this.lbDimension.Text = "Dimension";
            // 
            // lbIteraciones
            // 
            this.lbIteraciones.AutoSize = true;
            this.lbIteraciones.Location = new System.Drawing.Point(101, 144);
            this.lbIteraciones.Name = "lbIteraciones";
            this.lbIteraciones.Size = new System.Drawing.Size(107, 25);
            this.lbIteraciones.TabIndex = 5;
            this.lbIteraciones.Text = "Iteraciones";
            // 
            // nupIteraciones
            // 
            this.nupIteraciones.Location = new System.Drawing.Point(230, 142);
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
            this.lbPbMutacion.Location = new System.Drawing.Point(639, 157);
            this.lbPbMutacion.Name = "lbPbMutacion";
            this.lbPbMutacion.Size = new System.Drawing.Size(143, 25);
            this.lbPbMutacion.TabIndex = 9;
            this.lbPbMutacion.Text = "Prob. Mutación";
            // 
            // nupProbMutacion
            // 
            this.nupProbMutacion.DecimalPlaces = 4;
            this.nupProbMutacion.Location = new System.Drawing.Point(795, 155);
            this.nupProbMutacion.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupProbMutacion.Name = "nupProbMutacion";
            this.nupProbMutacion.Size = new System.Drawing.Size(120, 30);
            this.nupProbMutacion.TabIndex = 8;
            this.nupProbMutacion.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // lbPbCruz
            // 
            this.lbPbCruz.AutoSize = true;
            this.lbPbCruz.Location = new System.Drawing.Point(608, 49);
            this.lbPbCruz.Name = "lbPbCruz";
            this.lbPbCruz.Size = new System.Drawing.Size(174, 25);
            this.lbPbCruz.TabIndex = 7;
            this.lbPbCruz.Text = "Prob. Cruzamiento";
            // 
            // nupProbCruzamiento
            // 
            this.nupProbCruzamiento.DecimalPlaces = 4;
            this.nupProbCruzamiento.Location = new System.Drawing.Point(795, 47);
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
            this.label1.Location = new System.Drawing.Point(126, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Version";
            // 
            // cmbVersion
            // 
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Items.AddRange(new object[] {
            "Estacionario",
            "Generacional"});
            this.cmbVersion.Location = new System.Drawing.Point(230, 193);
            this.cmbVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(226, 33);
            this.cmbVersion.TabIndex = 10;
            // 
            // lbMetCruzamiento
            // 
            this.lbMetCruzamiento.AutoSize = true;
            this.lbMetCruzamiento.Location = new System.Drawing.Point(588, 215);
            this.lbMetCruzamiento.Name = "lbMetCruzamiento";
            this.lbMetCruzamiento.Size = new System.Drawing.Size(194, 25);
            this.lbMetCruzamiento.TabIndex = 12;
            this.lbMetCruzamiento.Text = "Metodo Cruzamiento";
            // 
            // cmbMetSeleccion
            // 
            this.cmbMetSeleccion.FormattingEnabled = true;
            this.cmbMetSeleccion.Items.AddRange(new object[] {
            "Proporcional",
            "NPM",
            "Torneo"});
            this.cmbMetSeleccion.Location = new System.Drawing.Point(795, 100);
            this.cmbMetSeleccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetSeleccion.Name = "cmbMetSeleccion";
            this.cmbMetSeleccion.Size = new System.Drawing.Size(226, 33);
            this.cmbMetSeleccion.TabIndex = 13;
            // 
            // cmbMetCruzamiento
            // 
            this.cmbMetCruzamiento.FormattingEnabled = true;
            this.cmbMetCruzamiento.Items.AddRange(new object[] {
            "Arimetico",
            "Plano"});
            this.cmbMetCruzamiento.Location = new System.Drawing.Point(795, 207);
            this.cmbMetCruzamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetCruzamiento.Name = "cmbMetCruzamiento";
            this.cmbMetCruzamiento.Size = new System.Drawing.Size(226, 33);
            this.cmbMetCruzamiento.TabIndex = 15;
            // 
            // lbMetSeleccion
            // 
            this.lbMetSeleccion.AutoSize = true;
            this.lbMetSeleccion.Location = new System.Drawing.Point(613, 100);
            this.lbMetSeleccion.Name = "lbMetSeleccion";
            this.lbMetSeleccion.Size = new System.Drawing.Size(169, 25);
            this.lbMetSeleccion.TabIndex = 14;
            this.lbMetSeleccion.Text = "Metodo Selección";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Purple;
            this.btnCalcular.Location = new System.Drawing.Point(857, 255);
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
            this.cmbMetReemplazo.Location = new System.Drawing.Point(230, 247);
            this.cmbMetReemplazo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetReemplazo.Name = "cmbMetReemplazo";
            this.cmbMetReemplazo.Size = new System.Drawing.Size(226, 33);
            this.cmbMetReemplazo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Metodo Reemplazo";
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(32, 316);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(989, 210);
            this.rtbResultado.TabIndex = 19;
            this.rtbResultado.Text = "";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1070, 538);
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
    }
}

