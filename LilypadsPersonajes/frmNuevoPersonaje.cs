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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace LilypadsPersonajes
{
    public partial class frmNuevoPersonaje : Form
    {
        private Personaje personaje = null;
        private OpenFileDialog archivo = null;
        public frmNuevoPersonaje()
        {
            InitializeComponent();
        }
        public frmNuevoPersonaje(Personaje pj)
        {
            InitializeComponent();
            personaje = pj;
            Text = "Modificar Personaje";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PersonajeDatos negocio = new PersonajeDatos();
            try 
            {
                if (personaje == null)
                {
                    personaje = new Personaje();
                }
                personaje.Nombre = txtbxNombre.Text;
                personaje.Apodo = txtbxApodo.Text;
                personaje.Sexo = txtbxSexo.Text;
                personaje.Raza = (Raza)cboRaza.SelectedItem;
                personaje.Clase = (Clase)cboClase.SelectedItem;
                personaje.Arma = (Armas)cboArmas.SelectedItem;
                personaje.Magia = txtbxMagia.Text;
                personaje.Historia= txtbxHistoria.Text;
                personaje.UrlImagen= txtbxUrlImagen.Text;

                if(personaje.Id != 0)
                {
                    negocio.modificar(personaje);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    negocio.agregar(personaje);
                    MessageBox.Show("Agregado exitosamente.");
                }
                if (archivo != null && !(txtbxUrlImagen.Text.Contains("http")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["image-folder"] + archivo.SafeFileName);
                Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
        private void frmNuevoPersonaje_Load(object sender, EventArgs e)
        {
            RazaDatos listaRazas = new RazaDatos();
            cboRaza.ValueMember = "IdRaza";
            cboRaza.DisplayMember = "NombreRaza";
            ArmasDatos listaArmas= new ArmasDatos();
            cboArmas.ValueMember = "IdArma";
            cboArmas.DisplayMember = "NombreArma";
            ClaseConexion listaClases = new ClaseConexion();
            cboClase.ValueMember = "IdClase";
            cboClase.DisplayMember = "NombreClase";
            try
            {
                cboRaza.DataSource = listaRazas.listar();
                cboArmas.DataSource = listaArmas.listar();
                cboClase.DataSource = listaClases.listar();
                if(personaje != null)
                {
                    txtbxNombre.Text = personaje.Nombre;
                    txtbxApodo.Text = personaje.Apodo;
                    txtbxSexo.Text = personaje.Sexo;
                    txtbxMagia.Text = personaje.Magia;
                    txtbxHistoria.Text = personaje.Historia;
                    txtbxUrlImagen.Text = personaje.UrlImagen;
                    cargarImagen(personaje.UrlImagen);
                    cboRaza.SelectedValue = personaje.Raza.IdRaza;
                    cboArmas.SelectedValue = personaje.Arma.IdArma;
                    cboClase.SelectedValue = personaje.Clase.IdClase;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
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

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtbxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
