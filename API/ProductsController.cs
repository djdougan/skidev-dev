using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Core.Entities;

namespace API.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController: ControllerBase
    {
        private readonly StoreContext _storeContext;

        public ProductsController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(){
            return await _storeContext.Products.ToListAsync();

        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            return await _storeContext.Products.FindAsync(id);
        }

    }
}