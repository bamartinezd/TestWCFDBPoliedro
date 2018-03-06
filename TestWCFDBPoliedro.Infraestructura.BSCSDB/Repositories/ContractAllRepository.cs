using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFDBPoliedro.Cross.Common;
using TestWCFDBPoliedro.Domain.ContractsBSCS;
using TestWCFDBPoliedro.Domain.EntityBSCS1;
using TestWCFDBPoliedro.Infraestructura.BSCSDB.Modelo;

namespace TestWCFDBPoliedro.Infraestructura.BSCSDB.Repositories
{
    public class ContractAllRepository : IContractAllRepository
    {
        private static volatile IContractAllRepository _contractAllRepository;

        public static IContractAllRepository Instance =>
            _contractAllRepository ?? (_contractAllRepository = new ContractAllRepository());
              

        public List<ContractAll> GetByCoId(decimal coId)
        {
            using (var context = new ModelBSCS())
            {
                var list = context.CONTRACT_ALL.Where(x => x.CO_ID == coId);
                return list.Select(Utility.MapperHelper<ContractAll, CONTRACT_ALL>).ToList();
            }
        }

        public List<ContractAll> GetByCustomerId(decimal customerId)
        {
            using (var context = new ModelBSCS())
            {
                var list = context.CONTRACT_ALL.Where(x => x.CUSTOMER_ID == customerId);
                return list.Select(Utility.MapperHelper<ContractAll, CONTRACT_ALL>).ToList();
            }
        }
    }
}
