using Business.Dtos.Requests.Order;
using Business.Dtos.Responses.Order;
using Entities.Concrete;

namespace Business.Abstract;

public interface IOrderService
{
    public Task<CreatedOrderResponse> AddAsync(CreateOrderRequest createOrderRequest);
    public Task<IList<GetListOrderResponse>> GetListAsync();
    public Task<GetByIdOrderResponse> GetByIdAsync(GetByIdOrderRequest getByIdOrderRequest);
    public Task<UpdatedOrderResponse> UpdateAsync(UpdateOrderRequest updateOrderRequest);
    public Task<DeletedOrderResponse> DeleteAsync(DeleteOrderRequest deleteOrderRequest);
    public Task<IList<DeletedOrderResponse>> DeleteRangeAsync(IList<DeleteOrderRequest> deleteOrderRequest);
 


    public Task<IList<GetListByTableIdOrderResponse>> GetListByTableIdAsync(int tableId);

}
