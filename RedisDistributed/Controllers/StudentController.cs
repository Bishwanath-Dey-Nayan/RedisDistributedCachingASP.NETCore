using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using RedisDistributed.Models;
using RedisDistributed.Helper;
using System.Threading;

namespace RedisDistributed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationContext _context = null;
        private readonly IDistributedCache _cache;
        public StudentController(ApplicationContext context, IDistributedCache cache)
        {
            _context = context;
            _cache = cache;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get()
        
        {
            var cacheKey = "GET_ALL_STUDENTS";
            List<Student> students = new List<Student>();

            var data = await _cache.GetRecordAsync<List<Student>>(cacheKey);

            if(data is null)
            {
                Thread.Sleep(10000);
                data = _context.Student.ToList();

                await _cache.SetRecordAsync(cacheKey, data);
            }
            return data;
        }
    }
}