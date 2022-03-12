using Moq;
using NUnit.Framework;
using QuotesAPI.Models;
using QuotesAPI.Repository;
using System.Collections.Generic;



namespace QuotesTests
{
    public class Tests
    {

        private Mock<IQuoteRepo> quotesMock;
        [SetUp]
        public void Setup()
        {
            quotesMock = new Mock<IQuoteRepo>();
        }



        [Test]
        public void GetQuotesTest()
        {
            List<QuotesMaster> quotes = new List<QuotesMaster>() { };
            quotesMock.Setup(c => c.GetQuotes()).Returns(quotes);
            var output = quotesMock.Object.GetQuotes();
            Assert.AreEqual(output, quotes);
        }



    }
}