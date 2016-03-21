namespace CasierModel
{
    public class Client
    {
        private int _idClient;
        private string _nom;
        private string _prenom;

        public int IdClient
        {
            get { return _idClient; }
            set
            {
                _idClient = value;
            }
        }
        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
            }
        }
        public string Prenom
        {
            get { return _prenom; }
            set
            {
                _prenom = value;
            }
        }
    }
}
