namespace Wipro_DFA_CountryStates_AutoMapper.DTO
{
    public class CreateStateDTO
    {
        public string StateName { get; set; } = null!;
        public int? CountryId { get; set; }
    }
}
