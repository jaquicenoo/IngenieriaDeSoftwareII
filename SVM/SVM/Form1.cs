
using CsvHelper;
using libsvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SVM
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        /// <summary>
        /// Dataset que se usara para la predición
        /// </summary>
        public svm_problem DataProblem { get; set; }
        public double C { get; set; }
        public double Gamma { get; set; }
        public double Elipson { get; set; }

        public Form1()
        {
            InitializeComponent();
            // bindigns
            ntb_c.DataBindings.Add("Text", this, "C", true, DataSourceUpdateMode.OnPropertyChanged);
            ntb_gamma.DataBindings.Add("Text", this, "Gamma", true, DataSourceUpdateMode.OnPropertyChanged);
            ntb_elipson.DataBindings.Add("Text", this, "Elipson", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileOpen = new OpenFileDialog();
            FileOpen.Title = "Seleccionar archivo de datos";
            FileOpen.Multiselect = false;
            //FileOpen.Filter = "(*.csv)|*.csv";
            DialogResult Result = FileOpen.ShowDialog();

            if (Result == DialogResult.OK)
            {
                string ruta = FileOpen.FileName;
                using (var reader = new StreamReader(ruta))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.Delimiter = ";";
                    csv.Configuration.HeaderValidated = null;
                    csv.Configuration.MissingFieldFound = null;
                    var records = (csv.GetRecords<dynamic>()).ToList();
                }

                using (var reader = new StreamReader(ruta))
                using (var csv = new CsvReader(reader))
                {
                    // Do any configuration to `CsvReader` before creating CsvDataReader.
                    csv.Configuration.Delimiter = ";";
                    csv.Configuration.HeaderValidated = null;
                    csv.Configuration.MissingFieldFound = null;

                    using (var dr = new CsvDataReader(csv))
                    {
                        
                        dt.Load(dr);
                    }

                    bs.DataSource = dt;
                }
            }

            dataGridView1.DataSource = bs;
            CargarListaAtributos(dt.Rows[0]);
            // se carga el archivo 
        }

        private void CargarListaAtributos(DataRow dataRow)
        {
            List<string> titulos = new List<string>();
            foreach (DataColumn columna in dataRow.Table.Columns)
            {
                checkedListBox1.Items.Add(columna.ColumnName, true);
                checkedListBoxVariableRellenar.Items.Add(columna.ColumnName, false);
            }

        }

        private void buttonSVM_Click(object sender, EventArgs e)
        {
            List<double> values = new List<double>();
            foreach (var column in checkedListBoxVariableRellenar.SelectedItems)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    values.Add(double.Parse(dt.Rows[i][column.ToString()].ToString()));
                }

                var dataTraining = ProblemHelper.ReadAndScaleProblem(new List<List<double>>() { values});
                var svm = new Epsilon_SVR(DataProblem, KernelHelper.RadialBasisFunctionKernel(Gamma), C, Elipson);
                double mse = svm.GetMeanSquaredError();

                var prediction = svm.Predict(dataTraining.x[0]);
            }

            
            // 1. primero se debe armar una subtabla con los atributos que se van a utilizar.
            // que serian los que estan en el checkbox.

            // 2. elegir la columna sobre la que se quiere rellenar valores

            // 3. se quitan los registros que contengan datos faltantes de las variables predictoras, para este caso son los que tengan valor de -200

            // 4. Aplicar el algoritmo de VSM

            // 5. Generar Vista con valores resultado

            // 6. Generar resumen de resultados: en tal fila, cambie tal por tal.

        }
    }
}
