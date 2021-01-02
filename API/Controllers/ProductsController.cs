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
using Core.Interfaces;

namespace API.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController: ControllerBase
    {
        private readonly IProductRepository _productsRepository;

        public ProductsController(IProductRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet()]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts(){
            var products = await _productsRepository.GetProductsAsync();
            return Ok(products);
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            return await _productsRepository.GetProductByIdAsync(id); 
            }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductsBrands(){

            var brands = await _productsRepository.GetProductBrandsAsync();
            return Ok(brands);
        }
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductsTypes(){

            var types = await _productsRepository.GetProductTypesAsync();
            return Ok(types);
        }

    }
}