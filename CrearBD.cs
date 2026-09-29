using Microsoft.Data.SqlClient;

var connectionString = "Server=localhost;Database=master;Integrated Security=True;TrustServerCertificate=True;";

using var connection = new SqlConnection(connectionString);
connection.Open();

using var command = new SqlCommand("IF DB_ID('Parcial1_P4_Camila') IS NULL CREATE DATABASE Parcial1_P4_Camila;", connection);
command.ExecuteNonQuery();

Console.WriteLine("Base de datos Parcial1_P4_Camila creada correctamente.");
