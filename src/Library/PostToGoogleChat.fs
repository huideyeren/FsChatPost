namespace FsChatPost.Library

open System
open FSharp.Data
open FSharp.Data.HttpRequestHeaders

module PostToGoogleChat = 
    let chatUrl = Environment.GetEnvironmentVariable("CHAT_URL")
    let card = GoogleChatCardJson.card
    let result = Http.RequestString( chatUrl, 
                                     headers = [ ContentTypeWithEncoding (HttpContentTypes.Json, Text.Encoding.UTF8) ],
                                     body = TextRequest card)