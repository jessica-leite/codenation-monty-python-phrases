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
            var quotesLength = _context.Quotes.Count();

            if (quotesLength == 0)
            {
                return null;
            }

            var index = _randomService.RandomInteger(quotesLength - 1);

            return _context.Quotes
                .ElementAt(index);
        }

        public Quote GetAnyQuote(string actor)
        {
            var quotesLength = _context.Quotes.Count(q => q.Actor == actor);

            if (quotesLength == 0)
            {
                return null;
            }

            var index = _randomService.RandomInteger(quotesLength - 1);

            return _context.Quotes
                .Where(q => q.Actor == actor)
                .ElementAt(index);
        }
    }
}