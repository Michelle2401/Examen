using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos
    {
        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM producto";

                using (MySqlConnection _conexion = new MySqlConnection(Conexioncadena.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }

            }
            catch (Exception ex)
            {

            }
            return dt;
        }
        public async Task<bool> InsertarAsync(Producto producto)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO producto VALUES (@Codigo, @Descripcion, @Precio);";

                using (MySqlConnection _conexion = new MySqlConnection(Conexioncadena.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 50).Value = producto.Descripcion;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        

                        await comando.ExecuteNonQueryAsync();
                        inserto = true;

                    }
                }
            }
            catch (Exception)
            {
            }
            return inserto;
        }
        public async Task<bool> ActualizarAsync(Producto producto)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE PRODUCTO SET Descripcion=@Descripcion, Precio=@Precio, WHERE Codigo=@Codigo";

                using (MySqlConnection _conexion = new MySqlConnection(Conexioncadena.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 50).Value = producto.Descripcion;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;


                        await comando.ExecuteNonQueryAsync();
                        actualizo = true;

                    }
                }
            }
            catch (Exception)
            {
            }
            return actualizo;
        }
       
    }
}

    
