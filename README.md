1. Zainstaluje .net core 5.
2. Zbuduj projekt i baw się :D
3. Baza SQLite: plik bazy usunięty z repo. Baza utworzy się automatycznie w przypadku nie odnalezienia pliku z bazą. 
4. Dodano mediatR:
   1. koncepcja mediatR: https://www.youtube.com/watch?v=YzOBrVlthMk&t=742s
   2. przykład wykorzystania w **MediatRExampleController**.
5. Dodano Automapper:
   1. koncepcja https://www.youtube.com/watch?v=ncRjahgY6hs
   2. przykład wykorzystania **MediatRExampleController**, oraz stworzyłem *Profile*, który definiuje nam sposób mapowania obieków **IdentityUsersMapperProfile**
6. Podpiąłem CI (Buddy): reaguje na tag ***deploy***: buduje apkę i robi deploy na azure: **https://fooddiarypzpp.azurewebsites.net/**