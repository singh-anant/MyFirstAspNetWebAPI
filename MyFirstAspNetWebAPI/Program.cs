//Program.cs is the the file from where the execution is going to begin.
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



//Here MapGet tells that on a specific port number we are going to get a response of Hello World.
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
    //gives you the url which we write
    //if we want to sent some value using URL then we can use QUERY STRING



    //--------------------------------------------------
    //if(context.Request.Method == "GET")
    //{
    //    string id = context.Request.Query["id"];
    //    string name = context.Request.Query["name"];



    //    await context.Response.WriteAsync($"<p>Value of id and name from URL  name is:ID:{id} NAME:{name}</p>");



    //}
    //string path=context.Request.Path;
    //string methodName=context.Request.Method;
    //if (context.Request.Headers.ContainsKey("AuthorizationKey"))
    //{
    //    string AuthorizationKey = context.Request.Headers["AuthorizationKey"];
    //    await context.Response.WriteAsync($"<p>Authorization Key is:{AuthorizationKey}</p>");



    //}
    //await context.Response.WriteAsync($"<p>Method name is:{methodName}</p>");
    //await context.Response.WriteAsync($"<p>Path is:{path}</p>");
    //await context.Response.WriteAsync("<i>Hello</i>");
    //await context.Response.WriteAsync("<b>From World</b>");
    //---------------------------------------------------------------



    //The StreamReader provides a convenient way to read the stream of data(in this case, the request body) character by character or line by line.



    StreamReader reader = new StreamReader(context.Request.Body);
    //we are using stream reader because context.Request.Body is of type stream
    string body = await reader.ReadToEndAsync();





});
app.Run();
