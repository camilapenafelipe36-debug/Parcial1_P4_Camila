using Microsoft.Data.SqlClient;

var connectionString = "Server=localhost;Database=Parcial1_P4_Camila;Integrated Security=True;TrustServerCertificate=True;";

using var connection = new SqlConnection(connectionString);
connection.Open();

var sql = @"
IF OBJECT_ID('Productos', 'U') IS NULL
BEGIN
    CREATE TABLE Productos
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Precio DECIMAL(10,2) NOT NULL,
        Cantidad INT NOT NULL
    );
END";

using var command = new SqlCommand(sql, connection);
command.ExecuteNonQuery();

Console.WriteLine("TABLA PRODUCTOS CREADA CORRECTAMENTE");
