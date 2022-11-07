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
                pj.Raza = (Raza)cboRaza.SelectedItem;
                pj.Clase = txtbxClase.Text;
                pj.Arma = (Armas)cboArmas.SelectedItem;
                pj.Magia = txtbxMagia.Text;
                pj.Historia= txtbxHistoria.Text;
                pj.UrlImagen= txtbxUrlImagen.Text;
                negocio.agregar(pj);
                MessageBox.Show("Agregado Existosamente.");
                Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
        

        private void frmNuevoPersonaje_Load(object sender, EventArgs e)
        {
            RazaDatos listaRazas = new RazaDatos();
            cboRaza.DataSource = listaRazas.listar();
            ArmasDatos listaArmas= new ArmasDatos();
            cboArmas.DataSource = listaArmas.listar();
        }

        private void txtbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbxUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try { pbxNuevoPersonaje.Load(imagen); }
            catch (Exception ex) { pbxNuevoPersonaje.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png"); }
        }
    }
}
