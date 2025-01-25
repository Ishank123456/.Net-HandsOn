using Wipro_DFA_CountryStates_AutoMapper.Models;

namespace Wipro_DFA_CountryStates_AutoMapper.Repository
{
    public interface IStateRepository
    {
        IEnumerable<State> GetStates();
        State GetState(int id);
        void InsertState(State state);
        void UpdateState(State state);
        void DeleteState(int id);
    }
}
