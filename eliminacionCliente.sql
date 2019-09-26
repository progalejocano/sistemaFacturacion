USE dbFacturacion
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE eliminarCliente
	@idCliente INT

AS

DELETE FROM tblClientes WHERE idCliente=@idCliente
GO