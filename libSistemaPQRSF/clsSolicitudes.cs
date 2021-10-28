using System;

namespace libSistemaPQRSF
{
    public abstract class clsSolicitudes
    {
        #region "Atributos"
        protected int intArea;
        protected int intidCliente;
        protected int intServicio;
        protected int intTipoSoli;
        protected string strFecha;
        protected string strError;
        #endregion

        #region "Constructor"
        public clsSolicitudes()
        {
            this.intArea = 0;
            this.intidCliente = 0;
            this.intServicio = 0;
            this.intTipoSoli = 0;
            this.strFecha = "";
            this.strError = "";
        }
        #endregion

        #region "Propiedades"
        public int Area { get => intArea; set => intArea = value; }
        public int idCliente { get => intidCliente; set => intidCliente = value; }
        public int Servicio { get => intServicio; set => intServicio = value; }
        public int TipoSoli { get => intTipoSoli; set => intTipoSoli = value; }
        public string Fecha { get => strFecha; set => strFecha = value; }
        public string Error { get => strError; set => strError = value; }
        #endregion

        #region "Métodos Públicos"
        public abstract bool registrar();
        public abstract bool consultar();
        public abstract bool validar();
        #endregion

  
    }
}
