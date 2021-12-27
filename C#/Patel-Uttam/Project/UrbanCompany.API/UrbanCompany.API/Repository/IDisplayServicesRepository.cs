using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanCompany.API.Models;
using UrbanCompany.API;

namespace UrbanCompany.API.Repository
{
    public interface IDisplayServicesRepository
    {

        IEnumerable<ServicesCategory> Get_Service_Category();

        // sub services

        IEnumerable<SubService> Get_Sub_Service(string name);

        // provider by service

        IEnumerable<Provider> Get_Provider_By_Service(string name);
    }
}
