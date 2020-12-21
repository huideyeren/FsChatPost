namespace FsChatPostLibrary

open System
open FSharp.Data
open FSharp.Data.HttpRequestHeaders

module PostToGoogleChat = 
    let chatUrl = Environment.GetEnvironmentVariable("CHAT_URL")
    let catUrl = CatPictureApi.url
    let card = $""" {{
                     "cards": [
                         {{
                             "header" : {{
                                 "title": "猫画像",
                                 "subtitle": "癒やしの猫画像をお届けします。"
                             }},
                             "sections": [
                                 {{
                                     "widgets": [
                                         {{
                                             "image": {{
                                                 "imageUrl": "{catUrl}",
                                                 "onClick": {{
                                                     "openLink": {{
                                                         "url": "{catUrl}"
                                                     }}
                                                 }}
                                             }}
                                         }},
                                         {{
                                             "textParagraph": {{
                                                 "text": "Photo by <a href='https://aws.random.cat/'>random.cat</a>"
                                             }}
                                         }}
                                     ]
                                 }}
                             ]
                         }}
                     ]
                 }} """
    let result = Http.RequestString( chatUrl, 
                                     headers = [ ContentTypeWithEncoding (HttpContentTypes.Json, Text.Encoding.UTF8) ],
                                     body = TextRequest card)