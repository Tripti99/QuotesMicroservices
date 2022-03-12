using QuotesAPI.Models;
using QuotesAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesAPI.Service
{
    public class QuoteService:IQuoteService
    {
        private readonly IQuoteRepo repo;
        public QuoteService(IQuoteRepo _repo)
        {
            repo = _repo;
        }
        public List<QuotesMaster> GetQuotes()
        {
            return repo.GetQuotes().ToList();
        }
    }
}
