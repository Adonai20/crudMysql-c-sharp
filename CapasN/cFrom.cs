using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaNegocio;

namespace CapasN
{
    public partial class cFrom : Form
    {
        negocio_Cliente cNegocio = new negocio_Cliente();
        public cFrom()
        {
            InitializeComponent();
        }

        //
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
        } 
        //Obtienen los registros desde la base de datos;
        private void cargarDatos ()
        {
            gridDatos.DataSource = cNegocio.obtenerDatos().Tables["tbl"];
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Carga la imagen y valida si se selecciono alguna imagen.
        private void userLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userDialog.FileName = string.Empty;
            if (userDialog.ShowDialog() == DialogResult.OK)
            {
                userImage.Load(userDialog.FileName);
            }
            userDialog.FileName = string.Empty;
        }


        //limpia el formulario para crear un nuevo usuario
        private void userNew_Click(object sender, EventArgs e)
        {
            formClear();
        }

        private void formClear()
        {
            userId.Value = 0;
            userName.Text = string.Empty;
            userLastName.Text = string.Empty;
            userImage.Image = null;

        }

        //Guarda el registro creado
        private void userSave_Click(object sender, EventArgs e)
        {
            bool result; 
            entidad_Cliente entidad_Cliente = new entidad_Cliente();
            entidad_Cliente.id = (int)userId.Value;
            entidad_Cliente.name = userName.Text;
            entidad_Cliente.lastname = userLastName.Text;
            entidad_Cliente.photo = userImage.ImageLocation;

            result = cNegocio.validarDatos(entidad_Cliente); 

            if (result == false)
            {
                return;
            }
            if (entidad_Cliente.id == 0)
            {
                cNegocio.creatRegisterCliente(entidad_Cliente);
            }
            else 
            {
                cNegocio.editarCliente(entidad_Cliente);  
            }
            formClear();
            cargarDatos();
        }

        //Elimina el usuario creado
        private void userDelete_Click(object sender, EventArgs e)
        {
            if (userId.Value == 0)
            {
                return;
            }
            else
            {
                entidad_Cliente CE = new entidad_Cliente();
                CE.id = (int)userId.Value;
                cNegocio.eliminarUser(CE);
                cargarDatos();
                formClear();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        //Muestra el registro Seleccionado
        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userId.Value = (int)gridDatos.CurrentRow.Cells["id"].Value;
            userName.Text = gridDatos.CurrentRow.Cells["name"].Value.ToString();
            userLastName.Text = gridDatos.CurrentRow.Cells["last_name"].Value.ToString();
            userImage.Load(gridDatos.CurrentRow.Cells["photo"].Value.ToString());
        }
    }
}
