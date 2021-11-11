using HotChocolateTest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddGraphQLServer()
  .AddQueryType<QueryType>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
  {
    endpoints.MapGraphQL("/graphql")
      .WithOptions(new HotChocolate.AspNetCore.GraphQLServerOptions
      {
        Tool = { Enable = true }
      });
  }
);

app.Run();
