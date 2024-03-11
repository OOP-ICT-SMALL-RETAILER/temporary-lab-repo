using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IDeliveryPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeliveryPointController : ControllerBase
    {
        private readonly IDeliveryPointService _deliveryPointService;

        public DeliveryPointController(IDeliveryPointService deliveryPointService)
        {
            _deliveryPointService = deliveryPointService;
        }

        [HttpGet("{id}")]
        public ActionResult<DeliveryPoint> Get(int id)
        {
            var dp = _deliveryPointService.GetDeliveryPointById(id);
            if (dp == null)
            {
                return NotFound();
            }
            return Ok(dp);
        }

        [HttpPost]
        public ActionResult<DeliveryPoint> Post(DeliveryPoint deliveryPoint)
        {
            _deliveryPointService.AddDeliveryPoint(deliveryPoint);
            return CreatedAtAction(nameof(Get), new { id = deliveryPoint.Id }, deliveryPoint);
        }

        [HttpGet]
        public ActionResult<List<DeliveryPoint>> GetAll()
        {
            var deliveryPoints = _deliveryPointService.GetAllDeliveryPoints();
            return Ok(deliveryPoints);
        }
    }
}