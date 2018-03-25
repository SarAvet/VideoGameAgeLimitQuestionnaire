# VideoGameAgeLimitQuestionnaire 
 Опросник в виде веб-приложения для определения возрастного ограничения видеоигр согласно законодательству РФ.
 
 Для запуска веб-приложения требуется установить следующие программы:
 - .NET Core SDK >= 2.0.2  (https://www.microsoft.com/net/download/windows/build)
 - PostgeSQL 10 (https://www.postgresql.org/download/)
 
 При запуске база данных создается автоматически, необходимо только заменить данные строки соединения. 
 Строка соединения содержится в корне проекта VideoGameAgeLimitQuestionnaire.WEB в файле appsettings.json.
 
 ```
  "ConnectionStrings": {
    "QuestionnaireContext": "Host = localhost; Port = 5432; Database=Questionnaire; User Id = имя_пользователя_для_подключения_к_серверу_БД; password = пароль_указанного_пользователя;"
  },
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  }
}
```
Для запуска можно воспользоваться IISExpressom в Visual Studio 2017 или, например, через консоль.
Рассмотрим вариант запуска через консоль:
- открыть командную строку
- перейти в корень проекта VideoGameAgeLimitQuestionnaire.WEB
- ввести следующее: ```dotnet run```

В этом случае будут использоваться данные из файла VideoGameAgeLimitQuestionnaire.WEB\Proporties\launchSettings.json.

Используемые клиентские технологии:
- Bootstrap 4
- JQuery 3.3.1

Используемые серверные технологии:
- ORM Entity Framework 6
