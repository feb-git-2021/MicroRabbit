using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Events
{
  public  class TransferCreated :Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public float Amount { get; private set; }
        public TransferCreated(int from , int to,float amount)
        {
            From = from;
            To = to;
            Amount = amount;

        }

    }
}
