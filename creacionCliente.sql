USE dbFacturacion
GO


CREATE PROCEDURE creacionCliente
					@strNombre VARCHAR(50),
					@NumDocumento BIGINT,
					@strDireccion VARCHAR(50),
					@strTelefono VARCHAR(30),
					@strEmail VARCHAR(50),
					@dtmFechaModifica DATETIME,
					@strUsuarioModifico VARCHAR(30)
AS

IF NOT EXISTS (SELECT idCliente FROM tblClientes WHERE numDocumento=@NumDocumento)

INSERT INTO tblClientes(
	strNombre,
	numDocumento,
	strDireccion,
	strTelefono,
	strEmail,
	dtmFechaModifica,
	strUsuarioModifico
)
VALUES(
	@strNombre,
	@numDocumento,
	@strDireccion,
	@strTelefono,
	@strEmail,
	@dtmFechaModifica,
	@strUsuarioModifico
	)

ELSE

UPDATE tblClientes
SET numDocumento=@NumDocumento
GO