# Control de Versiones

uso de herramientas de versionamiento de software

- Git
- GitHub

## Comando Básicos y Estructuras de un Repositorio

- git init → Crea un repositorio en la carpeta actual.
- git status → Muestra archivos modificados y pendientes de confirmar.
- git add archivos.txt → Añade archivos al área de preparación.
- git commit -m "Mensaje descriptivo" → Registra los cambios en el historial.
- git log → Muestra los cambios realizados en el repositorio.

## Estructura de un Repositorio Git

- .git/ → Carperta oculta con el historial de versiones.
- Archivos de trabajo → Código y otros archivos.

## Flujos de Trabajo en Git

### Clonar un repositorio remoto.

- git clone [URL] del repositorio

### Hacer cambios y confirmar

- git add .
- git commit -m "Descripción de los cambios"

### Enviar cambios al servidor

- git push origin main

### Actualizar cambios del repositorio remoto

- git pull origin main

## Ramas y Gestión  de Ramas

- git branch nueva-rama → Crear una nueva rama.
- git checkout nueva-rama → Cambiar de rama.
- git merge nueva-rama → Fusión de ramas.
- git branch -d nueva-rama → Eliminar una rama.

## Arreglos