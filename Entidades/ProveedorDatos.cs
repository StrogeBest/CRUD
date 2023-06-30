using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    internal static class ProveedorDatos<T>
    {
        public static void EscribirJson(string ruta, List<T> lista)
        {
            if (!File.Exists(ruta))
            {
                File.Create(ruta);
            }

            using (StreamWriter sr = new StreamWriter(ruta))
            {
                string datos = JsonSerializer.Serialize<List<T>>(lista);

                sr.WriteLine(datos);
            }
        }

        public static List<T> LeerJson(string ruta)
        {
            List<T> lista = new List<T>();

            if (!File.Exists(ruta))
            {
                File.Create(ruta);
            }
            
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string datos = sr.ReadToEnd();

                    try
                    {
                        lista = JsonSerializer.Deserialize<List<T>>(datos)!;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public static void EscribirXml(string ruta, List<T> lista)
        {
            if (!File.Exists(ruta))
            {
                File.Create(ruta);
            }

            using (StreamWriter sw = new StreamWriter(ruta))
            { 
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                xmlSerializer.Serialize(sw, lista);
            }
        }

        public static List<T> LeerXml(string ruta)
        {
            List<T> lista = new List<T>();

            using (StreamReader sr = new StreamReader("alumno.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                lista = xmlSerializer.Deserialize(sr) as List<T>;
            }

            return lista;
        }
    }
}
