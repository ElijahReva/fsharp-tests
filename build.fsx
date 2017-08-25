// include Fake lib
#r @"packages\FAKE\tools\FakeLib.dll"
open Fake

let buildDir = "./build/"

let buildMode = getBuildParamOrDefault "buildMode" "Release"

let setParams defaults =
        { defaults with
            Verbosity = Some(Quiet)
            Targets = ["Build"]
            Properties =
                [
                    "Optimize", "True"
                    "DebugSymbols", "True"
                    "Configuration", buildMode
                ]
                        
         }

let buildWithParam = build setParams

Target "Clean" (fun _ ->
        CleanDir buildDir
)

Target "Build" (fun _ ->
   "./FSharpTest.sln" |> buildWithParam
   trace msBuildExe
)

// Default target
Target "Default" (fun _ ->
    trace "Hello World fro FAKE"    
)

// Dependencies
"Clean"
  ==> "Default"
  ==> "Build"

// start build
RunTargetOrDefault "Build"