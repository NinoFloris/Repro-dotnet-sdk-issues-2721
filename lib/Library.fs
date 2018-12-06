module Library

open Microsoft.Extensions.Options
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Authentication

let useIt =
    // Each line will satisfy one import, and corresponds to 1 conflict warning
    // As I wasn't aware of how I could stop the assembly pruning...
    typeof<IPostConfigureOptions<_>> |> ignore
    typeof<IConfigurationSection> |> ignore
    typeof<IServiceCollection> |> ignore
    typeof<HttpContext> |> ignore
    typeof<IWebHostBuilder> |> ignore
    typeof<AuthenticationHandler<_>> |> ignore