#### _Pierr's Bakery By: Aaron Demski_

# Technologies Used

C#
.Net
JavaScript
HTML/CSS
JQuery
MySQL
Entity Framework Core
VsCode

# Description

_A Code Review Project from Aaron Demski, This repo is about Eau Claire's Salon! To make this project yourself, you will want to follow the Setup/Installation Requirements Below. Hope you enjoy!_


# Project Setup

Cloning the Repository:

Open Visual Studio Code (VSCode).

Click on the "Source Control" icon in the Activity Bar on the side (Ctrl+Shift+G).

Click the "Clone Repository" button and paste the GitHub repository URL (https://github.com/ajdemski/Hair-Salon) into the input box.

Choose a local directory where you want to clone the repository and click "Clone." Then open the Project.

In VSCode, click on the "Explorer" icon in the Activity Bar on the side (Ctrl+Shift+E).

Navigate to the folder where you cloned the repository.

Open the PierrsBakery folder.

Once the project is open in VSCode, you should see a notification at the top suggesting "Required assets to build and debug are missing from 'PierrsBakery'. Add them?" Click "Yes."
Alternatively, you can open the integrated terminal in VSCode (View > Terminal) and navigate to the PierrsBakery folder manually. Then run the following command:

`dotnet restore`

# Database Setup

Start by downloading MySQL you can search for it on the internet

Next add a appsettings.json file and paste the following code into it

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database={DATABASENAME};uid={USERNAME};pwd={PASSWORD};"
    }
}
```

Make sure to replace (Databasename) and (Password) with your own personal information

Next open the terminal and enter '$ dotnet build'

initialize the database by entering '$ dotnet EF migrations add InitialSetup'

Then enter '$ dotnet EF database update'

# Running the Application

With the terminal still open in VSCode, run the following command to start the application:

`$ dotnet watch run`

Open your browser and enter 'https://localhost:5001/' into the url


# Known Bugs

_No Known Bugs_

# License

_Copyright (c) <2023> <Aaron Demski>_

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _August 7th, 2023_ Aaron Demski