﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave.Models
{
    class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(User user, int amount ):base(user, amount)
        {

        }

        public override string ToString()
        {
            return $"Indbetaling:\n{base.ToString()}";
        }

        //public override void Execute(decimal amount)
        //{
        //    base.Execute(amount);
        //}

    }
}
