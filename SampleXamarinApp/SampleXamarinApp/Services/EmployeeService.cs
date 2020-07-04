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

        public async Task Insert(Employee emp)
        {
            var uriPost = new Uri($"{restUrl}/api/Employee");
            try
            {
                var jsonObj = JsonConvert.SerializeObject(emp);
                var content = new StringContent(jsonObj,
                    Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(uriPost, content);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Data gagal untuk ditambahkan");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Edit(Employee emp)
        {
            var uriPut = new Uri($"{restUrl}/api/Employee");
            try
            {
                var json = JsonConvert.SerializeObject(emp);
                var content = new StringContent(json, 
                    Encoding.UTF8, "application/json");
                var response = await _client.PutAsync(uriPut, content);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Data gagal untuk diupdate");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(string id)
        {
            var uriDelete = new Uri($"{restUrl}/api/Employee/{id}");
            try
            {
                var response = await _client.DeleteAsync(uriDelete);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Data gagal untuk didelete");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
