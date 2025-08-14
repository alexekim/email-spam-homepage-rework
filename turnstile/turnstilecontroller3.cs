using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;

namespace Launchpad.Api.Controllers
{
    public class TurnstileController : ApiController
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private async Task<IHttpActionResult> ValidateInternal(TurnstileRequest model, string secretKey)
        {
            var values = new Dictionary<string, string>
            {
                { "secret", secretKey },
                { "response", model.Token }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await httpClient.PostAsync("https://challenges.cloudflare.com/turnstile/v0/siteverify", content);
            var responseString = await response.Content.ReadAsStringAsync();

            return Ok(responseString);
        }

        [HttpPost]
        [Route("api/turnstile/validate-footer")]
        public async Task<IHttpActionResult> ValidateFooter([FromBody] TurnstileRequest model)
        {
            const string footerSecretKey = "0x4AAAAAABlDXPrNek0anc13g_tlliBa-zg";
            return await ValidateInternal(model, footerSecretKey);
        }

        [HttpPost]
        [Route("api/turnstile/validate-lightbox")]
        public async Task<IHttpActionResult> ValidateLightbox([FromBody] TurnstileRequest model)
        {
            const string lightboxSecretKey = "0x4BBBBBBBexampleLightboxSecret";
            return await ValidateInternal(model, lightboxSecretKey);
        }

        public class TurnstileRequest
        {
            public string Token { get; set; }
        }
    }
}
