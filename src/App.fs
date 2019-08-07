module App.View

open Elmish
open Elmish.React

open Fulma

open Fable.React
open Fable.React.Props

type Model = int

//type Msg = 0

let init () = 0

let update msg (model : Model) =
  0

let view model dispatch =
  div []
      [
        str "Hello World"
      ]

Program.mkSimple init update view
|> Program.withReactSynchronous "elmish-app"
// |> Program.withHMR
|> Program.run