var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "studentDetails",
    pattern: "test/info/{id}/{name}/{course}",
    defaults: new { controller = "Student", action = "Detailed" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Create}/{id?}");

app.Run();
