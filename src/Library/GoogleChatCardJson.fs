namespace FsChatPost.Library

open System
open FSharp.Json

type Header =
    {
        title: string
        subtitle: string
    }

type OpenLink =
    {
        url : string
    }

type OnClick =
    {
        openLink: OpenLink
    }

type ImageData =
    {
        imageUrl: string
        onClick: OnClick
    }

type TextParagraphData =
    {
        text: string
    }

type Widget =
    | [<JsonUnionCase(Case="image")>] Image of image: ImageData
    | [<JsonUnionCase(Case="textParagraph")>] TextParagraph of textParagraph: TextParagraphData

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
                    widgets = [Image(image = {imageUrl = DogPictureApi.url; onClick = {openLink = {url = DogPictureApi.url}}}); TextParagraph(textParagraph = {text = "Photo by <a href='https://dog.ceo/dog-api/'>Dog API</a>"})]
                }]
            }]
        }
    let card = Json.serialize cardObject