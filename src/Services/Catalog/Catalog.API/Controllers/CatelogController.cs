using Catalog.API.Entities;
using Catalog.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatelogController : ControllerBase
    {
        private readonly IProductRepository repository;
        private readonly ILogger<CatelogController> logger;

        public CatelogController(IProductRepository repository, ILogger<CatelogController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

            }
}
