using AutoMapper;
using Business.Dtos.Requests.Table;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.Table;
using Entities.Concrete;

namespace Business.Profiles;

public class TableMappingProfile : Profile
{
    public TableMappingProfile()
    {

       



        CreateMap<Table, CreateTableRequest>().ReverseMap();
        CreateMap<Table, CreatedTableResponse>().ReverseMap();

        CreateMap<Table, UpdateTableRequest>().ReverseMap();
        CreateMap<Table, UpdatedTableResponse>().ReverseMap();

        CreateMap<Table, DeleteTableRequest>().ReverseMap();
        CreateMap<Table, DeletedTableResponse>().ReverseMap();

        CreateMap<Table, GetByIdTableResponse>().ReverseMap();
        CreateMap<Table, GetByIdTableRequest>().ReverseMap();

        CreateMap<Table, GetListTableResponse>().ReverseMap();
   


    }

}
