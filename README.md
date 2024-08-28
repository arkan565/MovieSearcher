
# Movie Search

This is a movie searcher made for a example code to cleartech




## Tech Stack

**Client:** React, Vite, TailwindCSS

**Server:** .net Core 8, entity framework, Sql Server




## Run Locally

Clone the project

```bash
  git clone https://link-to-project
```

Open it on Visual Studio

Change appsettings to use the connection string to your sql server
Click start

## Running Tests

Test are TODO, but we can use vitest or jest to test frontend



## Documentation

On frontend (MovieSearcher.client):
/ all config elements are here
/public assets publit to the frontend
/src/assets Images and extra elements used in React code
/src/components TSX elements
/src/hooks React custom hooks
/types Typescript types

Backend (MovieSearcher.Server):
/Data DB related objects like context and data models
/Migrations Entity framework databases Migrations needed for generating the database model into sql server database, I used code first approach in this project
/Services Service layer that is used to access and manage database and server logic 
/Controllers api controllers
