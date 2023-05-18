using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjecteXML.model
{
    public static class DMCManager
    {
        private static List<Campionat> campionats = new List<Campionat>();
        private static string message = "";

        public static bool carregarModel(String filePath)
        {
            bool bres = false;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                XmlNodeList ElementsCampionat = doc.SelectNodes("//championship");
                foreach (XmlNode campionat in ElementsCampionat)
                {
                    Campionat championship = new Campionat();
                    championship.Year = int.Parse(campionat.Attributes["year"].InnerText);
                    championship.Country = campionat.Attributes["country"].Value;
                    championship.City = campionat.Attributes["city"].Value;

                    XmlNodeList ElementsDj = doc.SelectNodes("//dj");
                    foreach (XmlNode dj in ElementsDj)
                    {
                        DJ djockey = new DJ();
                        djockey.local = dj.Attributes["local"].Value;
                        djockey.nom = dj.SelectSingleNode("nom").InnerText;
                        djockey.pos = int.Parse(dj.SelectSingleNode("pos").InnerText);
                        championship.addDJ(djockey);
                    }
                }

                bres = true;
            }
            catch (Exception ex)
            {
                message = "error en carregar el fitxer " + ex.Message;
            }

            return bres;
        }

        //public static void EscriureEnArxiu(string filePath, Campionat championship)
        //{
        //    try
        //    {
        //        using (StreamWriter writer = new StreamWriter(filePath))
        //        {
        //            writer.WriteLine("Championship Details:");
        //            writer.WriteLine("Year: " + championship.Year);
        //            writer.WriteLine("Country: " + championship.Country);
        //            writer.WriteLine("City: " + championship.City);
        //            writer.WriteLine();

        //            writer.WriteLine("DJ Details:");
        //            foreach (DJ djockey in championship.(//falta getter de tots els dj)) 
        //            {
        //                writer.WriteLine("Local: " + djockey.local);
        //                writer.WriteLine("Nom: " + djockey.nom);
        //                writer.WriteLine("Pos: " + djockey.pos);
        //                writer.WriteLine();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejar la excepción aquí
        //    }
        //}


    }
}
