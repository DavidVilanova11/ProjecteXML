using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ProjecteXML.model;
using WinFormsApp1.Model;

namespace WinFormsApp1.DAO
{
    public static class BD
    {
        private const string server = "db4free.net";
        private const string port = "3306";
        private const string database = "animals";
        private const string username = "david1234";
        private const string password = "contrenyA2004";

        private const string connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Username=" + username + ";Password=" + password;
        private static MySqlConnection connection;

        private static bool Conectar()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private static void Desconectar()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        //public static bool EnviarDatosBDD(List<Zona> cotxes)
        //{
        //    try
        //    {
        //        EsborrarDades();

        //        if (Conectar())
        //        {
        //            foreach (var cotxe in cotxes)
        //            {
        //                int idCotxe = InsertarCotxe(cotxe);

        //                foreach (var caracteristica in cotxe.Caracteristiques)
        //                {
        //                    InsertarCaracteristica(caracteristica, idCotxe);
        //                }
        //                InsertarConcessionari(cotxe.Concessionari);
        //            }

        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        Desconectar();
        //    }
        //}

        //public static int InsertarAnimal(Zona cotxe)
        //{
        //    int insertedID = -1;
        //    try
        //    {
        //        Conectar();
        //        string query = "INSERT INTO animals (id_zona, especie, nom, edat, color) VALUES (@id_zona, @especie, @nom, @edat, @color);";
        //        string selectQuery = "SELECT LAST_INSERT_ID();";

        //        using (MySqlCommand command = new MySqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@id_zona", c);
        //            command.Parameters.AddWithValue("@model", cotxe.Model);
        //            command.Parameters.AddWithValue("@any", cotxe.Any);

        //            int rowsAffected = command.ExecuteNonQuery();

        //            using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
        //            {
        //                insertedID = Convert.ToInt32(selectCommand.ExecuteScalar());
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return insertedID;
        //}

        public static int InsertarZona(Zona zona)
        {
            int insertedID = -1;
            try
            {
                Conectar();
                string query = "INSERT INTO Zones (latitud, longitud, metres_quadrats) VALUES (@latitud, @longitud, @metres_quadrats);";
                string selectQuery = "SELECT LAST_INSERT_ID();";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@latitud", zona.Latitud);
                    command.Parameters.AddWithValue("@longitud", zona.Longitiud);
                    command.Parameters.AddWithValue("@metres_quadrats", zona.Metres_quadrats);

                    int rowsAffected = command.ExecuteNonQuery();

                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        insertedID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return insertedID;
        }

        public static int InsertarAnimal(Animal animal, int idZona)
        {
            int idAnimalInsertado = 0;

            try
            {
                Conectar();
                string query = "INSERT INTO Animals (id_zona, especie, nom, edat, color) VALUES (@id_zona, @especie, @nom, @edat, @color); SELECT LAST_INSERT_ID();";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_zona", idZona);
                    command.Parameters.AddWithValue("@especie", animal.Especie);
                    command.Parameters.AddWithValue("@nom", animal.Nom);
                    command.Parameters.AddWithValue("@edat", animal.Edat);
                    command.Parameters.AddWithValue("@color", animal.Color);

                    idAnimalInsertado = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
            }

            return idAnimalInsertado;
        }
        public static void InsertarExemplars(Animal animal, int numExemplars)
        {
            try
            {
                Conectar();
                string query = "UPDATE Animals SET exemplars = @numExemplars WHERE especie = @especieAnimal;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@numExemplars", numExemplars);
                    command.Parameters.AddWithValue("@especieAnimal", animal.Especie);
                    //command.Parameters.AddWithValue("@idAnimal", idAnimal);


                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
            }
        }


        //public static int InsertarConcessionari(ConcessionariModel concessionari )
        //{
        //    int insertedID = -1;
        //    try
        //    {
        //        Conectar();

        //        string query = "INSERT INTO concessionaris (nom, carrer, ciutat, codiPostal, telefon, dilluns, dimarts, dimecres, dijous, divendres, dissabte, diumenge) " +
        //            "VALUES (@nom, @carrer, @ciutat, @codiPostal, @telefon, @dilluns, @dimarts, @dimecres, @dijous, @divendres, @dissabte, @diumenge);";
        //        string selectQuery = "SELECT LAST_INSERT_ID();";

        //        using (MySqlCommand command = new MySqlCommand(query, connection))
        //        {
        //          //  command.Parameters.AddWithValue("@id", concessionari.Id);
        //            command.Parameters.AddWithValue("@nom", concessionari.Nom);
        //            command.Parameters.AddWithValue("@carrer", concessionari.Carrer);
        //            command.Parameters.AddWithValue("@ciutat", concessionari.Ciutat);
        //            command.Parameters.AddWithValue("@codiPostal", concessionari.CodiPostal);
        //            command.Parameters.AddWithValue("@telefon", concessionari.Telefon);
        //            command.Parameters.AddWithValue("@dilluns", concessionari.Dilluns);
        //            command.Parameters.AddWithValue("@dimarts", concessionari.Dimarts);
        //            command.Parameters.AddWithValue("@dimecres", concessionari.Dimecres);
        //            command.Parameters.AddWithValue("@dijous", concessionari.Dijous);
        //            command.Parameters.AddWithValue("@divendres", concessionari.Divendres);
        //            command.Parameters.AddWithValue("@dissabte", concessionari.Dissabte);
        //            command.Parameters.AddWithValue("@diumenge", concessionari.Diumenge);

        //            int rowsAffected = command.ExecuteNonQuery();

        //            if (rowsAffected > 0)
        //            {
        //                using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
        //                {
        //                    insertedID = Convert.ToInt32(selectCommand.ExecuteScalar());
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    finally
        //    {
        //        Desconectar();
        //    }

        //    return insertedID;
        //}

        public static int CalcularNumeroEjemplares(string especie)
        {
            int numExemplares = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("CalcularNumeroEjemplares", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@especieParam", especie);

                command.Parameters.Add(new MySqlParameter("@numExemplares", MySqlDbType.Int32));
                command.Parameters["@numExemplares"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                numExemplares = Convert.ToInt32(command.Parameters["@numExemplares"].Value);
            }

            return numExemplares;
        }

        public static void ObtenerAnimalConMasEjemplares(string filePath)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear el comando para llamar al procedimiento almacenado
                    MySqlCommand command = new MySqlCommand("obtenerAnimalConMásEjemplares", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro de entrada
                    command.Parameters.AddWithValue("@file_path", filePath);

                    // Ejecutar el comando y obtener el resultado
                    string xmlResult = command.ExecuteScalar().ToString();

                    // Guardar el resultado en un archivo
                    System.IO.File.WriteAllText(filePath, xmlResult);

                    Console.WriteLine("Archivo XML generado correctamente: " + filePath);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                Console.WriteLine("Error: " + ex.Message);
            }
        }



        public static int EsborrarDades()
        {
            int rowsAffected = 0;
            try
            {
                Conectar();
                {
                    string deleteZonesQuery = "DELETE FROM Zones";
                    string deleteAnimalsQuery = "DELETE FROM Animals";

                    using (MySqlCommand command = new MySqlCommand(deleteAnimalsQuery, connection))
                    {
                        command.CommandType = CommandType.Text;
                        rowsAffected += command.ExecuteNonQuery();
                    }

                    using (MySqlCommand command = new MySqlCommand(deleteZonesQuery, connection))
                    {
                        command.CommandType = CommandType.Text;
                        rowsAffected += command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Desconectar();
            }
            return rowsAffected;
        }
    }
}
