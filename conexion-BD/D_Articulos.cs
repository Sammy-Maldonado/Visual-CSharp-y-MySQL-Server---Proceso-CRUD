using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace conexion_BD
{
    public class D_Articulos
    {
        public DataTable Listado_ar(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();      //Recurso de la tabla
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();   //Aqui consumo la parte de conectividad.
                string sql_tarea = "SELECT a.codigo_ar," +
                                   "a.descripcion_ar," +
                                   "a.marca_ar," +
                                   "b.descripcion_um," +
                                   "c.descripcion_ca," +
                                   "a.stock_actual," +
                                   "a.codigo_um," +
                                   "a.codigo_ca " +
                                   "FROM tb_articulos a " +
                                   "INNER JOIN tb_unidades_medidas b on a.codigo_um=b.codigo_um " +
                                   "INNER JOIN tb_categorias c on a.codigo_ca=c.codigo_ca " +
                                   "where a.descripcion_ar like '" + cTexto + "' " +    //En C# asi se incrusta un dato dentro de un string.
                                   " and a.estado=1 " +
                                   " order by a.codigo_ar";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);     //El primer dato es la accion que se manda por el segundo dato que es la conexión.
                Comando.CommandTimeout = 60;
                SqlCon.Open();  //Aperturo para que se envie la consulta.
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Guardar_ar(int nOpcion, P_Articulos oAr)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                //Proceso de inserción
                SqlCon = Conexion.getInstancia().CrearConexion();
                if (nOpcion == 1)   //Si esto se cumple, estaria frente a proceso de nuevo registro
                {
                    Sqltarea = "insert into tb_articulos(descripcion_ar," +
                                                         "marca_ar, " +
                                                         "codigo_um, " +
                                                         "codigo_ca, " +
                                                         "stock_actual, " +
                                                         "fecha_crea, " +
                                                         "fecha_modifica, " +
                                                         "estado) " +
                                                " values('" + oAr.Descripcion_ar + "', " +
                                                        "'" + oAr.Marca_ar + "', " +
                                                        "'" + oAr.Codigo_um + "', " +
                                                        "'" + oAr.Codigo_ca + "', " +
                                                        "'" + oAr.Stock_actual + "', " +
                                                        "'" + oAr.Fecha_crea + "', " +
                                                        "'" + oAr.Fecha_modifica + "', 1)";

                }
                else                //Sino seria Actualizar Registro
                {
                    Sqltarea = "update tb_articulos set descripcion_ar='" + oAr.Descripcion_ar + "'," +
                                                        "marca_ar='" + oAr.Marca_ar + "'," +
                                                        "codigo_um='" + oAr.Codigo_um + "'," +
                                                        "codigo_ca='" + oAr.Codigo_ca + "'," +
                                                        "stock_actual='" + oAr.Stock_actual + "'," +
                                                        "fecha_modifica='" + oAr.Fecha_modifica + "'" +
                                                        " where codigo_ar='" + oAr.Codigo_ar + "'";
                }
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro solicitado";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;  //Obtengo el error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }

        public string Eliminar_ar(int nCodigo_ar)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                // Sqltarea = "delete from tb_articulos where codigo_ar='"+nCodigo_ar+"'";
                Sqltarea = "update tb_articulos set estado=0 where codigo_ar='" + nCodigo_ar + "'";
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;  //Obtengo el error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;

        }

        public DataTable Listado_um()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select descripcion_um, codigo_um from tb_unidades_medidas";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listado_ca()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select descripcion_ca, codigo_ca from tb_categorias";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
