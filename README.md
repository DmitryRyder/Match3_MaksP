# EPAM.TicketManagement.Chyrkov

## The Progect uses:

* MS SQL SERVER 2017
* .Net Framework 4.7.2

## Some conditions

* If you decide rebuild database then you need replace .dacpac file for IntegrationTestTiketsManagment project as well.
* If you decide rename database for tests you should change property DbName in DbInitializer class

## For start:

* Open .sln in Visual Studio
* Modify the connection strings in Constants class from Common project:

```csharp
public static class Constants
{
	public const string ConnectionStringForTestDb = "";// your connection string for test DB
	public const string ConnectionString  = "";//your connection string for main DB 
}
```

* Publish the TicketManagement.csproj
* Select TicketManagementMvc project as startup project
* Build Solution
* Register a new user
* After register you can log in as Administrator, Event manager or Venue manager. Use the login details below:

```shell
-SiteAdmin 
UserName: admin@mail.ru
Password: admin123

-Event manager 
UserName: eventManager@mail.ru
Password: eventManager123
	
-Venue manager 
UserName: venueManager@mail.ru
Password: venueManager123	
```
