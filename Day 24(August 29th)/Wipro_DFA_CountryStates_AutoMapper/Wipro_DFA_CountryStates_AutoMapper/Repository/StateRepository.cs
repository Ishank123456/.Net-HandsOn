using Wipro_DFA_CountryStates_AutoMapper.EntityFramework;
using Wipro_DFA_CountryStates_AutoMapper.Models;

namespace Wipro_DFA_CountryStates_AutoMapper.Repository
{
    public class StateRepository : IStateRepository
    {
        private readonly Wipro29082024Context stateDbContext;
        public StateRepository(Wipro29082024Context _stateDbContext)
        {
            stateDbContext = _stateDbContext;
        }

        public void DeleteState(int id)
        {
            State state = stateDbContext.State.SingleOrDefault(s => s.StateId == id);
            stateDbContext.State.Remove(state);
            stateDbContext.SaveChanges();
        }

        public IEnumerable<State> GetStates()
        {
            return stateDbContext.State.ToList();
        }

        public State GetState(int id)
        {
            return stateDbContext.State.FirstOrDefault(s => s.StateId == id);
        }

        public void InsertState(State state)
        {
            stateDbContext.State.Add(state);
            stateDbContext.SaveChanges();
        }

        public void UpdateState(State state)
        {
            stateDbContext.State.Update(state);
            stateDbContext.SaveChanges();
        }
    }
}
