using Microsoft.AspNetCore.ResponseCompression;
using ElectricityLoging.EF.Entities;
using Microsoft.EntityFrameworkCore;
using ElectricityLoging.EF.Repositories;
using ElectricityLoging.Core.Managers;
using ElectricityLoging.Core.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContextFactory<AppDbContext>(opt=>opt.UseSqlServer("server=localhost\\SQLEXPRESS;Database=ElectricityLoging;trusted_connection=true"));
builder.Services.AddScoped<IGenericRepository<PaymentEntry>, PaymentEntryRepository>();
builder.Services.AddScoped<IPaymentEntryManager, PaymentEntryManager>();
builder.Services.AddScoped<IRecordQuerries, RecordQuerries>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
