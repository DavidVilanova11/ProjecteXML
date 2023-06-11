using ProjecteXML.model;
using System;
using System.Collections.Generic;
using System.Xml;
using WinFormsApp1.DAO;

namespace WinFormsApp1.Model
{
    public static class ReservaManager
    {
        public static bool CarregarModel(string filePath)
        {

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                foreach (XmlNode zonaNode in doc.SelectNodes("//zona"))
                {
                    Zona zona = new Zona();
                    zona.Latitud = double.Parse(zonaNode.Attributes["latitud"]?.Value);
                    zona.Longitiud = double.Parse(zonaNode.Attributes["longitud"]?.Value);
                    zona.Metres_quadrats = double.Parse(zonaNode.Attributes["metres_quadrats"]?.Value);
                    int idZona = BD.InsertarZona(zona);


                    XmlNode animalsNode = zonaNode.SelectSingleNode("animals");
                    if (animalsNode != null)
                    {
                        foreach (XmlNode animalNode in animalsNode.SelectNodes("animal"))
                        {
                            Animal animal = new Animal();
                            animal.Especie = animalNode.Attributes["especie"]?.Value;
                            animal.Nom = animalNode.SelectSingleNode("nom")?.InnerText;
                            animal.Edat = int.Parse(animalNode.SelectSingleNode("edat").InnerText);
                            animal.Color = animalNode.SelectSingleNode("color")?.InnerText;
                            zona.Animals.Add(animal); //afegir animal a la llista de zones

                            if (idZona != -1)
                            {
                                int idAnimal = BD.InsertarAnimal(animal, idZona);
                                int numExemplars = BD.CalcularNumeroEjemplares(animal.Especie); //procedure examplars, funciona correctament. en aquest cas el procedure retorna un número d'exemplars
                                BD.InsertarExemplars(animal, numExemplars);

                            }
                        }
                    }

                }

                BD.ObtenerAnimalConMasEjemplares("C:\\Users\\PC\\Documents\\Classe\\XML\\AnimalAmbMesExemplars.xml"); //obtrnir nou xml a partir de procedure

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
