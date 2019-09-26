USE dbFacturacion
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

select @@language
SET LANGUAGE Español
set dateformat dmy
GO

CREATE PROCEDURE actualizarSeguridad
						@idEmpleado INT,
						@strUsuario VARCHAR(20),
						@strClave VARCHAR(20),
						@dtmFechaModifica DATETIME,
						@strUsuarioModifico VARCHAR(30)
						
AS
--actualizaSeguridad[dbFacturacion]
IF NOT EXISTS (SELECT idEmpleado FROM tblSeguridad WHERE strUsuario=@strUsuario)

INSERT INTO tblSeguridad(
	idEmpleado,
	strUsuario,
	strClave,
	dtmFechaModifica,
	strUsuarioModifico
	)
VALUES(
	@idEmpleado,
	@strUsuario,
	@strClave,
	@dtmFechaModifica,
	@strUsuarioModifico
	)

ELSE

UPDATE tblSeguridad
SET idEmpleado=@idEmpleado,
	strUsuario=@strUsuario,
	strClave=@strClave,
	dtmFechaModifica=@dtmFechaModifica,
	strUsuarioModifico=@strUsuarioModifico
WHERE strUsuario=@strUsuario
GO