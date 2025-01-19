public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<UserSessionService>();
        services.AddSingleton<AttendanceService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseResponseCompression();
        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapFallbackToFile("index.html");
        });
    }
}
