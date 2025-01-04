namespace CreditCardClientSideSolution
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var app = builder.Build();

			app.UseStaticFiles();

			app.MapGet("/", async context =>
			{
				context.Response.ContentType = "text/html";
				await context.Response.SendFileAsync("sign-up.html");
				
				
			});

			

			app.Run();
		}
	}
}
