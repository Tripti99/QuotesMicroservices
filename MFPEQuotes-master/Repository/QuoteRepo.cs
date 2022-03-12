using QuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesAPI.Repository
{
    public class QuoteRepo:IQuoteRepo
    {
        private readonly QuotesContext context;
        public QuoteRepo(QuotesContext _context)
        {
            context = _context;
        }
        public List<QuotesMaster> GetQuotes()
        {
            return context.Quotes.ToList();
        }
    }
}
