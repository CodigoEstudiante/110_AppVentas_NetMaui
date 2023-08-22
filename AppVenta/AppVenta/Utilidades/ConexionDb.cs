using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.Utilidades
{
    public static class ConexionDb
    {
        public static string DevolverRuta(string nombreBaseDatos)
        {
            string rutaBaseDatos = string.Empty;

            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                rutaBaseDatos = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                rutaBaseDatos = Path.Combine(rutaBaseDatos, nombreBaseDatos);

            }
            else if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                rutaBaseDatos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                rutaBaseDatos = Path.Combine(rutaBaseDatos, "..", "Library", nombreBaseDatos);
            }

            return rutaBaseDatos;

        }
    }
}
