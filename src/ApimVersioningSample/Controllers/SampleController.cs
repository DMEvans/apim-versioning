namespace ApimVersioningSample.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route("v{version:apiVersion}/[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1")]
        public string GetV1() => "A sample from V1";

        [HttpGet]
        [MapToApiVersion("2")]
        public string GetV2() => "A sample from V2";
    }
}
