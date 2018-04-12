-- Creamos la Tabla
CREATE TABLE dbo.Customers
(
   CustomerId   INT            NOT NULL   PRIMARY KEY,
   Nombre      [NVARCHAR](50)  NOT NULL,
   Lugar       [NVARCHAR](50)  NOT NULL,
   Email       [NVARCHAR](50)  NOT NULL
);