﻿namespace SimuladorDeInsumos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboGrafico = new System.Windows.Forms.ComboBox();
            this.comboMProd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.graficoAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pageSimulador = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlValores = new System.Windows.Forms.Panel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabSimulador.SuspendLayout();
            this.pageAnalizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAG)).BeginInit();
            this.pageSimulador.SuspendLayout();
            this.pnlValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(4, 3);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(248, 25);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(257, 9);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(46, 13);
            this.lblArchivo.TabIndex = 2;
            this.lblArchivo.Text = "Archivo:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(305, 6);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPath.Size = new System.Drawing.Size(210, 20);
            this.txtPath.TabIndex = 3;
            // 
            // pbarHojas
            // 
            this.pbarHojas.Location = new System.Drawing.Point(51, 34);
            this.pbarHojas.Name = "pbarHojas";
            this.pbarHojas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbarHojas.Size = new System.Drawing.Size(115, 17);
            this.pbarHojas.Step = 25;
            this.pbarHojas.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarHojas.TabIndex = 6;
            // 
            // cboxTablasMP
            // 
            this.cboxTablasMP.AutoSize = true;
            this.cboxTablasMP.Enabled = false;
            this.cboxTablasMP.Location = new System.Drawing.Point(172, 34);
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
            this.cboxTablasMT.Location = new System.Drawing.Point(347, 34);
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
            this.cboxTablasS.Location = new System.Drawing.Point(267, 34);
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
            this.cboxTablasH.Location = new System.Drawing.Point(442, 33);
            this.cboxTablasH.Name = "cboxTablasH";
            this.cboxTablasH.Size = new System.Drawing.Size(73, 17);
            this.cboxTablasH.TabIndex = 10;
            this.cboxTablasH.Text = "Historial T";
            this.cboxTablasH.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tablas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filas:";
            // 
            // pbarFilas
            // 
            this.pbarFilas.Location = new System.Drawing.Point(51, 57);
            this.pbarFilas.Name = "pbarFilas";
            this.pbarFilas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbarFilas.Size = new System.Drawing.Size(115, 17);
            this.pbarFilas.Step = 25;
            this.pbarFilas.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarFilas.TabIndex = 13;
            // 
            // cboxFilasH
            // 
            this.cboxFilasH.AutoSize = true;
            this.cboxFilasH.Enabled = false;
            this.cboxFilasH.Location = new System.Drawing.Point(442, 55);
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
            this.cboxFilasS.Location = new System.Drawing.Point(267, 56);
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
            this.cboxFilasMT.Location = new System.Drawing.Point(347, 56);
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
            this.cboxFilasMP.Location = new System.Drawing.Point(172, 56);
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
            this.tabSimulador.Location = new System.Drawing.Point(0, 80);
            this.tabSimulador.Name = "tabSimulador";
            this.tabSimulador.SelectedIndex = 0;
            this.tabSimulador.Size = new System.Drawing.Size(784, 482);
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
            this.pageAnalizador.Size = new System.Drawing.Size(776, 456);
            this.pageAnalizador.TabIndex = 0;
            this.pageAnalizador.Text = "Analizador gráfico";
            this.pageAnalizador.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Seleccionar producto a analizar:";
            // 
            // graficoAG
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoAG.ChartAreas.Add(chartArea1);
            this.graficoAG.Cursor = System.Windows.Forms.Cursors.Default;
            this.graficoAG.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.graficoAG.Legends.Add(legend1);
            this.graficoAG.Location = new System.Drawing.Point(3, 46);
            this.graficoAG.Name = "graficoAG";
            this.graficoAG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelToolTip = "#VALX #VAL";
            series1.Legend = "Legend1";
            series1.Name = "Producto";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.graficoAG.Series.Add(series1);
            this.graficoAG.Size = new System.Drawing.Size(770, 407);
            this.graficoAG.TabIndex = 0;
            this.graficoAG.Text = "Analizador Gráfico";
            this.graficoAG.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
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
            // pnlValores
            // 
            this.pnlValores.BackColor = System.Drawing.Color.White;
            this.pnlValores.Controls.Add(this.label9);
            this.pnlValores.Controls.Add(this.label8);
            this.pnlValores.Controls.Add(this.lblMedia);
            this.pnlValores.Controls.Add(this.lblMinimo);
            this.pnlValores.Controls.Add(this.lblMaximo);
            this.pnlValores.Controls.Add(this.lblProducto);
            this.pnlValores.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlValores.Location = new System.Drawing.Point(523, 0);
            this.pnlValores.Name = "pnlValores";
            this.pnlValores.Size = new System.Drawing.Size(261, 80);
            this.pnlValores.TabIndex = 20;
            this.pnlValores.Visible = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(3, 5);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(104, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Nombre producto";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(3, 18);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(49, 13);
            this.lblMaximo.TabIndex = 1;
            this.lblMaximo.Text = "Máximo: ";
            this.lblMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(3, 31);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(48, 13);
            this.lblMinimo.TabIndex = 2;
            this.lblMinimo.Text = "Mínimo: ";
            this.lblMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(3, 44);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(39, 13);
            this.lblMedia.TabIndex = 3;
            this.lblMedia.Text = "Media:";
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Desvio: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Varianza: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlValores);
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
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de insumos";
            this.tabSimulador.ResumeLayout(false);
            this.pageAnalizador.ResumeLayout(false);
            this.pageAnalizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoAG)).EndInit();
            this.pageSimulador.ResumeLayout(false);
            this.pageSimulador.PerformLayout();
            this.pnlValores.ResumeLayout(false);
            this.pnlValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Panel pnlValores;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMedia;
    }
}

