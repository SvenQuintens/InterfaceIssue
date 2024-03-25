using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Voyager;
using HotChocolate.Execution.Configuration;
using InterfaceIssue;
using InterfaceIssue.Extensions;
using InterfaceIssue.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Just a random comment
builder.Services.AddControllers();

builder.Services.AddGraphQLServerCore()
    .AddGraphQL()
    .AddHttpRequestInterceptor<DefaultHttpRequestInterceptor>()
    .AddGraphQLTypeExtensions(typeof(TypeBase<>))
    .AddQueryType()
        .AddTypeExtension<ProductQueries>()
        .AddTypeExtension<PackageQueries>()
        .AddTypeExtension<PackageNode>()
    .AddGlobalObjectIdentification();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints
        .MapGraphQL();

    app.UseVoyager("/graphql", "/graphql-voyager");

    endpoints.MapGet("/", context =>
    {
        context.Response.Redirect("/graphql", true);
        return Task.CompletedTask;
    });
});

app.Run();
