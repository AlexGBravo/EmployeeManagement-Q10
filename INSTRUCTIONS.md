# Prueba t�cnica para desarrollador

## Instrucciones generales

1. Desarrollar una aplicaci�n en C# utilizando .NET Framework 4.8.
2. Estructura tu proyecto de manera clara.
3. Documentar el c�digo donde sea necesario para explicar la l�gica implementada.
Requisitos de la prueba


### 1. Creaci�n del proyecto
Crear un proyecto ASP.NET MVC en Visual Studio (o cualquier otro entorno de desarrollo compatible) usando el Framework 4.8 de .Net.o Nombrar el proyecto como EmployeeManagement.

### 2. Modelo de datos

Crear un modelo de datos en C# para manejar la informaci�n de empleados.
El modelo debe llamarse Employee y debe contener las siguientes
propiedades:
* Id (int): Identificador �nico del empleado.
* Name (string): Nombre completo del empleado.
* Position (string): Cargo del empleado.
* Office (string): Oficina del empleado.
* Salary (decimal): Salario del empleado.

### 3. Interfaz de usuario
Crear una vista principal en HTML con un dise�o sencillo utilizando CSS para
estilizar la p�gina. La vista debe:
* Mostrar una lista de empleados en una tabla.
* Permitir agregar un nuevo empleado mediante un formulario.
* Permitir editar y eliminar empleados existentes.

### 4. Funcionalidad con jQuery
Utilizar jQuery para:
* Validar los campos del formulario (Nombre, Cargo, Oficina, Salario)
antes de enviarlo.
* Enviar los datos del formulario al servidor utilizando AJAX.
* Actualizar la tabla de empleados din�micamente sin recargar la p�gina.

### 5. Controlador y acciones
Crear un controlador llamado EmployeeController con las siguientes
acciones:
* Index: Para mostrar la vista principal.
* GetEmployees: Para obtener la lista de empleados en formato JSON.
* AddEmployee: Para agregar un nuevo empleado.
* UpdateEmployee: Para actualizar la informaci�n de un empleado
existente.
* DeleteEmployee: Para eliminar un empleado.

### 6. Requisitos adicionales
* Usar Bootstrap para mejorar el dise�o visual de la aplicaci�n.
* Incluir comentarios en el c�digo para explicar la l�gica implementada.

## Criterios de evaluaci�n
* Correctitud y funcionalidad del c�digo.
* Calidad y claridad del c�digo.
* Uso adecuado de HTML, CSS, jQuery y C#.
* Cumplimiento de los requisitos especificados.
* Eficiencia en el uso de recursos y rendimiento de la aplicaci�n.
* Estilo y organizaci�n del c�digo.
* Capacidad para seguir instrucciones y prestar atenci�n a los detalles.
 
## Entrega
Asegurarse de que el proyecto se pueda ejecutar sin problemas en otro entorno de
desarrollo.