using System.Collections.Generic;
using devPartnerTest.Services;
using Microsoft.AspNetCore.Mvc;
using devPartnerTest.Models.ViewModel;
using devPartnerTest.Models;
using AutoMapper;
using System;

namespace devPartnerTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotaFiscalController : ControllerBase
    {
        public readonly INotaFiscalService _service;
        private readonly IMapper mapper;

        public NotaFiscalController(INotaFiscalService service, IMapper mapper)
        {
            _service = service;
            this.mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<NotaFiscal> GetById(int id)
        {
            var entity = _service.GetById(id);
            if(entity is null) return NotFound();

            return Ok(entity);
        }

        [HttpGet]
        public ActionResult<IEnumerable<NotaFiscal>> GetAll()
        {
            var entities = _service.GetAll();

            return Ok(entities);
        }

        [HttpPost]
        public ActionResult<bool> Add([FromBody] NotaFiscalPostViewModel notaFiscalPostViewModel)
        {
            if(notaFiscalPostViewModel.cnpjDestinatarioNf == null) return BadRequest();
            var notaFiscal = mapper.Map<NotaFiscal>(notaFiscalPostViewModel);

            notaFiscal.dataNf = DateTime.Now;

            _service.Create(notaFiscal);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] NotaFiscalPostViewModel notaFiscalPostViewModel, int id)
        {
            var entity = mapper.Map<NotaFiscal>(notaFiscalPostViewModel);

            entity.Id = id;

            var entityDb = _service.GetById(id);
            entity.dataNf = entityDb.dataNf;

            var status =_service.Update(entity);
            if(status == false) return NotFound();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var status = _service.Delete(id);
            if(status == false) return NotFound();
            
            return Ok();
        }
    }
}