# wasm-blazor-lecture
This repo contains slides and materials for Web assembly and Blazor


## Tools

This repo is highly dependant on .NET Core Runtime (v3) and Mono SDK. Please install them first.

1. [Mono SDK](https://www.mono-project.com/download/stable/)
2. [.NET Core Runtime](https://dotnet.microsoft.com/download)
3. [Mono Wasm Compiler](https://jenkins.mono-project.com/job/test-mono-mainline-wasm/label=ubuntu-1804-amd64/lastSuccessfulBuild/Azure/)

You need a simple command line static file web server, I use `dotnet-serve`, it can be installed like this:

```
dotnet tool install --global dotnet-serve
```

## View the slides

Just go to the slides folder, and host it with the static file web-server:

```
cd slides/
dotnet serve
# will host on http://localhost:8080
```

## Run and compile the CSharp example

1. First make sure you have installed `Mono` and `.NET Core 3 runtime` and extracted `mono-wasm`.
2. Make sure Mono binaries can be accessed in the terminal/command-line. (Set the bin of the mono to env path)
3. In the `compile.ps1` change address of `$WASM_SDK` to the downloaded/extracted one.
4. Run `compile.ps1` to compile, publish and browse your code.
5. Go to `http://localhost:8080/index.html` to try it!