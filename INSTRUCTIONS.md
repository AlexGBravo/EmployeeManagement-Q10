# Prueba técnica para desarrollador

## Instrucciones generales

1. Desarrollar una aplicación en C# utilizando .NET Framework 4.8.
2. Estructura tu proyecto de manera clara.
3. Documentar el código donde sea necesario para explicar la lógica implementada.
Requisitos de la prueba


### 1. Creación del proyecto
Crear un proyecto ASP.NET MVC en Visual Studio (o cualquier otro entorno de desarrollo compatible) usando el Framework 4.8 de .Net.o Nombrar el proyecto como EmployeeManagement.

### 2. Modelo de datos

Crear un modelo de datos en C# para manejar la información de empleados.
El modelo debe llamarse Employee y debe contener las siguientes
propiedades:
* Id (int): Identificador único del empleado.
* Name (string): Nombre completo del empleado.
* Position (string): Cargo del empleado.
* Office (string): Oficina del empleado.
* Salary (decimal): Salario del empleado.

### 3. Interfaz de usuario
Crear una vista principal en HTML con un diseño sencillo utilizando CSS para
estilizar la página. La vista debe:
* Mostrar una lista de empleados en una tabla.
* Permitir agregar un nuevo empleado mediante un formulario.
* Permitir editar y eliminar empleados existentes.

### 4. Funcionalidad con jQuery
Utilizar jQuery para:
* Validar los campos del formulario (Nombre, Cargo, Oficina, Salario)
antes de enviarlo.
* Enviar los datos del formulario al servidor utilizando AJAX.
* Actualizar la tabla de empleados dinámicamente sin recargar la página.

### 5. Controlador y acciones
Crear un controlador llamado EmployeeController con las siguientes
acciones:
* Index: Para mostrar la vista principal.
* GetEmployees: Para obtener la lista de empleados en formato JSON.
* AddEmployee: Para agregar un nuevo empleado.
* UpdateEmployee: Para actualizar la información de un empleado
existente.
* DeleteEmployee: Para eliminar un empleado.

### 6. Requisitos adicionales
* Usar Bootstrap para mejorar el diseño visual de la aplicación.
* Incluir comentarios en el código para explicar la lógica implementada.

## Criterios de evaluación
* Correctitud y funcionalidad del código.
* Calidad y claridad del código.
* Uso adecuado de HTML, CSS, jQuery y C#.
* Cumplimiento de los requisitos especificados.
* Eficiencia en el uso de recursos y rendimiento de la aplicación.
* Estilo y organización del código.
* Capacidad para seguir instrucciones y prestar atención a los detalles.
 
## Entrega
Asegurarse de que el proyecto se pueda ejecutar sin problemas en otro entorno de
desarrollo.