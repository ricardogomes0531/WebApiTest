using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Shared.Utils
{
    public abstract class  ResultController : ControllerBase
    {
        public IActionResult GetResult<T>(IList<T> results)
        {
                        if (results.Count > 0)
                return Ok(results);

            return NoContent();
        }


    }
}
