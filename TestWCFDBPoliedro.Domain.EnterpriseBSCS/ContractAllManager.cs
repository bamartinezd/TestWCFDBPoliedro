using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFDBPoliedro.Domain.ContractsBSCS;
using TestWCFDBPoliedro.Domain.EntityBSCS1;

namespace TestWCFDBPoliedro.Domain.EnterpriseBSCS
{
    public class ContractAllManager
    {
        private readonly IContractAllRepository _contractAllRepository;

        public ContractAllManager(IContractAllRepository contractAllRepository)
        {
            _contractAllRepository = contractAllRepository;
        }

        public List<ContractAll> GetCoId(decimal coId){
            return _contractAllRepository.GetByCoId(coId);
        }

        public List<ContractAll> GetByCustomerId(decimal customerID) {
            return _contractAllRepository.GetByCustomerId(customerID);
        }

    }
}
