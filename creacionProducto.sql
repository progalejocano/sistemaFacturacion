USE dbFacturacion
GO


CREATE PROCEDURE creacionProducto
					@strNombre VARCHAR(50),
					@strReferencia VARCHAR(20),
					@numPrecioCompra DECIMAL,
					@numPrecioVente DECIMAL,
					@idCategoria INT,
					@strDetalle VARCHAR(250),
					@strForo VARCHAR(30),
					@numStock INT,
					@dtmFechaModifica DATETIME,
					@strUsuarioModifico VARCHAR(30)

AS

IF NOT EXISTS (SELECT idProducto FROM tblProductos WHERE strNombre=@strNombre)

INSERT INTO tblProductos(
	strNombre,
	strReferencia,
	numPrecioCompra,
	numPrecioVente,
	idCategoria,
	strDetalle,
	strForo,
	numStock,
	dtmFechaModifica,
	strUsuarioModifico
)
VALUES(
	@strNombre,
	@strReferencia,
	@numPrecioCompra,
	@numPrecioVente,
	@idCategoria,
	@strDetalle,
	@strForo,
	@numStock,
	@dtmFechaModifica,
	@strUsuarioModifico
	)

ELSE

UPDATE tblProductos
SET strNombre=@strNombre,
	strReferencia=@strReferencia,
	numPrecioCompra=@numPrecioCompra,
	numPrecioVente=@numPrecioVente,
	idCategoria=@idCategoria,
	strDetalle=@strDetalle,
	strForo=@strForo,
	numStock=@numStock,
	dtmFechaModifica=@dtmFechaModifica,
	strUsuarioModifico=@strUsuarioModifico
GO