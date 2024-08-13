using System;
using Final_MVC.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Final_MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }

}

