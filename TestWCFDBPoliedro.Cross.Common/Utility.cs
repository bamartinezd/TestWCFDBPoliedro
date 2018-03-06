using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCFDBPoliedro.Cross.Common.Entities_Aux;
using TestWCFDBPoliedro.Cross.Common.Enums;

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


        public static Message ResultMessages(Messages messajeType, string messageValue = "", Exception ex = null) {
            Message message;
            switch (messajeType)
            {
                case Messages.Succes:
                    message = new Message {
                        Id = 1,
                        Type = "Succes",
                        Description = (string.IsNullOrEmpty(messageValue) ? "Todo salio Ok..." : messageValue) 
                    };
                    break;
                case Messages.Error:
                    message = new Message
                    {
                        Id = 1,
                        Type = "Error!!",
                        Description = (string.IsNullOrEmpty(messageValue) ? "hay errores..." : messageValue)
                    };
                    break;
                case Messages.Exception:
                    message = new Message
                    {
                        Id = 1,
                        Type = "Exception",
                        Description = ex.Message
                    };
                    break;
                default:
                    message = new Message();
                    break;
            }
            return message;
        }

    }
}
