using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Referenciar y Usar 
using libRnUniversidad;

namespace libOpeUniversidad
{
    public class clsOpeUniversidad
    {
        #region Atributos

        private int    intTipoEst;
        private int    intCredit;
        private float  fltProm;
        private float  fltValorCred;
        private float  fltValDescuento;
        private float  fltValorPago;
        private string strError;

        #endregion

        #region Constructor

        public clsOpeUniversidad()
        {
            intTipoEst      = 0;
            intCredit       = 0;
            fltProm         = 0;
            fltValorCred    = 0;
            fltValDescuento = 0;
            fltValorPago    = 0;
            strError        = String.Empty;
        }

        #endregion

        #region Propiedades
        
        public int TipoEstudiante
        {
            set { intTipoEst = value; }
            get { return intTipoEst;  }
        }

        public int NumCreditos
        {
           get { return intCredit;  }
        }

        public float Promedio
        {
            set { fltProm = value; }
            get { return fltProm; }
        }

        public float ValorCred
        {
            get { return fltValorCred; }
        }

        public float Descuento
        {
            get { return fltValDescuento; }
        }

        public float ValorPago
        {
            get { return fltValorPago; }
        }

        public string Error
        {
            get { return strError; }
        }

        #endregion

        #region Metodos Privados
        #endregion

        #region Metodos Publicos
        public bool hallarPago()
        {
           ///<summary
           ///

            clsRnUniversidad obj = new clsRnUniversidad();
            float subTot = 0; 
            try
            {
                // Enviar informacion al Objeto
                obj.TipoEstudiante = intTipoEst;
                obj.Promedio       = fltProm;
                // Invocar metodo y tratamiento del error
                if (!obj.hallarDatos())
                {
                    strError = obj.Error;
                    return false;
                }
                // Recuperar la informacion clsRn
                fltValorCred    = obj.ValorCredito;
                intCredit       = obj.NumCreditos;
                subTot          = intCredit * fltValorCred;
                fltValDescuento = subTot * obj.Descuento / 100;
                fltValorPago = subTot - fltValDescuento;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
            finally
            {
                obj = null; // no es obligatoria 
            }
        }
        #endregion
    }
}
