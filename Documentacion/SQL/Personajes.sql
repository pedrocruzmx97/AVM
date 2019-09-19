
CREATE TABLE tbl_Personal
(
Activo int null,--Verifica si esta o no activo en el sistema
Conesteto int null,--Verifica si conesto la encuesta
pk_Personal int PRIMARY KEY IDENTITY (1, 1) ,
Contrasena nchar(50) NOT NULL,
Nombre varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
FechaNacimiento date NOT NULL,
Genero int NOT NULL,
Direccion varchar(100) NOT NULL,
Correo varchar(100) NOT NULL,
Telefono varchar(20) NOT NULL,
Area varchar(40) NOT NULL,
Turno varchar(20) NOT NULL,
Foto image null
)
GO
CREATE TABLE tbl_Administrador
(
pk_Administrador int PRIMARY KEY IDENTITY (1, 1) ,
Activo int null,--Verifica si esta o no activo en el sistema
Contrasena nchar(50) NOT NULL,
Nombre varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
Genero int NOT NULL,
Direccion varchar(100) NOT NULL,
Correo varchar(100) NOT NULL,
Telefono varchar(20) NOT NULL,
Foto image null
)
GO
CREATE TABLE ceAlumnos
(
alu_ID int PRIMARY KEY IDENTITY (1, 1) ,
alu_E1 int null,
alu_E2 int null,
alu_E3 int null,
alu_Rol int null,
alu_NumControl varchar(9) null,
alu_Nombre varchar(60)  NULL,
alu_ApePaterno varchar(20)  NULL,
alu_ApeMaterno varchar(20)  NULL,
alu_Sexo char(1)  null,
esp_Id tinyint  null,
pes_Id tinyint  null,
alu_CreditosAcum smallint null,
alu_StatusAct char(2) null,
alu_SemestreAct char(2) null,
per_ID_Ingreso tinyint null,
alu_inscrito char(1) null,
alu_Preinscrito char(1) null,
alu_CreditosActu tinyint null,
alu_AnioIngreso char(4) null,
per_ID_Termin tinyint null,
alu_AnioTermin char(4)null,
alu_Password varchar(40) null,
alu_MotivoBaja varchar(50)null,
alu_ClaveAutorizSem varchar(15) null,
alu_SemProrro tinyint null,
per_ID_BajaTem tinyint null,
alu_AnioBajaTem smallint null,
alu_FolioCertificado char(10) null,
alu_LibroCertificado char(10) null,
alu_aFojasCertificado char(10) null,
alu_FechaCertificado char(10) null,
moe_ID tinyint null,
alu_SemAutorizado tinyint null,
alu_CruceHoras tinyint null,
alu_Foto image null,
alu_FotoNombre  varchar(50),
alu_InsBProtesta bit null,
alu_Bloqueado bit null,
tut_ID int null
)
GO
CREATE TABLE tbl_Especialista
(
pk_Especialista int PRIMARY KEY IDENTITY (1, 1) ,
Activo int NULL,
Cedula nvarchar(20)  NULL,
Numero_Control nchar(50)  NULL,
Contrasena nchar(50)  NULL,
Nombre varchar(50)  NULL,
Apellido varchar(50)  NULL,
FechaNacimiento date  NULL,
Genero int  NULL,
Direccion varchar(100)  NULL,
Correo varchar(100)  NULL,
Telefono varchar(15)  NULL,
fk_Especialidad int  null,
Rol int  null
)
GO

