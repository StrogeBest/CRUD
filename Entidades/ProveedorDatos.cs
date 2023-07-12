using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ProveedorDatos<T>
    {
        public static void EscribirJson(string ruta, T obj)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            using (StreamWriter sr = new StreamWriter(ruta))
            {
                string datos = JsonSerializer.Serialize<T>(obj, opciones);
                
                sr.WriteLine(datos);
            }
        }

        public static T LeerJson(string ruta)
        {
            T obj = default(T)!;

            using (StreamReader sr = new StreamReader(ruta))
            {
                string datos = sr.ReadToEnd();

                obj = JsonSerializer.Deserialize<T>(datos)!;
            }

            return obj;
        }

        public static void EscribirXml(string ruta, T obj)
        {
            using (XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8))
            { 
                writer.Formatting = Formatting.Indented;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(writer, obj);
            }
        }

        public static T LeerXml(string ruta)
        {
            T obj = default(T)!;

            using (StreamReader sr = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                obj = (T)xmlSerializer.Deserialize(sr)!;
            }

            return obj;
        }

        public static void EscribirListaJson(string ruta, List<T> lista)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
    
            /*
            USANDO Newtonsoft.Json
            
            string json = JsonConvert.SerializeObject(listaAstro, Formatting.Indented);
            
            File.WriteAllText(@"Datos/planetario.json", json);
            */

            using (StreamWriter sr = new StreamWriter(ruta))
            {
                string datos = JsonSerializer.Serialize<List<T>>(lista, opciones);
                
                sr.WriteLine(datos);
            }
        }

        public static List<T> LeerListaJson(string ruta)
        {
            List<T> lista = new List<T>();

            using (StreamReader sr = new StreamReader(ruta))
            {
                string datos = sr.ReadToEnd();

                lista = JsonSerializer.Deserialize<List<T>>(datos)!;
            }

            return lista;
        }

        public static void EscribirListaXml(string ruta, List<T> lista)
        {
            using (XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8))
            { 
                writer.Formatting = Formatting.Indented;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                xmlSerializer.Serialize(writer, lista);
            }
        }

        public static List<T> LeerListaXml(string ruta)
        {
            List<T> lista = new List<T>();

            using (StreamReader sr = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                lista = (List<T>)xmlSerializer.Deserialize(sr)!;
            }

            return lista;
        }
    }
}
