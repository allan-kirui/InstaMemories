# InstaMemories Project

This repository contains the source code for the InstaMemories project, an application developed using ASP.NET Core. The project includes unit tests using xUnit and GitHub Actions for continuous integration and deployment to Azure App Service.

## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Build and Test](#build-and-test)
  - [Deployment](#deployment)
- [InstaMemories](#instamemories)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

### Prerequisites

- [.NET SDK 8.0.201](https://dotnet.microsoft.com/download) or later
- [Azure Account](https://azure.microsoft.com/en-us/free/) (for deployment)

### Build and Test

1. Clone the repository:

   ```bash
   git clone https://github.com/allan-kirui/InstaMemories.git
   cd InstaMemories
   ```

2. Build and test the project:

```bash
  dotnet restore
  dotnet build --configuration Release
  dotnet test --configuration Release --no-build
```

### Deployment

This project uses GitHub Actions for continuous integration and deployment to Azure App Service. Ensure you have set up the necessary secrets in your GitHub repository:

`AZURE_WEBAPP_PUBLISH_PROFILE`: The publish profile XML content from Azure App Service.

The workflow is configured to run on every push to the master branch. Successful builds are automatically deployed to Azure App Service.

## InstaMemories

### About the Application

The InstaMemories application is built using ASP.NET Core, a cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications. This section provides an overview of the key features and purpose of the InstaMemories application.

### Key Features

- **Image Display:** The main functionality of the application is to display a collection of images in a visually appealing matrix style on the homepage.
- **Dynamic Content:** The application dynamically reads images and their descriptions from a specified folder, allowing for easy updates without modifying the code.
- **Efficient Rendering:** The use of a for loop in the frontend ensures efficient rendering of image boxes with associated descriptions.
- **Image Upload:** Users can upload images through a dedicated page, enhancing the interactive nature of the application.

### Purpose

InstaMemories was made as a memory bank for me and my friends, simultaneuosly it serves as a showcase for utilizing ASP.NET Core, HTML, CSS, and Javascript to create a responsive and efficient web application. It demonstrates best practices for frontend development, including dynamic content loading, user interaction, and seamless deployment to Azure App Service.

### Technology Stack

- **ASP.NET Core:** The backend framework for building web applications and services.
- **HTML, CSS and Javascript** The frontend framework for building interactive and dynamic user interfaces.
- **GitHub Actions:** Used for continuous integration and deployment to Azure App Service.
- **Azure App Service:** The cloud platform for hosting and managing the deployed application.

### Directory Structure

The project follows a standard ASP.NET Core directory structure with specific folders for pages, forms, and other components. The `.github` folder contains GitHub Actions workflows for automating the build and deployment processes.

Feel free to explore the source code in the `WebApp` directory to understand the implementation details of InstaMemories.

### Contributing

If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix: git checkout -b feature/new-feature.
3. Make your changes and commit them: git commit -m "Description of your changes".
4. Push to the branch: git push origin feature/new-feature.
5. Submit a pull request.

### License

This project is licensed under the MIT License.
