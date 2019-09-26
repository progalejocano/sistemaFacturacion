USE dbFacturacion
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE eliminarCategoria
	@idCategoria INT

AS

DELETE FROM tblCategoriaProd WHERE idCategoria=@idCategoria
GO