// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using creadorUsuarios;
HttpClient client = new HttpClient();
string url = "https://jsonplaceholder.typicode.com/users";
HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();

string responseBody = await response.Content.ReadAsStringAsync();
List<Usuarios> listUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(responseBody);

for (int i = 0; i < 5; i++)
{
    var usuario = listUsuarios[i];
    Console.WriteLine($"Nombre del usuario[{usuario.name}]");
    Console.WriteLine($"Email del usuario[{usuario.email}]");
    Console.WriteLine($"Direccion del usuario[{usuario.address.suite}/{usuario.address.street}/{usuario.address.city}]");
    Console.WriteLine();
    }

