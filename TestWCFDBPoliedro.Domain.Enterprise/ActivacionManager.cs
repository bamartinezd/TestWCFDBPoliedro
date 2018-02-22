using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFDBPoliedro.Domain.Contracts;
using TestWCFDBPoliedro.Domain.Entities;

namespace TestWCFDBPoliedro.Domain.Enterprise
{
    public class ActivacionManager
    {
        #region Atributes
        private readonly IActivacionRepository _activacionRepository;
        #endregion

        #region Constructor
        public ActivacionManager(IActivacionRepository activacionRepository) {
            _activacionRepository = activacionRepository;
        }
        #endregion

        #region Public Methods
        public List<ACTIVACION> GetAll() {
            return _activacionRepository.GetAll();
        }
        #endregion


    }
}
