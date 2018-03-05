using System.Collections.Generic;
using System.Linq;
using TestWCFDBPoliedro.Application.DtoBSCS;
using TestWCFDBPoliedro.Cross.Common;
using TestWCFDBPoliedro.Domain.EnterpriseBSCS;
using TestWCFDBPoliedro.Domain.EntityBSCS1;
using TestWCFDBPoliedro.Infraestructura.BSCSDB.Repositories;

namespace TestWCFDBPoliedro.Application.HandlerBSCS
{
    public class ContractAllHandler
    {
        #region Attributes
        private readonly ContractAllManager _contractAllManager;
        #endregion

        #region Constructor
        public ContractAllHandler() {            
            _contractAllManager = new ContractAllManager(ContractAllRepository.Instance);
        }
        #endregion

        public List<ContractAllDto> GetByCoid(decimal coid) {
            return _contractAllManager.GetCoId(coid).Select(Utility.MapperHelper<ContractAllDto, ContractAll>).ToList();
        }

    }
}
