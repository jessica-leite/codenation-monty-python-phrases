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
            var index = _randomService.RandomInteger(maxIndex);

            return _context.Quotes.ElementAt(index);
        }

        public Quote GetAnyQuote(string actor)
        {
            var maxIndex = _context.Quotes.Count(q => q.Actor == actor);
            var index = _randomService.RandomInteger(maxIndex);

            return _context.Quotes.Where(q => q.Actor == actor).ElementAt(index);
        }
    }
}