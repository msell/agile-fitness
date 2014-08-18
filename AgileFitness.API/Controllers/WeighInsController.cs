﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using AgileFitness.API.Models;
using Microsoft.AspNet.Identity;

namespace AgileFitness.API.Controllers
{
    [RoutePrefix("api/WeighIns")]
    public class WeighInsController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(WeighIn.CreateWeighIns());
        }

        [Authorize]
        [Route("")]
        public IHttpActionResult Post(WeighIn weighIn)
        {
            var foo = ClaimsPrincipal.Current.Identity;
            return Ok(ClaimsPrincipal.Current.Claims.SingleOrDefault(c => c.Type == "sub").Value + " weighed in");
        }
    }

    public class WeighIn
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public static List<WeighIn> CreateWeighIns()
        {
            var list = new List<WeighIn>
            {
                new WeighIn {Id = 1, Name = "Matt", Weight = 255, Date = DateTime.Now},
                new WeighIn {Id = 2, Name = "Latish", Weight = 255, Date = DateTime.Now},
                new WeighIn {Id = 3, Name = "Michael", Weight = 255, Date = DateTime.Now}
            };

            return list;
        }
    }
}
