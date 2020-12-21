namespace FsChatPostLibrary

open FSharp.Data

type CatPictureApiJson = JsonProvider<"https://aws.random.cat/meow">

module CatPictureApi =
    let url = CatPictureApiJson.GetSample().File
