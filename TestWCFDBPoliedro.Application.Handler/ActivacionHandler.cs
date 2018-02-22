using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFDBPoliedro.Application.Dto;
using TestWCFDBPoliedro.Cross.Common;
using TestWCFDBPoliedro.Domain.Contracts;
using TestWCFDBPoliedro.Domain.Enterprise;
using TestWCFDBPoliedro.Domain.Entities;
using TestWCFDBPoliedro.Infraestructura.ActivaDB.Repositories;

namespace TestWCFDBPoliedro.Application.Handler
{
    public class ActivacionHandler
    {
        #region Attributes
        private readonly ActivacionManager _activacionManager;
        #endregion

        #region Constructor
        public ActivacionHandler() {
            _activacionManager = new ActivacionManager(ActivacionRepository.Instance);
        }
        #endregion

        #region Public Methods
        public List<ActivacionDto> GetAll() {
            return _activacionManager.GetAll().Select(Utility.MapperHelper<ActivacionDto, ACTIVACION>).ToList();
        }

        #endregion


    }
}
