﻿using Microsoft.AspNetCore.Mvc;
using TrafficEventsInformer.Models;
using TrafficEventsInformer.Services;

namespace TrafficEventsInformer.Controllers
{
    [ApiController]
    public class TrafficRoutesController : ControllerBase
    {
        private readonly ITrafficRoutesService _trafficRouteService;

        public TrafficRoutesController(ITrafficRoutesService trafficRouteService)
        {
            _trafficRouteService = trafficRouteService;
        }

        [HttpGet]
        [Route("api/trafficRoutes")]
        public IActionResult GetTrafficRoutes()
        {
            return Ok(_trafficRouteService.GetTrafficRouteNames());
        }

        [HttpPost]
        [Route("api/trafficRoutes")]
        public async Task<IActionResult> AddRouteAsync([FromForm] AddRouteRequest requestData)
        {
            await _trafficRouteService.AddRouteAsync(requestData);
            return Ok();
        }

        [HttpDelete]
        [Route("api/trafficRoutes")]
        public IActionResult DeleteRoute(int routeId)
        {
            _trafficRouteService.DeleteRoute(routeId);
            return Ok();
        }
    }
}
