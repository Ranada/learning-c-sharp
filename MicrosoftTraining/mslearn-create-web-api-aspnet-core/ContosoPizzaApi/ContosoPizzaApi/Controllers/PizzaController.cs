﻿using ContosoPizzaApi.Models;
using ContosoPizzaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizzaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    { 
        var pizza = PizzaService.Get(id);

        if (pizza == null) 
        {
            return NotFound();
        }

        return Ok(pizza);
    }

    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza) 
    { 
        if (id != pizza.Id) 
        {
            return BadRequest();
        }

        var existingPizza = PizzaService.Get(id);

        if (existingPizza == null) 
        { 
            return NotFound(id);
        }

        PizzaService.Update(pizza);

        return NoContent();
    }


    // DELETE action


}