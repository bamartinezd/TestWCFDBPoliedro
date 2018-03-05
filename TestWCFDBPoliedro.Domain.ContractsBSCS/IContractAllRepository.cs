using System.Collections.Generic;
using TestWCFDBPoliedro.Domain.EntityBSCS1;

namespace TestWCFDBPoliedro.Domain.ContractsBSCS
{
    public interface IContractAllRepository
    {
        List<ContractAll> GetByCoId(decimal coId);
        List<ContractAll> GetByCustomerId(decimal customerId);
    }
}
