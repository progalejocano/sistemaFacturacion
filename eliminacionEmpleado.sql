USE dbFacturacion
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarEmpleado]
@idEmpleado INT

AS

DELETE FROM tblEmpleado WHERE idEmpleado=@idEmpleado
GO