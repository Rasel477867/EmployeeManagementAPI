using EmployeeAPI.Repository;
using EmployeeAPI.Repository.Contact;
using EmployeeAPI.Service;
using EmployeeAPI.Service.Contacts;
using EmployeeAPI.Web.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// depedency injection
builder.Services.AddTransient<IEmployeeUnitOfWork , EmployeeUnitOfWork>();
builder.Services.AddTransient<IEmployeeService,EmployeeService>();
// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(DomainMaper));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
