CREATE DATABASE dbFacturacion
USE dbFacturacion

CREATE TABLE tblRoles
(
idRolEmpleado INT IDENTITY,
strDescripcion VARCHAR(50),
PRIMARY KEY (idRolEmpleado)
)

SELECT * FROM tblRoles

CREATE TABLE tblEmpleado
(
idEmpleado INT IDENTITY,
strNombre VARCHAR(50),
numDocumento BIGINT,
strDireccion VARCHAR(50),
strTelefono VARCHAR(30),
strEmail VARCHAR(50),
idRolEmpleado INT,
dtmIngreso DATETIME,
dtmRetiro DATETIME,
strDatosAdicionales VARCHAR(250),
stmFechaModifica DATETIME,
strUsuarioModifico VARCHAR(30),
PRIMARY KEY (idEmpleado),
FOREIGN KEY (idRolEmpleado) REFERENCES tblRoles (idRolEmpleado)
)

SELECT * FROM tblEmpleado

CREATE TABLE tblSeguridad
(
idSeguridad INT IDENTITY,
idEmpleado INT,
strUsuario VARCHAR(20),
strClave VARCHAR(20),
dtmFechaModifica DATETIME,
strUsuarioModifico VARCHAR(30),
PRIMARY KEY (idSeguridad),
FOREIGN KEY (idEmpleado) REFERENCES tblEmpleado (idEmpleado)
)

SELECT * FROM tblSeguridad

CREATE TABLE tblClientes(
idCliente INT IDENTITY,
strNombre VARCHAR(50),
numDocumento BIGINT,
strDireccion VARCHAR(50),
strTelefono VARCHAR(30),
strEmail VARCHAR(50),
dtmFechaModifica DATETIME,
strUsuarioModifico VARCHAR(30),
PRIMARY KEY (idCliente)
)

SELECT * FROM tblClientes

CREATE TABLE tblCategoriaProd
(
idCategoria INT IDENTITY,
strReferencia VARCHAR(20),
strDescripcion VARCHAR(50),
dtmFechaModifica DATETIME,
strUsuarioModifico VARCHAR(30),
PRIMARY KEY (idCategoria)
)

SELECT * FROM tblCategoriaProd

CREATE TABLE tblProductos
(
idProducto INT IDENTITY,
strNombre VARCHAR(50),
strReferencia VARCHAR(20),
numPrecioCompra DECIMAL,
numPrecioVente DECIMAL,
idCategoria INT,
strDetalle VARCHAR(250),
strForo	VARCHAR(30),
numStock INT,
dtmFechaModifica DATETIME,
strUsuarioModifico VARCHAR(30),
PRIMARY KEY (idProducto),
FOREIGN KEY (idCategoria) REFERENCES tblCategoriaProd (idCategoria)
)

SELECT * FROM tblProductos