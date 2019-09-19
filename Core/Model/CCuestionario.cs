using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using Core.Model;


namespace Core.Model
{
    public class CCuestionario
    {
        ManagerBD objManagerBD;

        public CCuestionario()
        {
            objManagerBD = new ManagerBD();
        }
        #region Reguistros
        public bool ReguistroDental( CCuestionario obj)
        {

           List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = 1 });
            lstParametros.Add(new SqlParameter("@fk_alumno", SqlDbType.NVarChar, 40) { Value = obj.fk_alumno });
            lstParametros.Add(new SqlParameter("@fk_tbl_g1", SqlDbType.Int) { Value = obj.fk_tbl_g1 });
            lstParametros.Add(new SqlParameter("@p2dDiagnostoco", SqlDbType.Int) { Value = obj.p2dDiagnostoco });
            lstParametros.Add(new SqlParameter("@p2dCaries", SqlDbType.Int) { Value = obj.p2dCaries });
            lstParametros.Add(new SqlParameter("@p2dProfiliaxis", SqlDbType.Int) { Value = obj.p2dProfiliaxis });
            lstParametros.Add(new SqlParameter("@p2dDolorDeMuelas", SqlDbType.Int) { Value = obj.p2dDolorDeMuelas });
            lstParametros.Add(new SqlParameter("@p2dGingivitis", SqlDbType.Int) { Value = obj.p2dGingivitis });
            lstParametros.Add(new SqlParameter("@p2dTratamientos", SqlDbType.Int) { Value = obj.p2dTratamientos });
            lstParametros.Add(new SqlParameter("@p2dEdolencias", SqlDbType.Int) { Value = obj.p2dEdolencias });
            lstParametros.Add(new SqlParameter("@p2dNinguno", SqlDbType.Int) { Value = obj.p2dNinguno });
            lstParametros.Add(new SqlParameter("@fk_tbl_g2", SqlDbType.Int) { Value = obj.fk_tbl_g2 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g3", SqlDbType.Int) { Value = obj.fk_tbl_g3 });
            lstParametros.Add(new SqlParameter("@pd5", SqlDbType.Int) { Value = obj.pd5 });
            lstParametros.Add(new SqlParameter("@pd6", SqlDbType.Int) { Value = obj.pd6 });
            lstParametros.Add(new SqlParameter("@pd7", SqlDbType.Int) { Value = obj.pd7 });
            lstParametros.Add(new SqlParameter("@pd8", SqlDbType.Int) { Value = obj.pd8 });
            lstParametros.Add(new SqlParameter("@pd9", SqlDbType.Int) { Value = obj.pd9 });
            lstParametros.Add(new SqlParameter("@pd10", SqlDbType.Int) { Value = obj.pd10 });
            lstParametros.Add(new SqlParameter("@pd11", SqlDbType.Int) { Value = obj.pd11 });
            objManagerBD = new ManagerBD();

            if (objManagerBD.UpdateData("MiCuestionario", lstParametros.ToArray())) {
                return true;
            }
             
            
            return false;
        }
        public bool ReguistroMedico( CCuestionario obj)
        {

            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op ", SqlDbType.Int) { Value = 2 });
            lstParametros.Add(new SqlParameter("@fk_alumno", SqlDbType.NVarChar, 40) { Value = obj.fk_alumno });
            lstParametros.Add(new SqlParameter("@fk_tbl_g4 ", SqlDbType.Int) { Value = obj.fk_tbl_g4 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g5 ", SqlDbType.Int) { Value = obj.fk_tbl_g5 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g6 ", SqlDbType.Int) { Value = obj.fk_tbl_g6 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g7 ", SqlDbType.Int) { Value = obj.fk_tbl_g7 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g8 ", SqlDbType.Int) { Value = obj.fk_tbl_g8 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g9 ", SqlDbType.Int) { Value = obj.fk_tbl_g9 });
            lstParametros.Add(new SqlParameter("@pm7 ", SqlDbType.NVarChar, 100) { Value = obj.pm7 });
            lstParametros.Add(new SqlParameter("@fk_enferdad", SqlDbType.Int) { Value = obj.fk_enferdad });//cambio 17-06-17 cambio de tabla tbl_enferdad
            lstParametros.Add(new SqlParameter("@fk_tbl_g11 ", SqlDbType.Int) { Value = obj.fk_tbl_g11 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g12 ", SqlDbType.Int) { Value = obj.fk_tbl_g12 });
            lstParametros.Add(new SqlParameter("@pm11 ", SqlDbType.Int) { Value = obj.pm11 });
            lstParametros.Add(new SqlParameter("@pm12 ", SqlDbType.Int) { Value = obj.pm12 });
            lstParametros.Add(new SqlParameter("@pm13 ", SqlDbType.Int) { Value = obj.pm13 });
            lstParametros.Add(new SqlParameter("@pm14 ", SqlDbType.Int) { Value = obj.pm14 });
            lstParametros.Add(new SqlParameter("@pm15 ", SqlDbType.Int) { Value = obj.pm15 });
            lstParametros.Add(new SqlParameter("@pm16 ", SqlDbType.Int) { Value = obj.pm16 });
            lstParametros.Add(new SqlParameter("@pm17 ", SqlDbType.Float) { Value = obj.pm17 });
            lstParametros.Add(new SqlParameter("@pm18 ", SqlDbType.Float) { Value = obj.pm18 });
            lstParametros.Add(new SqlParameter("@pm19 ", SqlDbType.Float) { Value = obj.pm19 });
            lstParametros.Add(new SqlParameter("@pm20 ", SqlDbType.Int) { Value = obj.pm20 });
            lstParametros.Add(new SqlParameter("@pm21 ", SqlDbType.Int) { Value = obj.pm21 });
            lstParametros.Add(new SqlParameter("@pm22 ", SqlDbType.Int) { Value = obj.pm22 });

            lstParametros.Add(new SqlParameter("@pm23DIABETES_MELLITUS ", SqlDbType.Int) { Value = obj.pm23DIABETES_MELLITUS });
            lstParametros.Add(new SqlParameter("@pm23HIPERTENSION_ARTERIAL ", SqlDbType.Int) { Value = obj.pm23HIPERTENSION_ARTERIAL });
            lstParametros.Add(new SqlParameter("@pm23CARDIOPATIAS  ", SqlDbType.Int) { Value = obj.pm23CARDIOPATIAS });
            lstParametros.Add(new SqlParameter("@pm23CANCER ", SqlDbType.Int) { Value = obj.pm23CANCER });
            lstParametros.Add(new SqlParameter("@pm23EPILEPSIA ", SqlDbType.Int) { Value = obj.pm23EPILEPSIA });
            lstParametros.Add(new SqlParameter("@pm23ENFERMEDADES_AUTOINMUNES ", SqlDbType.Int) { Value = obj.pm23ENFERMEDADES_AUTOINMUNES });
            lstParametros.Add(new SqlParameter("@pm23ENFERMEDADES_PSIQUIÁTRICAS ", SqlDbType.Int) { Value = obj.pm23ENFERMEDADES_PSIQUIÁTRICAS });
            lstParametros.Add(new SqlParameter("@pm23ENFERMEDADES_SANGRE ", SqlDbType.Int) { Value = obj.pm23ENFERMEDADES_SANGRE });
            lstParametros.Add(new SqlParameter("@pm23NOSE", SqlDbType.Int) { Value = obj.pm23NOSE });
            lstParametros.Add(new SqlParameter("@pm23Ninguno ", SqlDbType.Int) { Value = obj.pm23Ninguno });

            lstParametros.Add(new SqlParameter("@pm24DIABETES_MELLITUS ", SqlDbType.Int) { Value = obj.pm24DIABETES_MELLITUS });
            lstParametros.Add(new SqlParameter("@pm24HIPERTENSION_ARTERIAL ", SqlDbType.Int) { Value = obj.pm24HIPERTENSION_ARTERIAL });
            lstParametros.Add(new SqlParameter("@pm24CARDIOPATIAS ", SqlDbType.Int) { Value = obj.pm24CARDIOPATIAS });
            lstParametros.Add(new SqlParameter("@pm24CANCER ", SqlDbType.Int) { Value = obj.pm24CANCER });
            lstParametros.Add(new SqlParameter("@pm24EPILEPSIA ", SqlDbType.Int) { Value = obj.pm24EPILEPSIA });
            lstParametros.Add(new SqlParameter("@pm24ENFERMEDADES_AUTOINMUNES ", SqlDbType.Int) { Value = obj.pm24ENFERMEDADES_AUTOINMUNES });
            lstParametros.Add(new SqlParameter("@pm24ENFERMEDADES_PSIQUIÁTRICAS ", SqlDbType.Int) { Value = obj.pm24ENFERMEDADES_PSIQUIÁTRICAS });
            lstParametros.Add(new SqlParameter("@pm24ENFERMEDADES_SANGRE ", SqlDbType.Int) { Value = obj.pm24ENFERMEDADES_SANGRE });
            lstParametros.Add(new SqlParameter("@pm24NOSE", SqlDbType.Int) { Value = obj.pm24NOSE });
            lstParametros.Add(new SqlParameter("@pm24Ninguno ", SqlDbType.Int) { Value = obj.pm24Ninguno });

            lstParametros.Add(new SqlParameter("@pm25DIABETES_MELLITUS ", SqlDbType.Int) { Value = obj.pm25DIABETES_MELLITUS });
            lstParametros.Add(new SqlParameter("@pm25HIPERTENSION_ARTERIAL ", SqlDbType.Int) { Value = obj.pm25HIPERTENSION_ARTERIAL });
            lstParametros.Add(new SqlParameter("@pm25CARDIOPATIAS  ", SqlDbType.Int) { Value = obj.pm25CARDIOPATIAS });
            lstParametros.Add(new SqlParameter("@pm25CANCER ", SqlDbType.Int) { Value = obj.pm25CANCER });
            lstParametros.Add(new SqlParameter("@pm25EPILEPSIA ", SqlDbType.Int) { Value = obj.pm25EPILEPSIA });
            lstParametros.Add(new SqlParameter("@pm25ENFERMEDADES_AUTOINMUNES  ", SqlDbType.Int) { Value = obj.pm25ENFERMEDADES_AUTOINMUNES });
            lstParametros.Add(new SqlParameter("@pm25ENFERMEDADES_PSIQUIÁTRICAS ", SqlDbType.Int) { Value = obj.pm25ENFERMEDADES_PSIQUIÁTRICAS });
            lstParametros.Add(new SqlParameter("@pm25ENFERMEDADES_SANGRE  ", SqlDbType.Int) { Value = obj.pm25ENFERMEDADES_SANGRE });
            lstParametros.Add(new SqlParameter("@pm25NOSE", SqlDbType.Int) { Value = obj.pm25NOSE });
            lstParametros.Add(new SqlParameter("@pm25Ninguno ", SqlDbType.Int) { Value = obj.pm25Ninguno });
             
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("MiCuestionario", lstParametros.ToArray()))
                return true;
            return false;
        }
        public bool ReguistroPsicologico( CCuestionario obj)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op ", SqlDbType.Int) { Value = 3 });
            lstParametros.Add(new SqlParameter("@fk_alumno", SqlDbType.NVarChar,40) { Value = obj.fk_alumno });
            lstParametros.Add(new SqlParameter("@pp1", SqlDbType.Int) { Value = obj.pp1 });
            lstParametros.Add(new SqlParameter("@pp2  ", SqlDbType.Int) { Value = obj.pp2 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g13  ", SqlDbType.Int) { Value = obj.fk_tbl_g13 });
            lstParametros.Add(new SqlParameter("@pp4", SqlDbType.Int) { Value = obj.pp4 });
            lstParametros.Add(new SqlParameter("@tbl_g14_5  ", SqlDbType.Int) { Value = obj.tbl_g14_5 });
            lstParametros.Add(new SqlParameter("@tbl_g14_6  ", SqlDbType.Int) { Value = obj.tbl_g14_6 });
            lstParametros.Add(new SqlParameter("@tbl_g14_7  ", SqlDbType.Int) { Value = obj.tbl_g14_7 });
            lstParametros.Add(new SqlParameter("@tbl_g14_8  ", SqlDbType.Int) { Value = obj.tbl_g14_8 });
            lstParametros.Add(new SqlParameter("@pp9DivorcioPadres ", SqlDbType.Int) { Value = obj.pp9DivorcioPadres });
            lstParametros.Add(new SqlParameter("@pp9NacimmientoHermano ", SqlDbType.Int) { Value = obj.pp9NacimmientoHermano });
            lstParametros.Add(new SqlParameter("@pp9FallecimientoAbuelo ", SqlDbType.Int) { Value = obj.pp9FallecimientoAbuelo });
            lstParametros.Add(new SqlParameter("@pp9FallecimientoPadres ", SqlDbType.Int) { Value = obj.pp9FallecimientoPadres });
            lstParametros.Add(new SqlParameter("@pp9FallecimientoHermanos ", SqlDbType.Int) { Value = obj.pp9FallecimientoHermanos });
            lstParametros.Add(new SqlParameter("@pp9FallecimientoFamiliar ", SqlDbType.Int) { Value = obj.pp9FallecimientoFamiliar });
            lstParametros.Add(new SqlParameter("@pp9AusenciaDePadre ", SqlDbType.Int) { Value = obj.pp9AusenciaDePadre });
            lstParametros.Add(new SqlParameter("@pp9AusenciaDeMadre ", SqlDbType.Int) { Value = obj.pp9AusenciaDeMadre });
            lstParametros.Add(new SqlParameter("@pp9CambioDeDomicilio ", SqlDbType.Int) { Value = obj.pp9CambioDeDomicilio });
            lstParametros.Add(new SqlParameter("@pp9ViolenciaFamiliar ", SqlDbType.Int) { Value = obj.pp9ViolenciaFamiliar });
            lstParametros.Add(new SqlParameter("@pp9AbusoSexual ", SqlDbType.Int) { Value = obj.pp9AbusoSexual });
            lstParametros.Add(new SqlParameter("@pp9VictimaBullying ", SqlDbType.Int) { Value = obj.pp9VictimaBullying });
            lstParametros.Add(new SqlParameter("@pp9Ninguno ", SqlDbType.Int) { Value = obj.pp9Ninguno });
            lstParametros.Add(new SqlParameter("@pp10DivorcioPadres ", SqlDbType.Int) { Value = obj.pp10DivorcioPadres });
            lstParametros.Add(new SqlParameter("@pp10NacimmientoHermano ", SqlDbType.Int) { Value = obj.pp10NacimmientoHermano });
            lstParametros.Add(new SqlParameter("@pp10FallecimientoAbuelo ", SqlDbType.Int) { Value = obj.pp10FallecimientoAbuelo });
            lstParametros.Add(new SqlParameter("@pp10FallecimientoPadres ", SqlDbType.Int) { Value = obj.pp10FallecimientoPadres });
            lstParametros.Add(new SqlParameter("@pp10FallecimientoHermanos ", SqlDbType.Int) { Value = obj.pp10FallecimientoHermanos });
            lstParametros.Add(new SqlParameter("@pp10FallecimientoFamiliar ", SqlDbType.Int) { Value = obj.pp10FallecimientoFamiliar });
            lstParametros.Add(new SqlParameter("@pp10AusenciaDePadre ", SqlDbType.Int) { Value = obj.pp10AusenciaDePadre });
            lstParametros.Add(new SqlParameter("@pp10AusenciaDeMadre ", SqlDbType.Int) { Value = obj.pp10AusenciaDeMadre });
            lstParametros.Add(new SqlParameter("@pp10CambioDeDomicilio ", SqlDbType.Int) { Value = obj.pp10CambioDeDomicilio });
            lstParametros.Add(new SqlParameter("@pp10ViolenciaFamiliar ", SqlDbType.Int) { Value = obj.pp10ViolenciaFamiliar });
            lstParametros.Add(new SqlParameter("@pp10AbusoSexual ", SqlDbType.Int) { Value = obj.pp10AbusoSexual });
            lstParametros.Add(new SqlParameter("@pp10VictimaBullying ", SqlDbType.Int) { Value = obj.pp10VictimaBullying });
            lstParametros.Add(new SqlParameter("@pp10Ninguno ", SqlDbType.Int) { Value = obj.pp10Ninguno });
            lstParametros.Add(new SqlParameter("@fk_tbl_g15_1  ", SqlDbType.Int) { Value = obj.fk_tbl_g15_1 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g15_2  ", SqlDbType.Int) { Value = obj.fk_tbl_g15_2 });
            lstParametros.Add(new SqlParameter("@pp13  ", SqlDbType.Int) { Value = obj.pp13 });
            lstParametros.Add(new SqlParameter("@pp14  ", SqlDbType.Int) { Value = obj.pp14 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g16  ", SqlDbType.Int) { Value = obj.fk_tbl_g16 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g17  ", SqlDbType.Int) { Value = obj.fk_tbl_g17 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g18  ", SqlDbType.Int) { Value = obj.fk_tbl_g18 });
            lstParametros.Add(new SqlParameter("@pp19  ", SqlDbType.Int) { Value = obj.pp19 });
            lstParametros.Add(new SqlParameter("@fk_tbl_g19 ", SqlDbType.Int) { Value = obj.fk_tbl_g19 });
            objManagerBD = new ManagerBD();

            if (objManagerBD.UpdateData("MiCuestionario", lstParametros.ToArray()))
                return true;


            return false;
        }

        public bool AceptarTerminos(CCuestionario obj)
        {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op ", SqlDbType.Int) { Value = 8 });
            lstParametros.Add(new SqlParameter("@fk_alumno", SqlDbType.NVarChar, 40) { Value = obj.fk_alumno });   
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("MiCuestionario", lstParametros.ToArray()))
                return true;


            return false;
        }
        public bool AceptarArchivo(CCuestionario obj) {
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op ", SqlDbType.Int) { Value = 9 });
            lstParametros.Add(new SqlParameter("@fk_alumno", SqlDbType.NVarChar, 40) { Value = obj.fk_alumno });
            objManagerBD = new ManagerBD();
            if (objManagerBD.UpdateData("MiCuestionario", lstParametros.ToArray()))
                return true;
            return false;
        }
        #endregion

        //Metodo de evalua por opcion(opcion) que tipo de consulta hacia el cuestionario se desea seleccionar
        public bool listarAlumnoCuestionario(ref DataSet objDatos, string id,int opcion)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lsParametros = new List<SqlParameter>();
            lsParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion});
            lsParametros.Add(new SqlParameter("@fk_alumno", SqlDbType.NVarChar,40) { Value = id });
            objDatos = objManagerBD.GetData("MiCuestionario", lsParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;
            return ExisteDatos;
        }
        public bool ListarSangre(int opcion, ref DataSet objDatos)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lstParametros = new List<SqlParameter>();
            lstParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            objDatos = objManagerBD.GetData("MiCuestionario", lstParametros.ToArray());
            if (objDatos.Tables.Count > 0)
            {
                ExisteDatos = true;
            }
            return ExisteDatos;
        }

        //Get Folio
        public bool folio(ref DataSet objDatos, string id, int opcion)
        {
            bool ExisteDatos = false;
            List<SqlParameter> lsParametros = new List<SqlParameter>();
            lsParametros.Add(new SqlParameter("@Op", SqlDbType.Int) { Value = opcion });
            lsParametros.Add(new SqlParameter("@fk_alumno", SqlDbType.NVarChar, 40) { Value = id });
            objDatos = objManagerBD.GetData("MiCuestionario", lsParametros.ToArray());
            if (objDatos.Tables.Count > 0)
                ExisteDatos = true;
            return ExisteDatos;
        }

        #region Varibles
        //para combo
        public string Id { get; set; }
        public string Descripcion { get; set; }
        //Variables para el objeto encuesta
        //Dental

        public string fk_alumno { get; set; }
        public int fk_tbl_g1 { get; set; }
        public int p2dDiagnostoco { get; set; }
        public int p2dCaries { get; set; }
        public int p2dProfiliaxis { get; set; }
        public int p2dDolorDeMuelas { get; set; }
        public int p2dGingivitis { get; set; }
        public int p2dTratamientos { get; set; }
        public int p2dEdolencias { get; set; }
        public int p2dNinguno { get; set; }
        public int fk_tbl_g2 { get; set; }
        public int fk_tbl_g3 { get; set; }
        public int pd5 { get; set; }
        public int pd6 { get; set; }
        public int pd7 { get; set; }
        public int pd8 { get; set; }
        public int pd9 { get; set; }
        public int pd10 { get; set; }
        public int pd11 { get; set; }
        //Medico
        public int fk_tbl_g4 { get; set; }//1
        public int fk_tbl_g5 { get; set; }//2
        public int fk_tbl_g6 { get; set; }//3
        public int fk_tbl_g7 { get; set; }//4
        public int fk_tbl_g8 { get; set; }//5
        public int fk_tbl_g9 { get; set; }//6
        public string pm7 { get; set; }//7
        public int fk_enferdad { get; set; }//8  se actulizo fk_tbl_g10 a fk_enferdad
        public int fk_tbl_g11 { get; set; }//9
        public int fk_tbl_g12 { get; set; }//10
        public int pm11 { get; set; }//11
        public int pm12 { get; set; }//12
        public int pm13 { get; set; }//13
        public int pm14 { get; set; }//14
        public int pm15 { get; set; }//15
        public int pm16 { get; set; }//16
        public float pm17 { get; set; }//17
        public float pm18 { get; set; }//18
        public float pm19 { get; set; }//19
        public int pm20 { get; set; }//20
        public int pm21 { get; set; }//21
        public int pm22 { get; set; }//22
        public int pm23DIABETES_MELLITUS { get; set; }
        public int pm23HIPERTENSION_ARTERIAL { get; set; }
        public int pm23CARDIOPATIAS { get; set; }
        public int pm23CANCER { get; set; }
        public int pm23EPILEPSIA { get; set; }
        public int pm23ENFERMEDADES_AUTOINMUNES { get; set; }
        public int pm23ENFERMEDADES_PSIQUIÁTRICAS { get; set; }
        public int pm23ENFERMEDADES_SANGRE { get; set; }
        public int pm23NOSE { get; set; }
        public int pm23Ninguno { get; set; }
        public int pm24DIABETES_MELLITUS { get; set; }
        public int pm24HIPERTENSION_ARTERIAL { get; set; }
        public int pm24CARDIOPATIAS { get; set; }
        public int pm24CANCER { get; set; }
        public int pm24EPILEPSIA { get; set; }
        public int pm24ENFERMEDADES_AUTOINMUNES { get; set; }
        public int pm24ENFERMEDADES_PSIQUIÁTRICAS { get; set; }
        public int pm24ENFERMEDADES_SANGRE { get; set; }
        public int pm24NOSE { get; set; }
        public int pm24Ninguno { get; set; }
        public int pm25DIABETES_MELLITUS { get; set; }
        public int pm25HIPERTENSION_ARTERIAL { get; set; }
        public int pm25CARDIOPATIAS { get; set; }
        public int pm25CANCER { get; set; }
        public int pm25EPILEPSIA { get; set; }
        public int pm25ENFERMEDADES_AUTOINMUNES { get; set; }
        public int pm25ENFERMEDADES_PSIQUIÁTRICAS { get; set; }
        public int pm25ENFERMEDADES_SANGRE { get; set; }
        public int pm25NOSE { get; set; }
        public int pm25Ninguno { get; set; }
        //PSICÒLOGO
        public int pp1 { get; set; }
        public int pp2 { get; set; }
        public int fk_tbl_g13 { get; set; }
        public int pp4 { get; set; }
        public int tbl_g14_5 { get; set; }
        public int tbl_g14_6 { get; set; }
        public int tbl_g14_7 { get; set; }
        public int tbl_g14_8 { get; set; }
        //sucesos
        public int pp9DivorcioPadres { get; set; }
        public int pp9NacimmientoHermano { get; set; }
        public int pp9FallecimientoAbuelo { get; set; }
        public int pp9FallecimientoPadres { get; set; }
        public int pp9FallecimientoHermanos { get; set; }
        public int pp9FallecimientoFamiliar { get; set; }
        public int pp9AusenciaDePadre { get; set; }
        public int pp9AusenciaDeMadre { get; set; }
        public int pp9CambioDeDomicilio { get; set; }
        public int pp9ViolenciaFamiliar { get; set; }
        public int pp9AbusoSexual { get; set; }
        public int pp9VictimaBullying { get; set; }
        public int pp9Ninguno { get; set; }
        public int pp10DivorcioPadres { get; set; }
        public int pp10NacimmientoHermano { get; set; }
        public int pp10FallecimientoAbuelo { get; set; }
        public int pp10FallecimientoPadres { get; set; }
        public int pp10FallecimientoHermanos { get; set; }
        public int pp10FallecimientoFamiliar { get; set; }
        public int pp10AusenciaDePadre { get; set; }
        public int pp10AusenciaDeMadre { get; set; }
        public int pp10CambioDeDomicilio { get; set; }
        public int pp10ViolenciaFamiliar { get; set; }
        public int pp10AbusoSexual { get; set; }
        public int pp10VictimaBullying { get; set; }
        public int pp10Ninguno { get; set; }
        public int fk_tbl_g15_1 { get; set; }
        public int fk_tbl_g15_2 { get; set; }
        public int pp13 { get; set; }
        public int pp14 { get; set; }
        public int fk_tbl_g16 { get; set; }
        public int fk_tbl_g17 { get; set; }
        public int fk_tbl_g18 { get; set; }
        public int pp19 { get; set; }
        public int fk_tbl_g19 { get; set; }
        #endregion
    }
}
