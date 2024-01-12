using AutoMapper;
using Business.Dtos.Requests.DailyIncomeRecord;
using Business.Dtos.Responses.DailyIncomeRecord;
using Entities.Concrete;

namespace Business.Profiles;

public class DailyIncomeRecordMappingProfile : Profile
{
    public DailyIncomeRecordMappingProfile()
    {

        CreateMap<DailyIncomeRecord, GetListDailyIncomeRecordResponse>().ReverseMap();
                 
                 
              
        CreateMap< DailyIncomeRecord, CreateDailyIncomeRecordRequest>().ReverseMap();
        CreateMap< DailyIncomeRecord, CreatedDailyIncomeRecordResponse>().ReverseMap();
             
        CreateMap< DailyIncomeRecord, UpdateDailyIncomeRecordRequest>().ReverseMap();
        CreateMap< DailyIncomeRecord, UpdatedDailyIncomeRecordResponse>().ReverseMap();
           
        CreateMap< DailyIncomeRecord, DeleteDailyIncomeRecordRequest>().ReverseMap();
        CreateMap< DailyIncomeRecord, DeletedDailyIncomeRecordResponse>().ReverseMap();
                 
        CreateMap< DailyIncomeRecord, GetByIdDailyIncomeRecordResponse>().ReverseMap();
        CreateMap<DailyIncomeRecord, GetByIdDailyIncomeRecordRequest>().ReverseMap();



        CreateMap<DailyIncomeRecord, GetByProductNameDailyIncomeRecordResponse>().ReverseMap();
        CreateMap<DailyIncomeRecord, GetByProductNameDailyIncomeRecordRequest>().ReverseMap();




    }

}
