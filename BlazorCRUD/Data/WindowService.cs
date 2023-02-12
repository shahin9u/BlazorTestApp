using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorTestApp.Data
{
    public class WindowService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public WindowService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Windows
        public async Task<List<Window>> GetAllWindowAsync()
        {
            return await _appDBContext.Windows.ToListAsync();
        }
        #endregion

        #region Get List of Orders
        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _appDBContext.Orders.ToListAsync();
        }
        #endregion

        #region Insert Windows
        public async Task<bool> InsertWindowAsync(Window window)
        {
            await _appDBContext.Windows.AddAsync(window);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Windows by Id
        public async Task<Window> GetWindowAsync(int Id)
        {
            Window window = await _appDBContext.Windows.FirstOrDefaultAsync(c => c.WindowID.Equals(Id));
            return window;
        }
        #endregion

        #region Update Windows
        public async Task<bool> UpdateWindowAsync(Window window)
        {
             _appDBContext.Windows.Update(window);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteOrders
        public async Task<bool> DeleteWindowAsync(Window window)
        {
            _appDBContext.Remove(window);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
