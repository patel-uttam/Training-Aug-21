 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public class DisplayServicesRepository : IDisplayServicesRepository
    {
        private readonly UrbanCompanyContext context;

        public DisplayServicesRepository(UrbanCompanyContext _context)
        {
            context = _context;
        }

        public IEnumerable<Provider> Get_Provider_By_Service(string name)
        {
            int service_category_id = context.ServicesCategories.FirstOrDefault(s => s.ServiceName == name).ServiceId;
            var provider_by_service = context.Providers.Where(p => p.Service == service_category_id);
            return provider_by_service;
        }

        public IEnumerable<ServicesCategory> Get_Service_Category()
        {
            var service_category = context.ServicesCategories.Where(s => s.ServiceName != null);
            return service_category;
        }

        public IEnumerable<SubService> Get_Sub_Service(string name)
        {
            return context.SubServices.Where(s=>s.ServiceId == context.ServicesCategories.FirstOrDefault(s=>s.ServiceName == name).ServiceId);
            /*Console.WriteLine(subServices.FirstOrDefault(s=>s.ServiceId >0));*/
            
            
        }
    }
}



