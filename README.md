# EmployeeManagement

Proyecto ASP.NET MVC para la gestión de empleados, utilizando Entity Framework y SQL Server para la persistencia de datos.

## Requisitos

- Visual Studio 2019 o posterior
- .NET Framework 4.8
- SQL Server
- Paquetes NuGet necesarios:
  - EntityFramework

## Instrucciones de Configuración

### 1. Clonar el Repositorio

Clona el repositorio en tu máquina local.

```bash
git clone https://github.com/tu_usuario/EmployeeManagement.git
```


2. Abrir el Proyecto en Visual Studio
Abre el archivo de solución EmployeeManagement.sln en Visual Studio.

3. Configurar la Cadena de Conexión
Abre el archivo Web.config y asegúrate de que la cadena de conexión esté configurada correctamente. Añade o modifica la sección <connectionStrings> como se muestra a continuación:

```xml
<configuration>
  <connectionStrings>
    <add name="EmployeeDBContext" connectionString="Server=(localdb)\mssqllocaldb;Database=EmployeeDB;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

Reemplaza connectionString con una cadena de conexión valida.