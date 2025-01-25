using AutoMapper;
using Domain.Models;
using Wipro_OnionArchitecture_Ex2.DTO;

namespace Wipro_OnionArchitecture_Ex2.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateDeptDTO, Department>();
            CreateMap<CreateEmpDTO, Employee>();
            CreateMap<DeptEmpLstDTO, Department>();
        }
    }
}
