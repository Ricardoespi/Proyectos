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

namespace LilypadsPersonajes
{
    public partial class Form1 : Form
    {
        private List<Personaje> listaPersonajes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonajeDatos datos = new PersonajeDatos();
            listaPersonajes = datos.listar();
            dgvPersonajes.DataSource = listaPersonajes;
            cargarImagen(listaPersonajes[0].UrlImagen);
            for (int i = 1; i < 9; i++)
            {
                dgvPersonajes.Columns[i].Visible = false;
            }
            dgvPersonajes.Columns[0].Visible = true;
        }

        private void cargarImagen(string imagen)
        {
            try { pbxPersonajes.Load(imagen); }
            catch (Exception ex) { pbxPersonajes.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png"); }
        }

        private void dgvPersonajes_SelectionChanged(object sender, EventArgs e)
        {
            Personaje seleccionado = (Personaje)dgvPersonajes.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
            lblNombrePersonaje.Text = seleccionado.Nombre;
            lblDescripcion.Text = string.Format("Este es {0} , es conocido como {1}, es {2}, {3}, {4}, y usa {5} y {6}.",
                seleccionado.Nombre, seleccionado.Apodo, seleccionado.Sexo, seleccionado.Raza, seleccionado.Clase,
                seleccionado.Armas, seleccionado.Magia, seleccionado.Historia);
        }
    }
}
