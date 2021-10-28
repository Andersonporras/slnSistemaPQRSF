using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libSistemaPQRSF;

namespace libPQRSF
{
    public class clsFelicitaciones : clsSolicitudes
    {
        #region"Atributos"
        private int intIdFelicitacion;
        private int intIdsupervisor;
        private string strMensajeFelicitacion;
        #endregion

        #region"Constructor"
        public clsFelicitaciones()
        {
            this.intIdFelicitacion = 0;
            this.intIdsupervisor = 0;
            this.strMensajeFelicitacion = "";
        }
        #endregion

        #region"Propiedades"
        public int IdFelicitacion { get => intIdFelicitacion; set => intIdFelicitacion = value; }
        public int Idsupervisor { get => intIdsupervisor; set => intIdsupervisor = value; }
        public string MensajeFelicitacion { get => strMensajeFelicitacion; set => strMensajeFelicitacion = value; }
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
            if (intIdFelicitacion <= 0)
            {
                strError = "El código de la Felicitación no es válido";
                return false;
            }
            if (intIdsupervisor <= 0)
            {
                strError = "El código del supervisor no es válido";
                return false;
            }
            if (strMensajeFelicitacion == "")
            {
                strError = "El mensaje de Felicitación no debe estar vacío";
                return false;
            }
            return true;
        }
        #endregion
    }
}
