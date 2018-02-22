using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFDBPoliedro.Domain.Entities;

namespace TestWCFDBPoliedro.Domain.Contracts
{
    public interface IActivacionRepository
    {
        List<ACTIVACION> GetAll();
        List<ACTIVACION> GetAllByMin(string min);
        List<ACTIVACION> GetAllByDocument(string documentNumber);

    }
}
