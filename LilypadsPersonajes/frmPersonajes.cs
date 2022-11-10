using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominioLily;
using negocioLily;


namespace LilypadsPersonajes
{
    public partial class frmPersonajes : Form
    {
        private List<Personaje> listaPersonajes;
        public frmPersonajes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            PersonajeDatos datos = new PersonajeDatos();
            listaPersonajes = datos.listar();
            dgvPersonajes.DataSource = listaPersonajes;
            cargarImagen(listaPersonajes[0].UrlImagen);
            ocultarColumnas();
        }
        private void ocultarColumnas()
        {
            dgvPersonajes.Columns["UrlImagen"].Visible = false;
            dgvPersonajes.Columns["Id"].Visible = false;
        }
        private void cargarImagen(string imagen)
        {
            try { pbxPersonajes.Load(imagen); }
            catch (Exception ex) { pbxPersonajes.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png"); }
        }

        private void dgvPersonajes_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPersonajes.CurrentRow != null)
            {
                Personaje seleccionado = (Personaje)dgvPersonajes.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoPersonaje nuevo = new frmNuevoPersonaje();
            nuevo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Personaje seleccionado = (Personaje)dgvPersonajes.CurrentRow.DataBoundItem;
            frmNuevoPersonaje mod = new frmNuevoPersonaje(seleccionado);
            mod.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar(bool logico = false)
        {
            Personaje seleccionado;
            PersonajeDatos datos = new PersonajeDatos();
            if (DialogResult.Yes == MessageBox.Show("¿Estás seguro de que quieres eliminarlo?", "Eliminar Personaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                seleccionado = (Personaje)dgvPersonajes.CurrentRow.DataBoundItem;
                if (logico)
                    datos.eliminarLogico(seleccionado.Id);
                else
                    datos.eliminar(seleccionado.Id);
                cargar();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            List<Personaje> listaFiltrada;
            string filtro = txtFiltro.Text;
            if (txtFiltro.Text != "")
                listaFiltrada = listaPersonajes.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Apodo.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listaPersonajes;

            dgvPersonajes.DataSource = null;
            dgvPersonajes.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
