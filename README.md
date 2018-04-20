# Wapice "Leap of Fate" 2018

"Leap Of Fate" is our Company (Wapice) hackathon where we have 7.5 hours to work on a project of our own.

Initial plan was to produce highly usable C# wrapper(s) for calling bootstrap (and jQuery) directly from Blazor code thus reducing the need to write any Javascript.

We started this project with very little knowledge over Blazor project or Webassembly but the idea sounded good and we wanted to see if it would work as we thought it would.

The mono project had a promising start for a Typescript-into-C#-converter (mono/TsToCSharp) and so we took the challenge of hacking it into making us hopefully usable wrappers.

The tool worked but turned out to be too early in development to produce us good enough code. The tool was also a "single pass", single file converter, which means any dependencies to other definitions (such as HTMLElement, Event, etc.) cannot be resolved and being single pass, it does not know the they are not defined.

We also had too high hopes about interfacing with Blazor. We still had to write Javascript, as Blazor requires that any Javascript access by Blazor must be through "registered functions"

In the end we wrote a simple, limited Typescript definition file for a rather easily interfaceable Javascript library (Chartist.js) and used our hacked converter for producing the C# interfaces. Then we implemented a simple bridge for the C#-Javascript interoperation after which we were able to execute Javascript in the Razor template.
