using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TestWCFDBPoliedro.Application.DtoBSCS;
using TestWCFDBPoliedro.Application.HandlerBSCS;
using TestWCFDBPoliedro.Application.ServicesRest.Models;
using TestWCFDBPoliedro.Cross.Common;

namespace TestWCFDBPoliedro.Application.ServicesRest.Controllers
{
    public class ContractAllController : ApiController
    {
        private ContractAllHandler _contractAllHandler;

        public IEnumerable<ContractAllModel> GetByCoid(decimal coid) {
            return _contractAllHandler.GetByCoid(coid).Select(Utility.MapperHelper<ContractAllModel, ContractAllDto>);
        }
    }
}
