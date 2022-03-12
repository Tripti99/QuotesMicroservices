using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesAPI.Models;
using QuotesAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(QuotesController));
        private readonly IQuoteService service;
        public QuotesController(IQuoteService _service)
        {
            service = _service;
        }

        [HttpGet]
        public string GetQuote(int businesssValueFrom,int businesssValueTo,int propertyValueFrom,int propertyValueTo,string propertyType)
        {
            QuotesMaster quote = service.GetQuotes().SingleOrDefault(x => x.BusinesssValueFrom == businesssValueFrom
              && x.BusinesssValueTo == businesssValueTo
              && x.PropertyValueFrom == propertyValueFrom
              && x.PropertyValueTo == propertyValueTo
              && x.PropertyType == propertyType);

            if(quote!=null)
            {
                _log4net.Info("GetQuote has been accessed");
                return quote.QuoteValue+" INR";
            }
            else
            {
                _log4net.Error("Error in accessing quote" );
                return "No Quotes, Contact Insurance Provider";
            }
            
        }
    }
}
