using CasierModel;

namespace ModelManager.Interfaces
{
    public interface IClientDataService
    {
        Client GetClient(int idClient);
        Client[] GetClients();
        Client[] GetClientsByCasier(int idCasier);
        Client[] GetClientsByTypeCasier(TypeCasier typeCasier);
        Client GetClientByAffectationId(int affectationId);

        void AddClient(Client client);

        void UpdateClient(Client client);

        void RemoveClient(Client client);
    }
}
