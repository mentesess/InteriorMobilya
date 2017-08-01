using InteriorMobilya.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteriorMobilya.DataAccess.Interfaces;
using InteriorMobilya.Service.Interfaces;

namespace InteriorMobilya.Service.Services
{
    public class AddressService : BaseService<Address>,IAddressService
    {
        public AddressService(IRepository<Address> repository) : base(repository)
        {
        }
    }
}
