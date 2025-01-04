namespace CreditCardClientSideSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Serve static files from wwwroot
            app.UseStaticFiles();

            // Map the root route to serve the sign-up.html file from wwwroot folder
            app.MapGet("/", async context =>
            {
                context.Response.ContentType = "text/html";
                // Corrected path to the wwwroot folder
                await context.Response.SendFileAsync("wwwroot/RegistrationPage.html");
            });

            // Run the application
            app.Run();
        }
    }
}
