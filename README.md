# SqlBD
Проект по работе с БД.

Целью проекта являлось создание asp.net framework приложения с БД и взаимодействие с ней
Предметная область - список контактов

в БД имеются 2 таблицы:
1.People(
    PersonId
    FirstName
    LastName
    MiddleName
    Birthday
    Corporation
    EmployeePosition)
    
2.ContactInformations(
    ContactInformationId
    Phone
    Email
    Skype)
    
Связь построена 1 к 1,т.е. каждому человеку соотвествует только 1 набор контактных данных.
Обязательные для заполнения поля: Имя, Дата рождения и номер телефона. Имеется Валидация.

Функции:
1.Просмотр списка созданных элементов (index)
2.Создание нового элемента (create)
3.Редактирование элемента (edit)
4.Удаление элемента (delete)

База данных разворачивается локально с помощью Microsoft SQL Server в папке App_Data
Строка подключения:
add name="PersonContext" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|PersonContext.mdf';Integrated Security=True" 	   providerName="System.Data.SqlClient"

Для запуска открыть файл .sln в VisualStudio и запустить проект
