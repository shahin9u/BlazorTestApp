using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorTestApp.Data
{
    public class SubElementService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public SubElementService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of SubElements
        public async Task<List<SubElement>> GetAllSubElemetAsync()
        {
            return await _appDBContext.SubElements.ToListAsync();
        }
        #endregion

        #region Get List of SubElements
        public async Task<List<SubElement>> GetAllSubElementAsync()
        {
            return await _appDBContext.SubElements.ToListAsync();
        }
        #endregion

        #region Insert Windows
        public async Task<bool> InserSubElementAsync(SubElement window)
        {
            await _appDBContext.SubElements.AddAsync(window);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get SubElement by Id
        public async Task<SubElement> GetWindowAsync(int Id)
        {
            SubElement subElement = await _appDBContext.SubElements.FirstOrDefaultAsync(c => c.SubElementID.Equals(Id));
            return subElement;
        }
        #endregion

        #region Update Windows
        public async Task<bool> UpdateSubElementsync(SubElement subElement)
        {
             _appDBContext.SubElements.Update(subElement);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteSubElements
        public async Task<bool> DeleteSubElementAsync(SubElement window)
        {
            _appDBContext.Remove(window);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
