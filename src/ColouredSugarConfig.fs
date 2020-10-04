﻿module ColouredSugarConfig

open FSharp.Data

[<Literal>]
let sample = """
{
  "enableVSync": true,

  "screenshotScale": 1.01,

  "cursorForceScrollIncrease": 1.4,
  "cursorForceInverseFactor": 1.5,

  "bouncingBallSize": 0.125,
  "bouncingBallVelocity": {
    "x": -0.4,
    "y": 0.4,
    "z": -0.3
  },

  "particleCount": 1572864,

  "bassStartFreq": 20.01,
  "bassEndFreq": 350.01,
  "midsStartFreq": 300.01,
  "midsEndFreq": 2500.01,
  "highStartFreq": 2000.01,
  "highEndFreq": 15000.01,

  "minimumBass": 0.005,
  "minimumMids": 0.000125,
  "minimumHigh": 0.00009,

  "whiteHoleStrength": 1.01,
  "curlAttractorStrength": 8.01,
  "blackHoleStrength": 4.75,

  "cameraOrbitSpeed": 1.01,
  "cameraMoveSpeed": 1.01,
  "autoOrbitSpeed": 0.05,

  "shiftFactorOrbit": 0.33,
  "shiftFactorMove": 0.33,

  "cameraInertia": 0.3,

  "audioDisconnectCheckWait": 12
}
"""

type ConfigFormat = JsonProvider<sample>
type Config = JsonProvider<sample>.Root

let GetDefaultConfig () = ConfigFormat.Parse sample