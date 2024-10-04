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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArchivosPeroConVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filepath = "Archivo.dat";
        private string FilePath = "Archivo.dat";

        private void Btnsend_Click(object sender, EventArgs e)
        {
            if(tbinfo.Text.Length > 0)
            {
                File.WriteAllText(FilePath, tbinfo.Text + $" {tbage.Text}" + $" {tbgrade.Text}" + $" {tbgender.Text}");
                
                tbinfo.Clear();
                tbage.Clear(); 
                tbgrade.Clear(); 
                tbgender.Clear();

                MessageBox.Show("Guardado con Exito");
            }
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                
                string fileContent = File.ReadAllText(FilePath);
                textBox1.Text = fileContent;
                MessageBox.Show("Archivo leído con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }
            
        
    }
}
