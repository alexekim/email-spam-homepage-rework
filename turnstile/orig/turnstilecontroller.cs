using System;
using Launchpad.Core.Abstractions.Services;
using Launchpad.Core.Models;
using Launchpad.Core.Specifications;

using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;

namespace Launchpad.Api.Controllers
{
    public class TurnstileController : ApiController
    {
        private static readonly HttpClient httpClient = new HttpClient();

        [HttpPost]
        [Route("api/turnstile/validate")]
        public async Task<IHttpActionResult> Validate([FromBody] TurnstileRequest model)
        {
            var secretKey = "0x4AAAAAABlDXPrNek0anc13g_tlliBa-zg"

            var values = new Dictionary<string, string>
            {
                { "secret", secretKey },
                { "response", model.Token }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await httpClient.PostAsync("https://challenges.cloudflare.com/turnstile/v0/siteverify", content);
            var responseString = await response.Content.ReadAsStringAsync();

            return Ok(responseString); // You can parse and check success:true in production
        }

        public class TurnstileRequest
        {
            public string Token { get; set; }
        }
    }
}