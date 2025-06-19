using gestionTareas;
using System.Text.Json;
string url = "https://jsonplaceholder.typicode.com/todos/";
HttpClient client = new HttpClient();
HttpResponseMessage respuesta = await client.GetAsync(url);
respuesta.EnsureSuccessStatusCode();
string responseBody = await respuesta.Content.ReadAsStringAsync();
List<Tarea> listTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
string path = Path.Combine(Directory.GetCurrentDirectory(),"tareas.json");
string tareasJson = JsonSerializer.Serialize(listTareas);
File.WriteAllText(path, tareasJson);


Console.WriteLine("====TAREAS PENDIENTES====");
foreach (var tareasP in listTareas)
{
    if (!tareasP.completed)
    {
        Console.WriteLine($"Título: [{tareasP.title}]");
        Console.WriteLine($"Completada: [{tareasP.completed}]");
        Console.WriteLine();
    }
}

Console.WriteLine("====TAREAS REALIZADAS====");
foreach (var tareasR in listTareas)
{
    if (tareasR.completed == true)
    {
        Console.WriteLine($"Título: [{tareasR.title}]");
        Console.WriteLine($"Completada: [{tareasR.completed}]");
        Console.WriteLine();
    }
}
