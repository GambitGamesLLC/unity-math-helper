# unity-math-helper  
Provides a variety of common math functions for Unity3D development, including remapping value ranges for UI elements, game logic, and more.

**Assembly:**\
com.gambit.mathhelper

**Namespace:**\
gambit.mathhelper

**ASMDEF File:**\
gambit.mathhelper

**Scripting Define Symbol:**\
GAMBIT_MATHHELPER

------------------------------
USAGE INSTRUCTIONS
------------------------------

**MathHelper.cs**\
Static utility class containing math functions commonly needed in Unity. These functions are accessible globally without requiring instantiation.

### Example – Mapping a value:
```csharp
using gambit.mathhelper;

float remappedValue = MathHelper.Map(0.5f, 0f, 1f, 100f, 200f); 
// Returns 150f
```

### Public Functions
```csharp
/// <summary>
/// Remaps a value from one range to another.
/// </summary>
/// <param name="value">The value to remap</param>
/// <param name="inMin">Min value of original range</param>
/// <param name="inMax">Max value of original range</param>
/// <param name="outMin">Min value of new range</param>
/// <param name="outMax">Max value of new range</param>
/// <returns>The remapped value</returns>
public static float Map(float value, float inMin, float inMax, float outMin, float outMax)
```

------------------------------
INSTALLATION INSTRUCTIONS
------------------------------

- Open your Unity package manager manifest file (`YourProject/Packages/manifest.json`)

- Add a new entry like so:
```
"com.gambit.mathhelper": "https://github.com/GambitGamesLLC/unity-math-helper.git?path=Assets/Plugins/Package",
```

- If you want to track latest commits, you’re done.
- If you want a specific release version, append a tag to the URL like this:
```
"com.gambit.mathhelper": "https://github.com/GambitGamesLLC/unity-math-helper.git?path=Assets/Plugins/Package#v1.0.0"
```

- For more info on subfolder installs via Git, check Unity's docs:  
  [Unity UPM Git subfolder guide](https://docs.unity3d.com/Manual/upm-git.html#subfolder)

------------------------------
SUPPORT
------------------------------
Created and maintained by **Gambit Games LLC**.
For support or feature requests, contact: **gambitgamesllc@gmail.com**
