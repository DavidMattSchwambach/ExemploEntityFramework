﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interfaces;

namespace view.Controllers
{
    [Route("computadorepeca/")]
    public class ComputadorPecaController : Controller
    {
        private IComputadorPecaRepository repository;

        public ComputadorPecaController(IComputadorPecaRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("relacionar")]
        public JsonResult Relacionar(ComputadorPeca computadorPeca)
        {
            int id = repository.Relacionar(computadorPeca);
            return Json(new { id });
        }

        [HttpGet, Route("apagar")]
        public JsonResult Apagar(int id)
        {
            bool alterado = repository.Apagar(id);
            return Json(new { status = alterado });
        }

        [HttpGet, Route("obtertodos")]
        public JsonResult ObterTodosPeloIdComputador(int idComputador)
        {
            return Json(
                new
                {
                    data = repository.ObterTodosPeloIdComputador(idComputador)
                }

            );
                    
        }

        [HttpGet, Route("obterpeloid")]
        public ActionResult ObterTodosPeloId(int id)
        {
            var computadorPeca = repository.ObterPeloId(id);
            if (computadorPeca == null)
                return NotFound();
            return Json(computadorPeca);
            
        }
    }
}