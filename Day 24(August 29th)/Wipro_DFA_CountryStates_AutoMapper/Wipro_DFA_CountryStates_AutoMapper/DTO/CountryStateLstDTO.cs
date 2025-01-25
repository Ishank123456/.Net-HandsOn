namespace Wipro_DFA_CountryStates_AutoMapper.DTO
{
    public class CountryStateLstDTO
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public List<StateDTO> LstState { get; set; }
    }
}
