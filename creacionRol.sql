USE dbFacturacion
GO


CREATE PROCEDURE creacionRol
					@strDescripcion VARCHAR(50)

AS

IF NOT EXISTS (SELECT idRolEmpleado FROM tblRoles WHERE strDescripcion=@strDescripcion)

INSERT INTO tblRoles(
	strDescripcion
)
VALUES(
	@strDescripcion
	)

ELSE

UPDATE tblRoles
SET strDescripcion=@strDescripcion
GO