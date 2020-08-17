# Well Beings
Website promoting Well Beings' new products.

![Well Beings Landing Page](https://github.com/thanhtrannn/well_beings/blob/master/well_beings_front.png?raw=true)

## Installation

### Prerequisite
Install [.NET Core 2.1.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.1)

**IDE:** Visual Studio

1. **Command Line:**
    1. Navigate to web project folder and 'dotnet run'
1. **Visual Studio:**
    * Run IIS Express on Debug or Release
1. **IIS Deployment (Development):** Contained publish to IIS with Core .NET 2.1 Hosting Bundle (Capable of cross platform deployment)
    1. *well_beings\bin\Debug\netcoreapp2.1\publish* -> Move files to IIS directory
    1. Add Environment variable to IIS:
        * name: ASPNETCORE_ENVIRONMENT
        * value: Development

## Authors
* **[Thanh Tran](https://github.com/thanhtrannn)**
