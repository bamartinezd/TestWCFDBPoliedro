using System;
using System.Collections.Generic;
using System.Linq;
using TestWCFDBPoliedro.Domain.Contracts;
using TestWCFDBPoliedro.Domain.Entities;
using ACTIVACION = TestWCFDBPoliedro.Domain.Entities.ACTIVACION;
using TestWCFDBPoliedro.Infraestructura.ActivaDB.Model;
using TestWCFDBPoliedro.Cross.Common;

namespace TestWCFDBPoliedro.Infraestructura.ActivaDB.Repositories
{
    public class ActivacionRepository : IActivacionRepository
    {
        #region Attributes
        private static volatile IActivacionRepository _activacionRepository;
        #endregion

        #region Properties
        public static IActivacionRepository Instance =>
            _activacionRepository ?? (_activacionRepository = new ActivacionRepository());
        #endregion

        #region Public Methods
        public List<ACTIVACION> GetAll()
        {
            using (var context = new ModelActiva())
            {
                context.Database.Initialize(force: false);
                var list = context.ACTIVACION.Where(x => x.CODMIN == "3146835216").
                                   Select(Utility.MapperHelper<ACTIVACION, Model.ACTIVACION>).ToList();
                return list;
            }
        }

        public List<ACTIVACION> GetAllByDocument(string documentNumber)
        {
            using (var context = new ModelActiva())
            {
                context.Database.Initialize(force: false);
                var list = context.ACTIVACION.Where(x => x.NUMERO_DOCUMENTO == documentNumber).
                                   Select(Utility.MapperHelper<ACTIVACION, Model.ACTIVACION>).ToList();
                return list;
            }
        }

        public List<ACTIVACION> GetAllByMin(string min)
        {
            using (var context = new ModelActiva())
            {
                context.Database.Initialize(force: false);
                var list = context.ACTIVACION.Where(x => x.CODMIN == min).
                                   Select(Utility.MapperHelper<ACTIVACION, Model.ACTIVACION>).ToList();
                return list;
            }
        }
        #endregion

    }
}
