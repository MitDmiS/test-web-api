using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public class OrderControllerService : DBServiceBase
    {
        public OrderControllerService(OrderContext context):base(context)
        {

        }

        public async Task AddAsync(OrderData orderData,string systemType, CancellationToken cancellationToken)
        {
            var entity = new Order
            {
                OrderNumber = Int64.Parse(orderData.OrderNumber),
                CreatedAt=orderData.CreatedAt,
                SourceOrder=JsonConvert.SerializeObject(orderData),
                SystemType=systemType
            };

            var adder = await _context.Orders.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            
        }

        public async Task<IReadOnlyList<Order>> GetUnconvertedOrders(CancellationToken cancellationToken)
        {
            return await _context.Orders
                .Where(x => x.ConvertedOrder == null)
                .ToListAsync(cancellationToken);
        }
    }
}
