using AutoMapper;
using Business.Dtos.Requests.MonthlyIncomeRecord;
using Business.Dtos.Responses.MonthlyIncomeRecord;
using Entities.Concrete;

namespace Business.Profiles;

public class MonthlyIncomeRecordMappingProfile : Profile
{
    public MonthlyIncomeRecordMappingProfile()
    {

         CreateMap<MonthlyIncomeRecord, GetListMonthlyIncomeRecordResponse>().ReverseMap();
                 
                 
            
        CreateMap<MonthlyIncomeRecord, CreateMonthlyIncomeRecordRequest>().ReverseMap();
        CreateMap<MonthlyIncomeRecord, CreatedMonthlyIncomeRecordResponse>().ReverseMap();
             
        CreateMap<MonthlyIncomeRecord, UpdateMonthlyIncomeRecordRequest>().ReverseMap();
        CreateMap<MonthlyIncomeRecord, UpdatedMonthlyIncomeRecordResponse>().ReverseMap();
            
        CreateMap<MonthlyIncomeRecord, DeleteMonthlyIncomeRecordRequest>().ReverseMap();
        CreateMap<MonthlyIncomeRecord, DeletedMonthlyIncomeRecordResponse>().ReverseMap();
              
        CreateMap<MonthlyIncomeRecord, GetByIdMonthlyIncomeRecordResponse>().ReverseMap();
        CreateMap<MonthlyIncomeRecord, GetByIdMonthlyIncomeRecordRequest>().ReverseMap(); 
        
        CreateMap<MonthlyIncomeRecord, GetByDateMonthlyIncomeRecordResponse>().ReverseMap();
        CreateMap<MonthlyIncomeRecord, GetByDateMonthlyIncomeRecordRequest>().ReverseMap();
       
        




    }

}
