using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HTTPPost
{
    class Program
    {



        static async Task Main(string[] args)
        {
            var person = new Ticket()
            {
                Title = "abc",
                Description = "xyz",
                ContactName = "asdsad",
                ContactPhone = "1365456",
                ContactEmail = "abc@gmail.com",
                ContactAddress = "bbb hcm city",
                ContactCompanyName = "gn.com"
            };



            var json = JsonConvert.SerializeObject(person);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://gn-helpdesk-dev.azurewebsites.net/api/ticket/create";
            using var client = new HttpClient();

            var bearerToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6ImU5MGYxNWU4NzcxNzAyNWUyNjM5MjIwOTcwZjcyYWU3IiwidHlwIjoiYXQrand0In0.eyJuYmYiOjE1OTcyMjQ1NzksImV4cCI6MTU5NzU4NDU3OSwiaXNzIjoiaHR0cDovL3Bhc3Nwb3J0LmRldi5nYW5uaGEuY29tIiwiYXVkIjoiaHR0cDovL2FwaS5kZXYuZ2FubmhhLmNvbS9yZXNvdXJjZXMiLCJjbGllbnRfaWQiOiJhMWZjY2QxNS1iMzk1LTRkMjgtYWIyMy1mZWI1MDFhYjk4NzgiLCJ0aWQiOiJlOWM1OTNkZS0xOWViLTQwODctOTRmOS00MDEyODU4NzNiNzMiLCJzY29wZSI6WyJuZWFybWUuYXBpIl19.dY42e-L32019-3Bs5LNTai97AjjQXD_H8T7ARCjc2u6qIMNR-RaoiLbZEjk5DsXAeqpXZ5CsGBQ5q0poqXNnvzDZpqLy09yBG2dV_9BXhyCf86aFf_xSXDW7wQYHwcAyLwAmksisAr7Y1pOWdAfOIPpxFhX0HRZTtNdwiJJyIKZjMpN2iUipEkgXtd47_glAks98WM5UV1BuY_lV5SCbZIQqRDpllieSV-zBJBF5WE1JBdrAiqCLSqP3imaz7x1sl5I3SGMOoiEbQ2LZ7GcdA6UjfYIgDW0NC0DlkzEBAxz3AulxUwYlEwh0340XP-bezTBMHM_HtFVMzJLmmj6Y-A";

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }




        //static void Main(string[] args)
        //{
        //    bool POSTData(object json)
        //    {
        //        string url = "http://gn-helpdesk-dev.azurewebsites.net/api/ticket/create";

        //        var bearerToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6ImU5MGYxNWU4NzcxNzAyNWUyNjM5MjIwOTcwZjcyYWU3IiwidHlwIjoiYXQrand0In0.eyJuYmYiOjE1OTcyMjQ1NzksImV4cCI6MTU5NzU4NDU3OSwiaXNzIjoiaHR0cDovL3Bhc3Nwb3J0LmRldi5nYW5uaGEuY29tIiwiYXVkIjoiaHR0cDovL2FwaS5kZXYuZ2FubmhhLmNvbS9yZXNvdXJjZXMiLCJjbGllbnRfaWQiOiJhMWZjY2QxNS1iMzk1LTRkMjgtYWIyMy1mZWI1MDFhYjk4NzgiLCJ0aWQiOiJlOWM1OTNkZS0xOWViLTQwODctOTRmOS00MDEyODU4NzNiNzMiLCJzY29wZSI6WyJuZWFybWUuYXBpIl19.dY42e-L32019-3Bs5LNTai97AjjQXD_H8T7ARCjc2u6qIMNR-RaoiLbZEjk5DsXAeqpXZ5CsGBQ5q0poqXNnvzDZpqLy09yBG2dV_9BXhyCf86aFf_xSXDW7wQYHwcAyLwAmksisAr7Y1pOWdAfOIPpxFhX0HRZTtNdwiJJyIKZjMpN2iUipEkgXtd47_glAks98WM5UV1BuY_lV5SCbZIQqRDpllieSV-zBJBF5WE1JBdrAiqCLSqP3imaz7x1sl5I3SGMOoiEbQ2LZ7GcdA6UjfYIgDW0NC0DlkzEBAxz3AulxUwYlEwh0340XP-bezTBMHM_HtFVMzJLmmj6Y-A";
        //        var _httpClient = new HttpClient();
        //        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);


        //        using (var content = new StringContent(JsonConvert.SerializeObject(json), System.Text.Encoding.UTF8, "application/json"))
        //        {
        //            HttpResponseMessage result = _httpClient.PostAsync(url, content).Result;
        //            if (result.StatusCode == System.Net.HttpStatusCode.Created)
        //            {
        //                Console.WriteLine(result.StatusCode);
        //                return true;
        //            }
        //            string returnValue = result.Content.ReadAsStringAsync().Result;
        //            throw new Exception($"Failed to POST data: ({result.StatusCode}): {returnValue}");
        //        }
        //    }

        //    var tags = new Tag()
        //    {
        //        Value = "123"
        //    };

        //    var json = new Ticket()
        //    {
        //        Title = "abc",
        //        Description = "xyz",
        //        ContactName = "asdsad",
        //        ContactPhone = "1365456",
        //        ContactEmail = "abc@gmail.com",
        //        ContactAddress = "bbb hcm city",
        //        ContactCompanyName = "gn.com",
        //    };

        //    if (POSTData(json) == true)
        //    {

        //    }

        //    else
        //        Console.WriteLine("not oke");

        //}

    }


}
