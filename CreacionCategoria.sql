USE dbFacturacion
GO


CREATE PROCEDURE creacionCategoria
					@strReferencia VARCHAR(20),
					@strDescripcion VARCHAR(50),
					@dtmFechaModifica DATETIME,
					@strUsuarioModifico VARCHAR(30)

AS

IF NOT EXISTS (SELECT idCategoria FROM tblCategoriaProd WHERE strDescripcion=@strDescripcion)

INSERT INTO tblCategoriaProd(
	strReferencia,
	strDescripcion,
	dtmFechaModifica,
	strUsuarioModifico
)
VALUES(
	@strReferencia,
	@strDescripcion,
	@dtmFechaModifica,
	@strUsuarioModifico
	)

ELSE

UPDATE tblCategoriaProd
SET strDescripcion=@strDescripcion
GO