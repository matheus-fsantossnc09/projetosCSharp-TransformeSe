using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaABC
{
    internal class Conectado
    {
        private static string stringConectado = "Server=localhost;port=3306;Database=dbTransforme;Uid=root;Pwd=''";
        private static MySqlConnection conec = null;

        public static MySqlConnection obterConexao()
        {
            conec = new MySqlConnection(stringConectado);
            try
            {
                conec.Open();
            }
            catch (Exception)
            {
                conec = null;
            }
            return conec;
        }
        public static void fechaConexao()
        {
            if (conec != null)
            {
                conec.Close();
            }

        }
    }
}
