namespace FsChatPost.Library

open System
open FSharp.Json

type Header =
    {
        title: string
        subtitle: string
    }

type Url =
    {
        url: string
    }

type OnClick(url: string) =
    let openLink = url

type ImageData(url: string) =
    let imageUrl = url
    let _onClick = OnClick(url)

type TextParagraphData(text: string) =
    let text = text

type Widget =
    | Image of ImageData
    | TextParagraph of TextParagraphData

type Section =
    {
        widgets: List<Widget>
    }

type Card =
    {
        header: Header
        sections: List<Section>
    }

type GoogleChatCard =
    {
        cards: List<Card>
    }

module GoogleChatCardJson =
    let cardObject: GoogleChatCard =
        {
            cards = [{
                header = {
                    title = "今日の犬画像"
                    subtitle = "癒やしの犬画像をお届けします。"
                }
                sections = [{
                    widgets = [Image(DogPictureApi.url); TextParagraph("")]
                }]
            }]
        }
    let card = Json.serialize cardObject
    printfn "%s" card