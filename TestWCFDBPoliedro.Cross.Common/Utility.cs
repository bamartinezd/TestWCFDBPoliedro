using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWCFDBPoliedro.Cross.Common
{
    public class Utility
    {
        public static TSource MapperHelper<TSource, TDestination>(TDestination mapping)
            where TSource : class
            where TDestination :class
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TDestination, TSource>();
            });

            var mapper = config.CreateMapper();
            return mapper.Map<TSource>(mapping);
        }
    }
}
