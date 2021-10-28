using System;
using libSistemaPQRSF;

namespace libPQRSF
{
    public class clsPeticiones : clsSolicitudes
    {
        #region "Atributos"
        private int intIdPeticion;
        private int intIdSupervisor;
        #endregion

        #region "Constructor"
        public clsPeticiones()
        {
            this.intIdPeticion = 0;
            this.intIdSupervisor = 0;
        }

        #endregion

        #region "Propiedades"
        public int IdPeticion { get => intIdPeticion; set => intIdPeticion = value; }
        public int IdSupervisor { get => intIdSupervisor; set => intIdSupervisor = value; }
        #endregion

        #region "Metodos Publicos"     
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
            if (intIdPeticion <= 0)
            {
                strError = "El código de la petición no es válido";
                return false;
            }
            if (intIdSupervisor <= 0)
            {
                strError = "El código del supervisor no es válido";
                return false;
            }
            return true;
        }
        #endregion
    }
}
