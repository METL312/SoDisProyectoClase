﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Supermarket.API.Controllers
{
    [Route("lgomez9/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // obtener información de manera grupal, sin necesidad de un parámetro 
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return String.Format("Get individual con el parametro {0}", id);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return String.Format("Post: se creo un registro con los datos {0}", value);
            // permitir la creación de un elemento apoyado en los parámetros recibidos
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            // permitir la modificación de un elemento apoyado en los parámetros recibidos
            return String.Format("HttpPut modificar elmento {0}, con el valor {1}", id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            // permitir la eliminación de un elemento apoyado en los parámetros recibidos
            return String.Format("HttpDelete {0}", id);
        }
    }
}
