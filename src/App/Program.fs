// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open FsChatPostLibrary

[<EntryPoint>]
let main argv =
    printfn "Result: %s" PostToGoogleChat.result
    0
    