# EmployeeManagement

Proyecto ASP.NET MVC para la gesti�n de empleados, utilizando Entity Framework y SQL Server para la persistencia de datos.

## Requisitos

- Visual Studio 2019 o posterior
- .NET Framework 4.8
- SQL Server
- Paquetes NuGet necesarios:
  - EntityFramework


## Demo

Para efectos pr�cticos, esta aplicaci�n fue desplegada en un servidor gratuito en somee.com

https://q10-technical-test.somee.com/


## Instrucciones de Configuraci�n

### 1. Clonar el Repositorio

Clona el repositorio en tu m�quina local.

```bash
git clone https://github.com/AlexGBravo/EmployeeManagement-Q10
```


### 2. Abrir el Proyecto en Visual Studio
Abre el archivo de soluci�n EmployeeManagement.sln en Visual Studio.

### 3. Configurar la Cadena de Conexi�n
Abre el archivo Web.config y aseg�rate de que la cadena de conexi�n est� configurada correctamente. A�ade o modifica la secci�n <connectionStrings> como se muestra a continuaci�n:

```xml
<configuration>
  <connectionStrings>
    <add name="EmployeeDBContext" connectionString="Server=(localdb)\mssqllocaldb;Database=EmployeeDB;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

Reemplaza connectionString con una cadena de conexi�n valida.

### 4. Ejecutar el proyecto

Ahora se puede ejecutar el proyecto, la aplicaci�n al iniciar, creara la estructura de la base de datos.


Puedes ejecutar el proyecto desde la UI de Visual Studio o usando comandos.

Comandos:

* Ejecuta ```Developer Command Prompt``` 
* Navega a la carpeta donde esta el archivo ```EmployeeManagement.csproj``` usando ```cd ...```
* Restaurar los paquetes ```dotnet restore```
* Ejecuta ```msbuild EmployeeManagement.csproj```

* Navega a la carpeta final ```cd bin\Debug``` y ejecuta ```EmployeeManagement.exe```


