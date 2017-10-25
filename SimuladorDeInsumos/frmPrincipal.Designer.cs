namespace SimuladorDeInsumos
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pbarHojas = new System.Windows.Forms.ProgressBar();
            this.cboxTablasMP = new System.Windows.Forms.CheckBox();
            this.cboxTablasMT = new System.Windows.Forms.CheckBox();
            this.cboxTablasS = new System.Windows.Forms.CheckBox();
            this.cboxTablasH = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbarFilas = new System.Windows.Forms.ProgressBar();
            this.cboxFilasH = new System.Windows.Forms.CheckBox();
            this.cboxFilasS = new System.Windows.Forms.CheckBox();
            this.cboxFilasMT = new System.Windows.Forms.CheckBox();
            this.cboxFilasMP = new System.Windows.Forms.CheckBox();
            this.lblFilas = new System.Windows.Forms.Label();
            this.tabSimulador = new System.Windows.Forms.TabControl();
            this.pageAnalizador = new System.Windows.Forms.TabPage();
            this.pageSimulador = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.graficoAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.comboMProd = new System.Windows.Forms.ComboBox();
            this.comboGrafico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSimulador.SuspendLayout();
            this.pageAnalizador.SuspendLayout();
            this.pageSimulador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myriad Hebrew", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(209, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(387, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Simulador de Insumos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(430, 56);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(343, 25);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(3, 62);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(46, 13);
            this.lblArchivo.TabIndex = 2;
            this.lblArchivo.Text = "Archivo:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(51, 59);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(373, 20);
            this.txtPath.TabIndex = 3;
            // 
            // pbarHojas
            // 
            this.pbarHojas.Location = new System.Drawing.Point(51, 85);
            this.pbarHojas.Name = "pbarHojas";
            this.pbarHojas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbarHojas.Size = new System.Drawing.Size(373, 17);
            this.pbarHojas.Step = 25;
            this.pbarHojas.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarHojas.TabIndex = 6;
            // 
            // cboxTablasMP
            // 
            this.cboxTablasMP.AutoSize = true;
            this.cboxTablasMP.Enabled = false;
            this.cboxTablasMP.Location = new System.Drawing.Point(430, 86);
            this.cboxTablasMP.Name = "cboxTablasMP";
            this.cboxTablasMP.Size = new System.Drawing.Size(89, 17);
            this.cboxTablasMP.TabIndex = 7;
            this.cboxTablasMP.Text = "Maestro Prod";
            this.cboxTablasMP.UseVisualStyleBackColor = true;
            // 
            // cboxTablasMT
            // 
            this.cboxTablasMT.AutoSize = true;
            this.cboxTablasMT.Enabled = false;
            this.cboxTablasMT.Location = new System.Drawing.Point(605, 86);
            this.cboxTablasMT.Name = "cboxTablasMT";
            this.cboxTablasMT.Size = new System.Drawing.Size(89, 17);
            this.cboxTablasMT.TabIndex = 8;
            this.cboxTablasMT.Text = "Maestro Tran";
            this.cboxTablasMT.UseVisualStyleBackColor = true;
            // 
            // cboxTablasS
            // 
            this.cboxTablasS.AutoSize = true;
            this.cboxTablasS.Enabled = false;
            this.cboxTablasS.Location = new System.Drawing.Point(525, 86);
            this.cboxTablasS.Name = "cboxTablasS";
            this.cboxTablasS.Size = new System.Drawing.Size(74, 17);
            this.cboxTablasS.TabIndex = 9;
            this.cboxTablasS.Text = "Stock Ref";
            this.cboxTablasS.UseVisualStyleBackColor = true;
            // 
            // cboxTablasH
            // 
            this.cboxTablasH.AutoSize = true;
            this.cboxTablasH.Enabled = false;
            this.cboxTablasH.Location = new System.Drawing.Point(700, 85);
            this.cboxTablasH.Name = "cboxTablasH";
            this.cboxTablasH.Size = new System.Drawing.Size(73, 17);
            this.cboxTablasH.TabIndex = 10;
            this.cboxTablasH.Text = "Historial T";
            this.cboxTablasH.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tablas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filas:";
            // 
            // pbarFilas
            // 
            this.pbarFilas.Location = new System.Drawing.Point(51, 108);
            this.pbarFilas.Name = "pbarFilas";
            this.pbarFilas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbarFilas.Size = new System.Drawing.Size(373, 17);
            this.pbarFilas.Step = 25;
            this.pbarFilas.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarFilas.TabIndex = 13;
            // 
            // cboxFilasH
            // 
            this.cboxFilasH.AutoSize = true;
            this.cboxFilasH.Enabled = false;
            this.cboxFilasH.Location = new System.Drawing.Point(700, 107);
            this.cboxFilasH.Name = "cboxFilasH";
            this.cboxFilasH.Size = new System.Drawing.Size(73, 17);
            this.cboxFilasH.TabIndex = 17;
            this.cboxFilasH.Text = "Historial T";
            this.cboxFilasH.UseVisualStyleBackColor = true;
            // 
            // cboxFilasS
            // 
            this.cboxFilasS.AutoSize = true;
            this.cboxFilasS.Enabled = false;
            this.cboxFilasS.Location = new System.Drawing.Point(525, 108);
            this.cboxFilasS.Name = "cboxFilasS";
            this.cboxFilasS.Size = new System.Drawing.Size(74, 17);
            this.cboxFilasS.TabIndex = 16;
            this.cboxFilasS.Text = "Stock Ref";
            this.cboxFilasS.UseVisualStyleBackColor = true;
            // 
            // cboxFilasMT
            // 
            this.cboxFilasMT.AutoSize = true;
            this.cboxFilasMT.Enabled = false;
            this.cboxFilasMT.Location = new System.Drawing.Point(605, 108);
            this.cboxFilasMT.Name = "cboxFilasMT";
            this.cboxFilasMT.Size = new System.Drawing.Size(89, 17);
            this.cboxFilasMT.TabIndex = 15;
            this.cboxFilasMT.Text = "Maestro Tran";
            this.cboxFilasMT.UseVisualStyleBackColor = true;
            // 
            // cboxFilasMP
            // 
            this.cboxFilasMP.AutoSize = true;
            this.cboxFilasMP.Enabled = false;
            this.cboxFilasMP.Location = new System.Drawing.Point(430, 108);
            this.cboxFilasMP.Name = "cboxFilasMP";
            this.cboxFilasMP.Size = new System.Drawing.Size(89, 17);
            this.cboxFilasMP.TabIndex = 14;
            this.cboxFilasMP.Text = "Maestro Prod";
            this.cboxFilasMP.UseVisualStyleBackColor = true;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(3, 133);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(0, 13);
            this.lblFilas.TabIndex = 18;
            // 
            // tabSimulador
            // 
            this.tabSimulador.Controls.Add(this.pageAnalizador);
            this.tabSimulador.Controls.Add(this.pageSimulador);
            this.tabSimulador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabSimulador.Enabled = false;
            this.tabSimulador.Location = new System.Drawing.Point(0, 149);
            this.tabSimulador.Name = "tabSimulador";
            this.tabSimulador.SelectedIndex = 0;
            this.tabSimulador.Size = new System.Drawing.Size(784, 413);
            this.tabSimulador.TabIndex = 19;
            // 
            // pageAnalizador
            // 
            this.pageAnalizador.Controls.Add(this.label5);
            this.pageAnalizador.Controls.Add(this.comboGrafico);
            this.pageAnalizador.Controls.Add(this.comboMProd);
            this.pageAnalizador.Controls.Add(this.label4);
            this.pageAnalizador.Controls.Add(this.graficoAG);
            this.pageAnalizador.Location = new System.Drawing.Point(4, 22);
            this.pageAnalizador.Name = "pageAnalizador";
            this.pageAnalizador.Padding = new System.Windows.Forms.Padding(3);
            this.pageAnalizador.Size = new System.Drawing.Size(776, 387);
            this.pageAnalizador.TabIndex = 0;
            this.pageAnalizador.Text = "Analizador gráfico";
            this.pageAnalizador.UseVisualStyleBackColor = true;
            // 
            // pageSimulador
            // 
            this.pageSimulador.Controls.Add(this.label3);
            this.pageSimulador.Location = new System.Drawing.Point(4, 22);
            this.pageSimulador.Name = "pageSimulador";
            this.pageSimulador.Padding = new System.Windows.Forms.Padding(3);
            this.pageSimulador.Size = new System.Drawing.Size(776, 387);
            this.pageSimulador.TabIndex = 1;
            this.pageSimulador.Text = "Simulador de Insumos";
            this.pageSimulador.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "En estos momenos este sector no está disponible. Gracias :)";
            // 
            // graficoAG
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoAG.ChartAreas.Add(chartArea2);
            this.graficoAG.Cursor = System.Windows.Forms.Cursors.Default;
            this.graficoAG.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.graficoAG.Legends.Add(legend2);
            this.graficoAG.Location = new System.Drawing.Point(3, 46);
            this.graficoAG.Name = "graficoAG";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.LabelToolTip = "#VALX #VAL";
            series2.Legend = "Legend1";
            series2.Name = "Producto";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.graficoAG.Series.Add(series2);
            this.graficoAG.Size = new System.Drawing.Size(770, 338);
            this.graficoAG.TabIndex = 0;
            this.graficoAG.Text = "Analizador Gráfico";
            this.graficoAG.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Seleccionar producto a analizar:";
            // 
            // comboMProd
            // 
            this.comboMProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMProd.FormattingEnabled = true;
            this.comboMProd.Location = new System.Drawing.Point(8, 19);
            this.comboMProd.Name = "comboMProd";
            this.comboMProd.Size = new System.Drawing.Size(412, 21);
            this.comboMProd.TabIndex = 2;
            this.comboMProd.SelectedIndexChanged += new System.EventHandler(this.comboMProd_SelectedIndexChanged);
            // 
            // comboGrafico
            // 
            this.comboGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrafico.FormattingEnabled = true;
            this.comboGrafico.Items.AddRange(new object[] {
            "Entradas",
            "Salidas",
            "Variación de Stock"});
            this.comboGrafico.Location = new System.Drawing.Point(601, 19);
            this.comboGrafico.Name = "comboGrafico";
            this.comboGrafico.Size = new System.Drawing.Size(154, 21);
            this.comboGrafico.TabIndex = 3;
            this.comboGrafico.SelectedIndexChanged += new System.EventHandler(this.comboGrafico_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seleccionar tipo de gráfico:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabSimulador);
            this.Controls.Add(this.lblFilas);
            this.Controls.Add(this.cboxFilasH);
            this.Controls.Add(this.cboxFilasS);
            this.Controls.Add(this.cboxFilasMT);
            this.Controls.Add(this.cboxFilasMP);
            this.Controls.Add(this.pbarFilas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxTablasH);
            this.Controls.Add(this.cboxTablasS);
            this.Controls.Add(this.cboxTablasMT);
            this.Controls.Add(this.cboxTablasMP);
            this.Controls.Add(this.pbarHojas);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de insumos";
            this.tabSimulador.ResumeLayout(false);
            this.pageAnalizador.ResumeLayout(false);
            this.pageAnalizador.PerformLayout();
            this.pageSimulador.ResumeLayout(false);
            this.pageSimulador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox cboxTablasMP;
        private System.Windows.Forms.CheckBox cboxTablasMT;
        private System.Windows.Forms.CheckBox cboxTablasS;
        private System.Windows.Forms.CheckBox cboxTablasH;
        public System.Windows.Forms.ProgressBar pbarHojas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar pbarFilas;
        private System.Windows.Forms.CheckBox cboxFilasH;
        private System.Windows.Forms.CheckBox cboxFilasS;
        private System.Windows.Forms.CheckBox cboxFilasMT;
        private System.Windows.Forms.CheckBox cboxFilasMP;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.TabControl tabSimulador;
        private System.Windows.Forms.TabPage pageAnalizador;
        private System.Windows.Forms.TabPage pageSimulador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoAG;
        private System.Windows.Forms.ComboBox comboMProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboGrafico;
    }
}

