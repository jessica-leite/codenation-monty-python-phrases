using Codenation.Challenge.Models;
using System.Linq;

namespace Codenation.Challenge.Services
{
    public class QuoteService : IQuoteService
    {
        private ScriptsContext _context;
        private IRandomService _randomService;

        public QuoteService(ScriptsContext context, IRandomService randomService)
        {
            this._context = context;
            this._randomService = randomService;
        }

        public Quote GetAnyQuote()
        {
            var maxIndex = _context.Quotes.Count();

            return _context.Quotes.Find(_randomService.RandomInteger(maxIndex));
        }

        public Quote GetAnyQuote(string actor)
        {
            throw new System.NotImplementedException();
        }
    }
}