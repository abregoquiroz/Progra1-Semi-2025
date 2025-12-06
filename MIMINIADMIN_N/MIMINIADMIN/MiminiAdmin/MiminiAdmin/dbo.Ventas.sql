CREATE TABLE [dbo].[Ventas] (
    [IdVentas]      INT        IDENTITY (1, 1) NOT NULL,
    [Fecha_ventas]  DATETIME   NOT NULL,
    [ Metodo_pagos] CHAR (100) NOT NULL,
    [Codigo]        CHAR (100) NOT NULL,
    [IdProducto] INT NOT NULL, 
    [IdEmpleados] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([IdVentas] ASC), 
   
);

