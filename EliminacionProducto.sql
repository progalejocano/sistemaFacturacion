USE dbFacturacion
GO

CREATE PROCEDURE eliminarProducto
	@idProducto INT

AS

DELETE FROM tblProductos WHERE idProducto=@idProducto
GO