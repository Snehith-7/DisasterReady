# DisasterReady
# 🌍 Disaster Ready — Disaster Preparedness and Awareness System

**Disaster Ready** is a web-based disaster preparedness and awareness platform developed using ASP.NET Core MVC. It aims to educate students and the general public about natural disasters and provide practical safety guidelines to follow before, during, and after emergencies.

The project promotes disaster awareness through interactive learning materials, quizzes, emergency contact information, and a Go-Bag checklist.

## 🎯 Objectives

- Improve awareness of natural disasters and emergency situations.
- Provide clear safety guidelines for different types of disasters.
- Help users understand what to do before, during, and after a disaster.
- Encourage emergency preparedness through interactive activities.
- Make essential safety information accessible through a user-friendly website.

## ✨ Features

- **🏠 Interactive Homepage:** Introduces the platform and its disaster preparedness resources.
- **🌎 Disaster Learning Modules:** Educational content covering earthquakes, floods, fires, and cyclones.
- **📖 Before, During, and After Guidelines:** Practical safety instructions for different stages of a disaster.
- **🎒 Go-Bag Checklist:** Helps users track essential emergency supplies.
- **📝 Interactive Quiz:** A 12-question quiz to test disaster awareness and preparedness knowledge.
- **📞 Emergency Contacts:** Provides important emergency contact information relevant to India.
- **📱 Responsive Interface:** Designed using Bootstrap, CSS, and JavaScript for a user-friendly experience.
- **⚠️ Error and Privacy Pages:** Includes supporting pages for navigation and user information.

## 🛠️ Technologies Used

| Technology       | Purpose                   |
| ---------------- | ------------------------- |
| C#               | Application programming   |
| ASP.NET Core MVC | Web application framework |
| HTML5            | Page structure            |
| CSS3             | Styling and layout        |
| Bootstrap        | Responsive design         |
| JavaScript       | Interactive features      |
| Razor Views      | Dynamic page rendering    |
| Visual Studio    | Development environment   |

**Database:** SQL Server / Entity Framework Core may be used for future database integration. The current version's quiz and Go-Bag checklist use client-side functionality.

📂 Project Structure

DisasterReady/
└── DisasterReady/
    ├── Controllers/
    │   └── HomeController.cs
    │
    ├── Models/
    │   └── ErrorViewModel.cs
    │
    ├── Views/
    │   ├── Home/
    │   │   ├── Index.cshtml
    │   │   ├── Learn.cshtml
    │   │   ├── Quiz.cshtml
    │   │   ├── Emergency.cshtml
    │   │   └── Privacy.cshtml
    │   │
    │   └── Shared/
    │
    ├── wwwroot/
    │   ├── css/
    │   ├── js/
    │   ├── images/
    │   └── lib/
    │
    ├── Properties/
    │   └── launchSettings.json
    │
    ├── appsettings.json
    ├── appsettings.Development.json
    ├── Program.cs
    └── DisasterReady.csproj

*Note: The structure above illustrates the main files and folders. Your actual repository may contain additional files.*

## 🚀 Getting Started

### Prerequisites

Install the following software:

- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)
- ASP.NET and web development workload in Visual Studio

### Installation and Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
   ```

2. Open the downloaded project folder.

3. Open the `.sln` solution file in Visual Studio.

4. Allow Visual Studio to restore the required NuGet packages.

5. Set the DisasterReady web project as the startup project.

6. Press **F5** to run with debugging or **Ctrl + F5** to run without debugging.

Alternatively, from the directory containing the web project's `.csproj` file, run:

```bash
dotnet restore
dotnet run
```

7. Open the local URL displayed in the terminal or browser launch window.

## 🧭 How to Use

1. Open the DisasterReady homepage.
2. Explore the available disaster learning modules.
3. Read the safety guidelines for each disaster.
4. Use the Go-Bag checklist to review essential emergency supplies.
5. Attempt the interactive quiz to assess your knowledge.
6. Visit the Emergency section to access important contact information.

## 🎓 Project Applications

- Disaster awareness programs in schools and colleges.
- Educational demonstrations and student projects.
- Basic emergency preparedness training.
- Public awareness initiatives for disaster risk reduction.

## 🔮 Future Enhancements

- User registration and login.
- SQL Server database integration.
- Persistent user progress and quiz results.
- Real-time emergency alerts from verified sources.
- Location-based emergency information.
- Multilingual support for improved accessibility.
- Mobile-friendly enhancements and offline access.

## 👨‍💻 Project Information

**Project Name:** DisasterReady
**Category:** Web Application / Disaster Management
**Framework:** ASP.NET Core MVC
**Language:** C#
**Development Environment:** Microsoft Visual Studio

## 📄 Disclaimer

DisasterReady is an educational project intended to promote disaster awareness and preparedness. Its learning materials and emergency contact information should be verified against current official guidance. In an actual emergency, follow instructions from local authorities and emergency services.

---

⭐ If you find this project useful, consider giving the repository a star!
