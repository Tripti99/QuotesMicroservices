﻿using QuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesAPI.Service
{
    public interface IQuoteService
    {
        public List<QuotesMaster> GetQuotes();
    }
}
