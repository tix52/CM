using CasierModel;

namespace ModelManager.Interfaces
{
    public interface IAffectationDataService
    {
        AffectationCasierClient GetAffectation(int id);
        AffectationCasierClient[] GetAllAffectations();
        AffectationCasierClient[] GetAffectationsByClient(int clientId);
        AffectationCasierClient[] GetAffectationsByCasier(int casierId);
        
        void AddAffectation(Casier casier, Client client);
        void AddAffectation(AffectationCasierClient affectation);

        void UpdateAffectation(AffectationCasierClient affectation);

        void RemoveAffectation(AffectationCasierClient affectation);
    }
}
