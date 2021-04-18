using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SO.DI._001.Exceptions;
using SO.DI._001.Services;
using System;

namespace SO.DI._001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMyService _myService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         IMyService myService)
        {
            _logger = logger;
            _myService = myService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _myService.DoSomething();
            }
            catch (SomeCustomException ex)
            {
                _logger.LogError($"{nameof(SomeCustomException)} {ex.Message}");

                //Handle it
            }
            catch (AnotherCustomerException ex) when (ex.Message == "blabla")
            {
                _logger.LogError($"{nameof(AnotherCustomerException)} {ex.Message} blablabla");

                //Handle it
            }
            catch (AnotherCustomerException ex)
            {
                _logger.LogError($"{nameof(AnotherCustomerException)} {ex.Message}");

                //Handle it
                //Handle it
            }
            catch (Exception ex)
            {
                //This is the default exception
            }


            return Ok();
        }
    }
}
