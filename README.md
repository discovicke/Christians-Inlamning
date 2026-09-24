# Förslag till Christians-Inlämning 🤓🎉💪🏻

Counter i Blazor 🤖✨ Varje klick på Counter-knappen anropar OpenAI på Azure som adderar 1 ➕1️⃣

<img width="3560" height="2240" alt="2026-09-24 23 00 35" src="https://github.com/user-attachments/assets/bc6947ab-6b7d-4e3f-81ab-fbb8c411c105" />


## Köra 🚀

1. Kopiera env filen 📋
   ```
   cp Counter/.env.example Counter/.env
   ```

2. Fyll i dina värden i `Counter/.env` 🔑
   ```
   AZURE_OPENAI_ENDPOINT=https://din-resurs.openai.azure.com/ 🌐
   AZURE_OPENAI_KEY=din-nyckel 🔐
   AZURE_OPENAI_MODEL=din-deployment 🧠
   ```

3. Köra appen 🏃‍♂️
   ```
   dotnet run --project Counter/Counter.csproj
   ```
   öppna `http://localhost:5000/counter` och klicka på knappen 👆🎉

## Hur det funkar 🛠️

* `Counter/Program.cs` 📄 laddar `.env` med DotNetEnv 🌱 och registrerar en `OpenAIClient` med din endpoint och nyckel 🔌
* `Counter/Components/Pages/Counter.razor` 🖥️ skickar nuvarande tal till modellen och visar svaret 💬➡️🔢 Fel visas i röd text ❤️

## Filer 📁

* `Counter/.env` 🙈 ignoreras av git
* `Counter/.env.example` 📝 mall som är committad ✅

Ha så kul! 🎈🤩💥
