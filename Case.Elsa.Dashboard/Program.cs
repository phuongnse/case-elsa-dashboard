var webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder.Services.AddRazorPages();

var webApplication = webApplicationBuilder.Build();

webApplication.UseStaticFiles();
webApplication.UseRouting();

webApplication.UseEndpoints(
    endpointRouteBuilder =>
    {
        endpointRouteBuilder.MapFallbackToPage("/_Host");
    });

webApplication.Run();