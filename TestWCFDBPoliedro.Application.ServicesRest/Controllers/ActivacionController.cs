using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWCFDBPoliedro.Application.Dto;
using TestWCFDBPoliedro.Application.Handler;
using TestWCFDBPoliedro.Application.ServicesRest.Models;
using TestWCFDBPoliedro.Cross.Common;

namespace TestWCFDBPoliedro.Application.ServicesRest.Controllers
{
    public class ActivacionController : ApiController
    {
        private ActivacionHandler _activacionHandler;        

        public IEnumerable<ActivacionModel> Get()
        {
            try
            {
                _activacionHandler = new ActivacionHandler();
                return _activacionHandler.GetAll().Select(Utility.MapperHelper<ActivacionModel, ActivacionDto>);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
