using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libSistemaPQRSF;

namespace libPQRSF
{
    public class clsReclamos : clsSolicitudes
    {
        #region"Atributos"
        private int intIdReclamo;
        private int intIdTipoReclamo;
        private int intIdSolucion;
        private double dblCosto;
        #endregion

        #region"Constructor"
        public clsReclamos()
        {
            this.intIdReclamo = 0;
            this.intIdTipoReclamo = 0;
            this.intIdSolucion = 0;
            this.dblCosto = 0;
        }
        #endregion

        #region"Propiedades"
        public int IdReclamo { get => intIdReclamo; set => intIdReclamo = value; }
        public int IdTipoReclamo { get => intIdTipoReclamo; set => intIdTipoReclamo = value; }
        public int IdSolucion { get => intIdSolucion; set => intIdSolucion = value; }
        public double Costo { get => dblCosto; set => dblCosto = value; }
        #endregion

        #region"Metodos Públicos"
        public override bool registrar()
        {
            throw new NotImplementedException();
        }

        public override bool consultar()
        {
            throw new NotImplementedException();
        }

        public override bool validar()
        {
            if (intIdReclamo <= 0)
            {
                strError = "El código del reclamo no es válido";
                return false;
            }
            if (intIdTipoReclamo <= 0)
            {
                strError = "El código del tipo de reclamo no es válido";
                return false;
            }
            if (intIdSolucion <= 0)
            {
                strError = "El código de la solucion no es válido";
                return false;
            }
            if (dblCosto <= 0)
            {
                strError = "El valor del costo no es válido";
                return false;
            }
            return true;
        }
        #endregion


    }
}
