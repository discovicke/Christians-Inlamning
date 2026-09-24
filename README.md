# Christians-Inlamning 🤓

Dum Counter i Blazor 🤖✨ Varje klick pa Counter knappen anropar OpenAI pa Azure som adderar 1 ➕1️⃣

## Kora 🚀

1. Kopiera env filen 📋
   ```
   cp Counter/.env.example Counter/.env
   ```

2. Fyll i dina varden i `Counter/.env` 🔑
   ```
   AZURE_OPENAI_ENDPOINT=https://din-resurs.openai.azure.com/ 🌐
   AZURE_OPENAI_KEY=din-nyckel 🔐
   AZURE_OPENAI_MODEL=din-deployment 🧠
   ```

3. Kora appen 🏃‍♂️
   ```
   dotnet run --project Counter/Counter.csproj
   ```
   Oppna `http://localhost:5000/counter` och klicka pa knappen 👆🎉

## Hur det funkar 🛠️

* `Counter/Program.cs` 📄 laddar `.env` med DotNetEnv 🌱 och registrerar en `OpenAIClient` med din endpoint och nyckel 🔌
* `Counter/Components/Pages/Counter.razor` 🖥️ skickar nuvarande tal till modellen och visar svaret 💬➡️🔢 Fel visas i ratt text ❤️

## Filer 📁

* `Counter/.env` 🙈 ignoreras av git
* `Counter/.env.example` 📝 mall som ar committad ✅

Ha sa kul! 🎈🤩💥
