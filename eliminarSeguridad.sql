USE dbFacturacion
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarSeguridad]
@idEmpleado INT

AS

DELETE FROM tblSeguridad WHERE idEmpleado=@idEmpleado
GO