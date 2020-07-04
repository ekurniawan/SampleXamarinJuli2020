using Newtonsoft.Json;
using SampleXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SampleXamarinApp.Services
{
    public class EmployeeService
    {
        private string restUrl = "https://myactualbackend.azurewebsites.net";
        private HttpClient _client;
        public EmployeeService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", "ZXJpY2s6cmFoYXNpYWJybw==");
        }

        public async Task<List<Employee>> GetAll()
        {
            List<Employee> lstEmp = new List<Employee>();
            var uri = new Uri($"{restUrl}/api/Employee");
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    lstEmp = JsonConvert.DeserializeObject<List<Employee>>(content);
                }
                else
                {
                    throw new Exception("Gagal mengakses api");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lstEmp;
        }
    }
}
