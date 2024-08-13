using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//connect db
string connectionString = "Data Source=127.0.0.1;Initial Catalog=HR_Manage;TrustServerCertificate=True;User ID=sa;Password=Abcd@1234";
builder.Services.AddDbContext<Final_MVC.Entities.AppDbContext>(
    options => options.UseSqlServer(connectionString)
    );
//end

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

