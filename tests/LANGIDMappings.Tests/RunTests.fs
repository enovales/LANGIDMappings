open Expecto

module RunTests =

    [<EntryPoint>]
    let main args =

        Tests.runTestsWithArgs defaultConfig args LANGIDMappings.Tests.tests |> ignore

        0

