using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageDeliveryMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagingDeliveryCharge : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPackagingDeliveryCharge(string item, int count)
        {
            
            int Charges = 0;
            bool flag = false;
            if (count <= 0)
            {
                Charges = -1;
            }
            else if (item.Trim().ToUpper() == "INTEGRAL")
            {
                flag = true;
                Charges = 300;
            }
            else if (item.Trim().ToUpper() == "ACCESSORY")
            {
                flag = true;
                Charges = 150;
            }

            if (Charges != -1 && flag) {
                return Ok(Charges*count);
            }
            return BadRequest();
           // Charges * count;
            
        }

    }
}
