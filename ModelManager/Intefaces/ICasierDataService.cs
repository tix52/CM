using CasierModel;

namespace ModelManager.Interfaces
{
    public interface ICasierDataService
    {
        Casier GetCasier(int id);
        Casier[] GetAllCasiers();
        Casier[] GetCasiersDiponibles();

        void AddCasier(Casier casier);

        void RemoveCasier(Casier casier);

        void UpdateCasier(Casier casier);

    }
}
