using System.Net.Http.Json;

int id = 1; // ��� ��������� id ��������
// ��������� ������
List<Person> users = new List<Person>
{
    new() { Id = id++, Name = "Tom", Age = 37 },
    new() { Id = id++, Name = "Bob", Age = 41 },
    new() { Id = id++, Name = "Sam", Age = 24 }
};

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/api/users",  () => users);

app.MapGet("/api/users/{id}", (int id) =>
{
    // �������� ������������ �� id
    Person? user = users.FirstOrDefault(u => u.Id == id);
    // ���� �� ������, ���������� ��������� ��� � ��������� �� ������
    if (user == null) return Results.NotFound(new { message = "������������ �� ������" });

    // ���� ������������ ������, ���������� ���
    return Results.Json(user);
});

app.MapDelete("/api/users/{id}", (int id) =>
{
    // �������� ������������ �� id
    Person? user = users.FirstOrDefault(u => u.Id == id);

    // ���� �� ������, ���������� ��������� ��� � ��������� �� ������
    if (user == null) return Results.NotFound(new { message = "������������ �� ������" });

    // ���� ������������ ������, ������� ���
    users.Remove(user);
    return Results.Json(user);
});

app.MapPost("/api/users", (Person user) =>
{

    // ������������� id ��� ������ ������������
    user.Id = id++;
    // ��������� ������������ � ������
    users.Add(user);
    return user;
});

app.MapPut("/api/users", (Person userData) =>
{

    // �������� ������������ �� id
    var user = users.FirstOrDefault(u => u.Id == userData.Id);
    // ���� �� ������, ���������� ��������� ��� � ��������� �� ������
    if (user == null) return Results.NotFound(new { message = "������������ �� ������" });
    // ���� ������������ ������, �������� ��� ������ � ���������� ������� �������

    user.Age = userData.Age;
    user.Name = userData.Name;
    return Results.Json(user);
});

app.Run();

/*partial class Program
{
    static HttpClient httpClient = new HttpClient();
    static async Task Main()
    {
        List<Person>? people = await httpClient.GetFromJsonAsync<List<Person>>("https://localhost:5102/api/users");
        if (people != null)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}*/

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}