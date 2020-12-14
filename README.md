# SqlBD
Проект по работе с БД.

Функции:
1.Просмотр списка созданных элементов
2.Создание нового элемента
3.Редактирование элемента
4.Удаление элемента

База данных разворачивается локально с помощью Microsoft SQL Server 
Строка подключения:
  connectionStrings>
		<add name="PersonContext" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|PersonContext.mdf';Integrated Security=True" providerName="System.Data.SqlClient" />
	</connectionStrings>

Проект написан на языке C#

Для запуска открыть файл .sln в VisualStudio и запустить проект
