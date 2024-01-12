using AutoMapper;
using Business.Dtos.Requests.Order;
using Business.Dtos.Responses.Order;
using Business.Dtos.Responses.Product;
using Entities.Concrete;

namespace Business.Profiles;

public class OrderMappingProfile : Profile
{
    public OrderMappingProfile()
    {
        CreateMap<Order, GetListOrderResponse>()
            .ForMember(destinationMember: p => p.ProductName,
                       memberOptions: opt => opt.MapFrom(p => p.Product.Name))
             .ForMember(destinationMember: p => p.TableName,
                       memberOptions: opt => opt.MapFrom(p => p.Table.Name))
            .ReverseMap();



        CreateMap<Order, CreateOrderRequest>().ReverseMap();
        CreateMap<Order, CreatedOrderResponse>().ReverseMap();

        CreateMap<Order, UpdateOrderRequest>().ReverseMap();
        CreateMap<Order, UpdatedOrderResponse>().ReverseMap();

        CreateMap<Order, DeleteOrderRequest>().ReverseMap();
        CreateMap<Order, DeletedOrderResponse>().ReverseMap();
                 
        CreateMap<Order, GetByIdOrderRequest>().ReverseMap();
                  
        CreateMap<Order, GetByIdOrderResponse>()
           .ForMember(destinationMember: p => p.ProductName,
                       memberOptions: opt => opt.MapFrom(p => p.Product.Name))
             .ForMember(destinationMember: p => p.TableName,
                       memberOptions: opt => opt.MapFrom(p => p.Table.Name))
            .ReverseMap();

        CreateMap<Order, GetListByTableIdOrderResponse>()
          .ForMember(destinationMember: p => p.ProductName,
                      memberOptions: opt => opt.MapFrom(p => p.Product.Name))
            .ForMember(destinationMember: p => p.TableName,
                      memberOptions: opt => opt.MapFrom(p => p.Table.Name))
           .ReverseMap();

    }

}
