USE dbFacturacion
GO

CREATE PROCEDURE eliminarRol
	@idRolEmpleado INT

AS

DELETE FROM tblRoles WHERE idRolEmpleado=@idRolEmpleado
GO