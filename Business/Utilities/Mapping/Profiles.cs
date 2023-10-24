using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<User, UserProfileDto>().ReverseMap();

        CreateMap<EmployeeCreateDto, Employee>().ReverseMap();
        CreateMap<EmployeeUpdateDto, Employee>().ReverseMap();
        CreateMap<Employee, EmployeeInfoDto>().ReverseMap();

        CreateMap<DepartmentCreateDto, Department>().ReverseMap();
        CreateMap<DepartmentUpdateDto,Department>().ReverseMap();
        CreateMap<Department,DepartmentInfoDto>().ReverseMap();
    }
}