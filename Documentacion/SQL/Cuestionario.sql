create database A_Hospital

use A_Hospital

-------------------------------------------------------------------------------------
-------------Tablas generales--------------------------------------------------------
create table tbl_g1(
pk_tbl_g1 int PRIMARY KEY IDENTITY (1, 1) ,
descripcion varchar(20) null
)
insert into tbl_g1 values('Menos de 6 meses');
insert into tbl_g1 values('Menos de un a�o');
insert into tbl_g1 values('Un a�o o mas');
insert into tbl_g1 values('Nunca');

 create table tbl_g2(
 pk_tbl_g2 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(20) null
 )
 insert into tbl_g2 values('Muy buena');
 insert into tbl_g2 values('Buena');
 insert into tbl_g2 values('Mala');
 insert into tbl_g2 values('Muy mala');

  create table tbl_g3(
 pk_tbl_g3 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(20)null
 )
 insert into tbl_g3 values ('1 al dia');
 insert into tbl_g3 values ('2 al dia');
 insert into tbl_g3 values ('3 al dia');
 insert into tbl_g3 values ('Ninguna');

  create table tbl_g4(
 pk_tbl_g4 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(30) null
 )
 insert into tbl_g4 values('1 Comida');
 insert into tbl_g4 values('2 Comidas');
 insert into tbl_g4 values('3 Comidas');
 insert into tbl_g4 values('4 o mas comidas');

  create table tbl_g5(
 pk_tbl_g5 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(30) null
 )
 insert into tbl_g5 values('3 o mas veces por semana');
 insert into tbl_g5 values('Una vez a la semana');
 insert into tbl_g5 values('Una vez cada 15 dias');
 insert into tbl_g5 values('Una vez al mes');
 insert into tbl_g5 values('Nunca');
 --tipos de sanre
  create table tbl_g6(
 pk_tbl_g6 int  PRIMARY KEY IDENTITY (1, 1) ,
 Tipo varchar(50)
 )
 insert into tbl_g6 values('A Positiva');
 insert into tbl_g6 values('A Negativo');
 insert into tbl_g6 values('B Positivo');
 insert into tbl_g6 values('B Negativo');
 insert into tbl_g6 values('O Positivo');
 insert into tbl_g6 values('O Negativo');
 insert into tbl_g6 values('AB Positivo');
 insert into tbl_g6 values('AB Negativo');
 insert into tbl_g6 values('No se');
 ----------------------------------------------------------------------------------------------------------------<<<
   create table tbl_g7(
 pk_tbl_g7 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(30) null
 )
 insert into tbl_g7 values('2 o mas veces a la semana');
 insert into tbl_g7 values('Una ves a la semana');
 insert into tbl_g7 values('Una vez al mes');
 insert into tbl_g7 values('Nunca');

  create table tbl_g8(
 pk_tbl_g8 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g8 values('Diario')
 insert into tbl_g8 values('Una o mas por semana')
 insert into tbl_g8 values('Una vez o mas por mes')
 insert into tbl_g8 values('Nunca')

 create table tbl_g9(
 fk_tbl_g9 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )

 insert into tbl_g9 values('Diario')
 insert into tbl_g9 values('Una o mas por semana')
 insert into tbl_g9 values('Una vez o mas por mes')
 insert into tbl_g9 values('Nunca')

  create table tbl_g10(
 pk_tbl_g10 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50) null
 )

 ----------------------------------------------------------------------------------------------------------<<<<<<<<<<<<<<<<<<<<<cie 10
  create table tbl_g11(
 pk_tbl_g11 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g11 values('Diario')
 insert into tbl_g11 values('Cada tercer dia')
 insert into tbl_g11 values('Cada semana')
 insert into tbl_g11 values('Cada 15 dias')

  create table tbl_g12(
 pk_tbl_g12 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50) null
 )
 insert into tbl_g12 values ('Ba�o con drenaje')
 insert into tbl_g12 values ('Letrina')
 insert into tbl_g12 values ('Fosa Septica')
 insert into tbl_g12 values ('Ras de suelo')

  create table tbl_g13(
  pk_tbl_g13 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50) null
 )
 insert into tbl_g13 values('Muy satisfecho');
 insert into tbl_g13 values('Satisfecho');
 insert into tbl_g13 values('Poco satisfecho');
 insert into tbl_g13 values('Insatisfecho');


  create table tbl_g14(
   pk_tbl_g14 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g14 values ('Buena')
 insert into tbl_g14 values ('Regular')
 insert into tbl_g14 values ('Mala')
 insert into tbl_g14 values ('Sin Relacion')

 

 create table tbl_g15(
pk_tbl_g15 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g15 values('Muy buena')
 insert into tbl_g15 values('Buena')
 insert into tbl_g15 values('Mala')
 insert into tbl_g15 values('Muy mala')

 create table tbl_g16(
pk_tbl_g16 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g16 values('Mayor')
 insert into tbl_g16 values('Intermedio')
 insert into tbl_g16 values('Menor')
 insert into tbl_g16 values('Unico')

 create table tbl_g17(
pk_tbl_g17 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g17 values('Papas')
 insert into tbl_g17 values('Familiares o Amigos')
 insert into tbl_g17 values('Casa de huespedes')
 insert into tbl_g17 values('Solo')


 create table tbl_g18(
pk_tbl_g18 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g18 values('Hetero Sexual')
 insert into tbl_g18 values('Homosexual')
 insert into tbl_g18 values('Bisexual')
 insert into tbl_g18 values('Otro')

 create table tbl_g19(
pk_tbl_g19 int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(50)
 )
 insert into tbl_g19 values('Menos de 2 horas')
 insert into tbl_g19 values('De 2 a 5 horas')
 insert into tbl_g19 values('De 5 a 8 horas')
 insert into tbl_g19 values('Mas de 8 horas')

 create table tbl_alergia(
pk_alergia int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(100)
 )
 insert into tbl_alergia values('Ninguno');
  insert into tbl_alergia values('Otra');
 insert into tbl_alergia values('Alergia a los �caros');
 insert into tbl_alergia values('Alergia al polen');
 insert into tbl_alergia values('Alergia al pelo de animales');
 insert into tbl_alergia values('Alergia a las picaduras de insectos');
 insert into tbl_alergia values('Alergia al moho');
 insert into tbl_alergia values('Alergia a alimentos (cacahuetes, marisco, leche, etc.)');
 insert into tbl_alergia values('Alergia al l�tex');
 insert into tbl_alergia values('Alergia a fragancias');

 create table tbl_efermedad(
pk_enferdad int  PRIMARY KEY IDENTITY (1, 1) ,
 Descripcion varchar(100)
 )
 insert into tbl_efermedad values('Ninguna');
 insert into tbl_efermedad values('Otra');
 insert into tbl_efermedad values('Enfermedades del Coraz�n');
 insert into tbl_efermedad values('Diabetes Mellitus');
 insert into tbl_efermedad values('Tumores Malignos');
 insert into tbl_efermedad values('Enfermedades Cerebrovasculares');
 insert into tbl_efermedad values('Enfermedades Pulmonares ');
 insert into tbl_efermedad values('Enfermedades del H�gado');
 insert into tbl_efermedad values('Influenza');
 insert into tbl_efermedad values('Afecciones originadas en el periodo perinatal');
 insert into tbl_efermedad values('Insuficiencia Renal');
 insert into tbl_efermedad values('Obesidad');

----------------------------------------Cuestionario-------------------
------------------------------------------------------------------------------------------
 ----------------------------------------Cuestionario de m�dico-------------------
--1.-ALIMENTACION 
--2.-CUANTAS VECES A LA SEMANA REALIZAS EJECICIO
--3.-TIPO DE SANGRE  	GRUPO SANGUINEO
--4.-CON QUE FRECUENCIAS CONSUMES BEBIDAS  ALCOHOLICAS
--5.-CON QUE FRECUENCIA FUMAS TABACO
--6.-CONSUMES ALGUNA DROGA ILEGAL (MARIHUANA , COCAINA , ACIDOS (LCD),   INHALANTES ETC )
--7.-TIENES ALGUNA ALERGIA?
--8.-QUE ENFERMEDAD  PADECES ?------->> cie10
--9.-CON QUE FRECUENCIA TE BA�AS
--10.-QUE TIPO DE BA�O HAY DONDE VIVES
--11.-VIVES EN LUGARES  CON ENFERMEDAES TRASMITIDAS POR COMO EL DENGE, PALUDISMO, ETC.)
--12.-[ESTAS EN ALG�N TRATAMIENTO HORMONAL]
--13.-[TOMAS ANTICONCEPTIVOS]------------13/06/15 en caso que si indicar que tipo

--14.-"QUIRURGICOS  	ALGUNA VEZ TE PRACTICARON ALGUNA CIRUGIA�"   ------------13/06/15 especidicar que tipo de cirujia**
--15.-"TRANSFUCIONES  	INDICA SI ALGUNA VEZ TE HAN TRANSFUNDIDO SANGRE"
--16.-ESTAS EN CONTACTO DIRECTO CON PACIENTES DIAGNOSTICADOS CON VIH O TUBERCULOSIS.
--17.-CUAL ES TU ESTATURA (METROS)
--18.-INDICA TU PESO EN KILOS
--19CALCULO IMC = KILOS/(M*M)  ESTADISTICA (RANGO )
--20.-[TU REGLA ES REGULAR (CADA MES APROXIMADAMENTE)]
--21.-[�ESTAS EMBARAZADA?]
--22.-�ESTAS LACTANDO? (DANDO PECHO)

--23-.TUS ABUELOS PADECIERON ALGUNAS DE ESTAS ENFERMEDADES ------------13/06/15 incluir el no se*
--24.-TUS PADRES PADECEN  ALGUNAS DE ESTAS ENFERMEDADES    ------------13/06/15 incluir el no se*
--25.-TUS HERMANOS, PRIMOS Y TIOS  PADECEN  ALGUNAS DE ESTAS ENFERMEDADES ------------13/06/15 incluir el no se*

 ---------------------------------------------------------------------------------------------------------
 ---------------------------------------------------------------------Psicologico-----------------
 
 ----------------------------------------Cuestionario de Psicologico-------------------
--1.�LA UNIVERSIDAD POLITECNICA DE TULANCINGO FUE TU PRIMERA OPCION?
--2.-�LA CARRERA QUE ELEGISTE FUE TU PRIMERA OPCION?
--3.-QUE TAN SATISFECHO ESTAS CON LA ELECCI�N DE CARRERA
--4.-SABES CUAL ES TU PERFIL VOCACIONAL
--5.-COMO ES TU RELACI�N CON TUS ABUELOS
--6.-COMO ES LA RELACI�N CON TU MAM�
--7.-COMO ES LA RELACI�N CON TU PAP�
--8.-COMO ES LA RELACI�N CON TUS HERMANOS
--9.-CUAL ES EL ACONTECIMIENTO M�S RELEVANTE DE TU INFANCIA (0-9 A�OS)
--10.-CUAL ES EL ACONTECIMIENTO M�S RELEVANTE DE TU ADOLESCENCIA (10-19 A�OS)
--11.-COMO CONSIDERAS QUE ES TU AUTOESTIMA
--12.-COMO CONSIDERAS TU CAPACIDAD PARA RELACIONARTE CON OTRAS PERSONAS?
--13.-TIENES UN PROYECTO DE VIDA?
--14.-TE GUSTAR�A RECIBIR ORIENTACI�N PSICOL�GICA
--15.-NUMERO DE HIJO QUE ERES
--16.-CON QUIEN VIVES ACTUALMENTE
--17.-CUALES SON TUS PREFERENCIAS SEXUALES
--18.-HAS ASISTIDO A TERAPIA PSICOL�GICA ANTERIORMENTE
--19.-CUANTAS HORAS DUERMES DIARIAMENTE

create table Dental(
 pk_Dental int  PRIMARY KEY IDENTITY (1, 1) ,
 fk_Alumno nvarchar(40) null,
 --1.-CUANDO FUE LA ULTIMA VEZ QUE ACUDISTE AL DENTISTA
 fk_tbl_g1 int null,--1
 --2.-MOTIVO DE TU ULTIMA CONSULTA �DENTAL.
 p2dDiagnostoco int null,--2
 p2dCaries int null,--2
 p2dProfiliaxis int null,--2
 p2dDolorDeMuelas int null,--2
 p2dGingivitis int null,--2
 p2dTratamientos int null,--2
 p2dEdolencias int null,--2
 p2dNinguno int null,--2
 --3.-�COMO CALIFICA SU BOCA?
 fk_tbl_g2 int null,--3
 --4.-�CUANTAS VECES AL DIA CEPILLA SUS DIENTES?
 fk_tbl_g3 int null,--4
 --5.-TE TRUENA LA MANDIBULA  CUANDO ABRES MUCHO LA BOCA
 pd5 int null,--5
 --6.-TE SANGRAN LAS ENCIAS CUANDO TE CEPILLAS LOS DIENTES?
 pd6 int null,--6
 --7.-TIENE DIFICULTAD PARA ABRIR LA BOCA EN ALGUNAS OCASIONES
 pd7 int null,--7
 --8.-SE HA QUEDADO ALGUNA VEZ CON LA BOCA ABIERTA Y HA TENIDO INCAPACIDAD PARA CERRARLA
 pd8 int null,--8
 --9.-HAS TENIDO PERFORACIONES EN BOCA (PIERCINGS)
 pd9 int null,--9
 --10.-HAS PRESENTADO MAL ALIENTO?
 pd10 int null,	--10
 --11.-TIENES H�BITO DE MORDERTE LAS U�AS, APRETAR O TALLRTE LOS DIENTES O MORDER OBJETOS?
 pd11 int null--11
 )


 

 create table Medico(
  pk_Medico int  PRIMARY KEY IDENTITY (1, 1) ,
 fk_Alumno nvarchar(40) null,
--1.-ALIMENTACION 
 fk_tbl_g4 int null,--1
--2.-CUANTAS VECES A LA SEMANA REALIZAS EJECICIO
 fk_tbl_g5 int null,--2
--3.-TIPO DE SANGRE  	GRUPO SANGUINEO
 fk_tbl_g6 int null,--3
--4.-CON QUE FRECUENCIAS CONSUMES BEBIDAS  ALCOHOLICAS
 fk_tbl_g7 int null,--4
--5.-CON QUE FRECUENCIA FUMAS TABACO
 fk_tbl_g8 int null,--5
--6.-CONSUMES ALGUNA DROGA ILEGAL (MARIHUANA , COCAINA , ACIDOS (LCD),   INHALANTES ETC )
 fk_tbl_g9 int null,--6
--7.-TIENES ALGUNA ALERGIA?
 pm7 nvarchar(100) null,--7
 --8.-QUE ENFERMEDAD  PADECES ?------->> cie10
 fk_tbl_g10 int null,--8
 --9.-CON QUE FRECUENCIA TE BA�AS
 fk_tbl_g11 int null,--9
 --10.-QUE TIPO DE BA�O HAY DONDE VIVES
 fk_tbl_g12 int null,--10
 --11.-VIVES EN LUGARES  CON ENFERMEDAES TRASMITIDAS POR COMO EL DENGE, PALUDISMO, ETC.)
 pm11 int null,--11
 --12.-[ESTAS EN ALG�N TRATAMIENTO HORMONAL]
 pm12 int null,--12
 --13.-[TOMAS ANTICONCEPTIVOS]
 pm13 int null,--13
 --14.-"QUIRURGICOS  	ALGUNA VEZ TE PRACTICARON ALGUNA CIRUGIA�"
 pm14 int null,--14
 --15.-"TRANSFUCIONES  	INDICA SI ALGUNA VEZ TE HAN TRANSFUNDIDO SANGRE"
 pm15 int null,--15
 --16.-ESTAS EN CONTACTO DIRECTO CON PACIENTES DIAGNOSTICADOS CON VIH O TUBERCULOSIS.
 pm16 int null,--16
 --17.-CUAL ES TU ESTATURA (METROS)
 pm17 float null,--17
 --18.-INDICA TU PESO EN KILOS
 pm18 float null,--18
 --19CALCULO IMC = KILOS/(M*M)  ESTADISTICA (RANGO )
 pm19 float null,--19---> se calcula
 --20.-[TU REGLA ES REGULAR (CADA MES APROXIMADAMENTE)]
 pm20 int null,--20
 --21.-[�ESTAS EMBARAZADA?]
 pm21 int null,--21
 --22.-�ESTAS LACTANDO? (DANDO PECHO)
 pm22 int null,--22
 --23-.TUS ABUELOS PADECIERON ALGUNAS DE ESTAS ENFERMEDADES 
 pm23DIABETES_MELLITUS int null,--23
 pm23HIPERTENSION_ARTERIAL int null,
 pm23CARDIOPATIAS int null, 
 pm23CANCER int null,
 pm23EPILEPSIA int null,
 pm23ENFERMEDADES_AUTOINMUNES int null, 
 pm23ENFERMEDADES_PSIQUI�TRICAS int null,
 pm23ENFERMEDADES_SANGRE int null,
 m23NingunoA int null,
 --24.-TUS PADRES PADECEN  ALGUNAS DE ESTAS ENFERMEDADES 
 pm24DIABETES_MELLITUS int null,--24
 pm24HIPERTENSION_ARTERIAL int null,
 pm24CARDIOPATIAS int null,
 pm24CANCER int  null,
 pm24EPILEPSIA int null,
 pm24ENFERMEDADES_AUTOINMUNES int null,
 pm24ENFERMEDADES_PSIQUI�TRICAS int null,
 pm24ENFERMEDADES_SANGRE int null,
 m24NingunoA int null,
 --25.-TUS HERMANOS, PRIMOS Y TIOS  PADECEN  ALGUNAS DE ESTAS ENFERMEDADES 
 pm25DIABETES_MELLITUS int null,--23
 pm25HIPERTENSION_ARTERIAL int null,
 pm25CARDIOPATIAS int null, 
 pm25CANCER int null,
 pm25EPILEPSIA int null,
 pm25ENFERMEDADES_AUTOINMUNES int null, 
 pm25ENFERMEDADES_PSIQUI�TRICAS int null,
 pm25ENFERMEDADES_SANGRE int null,
 m25NingunoA int null
 )
 
  create table Psicologico(

   pk_Psicologico int  PRIMARY KEY IDENTITY (1, 1) ,
 fk_Alumno nvarchar(40) null,
 --1.�LA UNIVERSIDAD POLITECNICA DE TULANCINGO FUE TU PRIMERA OPCION?
 pp1 int null, --1
 --2.-�LA CARRERA QUE ELEGISTE FUE TU PRIMERA OPCION?
 pp2 int null, --2
 --3.-QUE TAN SATISFECHO ESTAS CON LA ELECCI�N DE CARRERA
 fk_tbl_g13 int null, --3
 --4.-SABES CUAL ES TU PERFIL VOCACIONAL
 pp4 int null, --4
 --5.-COMO ES TU RELACI�N CON TUS ABUELOS
  tbl_g14_5 int null, --5
  --6.-COMO ES LA RELACI�N CON TU MAM�
  tbl_g14_6 int null, --6
  --7.-COMO ES LA RELACI�N CON TU PAP�
  tbl_g14_7 int null, --7
  --8.-COMO ES LA RELACI�N CON TUS HERMANOS
  tbl_g14_8 int null, --8
  --9.-CUAL ES EL ACONTECIMIENTO M�S RELEVANTE DE TU INFANCIA (0-9 A�OS)
  pp9DivorcioPadres int null,--9
  pp9NacimmientoHermano int null,--9
  pp9FallecimientoAbuelo int null,--9
  pp9FallecimientoPadres int null,--9
  pp9FallecimientoHermanos int null,--9
  pp9FallecimientoFamiliar int null,--9
  pp9AusenciaDePadre int null,--9
  pp9AusenciaDeMadre int null,--9
  pp9CambioDeDomicilio int null,--9
  pp9ViolenciaFamiliar int null,--9
  pp9AbusoSexual int null,--9
  pp9VictimaBullying int null,--9
  pp9Ninguno int null,--9
  --10.-CUAL ES EL ACONTECIMIENTO M�S RELEVANTE DE TU ADOLESCENCIA (10-19 A�OS)
  pp10DivorcioPadres int null,--10
  pp10NacimmientoHermano int null,--10
  pp10FallecimientoAbuelo int null,--10
  pp10FallecimientoPadres int null,--10
  pp10FallecimientoHermanos int null,--10
  pp10FallecimientoFamiliar int null,--10
  pp10AusenciaDePadre int null,--10
  pp10AusenciaDeMadre int null,--10
  pp10CambioDeDomicilio int null,--10
  pp10ViolenciaFamiliar int null,--10
  pp10AbusoSexual int null,--10
  pp10VictimaBullying int null,--10
  pp10Ninguno int null,--10
  --11.-COMO CONSIDERAS QUE ES TU AUTOESTIMA
  fk_tbl_g15_1 int null, --11
  --12.-COMO CONSIDERAS TU CAPACIDAD PARA RELACIONARTE CON OTRAS PERSONAS?
  fk_tbl_g15_2 int null, --12
  --13.-TIENES UN PROYECTO DE VIDA?
  pp13 int null, --13
  --14.-TE GUSTAR�A RECIBIR ORIENTACI�N PSICOL�GICA
  pp14 int null, --14
  --15.-NUMERO DE HIJO QUE ERES
  fk_tbl_g16 int null, --15
  --16.-CON QUIEN VIVES ACTUALMENTE
  fk_tbl_g17  int null, --16
  --17.-CUALES SON TUS PREFERENCIAS SEXUALES
  fk_tbl_g18 int null, --17
  --18.-HAS ASISTIDO A TERAPIA PSICOL�GICA ANTERIORMENTE
  pp19 int null, --18
  --19.-CUANTAS HORAS DUERMES DIARIAMENTE
  fk_tbl_g19 int null --19
 )