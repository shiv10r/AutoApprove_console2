using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AutoApprove_console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string apiUrl = "https://api.example.com/data"; // Replace with your actual API endpoint

            using HttpClient client = new HttpClient();

            try
            {
                // Making a GET request and deserializing the JSON response into the ApiResponse class
                var response = await client.GetFromJsonAsync<ApiResponse>(apiUrl);
                if (response != null)
                {
                    Console.WriteLine("Data retrieved successfully:");
                    Console.WriteLine($"ID: {response.Id}, Name: {response.Name}, Value: {response.Value}");
                }
                else
                {
                    Console.WriteLine("No data found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    // Define a class to represent the API response structure
    public class ApiResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
