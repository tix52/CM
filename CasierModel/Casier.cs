namespace CasierModel
{
    public class Casier
    {
        private int _idCasier;
        private TypeCasier _typeCasier;
        private uint _stockDisponible;

        public int IdCasier
        {
            get { return _idCasier; }
            set
            {
                _idCasier = value;
            }
        }
        private TypeCasier TypeCasier
        {
            get { return _typeCasier; }
            set
            {
                _typeCasier = value;
            }
        }

        public uint StockDisponible
        {
            get
            {
                return _stockDisponible;
            }

            set
            {
                _stockDisponible = value;
            }
        }
    }
}
