// my practice describe:
 //This is a class in ASP.NET Core that provides a fluent API for configuring and building web applications. It's part of the hosting infrastructure for ASP.NET Core applications.
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
}
var app = builder.Build(); //This line creates an instance of the application by calling the Build
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

