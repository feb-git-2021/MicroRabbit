using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
 public abstract   class Message :IRequest<bool>
    {
        public string MesssageType { get; protected set; }

        protected Message()
        {
            MesssageType = GetType().Name;
        }
    }
}
