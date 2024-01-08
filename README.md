# AgentAPI C# SDK

## **Introduction**

This SDK provides a convenient way to interact with the AgentAPI using C#. It is a maintained build of an automatically generated SDK using OpenAPI Tools Codegen.

## **Prerequisites**

1. **.NET Standard 2.0 Compatibility**: The AgentApi SDK targets .NET Standard 2.0, ensuring compatibility across multiple .NET environments, including .NET Core and .NET Framework. Make sure your development environment supports .NET Standard 2.0.
2. **.NET 6.0 SDK**: As the example projects target .NET 6.0, ensure that you have the .NET 6.0 SDK installed on your machine. This will allow you to build and run the examples seamlessly.

## **Installation**

There are two ways to install the SDK in your project: via NuGet package manager or by adding a project reference directly. Choose the method that best suits your workflow.

### Installing via NuGet

1. **NuGet Package Manager (Visual Studio)**:
   - In Visual Studio, right-click on your project in the Solution Explorer and select "Manage NuGet Packages".
   - Search for [AgentApi](https://www.nuget.org/packages/AgentApi) and click 'Install' to add it to your project.

2. **NuGet CLI**:
   - Open a command prompt and navigate to your project directory.
   - Run the following command:  
     ```
     dotnet add package AgentApi
     ```

3. **PackageReference in .csproj File**:
   - Open your project's .csproj file and add the following line within the `<ItemGroup>` tag:
     ```xml
     <PackageReference Include="AgentApi" Version="1.*" />
     ```
   - Save the file and restore the NuGet packages.

### Installing via Project Reference

If you have the SDK source code and prefer to reference it directly:

1. **Add SDK Project to Your Solution**:
   - Open your solution in Visual Studio.
   - Right-click on the solution in the Solution Explorer, choose "Add" and then "Existing Project...".
   - Navigate to and select the SDK's project file (`.csproj`).

2. **Add a Reference to the SDK**:
   - Right-click on your project in the Solution Explorer and select "Add" > "Reference...".
   - In the Reference Manager, check the SDK project under the "Projects" tab.
   - Click "OK" to add the reference.

## Documentation

You can find the SDKs generated documentation in the `sdk\Readme.md` file.

## Notes

The OpenAPI 3.0 specification used for this SDK can be found at the [AgentApiYaml repository](https://github.com/Trust-Anchor-Group/AgentApiYaml)

## Examples

You can find an example solution that demonstrates how to use the SDK in the `examples` folder. This will help you get started with integrating the SDK into your own project.
In this solution each project is a different example.

* ApiUsageExample
   
   - Simple example that displays some core concepts of using the SDK

* AuthenticationExample

   - Simple example that displays how authentication works using the SDK

* WalletExample
  
   - A console application the goes trough the proccess of creating a wallet for an account, which is explained in this [community post](https://lab.tagroot.io/Community/Post/Creating_a_wallet_using_Agent_API)
   - The domain on which to connect to can be changed in the `GlobalConfig.cs` file


### How to run examples

   - Open the examples.sln with visual studio
   - Set the startup project to the example you want to run
