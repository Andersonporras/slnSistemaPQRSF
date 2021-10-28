using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libSistemaPQRSF;

namespace libPQRSF
{
    public class clsSugerencias : clsSolicitudes
    {
        #region"Atributos"
        private int intIdSugerencia;
        private int intIdServicioSugerencia;
        private string strMensajeSugerencia;
        #endregion

        #region"Constructor"
        public clsSugerencias()
        {
            this.intIdSugerencia = 0;
            this.intIdServicioSugerencia = 0;
            this.strMensajeSugerencia = "";
        }
        #endregion

        #region"Propiedades"
        public int IdSugerencia { get => intIdSugerencia; set => intIdSugerencia = value; }
        public int IdServicioSugerencia { get => intIdServicioSugerencia; set => intIdServicioSugerencia = value; }
        public string MensajeSugerencia { get => strMensajeSugerencia; set => strMensajeSugerencia = value; }
        #endregion

        #region"Métodos Públicos"
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
            if (intIdSugerencia <= 0)
            {
                strError = "El código de la sugerencia no es válido";
                return false;
            }
            if (intIdServicioSugerencia <= 0)
            {
                strError = "El código del servicio asociado a la sugerencia no es válido";
                return false;
            }
            if (strMensajeSugerencia == "")
            {
                strError = "El mensaje de sugerencia no debe estar vacío";
                return false;
            }
            return true;
        }
        #endregion
    }
}
