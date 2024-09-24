using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using SIGESPROC.API;
using System.Collections.Generic;
using Newtonsoft.Json;
using SIGESPROC.Entities.Entities;
using SIGESPROC.Common.Models.ModelsPlanilla;
using SIGESPROC.Common.Models.ModelsProyecto;
using System.Text;
using System;

public class IntegrationTEstPresupuesto : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    private const string ApiKey = "4b567cb1c6b24b51ab55248f8e66e5cc"; 

    public IntegrationTEstPresupuesto(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();

        _client.DefaultRequestHeaders.Add("XApiKey", ApiKey);
    }

    [Fact]
    public async Task Post_PresupuestoEncabezado_Create_ReturnsSuccess()
    {
        var presupuestoData = new PresupuestoEncabezadoViewModel
        {
            pren_Titulo = "Presupuesto de Ejemplo",
            pren_Descripcion = "Descripción del presupuesto",
            pren_Fecha = DateTime.Now,
            pren_FechaFinalizacion = DateTime.Now.AddMonths(6),
            pren_PorcentajeGanancia = 30,
            pren_Observacion = "Sin observaciones",
            pren_Maquinaria = true,
            pren_Impuesto = 15,
            empl_Id = 2, 
            clie_Id = 2, 
            usua_Creacion = 3, 
            pren_FechaCreacion = DateTime.Now,
            pren_Estado = "string",
            proy_Id = 4
        };

        var content = new StringContent(JsonConvert.SerializeObject(presupuestoData), Encoding.UTF8, "application/json");

        var response = await _client.PostAsync("/api/PresupuestoEncabezado/Insertar", content);

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();

        Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());

        Assert.NotEmpty(responseContent);

        var result = JsonConvert.DeserializeObject<PresupuestoEncabezadoViewModel>(responseContent);
        Assert.NotNull(result);
    }

    //[Fact]
    //public async Task Get_Endpoint_ReturnsSuccess()
    //{
    //    // Act: Call the API endpoint
    //    var response = await _client.GetAsync("/api/Planilla/ListarDeduccionesJefesObras/2024-09-23");

    //    // Ensure the response was successful 
    //    response.EnsureSuccessStatusCode(); // Check for status code 2xx

    //    // Read the response content
    //    var content = await response.Content.ReadAsStringAsync();

    //    // Verify the content type
    //    Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());

    //    // Optional: Validate the content (for example, check if the result is not empty)
    //    Assert.NotEmpty(content); // Assuming you expect some data to be returned

    //    // You could also deserialize the JSON and assert specific properties if needed
    //    var responseData = JsonConvert.DeserializeObject<List<PagoJefeObraPlanillaViewModel>>(content); // Adjust type
    //    Assert.NotNull(responseData); // Ensure data is not null
    //    Assert.All(responseData, item => Assert.False(string.IsNullOrEmpty(item.empl_Id.ToString()))); // Example property check
    //}

    //[Fact]
    //public async Task Post_Endpoint_CreatesNewResource()
    //{
    //    // Prepara el contenido para un POST
    //    var content = new StringContent("{\"name\":\"test value\"}",
    //                                     System.Text.Encoding.UTF8,
    //                                     "application/json");

    //    // Actúa: Envía la petición POST
    //    var response = await _client.PostAsync("/api/Proyecto/Listar", content);

    //    // Asegúrate de que la respuesta fue un código de éxito
    //    response.EnsureSuccessStatusCode();

    //    // Verifica que el recurso fue creado
    //    var responseString = await response.Content.ReadAsStringAsync();
    //    Assert.Contains("test value", responseString);
    //}
}
