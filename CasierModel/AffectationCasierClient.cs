using System;

namespace CasierModel
{
    public class AffectationCasierClient
    {
        private int _idAffectation;
        private int _IdClient;
        private int _idCasier;
        private DateTime _dateDebut;
        private uint dureeEnJour;
        private decimal _total;

        public int IdAffectation
        {
            get
            {
                return _idAffectation;
            }

            set
            {
                _idAffectation = value;
            }
        }

        public int IdClient
        {
            get
            {
                return _IdClient;
            }

            set
            {
                _IdClient = value;
            }
        }

        public int IdCasier
        {
            get
            {
                return _idCasier;
            }

            set
            {
                _idCasier = value;
            }
        }

        public DateTime DateDebut
        {
            get
            {
                return _dateDebut;
            }

            set
            {
                _dateDebut = value;
            }
        }

        public uint DureeEnJour
        {
            get
            {
                return dureeEnJour;
            }

            set
            {
                dureeEnJour = value;
            }
        }

        public decimal Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }
    }
}
