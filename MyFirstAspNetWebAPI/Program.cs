//Program.cs is the the file from where the execution is going to begin.
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Here MapGet tells that on a specific port number we are going to get a response of Hello World
//here response body is the Hello World.
//app.MapGet("/", () => "Hello World!");

//run method is used to start the server
//automatically it takes a kestrel server
//can be chaged with using launchSetting.json


app.Run(async (HttpContext context) =>
{
    if (1 == 1)
    {
        context.Response.StatusCode = 200;
    }
    else
    {
        context.Response.StatusCode = 500;
    }
    //now lets say you want to give your own response headers then 
    context.Response.Headers["MyCustomKey"] = "my value";
    //this will overrride the actual response header
    context.Response.Headers["Server"] = "MyServer";
    //type of content you want as a response 
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("<i>Hello</i>");
    await context.Response.WriteAsync("<b>From World</b>");
});
app.Run();
