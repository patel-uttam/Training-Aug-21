using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;

namespace UrbanCompany.API.Repository
{
    public interface IProviderRepository
    {
        IEnumerable<Provider> GetProviders();
        Provider GetProvider(int id);
        Provider UpdateProvider(Provider provider);
        /*        Provider DeleteProvider(string name);*/

        //
        Provider AddProvider(Provider provider);

        // filter method

        IEnumerable<Provider> GetProviderByService(string service);
    }
}
