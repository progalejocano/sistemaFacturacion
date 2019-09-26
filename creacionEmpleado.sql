USE dbFacturacion
GO

CREATE PROCEDURE creacionEmpleado
					@strNombre VARCHAR(50),
					@NumDocumento BIGINT,
					@strDireccion VARCHAR(50),
					@strTelefono VARCHAR(30),
					@strEmail VARCHAR(50),
					@idRolEmpleado INT,
					@dtmIngreso DATETIME,
					@dtmRetiro DATETIME,
					@strDatosAdicionales VARCHAR(250),
					@stmFechaModifica DATETIME,
					@strUsuarioModifico VARCHAR(30)
AS

IF NOT EXISTS (SELECT idEmpleado FROM tblEmpleado AS e INNER JOIN tblRoles AS r ON e.idRolEmpleado=r.idRolEmpleado 
				WHERE strNombre=@strNombre)

INSERT INTO tblEmpleado(
	strNombre,
	numDocumento,
	strDireccion,
	strTelefono,
	strEmail,
	idRolEmpleado,
	dtmIngreso,
	dtmRetiro,
	strDatosAdicionales,
	stmFechaModifica,
	strUsuarioModifico
	)
VALUES(
	@strNombre,
	@numDocumento,
	@strDireccion,
	@strTelefono,
	@strEmail,
	@idRolEmpleado,
	@dtmIngreso,
	@dtmRetiro,
	@strDatosAdicionales,
	@stmFechaModifica,
	@strUsuarioModifico
	)
ELSE
UPDATE tblEmpleado
SET strNombre=@strNombre,
	numDocumento=@numDocumento,
	strDireccion=@strDireccion,
	strTelefono=@strTelefono,
	strEmail=@strEmail,
	idRolEmpleado=@idRolEmpleado,
	dtmIngreso=@dtmIngreso,
	dtmRetiro=@dtmRetiro,
	strDatosAdicionales=@strDatosAdicionales,
	stmFechaModifica=@stmFechaModifica,
	strUsuarioModifico=@strUsuarioModifico
WHERE strNombre=@strNombre
GO