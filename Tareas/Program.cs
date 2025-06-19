using gestionTareas;
using System.Text.Json;
string url = "https://jsonplaceholder.typicode.com/todos/";
HttpClient client = new HttpClient();
HttpResponseMessage respuesta = await client.GetAsync(url);
respuesta.EnsureSuccessStatusCode();
string responseBody = await respuesta.Content.ReadAsStringAsync();
List<Tarea> listTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);

foreach (var tareas in listTareas)
{
    Console.WriteLine($"UserId:[{tareas.userId}]");
    Console.WriteLine($"Id de la tarea[{tareas.id}]");
    Console.WriteLine($"Titulo:[{tareas.title}]");
    Console.WriteLine($"Completada:[{tareas.completed}]");
}