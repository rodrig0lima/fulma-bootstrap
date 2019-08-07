module App.View

open Elmish
open Elmish.React

open Fulma

open Fable.React
open Fable.React.Props

type Model = int

type Msg = Increment | Decrement

let init () = 0

let update msg (model : Model) =
  match msg with
  | Increment -> model + 1
  | Decrement -> model - 1

let view model dispatch =
  div []
      [
        str "Hello World"
      ]

Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
// |> Program.withHMR
|> Program.run