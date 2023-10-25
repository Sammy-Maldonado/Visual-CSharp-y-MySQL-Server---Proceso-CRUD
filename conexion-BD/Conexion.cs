using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace conexion_BD
{
    public class Conexion
    {
        //1) Establecemos las variables para la conexión.

        private string Base;        //Nombre de la base de datos
        private string Servidor;    //Donde se encuentra alojado el servidor de MySQL server
        private string Puerto;      //Puerto del servidor en MySQl server
        private string Usuario;     //Usuario que se está utilizando
        private string Clave;       //Contraseña de acceso al servidor de MySQL
        private static Conexion Con = null;     //Variable estatica para la conexion, inicializada con la variable Con = null

        //2) Instanciamos la conexión con la información correspondiente.
        private Conexion() 
        {
            this.Base = "bd_almacen";    //Nombre de la base de datos (schema) que voy a usar.
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "123456";
        }

        //3) Definimos la forma de conexión.

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();     //Instanciamos la conexión en una variable llamada "Cadena"
            
            try
            {
                //Conexión string que nos permitirá la conexión.
                Cadena.ConnectionString="datasource="+this.Servidor+
                                        "; port="+this.Puerto+
                                        ";username="+this.Usuario+
                                        ";password="+this.Clave+
                                        ";Database="+this.Base;
                    ;
            }
            catch (Exception ex)
            {
                Cadena = null;  //En el caso de algun inconveniente, Cadena será null.
                throw ex;
            }
            return Cadena;      //Al final tenemos que devolver el contenido de "Cadena"
        }

        //4) Creamos la instancia de conexión.

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
