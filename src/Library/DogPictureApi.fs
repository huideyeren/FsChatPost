namespace FsChatPost.Library

open FSharp.Data
open System

type DogPictureApiJson = JsonProvider<"https://dog.ceo/api/breeds/image/random">

module DogPictureApi =
    let url = DogPictureApiJson.GetSample().Message