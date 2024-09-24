using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using SIGESPROC.API;
using Newtonsoft.Json;
using SIGESPROC.Common.Models.ModelsProyecto;
using System.Text;
using System;

public class IntegrationTestPresupuestoEditar : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    private const string ApiKey = "4b567cb1c6b24b51ab55248f8e66e5cc"; 

    public IntegrationTestPresupuestoEditar(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
        _client.DefaultRequestHeaders.Add("XApiKey", ApiKey); 
    }

    [Fact]
    public async Task Put_PresupuestoEncabezado_Actualizar_ReturnsSuccess()
    {
        var presupuestoData = new PresupuestoEncabezadoViewModel
        {
            pren_Id = 91, 
            pren_Titulo = "Presupuesto Actualizado",
            pren_Descripcion = "Descripción actualizada del presupuesto",
            pren_Fecha = DateTime.Now,
            pren_FechaFinalizacion = DateTime.Now.AddMonths(6),
            pren_PorcentajeGanancia = 30,
            pren_Observacion = "Observaciones actualizadas",
            pren_Maquinaria = true,
            pren_Impuesto = 18,
            empl_Id = 2,
            clie_Id = 2,
            usua_Creacion = 3,
            pren_FechaCreacion = DateTime.Now,
            pren_Estado = "string",
            proy_Id = 4
        };

        var content = new StringContent(JsonConvert.SerializeObject(presupuestoData), Encoding.UTF8, "application/json");

        var response = await _client.PutAsync("/api/PresupuestoEncabezado/Actualizar", content); // Cambié a PUT para actualizaciones

        Assert.True(response.IsSuccessStatusCode, $"Error en la solicitud: {response.StatusCode}");

        var responseContent = await response.Content.ReadAsStringAsync();

        Assert.NotEmpty(responseContent);

        Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());

        var result = JsonConvert.DeserializeObject<PresupuestoEncabezadoViewModel>(responseContent);
        Assert.NotNull(result); 
    }
}
