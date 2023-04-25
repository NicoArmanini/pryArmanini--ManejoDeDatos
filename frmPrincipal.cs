using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryArmanini__ManejoDeDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            StreamWriter manejoArchivo = new StreamWriter("ArchivoDatos.txt", true);
            string Texto = txtGrabar.Text;
            using (StreamWriter mA = manejoArchivo)
            {
                mA.WriteLine(Texto);
            }
            MessageBox.Show("Archivo Guardado con EXITO!!");

            txtGrabar.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

            StreamReader ManejoArchivo = new StreamReader("ArchivoDatos.txt");
            using (StreamReader mA = new StreamReader("ArchivoDatos.txt"))
            {
                string Contenido = mA.ReadToEnd();
                rtbDatos.Text = Contenido;
            }
            MessageBox.Show("Leido Correctamente");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            StreamReader leerArchivo = new StreamReader("ArchivoDatos.txt");

            while (leerArchivo.EndOfStream == false)
            {
                string auxiliar = leerArchivo.ReadLine();
                //buscar dentro del stream / texto
                if (auxiliar.Contains(txtDatoABuscar.Text))
                {
                    rtbDatos.Text = "Encntrado con EXITO!! ";
                    rtbDatos.Text += auxiliar;
                    break;
                }
                else
                {
                    rtbDatos.Text = "No se encuentra este ARCHIVO" + " || " + " Revise que este bien escrito!!";
                }
            }

            leerArchivo.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void frmPrincipal_Load(object sender, EventArgs e)
        //{
            //sacar datos de un archivo


            //ABRIR O CREAR UN ARCHIVO
            //StreamWriter manejoArchivo = new StreamWriter("LIBRO1.txt");

            //StreamReader leerArchivo = new StreamReader("LIBRO1.txt");

            //while (leerArchivo.EndOfStream == false)
            //{

            //    lblDatos.Text += leerArchivo.ReadLine() + "/n";
            //    lblDatos.Text = lblDatos.Text + leerArchivo.ReadLine();
            //    es lo mismo que lo de arriba
            //}

            //leerArchivo.Close();
            //manejoArchivo.Close();
        //}
    }
}
