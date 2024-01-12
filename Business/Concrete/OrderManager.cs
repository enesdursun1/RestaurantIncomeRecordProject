using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.Order;
using Business.Dtos.Requests.Table;
using Business.Dtos.Responses.Order;
using Business.Dtos.Responses.Table;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business.Concrete;

public class OrderManager : IOrderService
{

    private readonly IOrderDal _orderDal;
    private readonly IMapper _mapper;

    public OrderManager(IOrderDal orderDal, IMapper mapper)
    {
        _orderDal = orderDal;
        _mapper = mapper;
    }

    public async Task<CreatedOrderResponse> AddAsync(CreateOrderRequest createOrderRequest)
    {
        Order order = _mapper.Map<Order>(createOrderRequest);

        Order createdOrder = await _orderDal.AddAsync(order);

        CreatedOrderResponse createdOrderResponse = _mapper.Map<CreatedOrderResponse>(createdOrder);

        return createdOrderResponse;
    }

    public async Task<DeletedOrderResponse> DeleteAsync(DeleteOrderRequest deleteOrderRequest)
    {
        Order order = _mapper.Map<Order>(deleteOrderRequest);

        Order? deletedOrder = await _orderDal.DeleteAsync(order);

        DeletedOrderResponse mappedOrder = _mapper.Map<DeletedOrderResponse>(deletedOrder);

        return mappedOrder;
    }

    public async Task<GetByIdOrderResponse> GetByIdAsync(GetByIdOrderRequest getByIdOrderRequest)
    {
        Order? order = await _orderDal.GetAsync(p => p.Id == getByIdOrderRequest.Id, include: p => p
                                                                            .Include(p => p.Product).Include(p => p.Table),enableTracking: false);

        GetByIdOrderResponse getByIdOrderResponse = _mapper.Map<GetByIdOrderResponse>(order);

        return getByIdOrderResponse;
    }

  
    public async Task<IList<GetListOrderResponse>> GetListAsync()
    {
        var data = await _orderDal.GetListAsync(include: p => p
                                                .Include(p=>p.Product).Include(p => p.Table),enableTracking:false);
        IList<GetListOrderResponse> getListOrderResponses = _mapper.Map<IList<GetListOrderResponse>>(data);
        return getListOrderResponses;
    }

    public async Task<UpdatedOrderResponse> UpdateAsync(UpdateOrderRequest updateOrderRequest)
    {
        Order order = _mapper.Map<Order>(updateOrderRequest);

        Order? updatedOrder = await _orderDal.UpdateAsync(order);

        UpdatedOrderResponse mappedOrder = _mapper.Map<UpdatedOrderResponse>(updatedOrder);

        return mappedOrder;
    }





    public async Task<IList<GetListByTableIdOrderResponse>> GetListByTableIdAsync(int tableId)
    {
        IList<Order?> data = await _orderDal.GetListAsync(predicate:p=>p.TableId == tableId, include: p => p.Include(p => p.Product).Include(p => p.Table), enableTracking: false);

        IList<GetListByTableIdOrderResponse> getListByTableIdOrderResponse = _mapper.Map<IList<GetListByTableIdOrderResponse>>(data);
        return getListByTableIdOrderResponse;


    }

    public async Task<IList<DeletedOrderResponse>> DeleteRangeAsync(IList<DeleteOrderRequest> deleteOrderRequest)
    {
        IList<Order> orders = _mapper.Map<IList<Order>>(deleteOrderRequest);

        IList<Order> deletedOrders = await _orderDal.DeleteRangeAsync(orders);

        IList<DeletedOrderResponse> mappedOrders = _mapper.Map<IList<DeletedOrderResponse>>(deletedOrders);

        return mappedOrders;
    }
}
