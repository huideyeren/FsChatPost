// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open FsChatPost.Library

[<EntryPoint>]
let main argv =
    printfn "Result: %s" PostToGoogleChat.result
    0
    