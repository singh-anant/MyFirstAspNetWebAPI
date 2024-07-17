//Program.cs is the the file from where the execution is going to begin.
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Here MapGet tells that on a specific port number we are going to get a response of Hello World
app.MapGet("/", () => "Hello World!");

//run method is used to start the server
//automatically it takes a kestral server
app.Run();
