
--Modifacion 26 de junio del 2017
--TBL Historial clinico:cambios se agregadon los campos de temperatura,ritmo cardiaco,Diasreposo.
--TBL Reservacion cambio: se agregadon campo tipo de usuario


--Modifacion 17 de agosto  del 2017
-- agregacion de la tabla de odontograma
CREATE TABLE tbl_HistorialCitas
(
pk_HistorialCitas int PRIMARY KEY IDENTITY (1, 1) ,
fk_Alumno varchar(40)  null,
fk_Especialista varchar(40)  null,
fk_Reservacion int null,
ResumenAntecedente varchar(1024)  null,
Talla float  null,
Temperatura float null,
Peso float  null,

RitmoCardiaco float null,
PresionArterial float  null,


ExploracionFisica nvarchar(4048) null,
Diagnostico nvarchar(4048)  null,
PlanDeTratamiento nvarchar(4048) null,


DiasReposo int null
)
CREATE TABLE tbl_HistorialCitas
(
pk_HistorialCitas int PRIMARY KEY IDENTITY (1, 1) ,
fk_Alumno varchar(40)  null,
fk_Especialista varchar(40)  null,
fk_Reservacion int null,
ResumenAntecedente text  null,
Talla decimal(5,2)  null,
Temperatura decimal(5,2) null,
Peso decimal(5,2)  null,

RitmoCardiaco float null,
PresionArterial float  null,


ExploracionFisica text null,
Diagnostico int  null,
PlanDeTratamiento text null,


DiasReposo int null
)


--Tablas de reservaciones

CREATE TABLE tbl_Horario
(
pk_Horario int PRIMARY KEY IDENTITY (1, 1) ,
Horario date not null
)


CREATE TABLE tbl_Reservacion
(
pk_Reservacion int PRIMARY KEY IDENTITY (1, 1) ,
ConsultaActiva int,
fk_Alumno varchar(40)  null,
fk_Especialista varchar(40)  null,
Fecha date  null,
fk_Horario int  null,

)


CREATE TABLE tbl_TipoUsuarioCita
(
pk_TipoUsuarioCita int PRIMARY KEY IDENTITY (1, 1) ,
descripcion varchar(40)  null
)

insert into tbl_TipoUsuarioCita values('Alumno');--1
insert into tbl_TipoUsuarioCita values('Familiar');--2
insert into tbl_TipoUsuarioCita values('Personal UPT');--3



CREATE TABLE tbl_EstadoCita
(
pk_EstadoCita int PRIMARY KEY IDENTITY (1, 1) ,
descripcion varchar(40)  null
)
insert into tbl_EstadoCita values('Cancelada');--1
insert into tbl_EstadoCita values('Activa');--2
insert into tbl_EstadoCita values('Emergencia');--3
insert into tbl_EstadoCita values('Completa');--4


CREATE TABLE tbl_Diagnostico
(
pk_Diagnostico int PRIMARY KEY IDENTITY (1, 1) ,
descripcion varchar(40)  null
)
insert into tbl_Diagnostico values('Fiebre');--1
insert into tbl_Diagnostico values('Dolor estomacal');--2
insert into tbl_Diagnostico values('Intoxicación');--3
insert into tbl_Diagnostico values('Gripe');--4


CREATE TABLE tbl_Odontograma
(
pk_Odontograma int PRIMARY KEY IDENTITY (1, 1) ,
fk_Especialista varchar(15) not null,
fk_Alumno varchar(15) not null,
Fecha date not null,
Diente varchar(5),
Diagnistico varchar(512),
Tratamiento varchar(512),
observaciones varchar(512)
)

