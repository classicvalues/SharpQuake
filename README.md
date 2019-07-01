# SharpQuakeEvolved

### Description 

SharpQuakeEvolved is based on **[SharpQuake](https://memorix101.itch.io/sharpquake)** a **[GLQuake](https://github.com/dpteam/GLQuake3D)** reimplementation in C# using the **[OpenTK](https://github.com/opentk/opentk)** library.

### Goals

To try and reorganise and improve the already great work done by those who have contributed to SharpQuake (Credited below).

** Many code changes are based on my own personal coding style which is more of a preference*

### Roadmap
- Code cleanup:
	* Convert static classes to instance classes where static is unnecessarily used
	* Change Init / Shutdown pattern for IDisposable pattern
	* Move type definitions out of core code and into a Framework library
	* Use PascalCase for properties, fields, function names, class names & structs
	* Use camelCase for local variables
	* Rename type definitions to .NET style variations (Even if they are Quake specific)
	* Remove code duplication via file loading and handling in many non-filesystem related classes
	
- Features planned:
	* Implement central messaging system like those in engines like idtech3 and idtech4 (Allowing for the reduction of spaghetti code)
	* Abstract GL code from renderer pipeline (Relying on a standard drawing framework so you can use either D3D or OpenGL)
	* Add support for Quake 3 BSPs and potentially Quake 3 shaders
	* Upgrade lighting system/introduce Normal Map and specular map support
	* Add support for MD3 and more modern model formats
	* Introduce support for higher resolution textures

### Dependencies
* OpenTK 3.0.1
* NVorbis 0.8.6
* **[OpenAL](https://www.openal.org/downloads/)** (Windows) / libopenal on Linux
* **[SDL2](https://www.libsdl.org/download-2.0.php)** (Windows and macOS) / libsdl2-2.0 on Linux (Runtime binaries)
  
### Building

**Project is built against and tested for Visual Studio 2019 on .NET 4.7.2**

1) **Add the OpenTK nuget package with the package manager console in Visual Studio.**
    - `Install-Package OpenTK -Version 3.0.1`
    - `Install-Package NVorbis -Version 0.8.6`
    - `Install-Package NVorbis.OpenTKSupport -Version 1.2.0`

2) **Initialize git submodules**

3) **Add dependencies for your target architecture in your output directory (defaults to `<project root>/Quake`).**
    - See links under dependencies header above
4) **Add ld1, hipnotic, and rogue (minimum ld1) data directories to `<project root>/Quake`.**
    - You only need the `<mod>\pak0.pak`, etc. and `<mod>\config.cfg` files of each directory if copying from a steam install.

5) **Build solution.**

### Running

In case you don't own a copy of Quake you can purchase it on **[GOG.com](https://www.gog.com/game/quake_the_offering)**, **[Steam](https://store.steampowered.com/app/2310/QUAKE/)** or use the **[shareware version](https://community.pcgamingwiki.com/files/file/411-quake-shareware-pak/)**.

**As Linux is case-sensitive make sure your folder and file names look like that `Id1` and `PAK0.PAK` and `PAK1.PAK` (in case you own the full version).**

**To play with soundtrack add it to `Id1/music` or the mission pack folder you want to play in OGG Vorbis format like this `track02.ogg`. You can get it here** **[Steam Guide](https://steamcommunity.com/sharedfiles/filedetails/?id=119489135)**

**macOS / OSX is not official supported as OpenGL on Mac is poorly supported and has been replaced in favour of their own graphics API [Metal](https://en.wikipedia.org/wiki/Metal_(API)).**

The `-basedir <directory>` switch can be used to change the default data directory. e.g. `SharpQuake.exe -basedir C:\Quake\`

`-window` switch is pre-defined in project settings, but if you change the default directory of where you want your data, you may need to add `-basedir <directory>` to `project properties > Debug > Command line arguments` 

The original expansion packs can be run using `-rogue` or `-hipnotic` switches if the data is present for it.

Original Quake switches apply and can be used.

Enjoy! 🙂

![](https://user-images.githubusercontent.com/1466920/56814073-a068e200-683e-11e9-8e90-b75ca617d9ce.png)

### Credits
* Made by **[yurykiselev](https://sourceforge.net/u/yurykiselev/profile/)** and **Uze** and brought to Github by **[Memorix101](https://github.com/Memorix101)**

* QuakeSharpEvolved enhancements by **[optimus-code](https://github.com/optimus-code)**

* Updated to .NET 4.7.1 and OpenTK 3.0.1 by **[Daniel Cornelius (Kerfuffles/NukeAndBeans)](https://github.com/Kerfuffles)**

* Engine additions and fixes by **[multiguy18](https://github.com/multiguy18)** and **[Memorix101](https://github.com/Memorix101)**

* Original source code on **[SourceForge.net](https://sourceforge.net/projects/sharpquake/)**