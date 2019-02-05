# Fibonacci_Exercise
Ejercicio para iniciar en prácticas de programación

# Descripción del proyecto

# Herramientas
- SDK de net core 2.2 [Download](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- Visual Code [Download](https://code.visualstudio.com/)
- Git [Download](https://git-scm.com/downloads)


# Tareas
- [ ] Descargarse el proyecto
- [ ] Crear una nueva rama
- [ ] Ejecutar el proyecto y sus test unitarios
- [ ] Completar los issues pendientes en el proyecto
- [ ] Crear un pull request y solicitar revisión del mismo

# Convenciones del proyecto
A continuación se detallan algunos de los puntos principales, el resto se explican en el documento.

**Reglas:**

- Se utiliza PascalCase para nombres y entidades públicas (clases, propiedades, etc)
- Se utiliza camelCase para nombres y entidades privadas (parámetros, variables, etc.)
- La configuración propia de la aplicación se almacena en appSetings
- La configuración propia del deploy se almacena como variables de ambiente o secretos
- Todos los recursos y servicios externos deben tener un wrapper que permita encapsularlo y definir una interfaz.
- Se deben crear test unitarios para todas las clases públicas de un proyecto
- La inicialización de una clase se debe realizar enteramente en el constructor. Una vez construida la instancia la misma debe poderse utilizar.
- Las excepciones se utilizan para interrumpir el flujo del programa, si es posible continuar operando se debe retornar un código de error.

**Ideas**

- Minimizar la dependencia entre proyectos/paquetes/servicios
- Maximizar la "testeabilidad" del código
- Usar Inyección de dependencias cuando sea posible

**Mensajes de commit**

- feat: A new feature
- fix: A bug fix
- docs: Documentation only changes
- style: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc.)
- refactor: A code change that neither fixes a bug nor adds a feature
- perf: A code change that improves performance
- test: Adding missing or correcting existing tests
- chore: Changes to the build process or auxiliary tools and libraries such as documentation generation

**Template de commit** (se deben dejar una líneae en blanco entre cada sección)

```
fix:  Resuelve error al intentar generar enlace sin parámetros

Descripción más larga de las cambios y explicación

{issue|close}: #5
```
