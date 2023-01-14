using Database;
using Microsoft.EntityFrameworkCore;
using Mocks.Services;
using Services.Goods;
using Services.Races;
using Services.Toasts;

var builder = WebApplication.CreateBuilder(args);
var cx = builder.Configuration.GetValue<string>("HHh");
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite("Filename=../Database/Database.db"));
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

if (builder.Configuration.GetValue<bool>("UseInMemoryDatabase")) {
  builder.Services.AddScoped<IRaceService, MockRaceService>();
  builder.Services.AddScoped<IGoodService, MockGoodService>();
} else {
  builder.Services.AddScoped<IRaceService, RaceService>();
  builder.Services.AddScoped<IGoodService, GoodService>();
}
builder.Services.AddScoped<IToastService, ToastService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
  app.UseExceptionHandler("/Error");
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
