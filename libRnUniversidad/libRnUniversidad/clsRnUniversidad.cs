using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libRnUniversidad
{
    public class clsRnUniversidad
    {
        #region Atributos   

        private int intTipoEst;
        private float fltProm;

        private String strError;
        #endregion

        #region Constructor         
        #endregion

        #region Propiedades   
        public int tipoEstudiante
         //Entrada
        {
            set { intTipoEst = value; }
        }

        //
        public String Error
        {
            get { return strError;}
        }
        #endregion
        #region Metodos Privados    
        private bool leerArchivo()
        {
            if (!Validar())
                return false;
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Descuentos.txt";
                int intCant = 0;
                string strLinea;
                string[] vectorLinea;
                string strCodigo;
                float fltNota;
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath);         // Crear objeto para leer el archivo
                while ((strLinea = Archivo.ReadLine()) != null)             //  Leer linea por linea del archivo
                {
                    vectorLinea = strlinea.Split(':');
                    strCodigo = vectorLinea[0];                            //Tipo de Estudiante (Programa)
                    fltNota = Convert.ToSingle(vectorLinea[1]);             //Promedio Mínimo de Nota
                    if (strCodigo == intTipoEst.ToString() && fltProm >= fltNota)
                    {
                        fltValCredito = Convert.ToSingle(vectorLinea[2]);    // Valor de Credito
                        intCredit = Convert.ToInt16(vectorLinea[3]);    //Cantidad Créditos 
                        fltDesc = Convert.ToSingle(vectorLinea[4]);    //Porcentaje de Dscto
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
        #region Metodos Publicos         
        #endregion
    }
}
