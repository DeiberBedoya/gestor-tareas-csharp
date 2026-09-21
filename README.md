# Gestor de Tareas por Consola (C#)

Aplicación de consola en C# / .NET para gestionar tareas personales: crear, listar, completar y eliminar. Proyecto de práctica para consolidar fundamentos de C# (control de flujo, funciones, colecciones, clases) construyendo algo funcional de principio a fin.

## Objetivo del proyecto

Aprender C# construyendo directamente, en vez de solo estudiar teoría de forma aislada. Cada funcionalidad del MVP corresponde a un concepto del lenguaje que se practica en el momento de implementarla.

## Stack

- **Lenguaje:** C#
- **Plataforma:** .NET (consola)
- **Persistencia:** archivo de texto plano o JSON local (sin base de datos en el MVP)
- **Control de versiones:** Git + GitHub

---

## MVP (Producto Mínimo Viable)

La versión mínima funcional del gestor de tareas debe permitir:

1. Agregar una tarea nueva
2. Ver el listado completo de tareas (pendientes y completadas)
3. Marcar una tarea como completada
4. Eliminar una tarea
5. Que las tareas persistan al cerrar y volver a abrir el programa

Todo lo que no esté en esta lista queda fuera del MVP (ver sección "Fuera de alcance").

---

## Historias de usuario

Formato: *Como [rol], quiero [acción], para [beneficio]*.

| ID | Historia de usuario |
|----|---|
| HU-01 | Como usuario, quiero agregar una tarea con un título, para registrar algo pendiente por hacer. |
| HU-02 | Como usuario, quiero ver la lista completa de mis tareas, para saber qué tengo pendiente y qué ya completé. |
| HU-03 | Como usuario, quiero marcar una tarea como completada, para llevar control de mi progreso. |
| HU-04 | Como usuario, quiero eliminar una tarea, para quitar algo que ya no necesito tener registrado. |
| HU-05 | Como usuario, quiero que mis tareas se guarden automáticamente, para no perderlas al cerrar el programa. |
| HU-06 | Como usuario, quiero recibir un mensaje claro si ingreso una opción inválida, para saber cómo corregirlo. |

### Historias fuera del MVP (backlog futuro)

| ID | Historia de usuario |
|----|---|
| HU-07 | Como usuario, quiero asignar una fecha límite a una tarea, para priorizar por urgencia. |
| HU-08 | Como usuario, quiero categorizar tareas (trabajo, personal, estudio), para organizarlas mejor. |
| HU-09 | Como usuario, quiero editar el título de una tarea existente, sin tener que eliminarla y crearla de nuevo. |
| HU-10 | Como usuario, quiero buscar tareas por palabra clave, para encontrarlas más rápido si tengo muchas. |

---

## Requisitos funcionales (RF)

| ID | Requisito |
|----|---|
| RF-01 | El sistema debe permitir agregar una tarea con un título (texto no vacío). |
| RF-02 | El sistema debe listar todas las tareas, indicando visualmente cuáles están completadas. |
| RF-03 | El sistema debe permitir seleccionar una tarea existente y marcarla como completada. |
| RF-04 | El sistema debe permitir seleccionar una tarea existente y eliminarla de la lista. |
| RF-05 | El sistema debe guardar el estado de las tareas en un archivo local cada vez que se agregue, complete o elimine una tarea. |
| RF-06 | El sistema debe cargar las tareas guardadas al iniciar el programa. |
| RF-07 | El sistema debe mostrar un menú con las opciones disponibles y repetirlo hasta que el usuario elija salir. |
| RF-08 | El sistema debe validar la entrada del usuario y mostrar un mensaje de error si la opción u tarea seleccionada no existe. |

## Requisitos no funcionales (RNF)

| ID | Requisito |
|----|---|
| RNF-01 | **Usabilidad:** los mensajes del menú y las instrucciones deben ser claros y en español. |
| RNF-02 | **Portabilidad:** el programa debe correr con `dotnet run` sin dependencias externas más allá del SDK de .NET. |
| RNF-03 | **Mantenibilidad:** el código debe organizarse en clases separadas por responsabilidad (no todo en `Program.cs`). |
| RNF-04 | **Persistencia liviana:** no se requiere una base de datos; un archivo local es suficiente para el MVP. |
| RNF-05 | **Robustez básica:** el programa no debe cerrarse abruptamente por una entrada inválida del usuario (manejo de excepciones donde aplique). |

---

## Fuera de alcance (para este MVP)

- Interfaz gráfica o web (se queda en consola)
- Múltiples usuarios o autenticación
- Base de datos relacional
- Sincronización en la nube

---

## Estructura de carpetas propuesta

```
GestorTareas/
├── GestorTareas.csproj
├── Program.cs          # Punto de entrada, menú principal
├── Models/
│   └── Tarea.cs         # Clase que representa una tarea
├── Services/
│   └── TareaService.cs  # Lógica: agregar, listar, completar, eliminar
├── Data/
│   └── Almacenamiento.cs # Lectura/escritura del archivo de persistencia
├── .gitignore
└── README.md
```

Esta estructura se irá construyendo paso a paso junto con el código — no hace falta crearla toda de una vez.

---

## Flujo de trabajo con Git

### 1. Inicializar el repositorio

```bash
cd GestorTareas
git init
```

### 2. Crear un `.gitignore` para .NET

Antes del primer commit, crea un archivo `.gitignore` en la raíz del proyecto con este contenido mínimo:

```
bin/
obj/
*.user
.vs/
```

Esto evita subir archivos generados automáticamente por el compilador.

### 3. Primer commit

```bash
git add .
git commit -m "Inicializa proyecto Gestor de Tareas con README y documentación"
```

### 4. Crear el repositorio remoto en GitHub

En GitHub, crea un repositorio nuevo llamado `gestor-tareas-csharp` (o el nombre que prefieras), **sin** inicializarlo con README (ya tienes uno local). Luego conéctalo:

```bash
git remote add origin https://github.com/TU_USUARIO/gestor-tareas-csharp.git
git branch -M main
git push -u origin main
```

### 5. Flujo de ramas durante el desarrollo

Para que el historial quede prolijo en tu portafolio, trabaja cada funcionalidad en su propia rama:

```bash
git checkout -b feature/agregar-tarea
# ... programas la funcionalidad ...
git add .
git commit -m "Implementa agregar tarea (HU-01)"
git checkout main
git merge feature/agregar-tarea
git push
```

Repite esto por cada historia de usuario (`feature/listar-tareas`, `feature/completar-tarea`, `feature/eliminar-tarea`, `feature/persistencia`). Así tu repositorio muestra progreso real y ordenado, no un único commit gigante — eso se ve bien para quien revise tu portafolio.

### Convención de commits sugerida

| Prefijo | Uso |
|---|---|
| `feat:` | nueva funcionalidad |
| `fix:` | corrección de un error |
| `docs:` | cambios en documentación |
| `refactor:` | cambios internos sin alterar el comportamiento |

Ejemplo: `feat: agrega opción para marcar tarea como completada`

---

## Estado del proyecto

- [ ] HU-01 — Agregar tarea
- [ ] HU-02 — Listar tareas
- [ ] HU-03 — Marcar tarea como completada
- [ ] HU-04 — Eliminar tarea
- [ ] HU-05 — Persistencia en archivo
- [ ] HU-06 — Validación de entradas inválidas
