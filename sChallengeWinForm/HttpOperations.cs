using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

/*
 * Singleton class containing HTTP operations for the Telehealth application
 */

namespace sChallengeWinForm
{
    class HttpOperations
    {
        // Defines a patient object to be sent to the API (matches the PatientDTO)
        public class Patient
        {
            public long Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string Province { get; set; }
            public string Country { get; set; }
            public bool HasCovid { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Health_Notes { get; set; }
            public DateTime Call_Date { get; set; }
            public long AgentId { get; set; }
        }

        public class Login
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        // Defines a user object to be sent to the API (matches the UserDTO)
        public class User
        {
            public long Id { get; set; }
            public string Username { get; set; }
        }

        private static HttpClient client = new HttpClient();
        private static HttpOperations operations = new HttpOperations();

        private HttpOperations()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:44322/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static HttpOperations OperationsInstance
        {
            get { return operations; }
        }

        /*
         * Interacts with the accompanying API to perform a login operation. Returns a 
         * true/false depending on if the login credentials are successful.
         */
        public async Task<object> login(string username, string password)
        {
            string url = "api/Users/login";
            JObject data = null;

            Login loginPost = new Login
            {
                Username = username,
                Password = password
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(url, loginPost);

            if(response.IsSuccessStatusCode) // login request executed successfully
            {
                data = await response.Content.ReadAsAsync<JObject>();
            }

            bool resSuccess = data.Value<bool>("success"); // JSON response "success" field
            
            if (resSuccess) // login successful
            {
                long resUserID = data.Value<int>("userId"); // JSON response "userID" field
                return new { success = resSuccess, userId = resUserID};
            } else // login unsuccessful
            {
                return new { success = false };
            }
        }

        public async Task<Uri> postPatient(Patient patientPost)
        {
            string url = "api/Patients";

            HttpResponseMessage response = await client.PostAsJsonAsync(url, patientPost);

            response.EnsureSuccessStatusCode();

            return response.Headers.Location; // return URI of the created resource
            
        }
    }
}
