﻿using Microsoft.AspNetCore.Mvc;
using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;

namespace RSMEnterpriseIntegrationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase

    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        [HttpGet("GetAll")]

        public async Task<IActionResult> Get()
        {
            return Ok(await _productCategoryService.GetAll());

        }
        [HttpPost("Create")]

        public async Task<IActionResult> Create(CreateProductCategoryDto dto)
        {
            return Ok(await _productCategoryService.CreateProduct(dto));
        }

    }
 }
