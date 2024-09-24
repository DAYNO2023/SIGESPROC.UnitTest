using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using SIGESPROC.API.Controllers.ControllersProyecto;
using SIGESPROC.BusinessLogic.Services.ServiceProyecto;
using SIGESPROC.Common.Models.ModelsProyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESPROC.UnitTest.Controllers
{
    [TestFixture]
    public class ProsupuestoEmcabezadoTest
    {
        private ProyectoService _proyectoService;
        private static IMapper _mapper;

        [Test]
        public void presupuestoEncabezadoCreate()
        {
            PresupuestoEncabezadoViewModel presupuestoEncabezadoViewModel = new PresupuestoEncabezadoViewModel();
            PresupuestoEncabezadoController presupuestoEncabezadoController = new PresupuestoEncabezadoController(_proyectoService, _mapper);
            var result = presupuestoEncabezadoController.Create(presupuestoEncabezadoViewModel);
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IActionResult>(result);
        }
        [Test]
        public void presupuestoEncabezadoUpdate()
        {
            int id = 2;
            PresupuestoEncabezadoViewModel presupuestoEncabezadoViewModel = new PresupuestoEncabezadoViewModel();
            PresupuestoEncabezadoController presupuestoEncabezadoController = new PresupuestoEncabezadoController(_proyectoService, _mapper);
            var result = presupuestoEncabezadoController.Update(presupuestoEncabezadoViewModel);
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IActionResult>(result);
        }
    }

    
}
