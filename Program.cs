using Connect_ong_API.Data;
using Connect_ong_API.Data.Repository.Implementation;
using Connect_ong_API.Data.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<AppDbContext>(builder.Configuration.GetConnectionString("connect-ong"));

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IPhoneRepository, PhoneRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
