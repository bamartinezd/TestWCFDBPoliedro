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

        public string Get()
        {
            return "Prueba";
        }

        public IHttpActionResult GetById()//IEnumerable<ContractAllModel> GetById()
        {
            try
            {                
                _contractAllHandler = new ContractAllHandler();
                return Ok(_contractAllHandler.GetByCoid(5893940).Select(Utility.MapperHelper<ContractAllModel, ContractAllDto>));
            }
            catch (Exception ex)
            {
                var result = Utility.ResultMessages(Cross.Common.Enums.Messages.Exception, string.Empty, ex);
                return Ok(result); //throw new Exception(ex.Message);
            }
            
        }
    }
}
