# Selenium-Webscraping

Will need to modify to make part of Arbitraging Sport Betting Line Exchanges

Does not auto-update. This documentation is for a Stack of Windows/VSCode.

Stack
-Netcore App 2.2 | Selenium WebDriver | VScode/NugetPM/C# | Excel 

**This is for updating to new .Net versions(Optional)** 

1.) Download the core SDK + Dev Pack Framework - https://aka.ms/dotnet-download

2.) Delete old Dotnet Builds 


  Selenium-Webscraping/obj/debug |
    -Delete all old file versions
  
  Selenium-Webscraping/.vscode |
    -Delete all old file versions
    
  Selenium-Webscraping/bin/debug |
    -Delete all old file versions
    
   Selenium-Webscraping/WebScrapping.csproj |
    -Delete old file
  
  
3.) Terminal | CD into Selenium project | dotnet restore 

**End of Optional Manual Updating** 

4.) VSCode -> Extension -> Install Nuget Package Manager (Extension) | Install C# (Extension)

5.) Control+Shift+P -> Nuget Package Manager (add package) -> Install Selenium.Webdriver (newest version)

6.) Install locally

7.) CD intoUpdate Chrome Driver - https://chromedriver.storage.googleapis.com/index.html?path=76.0.3809.68/

8.) Change pathing to reflect local pathing- C:\Users\cchow\Documents\Coding Projects\Selenium-Webscraping\bin\Debug\netcoreapp2.2

9.) 

Vscode -> Install C# -> Download .NET SDK -> Update Driver -> Run

To-Do

-Need to implement extraneous algo

-Need to add excel support/SQL Support
