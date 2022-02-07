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

        public Provider GetProvider(string name)
        {
            var selected_provider = context.Providers.FirstOrDefault(p=>p.UserName == name);
            return selected_provider;
        }

        public IEnumerable<Provider> GetProviders()
        {
            return context.Providers;
        }

        public Provider UpdateProvider(Provider provider)
        {
            Provider p = context.Providers.FirstOrDefault(p=>p.ProviderId == provider.ProviderId);
            
            p.FirstName = provider.FirstName;
            p.LastName = provider.LastName;
            p.ProviderCity = provider.ProviderCity;             
            p.ProviderDistrict = provider.ProviderDistrict;

            context.Providers.Update(p);
            context.SaveChanges();
            return p;
        }


        /*filter*/
        public IEnumerable<Provider> GetProviderByCategory_City(int category , string city)
        {                    
            return context.Providers.Where(p => p.Category == category && p.ProviderCity == city);
        }

        public IEnumerable<string> GetCategory(string dist)
        {
            var categories_id= context.Providers.Where(p => p.ProviderDistrict == dist).Select(p=>p.Category).Distinct().ToList();

            List<string> category = new List<string>();

            foreach(var id in categories_id)
            {
                category.Add(context.Categories.FirstOrDefault(c => c.CategoryId == id).CategoryName.ToString());
            }
            return category;
        }
    }
}
