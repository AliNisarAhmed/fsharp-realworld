namespace fsharp_realworld.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open fsharp_realworld

type Article =
    { Title: String
      Slug: String
      Body: String
      CreatedAt: String
      UpdatedAt: String
      Description: String
      TagList: String []
      Author: int
      Favorited: Boolean
      FavoritesCount: int }

[<ApiController>]
[<Route("[controller]")>]
type ArticlesController(logger: ILogger<ArticlesController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        {| Articles =
               [| { Title = "First Article"
                    Slug = "/article/1"
                    Body = "Hello World"
                    CreatedAt = DateTime(2021, 12, 21).ToString("s")
                    UpdatedAt = DateTime(2021, 12, 21).ToString("o")
                    Description = "Article"
                    TagList = [| "article"; "first" |]
                    Author = 1
                    Favorited = true
                    FavoritesCount = 10 } |]

           ArticlesCount = 1 |}
