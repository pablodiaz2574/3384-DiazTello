# Control de Versiones 

Uso de herramientas de versionamiento de software

- GitBash
- Github

## Comandos de Configuración

- git config --global user.name "PabloDiaz"
- git config --global user.email "N00483823@upn.pe"
- git config --global core.editor "core -wait"
- git config --list

## Comandos Basicos de Repositorio

- git init → Crea un repositorio en la carpeta actual.
- git status → Muestra archivos modificados y pendientes de confirmar.
- git add archivos.txt → Añade archivos al área de preparación.
- git add . → Agregar Todos los archivos.
- git commit -m "Mensaje descriptivo" → Registra los cambios en el historial.
- git log → Muestra los cambios realizados en el repositorio.
- git log --oneline → Ver historial resumido.

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

## Comando de Repositorio Remoto

- git remote add origin [URL] →  Conectar con Repositorio Remoto
- git remote -v → Ver repositorios remotos
- git push origin main → Subir cambios a GitHub
- git push -u origin main → Primer push (establecer upstream)
- git pull origin main → Descargar cambios de GitHub
- git clone [URL] → Clonar repositorio existente

## Comandos de Información

- git diff → Ver Cambios no confirmados
- git diff --staged → Ver cambios en staging
- git show → Ver último commit
- git branch → Ver ramas locales
- git branch -r → Ver ramas remotas

#  Estructura de Control de Versiones

- Estructuras Secuenciales
- Estructuras Condicionales Simpleas
- Estructuras Condicionales Dobles
- Estructuras Condicionales Multiples
- Estructuras Condicionales Anidadas
- Estructuras Condicionales Repetitivas (For, While, Do While)