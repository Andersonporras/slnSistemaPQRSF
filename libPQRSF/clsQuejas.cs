using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libSistemaPQRSF;

namespace libPQRSF
{
    public class clsQuejas : clsSolicitudes
    {
        #region"Atributos"
        private int intIdQueja;
        private int intIdSupervisor;
        private int intIdTipoRemuneracion;
        #endregion

        #region"Cosntructor"
        public clsQuejas()
        {
            this.intIdQueja = 0;
            this.intIdSupervisor = 0;
            this.intIdTipoRemuneracion = 0;
        }
        #endregion

        #region"Propiedades"
        public int IdQueja { get => intIdQueja; set => intIdQueja = value; }
        public int IdSupervisor { get => intIdSupervisor; set => intIdSupervisor = value; }
        public int IdTipoRemuneracion { get => intIdTipoRemuneracion; set => intIdTipoRemuneracion = value; }
        #endregion

        #region"Metodos Publicos"
        public override bool consultar()
        {
            throw new NotImplementedException();
        }

        public override bool registrar()
        {
            throw new NotImplementedException();
        }

        public override bool validar()
        {
            if (intIdQueja <= 0)
            {
                strError = "El código de la Queja no es válido";
                return false;
            }
            if (intIdSupervisor <= 0)
            {
                strError = "El código del supervisor no es válido";
                return false;
            }
            if (intIdTipoRemuneracion <= 0)
            {
                strError = "El código del tipo de remuneración no es válido";
                return false;
            }
            return true;
        }
        #endregion
    }
}
