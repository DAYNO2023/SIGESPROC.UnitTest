using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SIGESPROC.API.Controllers.ControllersProyecto;
using SIGESPROC.API.Extensions;
using SIGESPROC.BusinessLogic.Services.ServiceProyecto;
using SIGESPROC.Common.Models.ModelsProyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESPROC.UnitTest.Controllers
{
    [TestClass]
    public class ProsupuestoEmcabezadoTest
    {
        private ProyectoService _proyectoService;
        private static IMapper _mapper;

        public ProsupuestoEmcabezadoTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfileExtensions());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }
        protected Mock<IMapper> map = new Mock<IMapper>();
        PresupuestoEncabezadoController _presupuestoEncabezado;

        [TestInitialize]
        public void Initalize()
        {
            _presupuestoEncabezado = new PresupuestoEncabezadoController(_proyectoService, _mapper);
        }


        [TestMethod]
        public void presupuestoEncabezadoCreate()
        {
            var data = new PresupuestoEncabezadoViewModel();
            var result = _presupuestoEncabezado.Create(data);

            Assert.IsInstanceOfType<IActionResult>(result);
            Assert.IsNotNull(result);
        }



        [TestMethod]
        public void presupuestoEncabezadoUpdate()
        {
            int id = 0;
            var data = new PresupuestoEncabezadoViewModel();
            var result = _presupuestoEncabezado.Update(data);

            Assert.IsInstanceOfType<IActionResult>(result);
            Assert.IsNotNull(result);
        }





    }
}
