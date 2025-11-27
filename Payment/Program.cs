using Application.Common.Helpers;
using Application.Configures;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Interface;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IDataBaseContext, DataBaseContext>(p => p.UseSqlServer(builder.Configuration["conection"], x => x.UseNetTopologySuite()));
builder.Services.AddApplicationServices();
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new List<CultureInfo>
                    {
                        new CultureInfo("fa"),
                        //new CultureInfo("en-US")
                    };
    options.DefaultRequestCulture = new RequestCulture("fa", "fa");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.ApplyCurrentCultureToResponseHeaders = true;
    //options.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(async context =>
    //{
    //    var userLangs = context.Request.Headers["Accept-Language"].ToString();
    //    var firstLang = userLangs.Split(',').FirstOrDefault();
    //    var defaultLang = string.IsNullOrEmpty(firstLang) ? "fa" : firstLang;
    //    return await Task.FromResult(new ProviderCultureResult(defaultLang, defaultLang));
    //}));
});
builder.Services.AddControllers().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRequestLocalization();
AppSettingsHelper.Initialize(builder.Configuration);
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Callback}/{action=Index}/{id?}");

app.Run();
