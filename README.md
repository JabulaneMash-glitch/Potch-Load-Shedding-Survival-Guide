⚡ Zone Watt

A zone-based load shedding schedule lookup app for Potchefstroom, South Africa.

Zone Watt helps residents quickly check whether their area is affected by load shedding on a given day, and see the scheduled outage times for their specific municipal zone.

🖥️ Features
User details form — capture name, surname, and email with client-side validation
Zone selection — choose from 6 Potchefstroom load shedding zones (CBD, Van der Hoff Park, Bult & University, Grimbeek Park & Baillie Park, Mohadin & Promosa, Ikageng)
Personalized results page — greets the user and displays their selected zone
Interactive calendar — pick any date to see that day's load shedding forecast
Zone-specific schedules — each zone has its own outage windows and "safe days" with no load shedding

🛠️ Tech Stack
Framework: ASP.NET Web Forms (.NET Framework 4.7.2)
Language: C#
Server: IIS Express
State management: Cookies (user info) + Session state (selected zone)
UI: Web Forms server controls (TextBox, RadioButton, Calendar, validators)

📂 Project Structure
FirstOpp2024/
├── default.aspx / .cs      # Home page — user info + zone selection form
├── Info.aspx / .cs         # Results page — greeting + zone schedule + calendar
├── Global.asax / .cs       # Application-level event handlers
├── Web.config               # App configuration
├── Candles.jpg               # Home page image
└── FirstOpp2024.csproj       # Project file

🚀 Getting Started
Prerequisites
Visual Studio 2019 or later (with ASP.NET and web development workload installed)
.NET Framework 4.7.2
Running locally
Clone the repo:
bash
   git clone https://github.com/<your-username>/shedwise.git
Open FirstOpp2024.sln in Visual Studio
Restore NuGet packages if prompted
Press F5 to run — the app will launch via IIS Express at http://localhost:50023/

📖 How It Works
On the home page, the user enters their details and selects their load shedding zone
On submit, their info is stored in a cookie and their zone is stored in session state, then they're redirected to the results page
The results page greets the user and shows their zone
Selecting a date on the calendar shows that day's load shedding forecast — each zone has two fixed outage windows per day, except on its two designated "safe" days each week

Built by [Jabulane Mashinini] as a portfolio project.
