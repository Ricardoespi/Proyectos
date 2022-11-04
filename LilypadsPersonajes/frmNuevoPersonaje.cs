using dominioLily;
using negocioLily;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LilypadsPersonajes
{
    public partial class frmNuevoPersonaje : Form
    {
        public frmNuevoPersonaje()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PersonajeDatos negocio = new PersonajeDatos();
            Personaje pj = new Personaje();
            try
            {
                pj.Nombre = txtbxNombre.Text;
                pj.Apodo = txtbxApodo.Text;
                pj.Sexo = txtbxSexo.Text;
                pj.Raza= txtbxRaza.Text;
                pj.Clase = txtbxClase.Text;
                pj.Armas= txtbxArmas.Text;
                pj.Magia = txtbxMagia.Text;
                pj.Historia= txtbxHistoria.Text;
                pj.UrlImagen= txtbxUrlImagen.Text;
                negocio.agregar(pj);
                MessageBox.Show("Agregado Existosamente.");
                Close();
            }
            catch (Exception ex)
            {throw ex;}
        }
    }
}
