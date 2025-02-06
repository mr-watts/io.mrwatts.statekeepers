# Package Installation

See [the package README](Assets/StateKeepers/README.md).

# Package Development

Ensure all variables in `.env.dist` are loaded in your environment before running commands. There are a couple of ways to do that:

1. Export the variables in `.env.dist` manually:
    1. [Using `$env:FOO = 'Bar'`](https://stackoverflow.com/a/714918) (PowerShell only)
    1. Using `SET FOO=Bar` (Windows Command Prompt only)
    1. Using `export FOO=BAR` (Bash and compatible shells only).
        - With Bash, you can also put these in your `.bashrc` to not have to do this every time, if desired.
    1. Prepend the variables in `.env.dist` to the command using `FOO=BAR BAZ=CUX dotnet ...` (Bash and compatible shells only).
1. Copy `.env.dist` to `.env`, fill in the variables to your liking, and use something like [direnv](https://direnv.net/) to automatically load them into your environment. (That way you can use the same configuration for native and container builds.)

## Installing Unity NuGet Packages

After all necessary variables are in your environment:

```sh
dotnet msbuild -target:PostProcessDotNetPackagesForUnity -restore NuGetDependencies/Unity/
```

After post-processing finishes, you can start or focus the Unity window of your project and let Unity import the dependencies.