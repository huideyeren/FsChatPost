// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open FsChatPost.Library

[<EntryPoint>]
let main argv =
    let json = PostToGoogleChat.card
    printfn "%s" json
    0
    