using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
   public class CreateTransferCommand :TransferCommand
    {
        public CreateTransferCommand(int from,int to,float amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
