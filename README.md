# Selenium-Webscraping

Does not auto-update. This documentation is for a Stack of Windows/VSCode.


1.) Download the SDK + Framework - https://aka.ms/dotnet-download

2.) Install Nuget Package Manager (Extension)

3.) Delete old Dotnet Builds 
Selenium-Webscraping/obj/debug
  -Delete all old file versions
Selenium-Webscraping/.vscode
  -Delete all old file versions
  
4.) Terminal | CD into Selenium project | dotnet new console 

5.) Control+Shift+P -> Nuget Package Manager (add package) -> Install Selenium.Webdriver (newest version)

6.) Install locally

7.) Update Chrome Driver - https://chromedriver.storage.googleapis.com/index.html?path=76.0.3809.68/

Will need to replace the driver respective to the version being currently utilized by the machine. 

Make sure to manually reinstall the ChromeWebDriver after Chrome updates. 

Vscode -> Install C# -> Download .NET SDK -> Update Driver -> Run

To-Do

-Need to implement extraneous algo

-Need to add excel support/SQL Support
