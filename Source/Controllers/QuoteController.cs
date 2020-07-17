﻿using Codenation.Challenge.Models;
using Codenation.Challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace Codenation.Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _service;

        public QuoteController(IQuoteService service)
        {
            _service = service;
        }

        // GET api/quote
        [HttpGet]
        public ActionResult<QuoteView> GetAnyQuote()
        {
            var quote = _service.GetAnyQuote();
            return Ok(new QuoteView()
            {
                Id = quote.Id,
                Actor = quote.Actor,
                Detail = quote.Detail
            });
        }

        // GET api/quote/{actor}
        [HttpGet("{actor}")]
        public ActionResult<QuoteView> GetAnyQuote(string actor)
        {
            if (!_service.HasQuoteByActor(actor))
            {
                return NotFound();
            }

            var quote = _service.GetAnyQuote(actor);

            return Ok(new QuoteView()
            {
                Id = quote.Id,
                Actor = quote.Actor,
                Detail = quote.Detail
            });
        }
    }
}
