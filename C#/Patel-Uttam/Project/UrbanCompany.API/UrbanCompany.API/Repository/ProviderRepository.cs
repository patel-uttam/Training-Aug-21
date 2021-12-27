using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
 
    public class ProviderRepository : IProviderRepository
    {

        private readonly UrbanCompanyContext context;

        public ProviderRepository(UrbanCompanyContext _context)
        {
            context = _context;
        }

        public Provider AddProvider(Provider provider)
        {
            context.Providers.Add(provider);
            context.SaveChanges();
            return provider;
        }

        /*        public Provider DeleteProvider(string name)
                {
                    var deleted_provider = context.Providers.FirstOrDefault(p=>p.ProviderName == name);
                    context.Providers.Remove(deleted_provider);
                    context.SaveChanges();
                    return deleted_provider;
                }*/

        public Provider GetProvider(int id)
        {
            var selected_provider = context.Providers.FirstOrDefault(p=>p.ProviderId == id);
            return selected_provider;
        }

        public IEnumerable<Provider> GetProviders()
        {
            return context.Providers;
        }

        public Provider UpdateProvider(Provider provider)
        {
            var updated_provider = context.Attach(provider);
            updated_provider.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return provider;
        }


        /*filter*/
        public IEnumerable<Provider> GetProviderByService(string service)
        {
/*            int serviceId = context.ServicesCategories.FirstOrDefault(s => s.ServiceName == service).ServiceId;
            Console.WriteLine(serviceId);
            Console.WriteLine(service);
*/            return context.Providers.Where(p => p.Service == context.ServicesCategories.FirstOrDefault(s=>s.ServiceName == service).ServiceId);
            
            
        }
    }
}
