using System;
using System.Windows.Forms;
using capaEntidad;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class negocio_Cliente
    {
        datos_Cliente clienteDatos = new datos_Cliente();

        //Valida los datos que no existe ningun campo vacio
        public bool validarDatos(entidad_Cliente Cliente)
        {
            bool result = true;

            if(Cliente.name == String.Empty)
            {
                result = false;
                MessageBox.Show("Campo Name is obligatory");
            }
            if(Cliente.lastname == String.Empty)
            {
                result = false;
                MessageBox.Show("Campo LastName is obligatory");
            }

            if (Cliente.photo == null)
            {
                result = false;
                MessageBox.Show("Campo Image is obligatory");
            }
            return result;
        }

        //Comprueba la conexion a la base de datos
        public void pruebaConnection()
        {
            clienteDatos.connectionMysql();
        }

        //Crea un nuevo Registro
        public void creatRegisterCliente(entidad_Cliente CE)
        {
            clienteDatos.createRegister(CE);
        }

        //Obtiene el registro desde la base de datos.
        public DataSet obtenerDatos()
        {
            return clienteDatos.userRead();
        }

        //Edita el registro selecionado
        public void editarCliente(entidad_Cliente CE)
        {
            clienteDatos.userUpdate(CE);
        }

        //Eliminar Registro
        public void eliminarUser(entidad_Cliente CE)
        {
            clienteDatos.userDelete(CE);
        }
        
    }
}