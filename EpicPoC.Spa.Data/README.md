## Database

Create migration:

`dotnet ef migrations add InitialMigration --project ./EpicPoC.Spa.Data --startup-project ./EpicPoC.Spa.Server --context ApplicationDbContext`

Apply migrations:

`dotnet ef database update --project ./EpicPoC.Spa.Data --startup-project ./EpicPoC.Spa.Server --context ApplicationDbContext`

Remove migrations:

`dotnet ef migrations remove --project ./EpicPoC.Spa.Data --startup-project ./EpicPoC.Spa.Server --context ApplicationDbContext`

Drop database:

`dotnet ef database drop -f --project ./EpicPoC.Spa.Data --startup-project ./EpicPoC.Spa.Server --context ApplicationDbContext`