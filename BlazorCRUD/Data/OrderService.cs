using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorTestApp.Data
{
    public class OrderService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public OrderService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Orders
        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _appDBContext.Orders.ToListAsync();
        }
        #endregion

        #region Insert Orders
        public async Task<bool> InsertOrderAsync(Order order)
        {
            await _appDBContext.Orders.AddAsync(order);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Order by Id
        public async Task<Order> GetEmployeeAsync(int Id)
        {
            Order order = await _appDBContext.Orders.FirstOrDefaultAsync(c => c.OrderID.Equals(Id));
            return order;
        }
        #endregion

        #region Update Orders
        public async Task<bool> UpdateEmployeeAsync(Order order)
        {
             _appDBContext.Orders.Update(order);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteOrders
        public async Task<bool> DeleteEmployeeAsync(Order order)
        {
            _appDBContext.Remove(order);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
