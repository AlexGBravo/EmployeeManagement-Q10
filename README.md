# EmployeeManagement

Proyecto ASP.NET MVC para la gesti�n de empleados, utilizando Entity Framework y SQL Server para la persistencia de datos.

## Requisitos

- Visual Studio 2019 o posterior
- .NET Framework 4.8
- SQL Server
- Paquetes NuGet necesarios:
  - EntityFramework

## Instrucciones de Configuraci�n

### 1. Clonar el Repositorio

Clona el repositorio en tu m�quina local.

```bash
git clone https://github.com/tu_usuario/EmployeeManagement.git
```


2. Abrir el Proyecto en Visual Studio
Abre el archivo de soluci�n EmployeeManagement.sln en Visual Studio.

3. Configurar la Cadena de Conexi�n
Abre el archivo Web.config y aseg�rate de que la cadena de conexi�n est� configurada correctamente. A�ade o modifica la secci�n <connectionStrings> como se muestra a continuaci�n:

```xml
<configuration>
  <connectionStrings>
    <add name="EmployeeDBContext" connectionString="Server=(localdb)\mssqllocaldb;Database=EmployeeDB;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

Reemplaza connectionString con una cadena de conexi�n valida.