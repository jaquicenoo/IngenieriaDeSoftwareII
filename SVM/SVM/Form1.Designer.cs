namespace SVM
{
    partial class Form1
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
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.labelRutaArchivo = new System.Windows.Forms.Label();
            this.labelAtributos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.checkBoxDatosFaltantes = new System.Windows.Forms.CheckBox();
            this.buttonSVM = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatosOriginales = new System.Windows.Forms.TabPage();
            this.tabDatosFaltantes = new System.Windows.Forms.TabPage();
            this.tabPageResultadosFaltantes = new System.Windows.Forms.TabPage();
            this.checkedListBoxVariableRellenar = new System.Windows.Forms.CheckedListBox();
            this.labelVariableRellenar = new System.Windows.Forms.Label();
            this.ntb_c = new System.Windows.Forms.NumericUpDown();
            this.ntb_gamma = new System.Windows.Forms.NumericUpDown();
            this.ntb_elipson = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDatosOriginales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_gamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_elipson)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRutaArchivo
            // 
            this.textBoxRutaArchivo.Location = new System.Drawing.Point(81, 20);
            this.textBoxRutaArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRutaArchivo.Name = "textBoxRutaArchivo";
            this.textBoxRutaArchivo.ReadOnly = true;
            this.textBoxRutaArchivo.Size = new System.Drawing.Size(339, 20);
            this.textBoxRutaArchivo.TabIndex = 0;
            // 
            // labelRutaArchivo
            // 
            this.labelRutaArchivo.AutoSize = true;
            this.labelRutaArchivo.Location = new System.Drawing.Point(8, 22);
            this.labelRutaArchivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRutaArchivo.Name = "labelRutaArchivo";
            this.labelRutaArchivo.Size = new System.Drawing.Size(72, 13);
            this.labelRutaArchivo.TabIndex = 1;
            this.labelRutaArchivo.Text = "Ruta Archivo:";
            // 
            // labelAtributos
            // 
            this.labelAtributos.AutoSize = true;
            this.labelAtributos.Location = new System.Drawing.Point(8, 45);
            this.labelAtributos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAtributos.Name = "labelAtributos";
            this.labelAtributos.Size = new System.Drawing.Size(106, 13);
            this.labelAtributos.TabIndex = 2;
            this.labelAtributos.Text = "Atributos Detectados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(749, 177);
            this.dataGridView1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 67);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(238, 64);
            this.checkedListBox1.TabIndex = 4;
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.Location = new System.Drawing.Point(424, 22);
            this.buttonCargarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(25, 18);
            this.buttonCargarArchivo.TabIndex = 5;
            this.buttonCargarArchivo.Text = "...";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // checkBoxDatosFaltantes
            // 
            this.checkBoxDatosFaltantes.AutoSize = true;
            this.checkBoxDatosFaltantes.Location = new System.Drawing.Point(605, 67);
            this.checkBoxDatosFaltantes.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDatosFaltantes.Name = "checkBoxDatosFaltantes";
            this.checkBoxDatosFaltantes.Size = new System.Drawing.Size(163, 17);
            this.checkBoxDatosFaltantes.TabIndex = 6;
            this.checkBoxDatosFaltantes.Text = "Registros con datos faltantes";
            this.checkBoxDatosFaltantes.UseVisualStyleBackColor = true;
            // 
            // buttonSVM
            // 
            this.buttonSVM.Location = new System.Drawing.Point(605, 88);
            this.buttonSVM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSVM.Name = "buttonSVM";
            this.buttonSVM.Size = new System.Drawing.Size(137, 22);
            this.buttonSVM.TabIndex = 7;
            this.buttonSVM.Text = "Estimar Valores Faltantes";
            this.buttonSVM.UseVisualStyleBackColor = true;
            this.buttonSVM.Click += new System.EventHandler(this.buttonSVM_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatosOriginales);
            this.tabControl1.Controls.Add(this.tabDatosFaltantes);
            this.tabControl1.Controls.Add(this.tabPageResultadosFaltantes);
            this.tabControl1.Location = new System.Drawing.Point(8, 142);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 190);
            this.tabControl1.TabIndex = 8;
            // 
            // tabDatosOriginales
            // 
            this.tabDatosOriginales.Controls.Add(this.dataGridView1);
            this.tabDatosOriginales.Location = new System.Drawing.Point(4, 22);
            this.tabDatosOriginales.Margin = new System.Windows.Forms.Padding(2);
            this.tabDatosOriginales.Name = "tabDatosOriginales";
            this.tabDatosOriginales.Padding = new System.Windows.Forms.Padding(2);
            this.tabDatosOriginales.Size = new System.Drawing.Size(752, 164);
            this.tabDatosOriginales.TabIndex = 0;
            this.tabDatosOriginales.Text = "Datos Originales";
            this.tabDatosOriginales.UseVisualStyleBackColor = true;
            // 
            // tabDatosFaltantes
            // 
            this.tabDatosFaltantes.Location = new System.Drawing.Point(4, 22);
            this.tabDatosFaltantes.Margin = new System.Windows.Forms.Padding(2);
            this.tabDatosFaltantes.Name = "tabDatosFaltantes";
            this.tabDatosFaltantes.Padding = new System.Windows.Forms.Padding(2);
            this.tabDatosFaltantes.Size = new System.Drawing.Size(592, 164);
            this.tabDatosFaltantes.TabIndex = 1;
            this.tabDatosFaltantes.Text = "Datos Faltantes";
            this.tabDatosFaltantes.UseVisualStyleBackColor = true;
            // 
            // tabPageResultadosFaltantes
            // 
            this.tabPageResultadosFaltantes.Location = new System.Drawing.Point(4, 22);
            this.tabPageResultadosFaltantes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageResultadosFaltantes.Name = "tabPageResultadosFaltantes";
            this.tabPageResultadosFaltantes.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageResultadosFaltantes.Size = new System.Drawing.Size(592, 164);
            this.tabPageResultadosFaltantes.TabIndex = 2;
            this.tabPageResultadosFaltantes.Text = "Resultados";
            this.tabPageResultadosFaltantes.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxVariableRellenar
            // 
            this.checkedListBoxVariableRellenar.FormattingEnabled = true;
            this.checkedListBoxVariableRellenar.Location = new System.Drawing.Point(291, 68);
            this.checkedListBoxVariableRellenar.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxVariableRellenar.Name = "checkedListBoxVariableRellenar";
            this.checkedListBoxVariableRellenar.Size = new System.Drawing.Size(258, 64);
            this.checkedListBoxVariableRellenar.TabIndex = 10;
            // 
            // labelVariableRellenar
            // 
            this.labelVariableRellenar.AutoSize = true;
            this.labelVariableRellenar.Location = new System.Drawing.Point(288, 45);
            this.labelVariableRellenar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVariableRellenar.Name = "labelVariableRellenar";
            this.labelVariableRellenar.Size = new System.Drawing.Size(108, 13);
            this.labelVariableRellenar.TabIndex = 9;
            this.labelVariableRellenar.Text = "Rellenar Valores para";
            // 
            // ntb_c
            // 
            this.ntb_c.Location = new System.Drawing.Point(493, 19);
            this.ntb_c.Name = "ntb_c";
            this.ntb_c.Size = new System.Drawing.Size(56, 20);
            this.ntb_c.TabIndex = 11;
            this.ntb_c.Value = new decimal(new int[] {
            38,
            0,
            0,
            0});
            // 
            // ntb_gamma
            // 
            this.ntb_gamma.Location = new System.Drawing.Point(605, 18);
            this.ntb_gamma.Name = "ntb_gamma";
            this.ntb_gamma.Size = new System.Drawing.Size(49, 20);
            this.ntb_gamma.TabIndex = 12;
            this.ntb_gamma.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ntb_elipson
            // 
            this.ntb_elipson.Location = new System.Drawing.Point(710, 18);
            this.ntb_elipson.Name = "ntb_elipson";
            this.ntb_elipson.Size = new System.Drawing.Size(48, 20);
            this.ntb_elipson.TabIndex = 13;
            this.ntb_elipson.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gamma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Elipson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ntb_elipson);
            this.Controls.Add(this.ntb_gamma);
            this.Controls.Add(this.ntb_c);
            this.Controls.Add(this.checkedListBoxVariableRellenar);
            this.Controls.Add(this.labelVariableRellenar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSVM);
            this.Controls.Add(this.checkBoxDatosFaltantes);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelAtributos);
            this.Controls.Add(this.labelRutaArchivo);
            this.Controls.Add(this.textBoxRutaArchivo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Completar Valores Faltantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDatosOriginales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ntb_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_gamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_elipson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRutaArchivo;
        private System.Windows.Forms.Label labelRutaArchivo;
        private System.Windows.Forms.Label labelAtributos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.CheckBox checkBoxDatosFaltantes;
        private System.Windows.Forms.Button buttonSVM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatosOriginales;
        private System.Windows.Forms.TabPage tabDatosFaltantes;
        private System.Windows.Forms.TabPage tabPageResultadosFaltantes;
        private System.Windows.Forms.CheckedListBox checkedListBoxVariableRellenar;
        private System.Windows.Forms.Label labelVariableRellenar;
        private System.Windows.Forms.NumericUpDown ntb_c;
        private System.Windows.Forms.NumericUpDown ntb_gamma;
        private System.Windows.Forms.NumericUpDown ntb_elipson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

