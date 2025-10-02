using Actividad8._1.Models;

namespace Actividad8._1
{
    public partial class Form1 : Form
    {
        List<Cuenta> cuentas = new List<Cuenta>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);
            Cuenta c = new Cuenta(nombre, dni, importe);
            cuentas.Sort();
            int idx = cuentas.BinarySearch(c);
            if (idx >= 0) //Actualizar
            {
                cuentas[idx].Nombre = nombre;
                cuentas[idx].Importe += importe;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Cuenta c in cuentas)
            {
                listBox1.Items.Add(c);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta c = listBox1.SelectedItem as Cuenta;
            if (c != null)
            {
                tbDNI.Text = "{c.DNI}";
                tbNombre.Text = $"{c.Nombre}";
                tbImporte.Text = $"{c.Importe}";
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while(!sr.EndOfStream==false)
                {
                    string linea = sr.ReadLine();
                    string dni = linea.Substring(0, 9);
                    string nombre = linea.Substring(9, 10).Trim();
                    string importe = linea.Substring(19, 9);
                    Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToDouble(importe));
                }
            }
        }
    }
}
