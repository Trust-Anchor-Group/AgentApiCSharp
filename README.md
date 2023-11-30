# AgentAPI C# SDK

This SDK provides a convenient way to interact with the AgentAPI using C#. It is a maintained build of an automatically generated SDK using OpenAPI Tools Codegen.

## Notes

Currently the SDK is not ready for production use, mainly because the SDK has not been thoroughly tested. The OpenAPI 3.0 specification used for this SDK can be found at the [AgentApiYaml repository](https://github.com/Trust-Anchor-Group/AgentApiYaml)

## Installation

To use the AgentAPI C# SDK in your project, follow these steps:

1. Clone this repository.
2. Navigate to the `sdk\src\TAG.Networking.Agent\` folder.
3. Include the `TAG.Networking.Agent.csproj` in your project

The SDK will also be available as a nuget in the near future

## Examples

You can find an example solution that demonstrates how to use the SDK in the `examples` folder. This will help you get started with integrating the SDK into your own project.

- ApiUsageExample
  - A simple console application, which goes over how to use the SDK, including Configuration, Api instances and requests.
- AccountApiExample
  - A console application which allows a user to create and login to accounts on a neuron.

Examples with continuously be expanded as this project progresses

## Documentation

You can find the SDKs generated documentation in the `sdk\Readme.md` file.

## Generating Custom SDK

If you need to generate a custom version of the SDK, you can do so by following the instructions in the [AgentApiYaml repository](https://github.com/Trust-Anchor-Group/AgentApiYaml). This repository contains the OpenAPI specification and steps on how to generate your own SDK.
