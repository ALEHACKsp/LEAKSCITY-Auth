# LEAKSCITY.cc  AUTH
Biblioteka logowania do systemu AuthKey LeaksCity.cc - https://leakscity.cc/lcui/auth
# Instalacja
Zainstaluj paczki Newtonsoft.Json i System.Management, skompiluj bibliotekę logowania, dodaj odwołanie do swojego projektu.
# Przykładowe użycie
```csharp
			using LEAKSCITY_Auth;
			using LEAKSCITY_Auth.Model;
            Console.WriteLine("Authkey:");
            string key = Console.ReadLine();

            Auth _login = new Auth();
            AuthModel authModel = _login.Login(key);

            if (!authModel.AuthStatus)
            {
                Console.WriteLine("Błąd podczas logowania");
                Console.ReadLine();
            } else {
                Console.WriteLine("Zalogowano: " + authModel.Username);
                Console.ReadLine();
            }
```


