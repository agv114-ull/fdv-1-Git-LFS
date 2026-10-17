# Práctica 1.1 · Uso de Git LFS

**Fundamentos del Desarrollo de Videojuegos** · Máster Universitario en Desarrollo de Videojuegos · Universidad de La Laguna · Curso 2026-27
**Autor:** Ángel Gonjar Verdejo

![Ejecución de la escena: el mensaje «Script tarea 1.1» aparece en pantalla y en la consola](docs/img/06-play-script-tarea-1-1.gif)

## Objetivo

Versionar un proyecto Unity con Git y gestionar sus ficheros de gran tamaño mediante Git LFS.

## 1. Proyecto Unity y repositorio Git

Se creó un proyecto Unity 3D con la plantilla Universal 3D y se añadieron a la escena dos objetos 3D, un plano y una esfera. Siguiendo el flujo de trabajo de Unity, cada objeto tiene su propio material: *Green* para el plano y *Orange* para la esfera (figuras 3 a 5).

El proyecto está configurado para el control de versiones con *Visible Meta Files* y serialización de recursos en *Force Text* (figuras 6 y 7). Se versiona en un repositorio Git local, creado con Git GUI y conectado a un repositorio remoto en GitHub, que incluye el fichero `.gitignore` de Unity (figuras 1 y 2).

## 2. Git LFS

Git LFS se configuró mediante el fichero `.gitattributes` de Unity, que indica qué tipos de fichero se almacenan en LFS: vídeo, audio, imágenes y modelos 3D, entre otros.

En una segunda versión del proyecto se incorporaron:

- Un vídeo de 232 MB en la carpeta `Assets/Media`, almacenado mediante Git LFS (figura 8).
- El script `ScriptTarea11`, asignado a la esfera, que muestra el mensaje «Script tarea 1.1» en la consola y en pantalla (animación inicial).

## Verificación

Los ficheros de vídeo figuran entre los gestionados por Git LFS:

```text
$ git lfs ls-files
95fe8f503f * Assets/Media/Grabación de pantalla 2026-07-17 203808.mp4
8a71c076bc * Assets/Media/Grabación de pantalla 2026-09-11 200212.mp4
```

En GitHub, el vídeo de 232 MB aparece con la indicación «Stored with Git LFS» (figura 8).

## Capturas del proceso

![Creación del proyecto en Unity Hub con la plantilla Universal 3D](docs/img/00a-unity-hub-nuevo-proyecto.png)

*Figura 1. Creación del proyecto en Unity Hub con la plantilla Universal 3D.*

![Creación del repositorio local con Git GUI](docs/img/00b-git-gui-nuevo-repositorio.png)

*Figura 2. Creación del repositorio local con Git GUI.*

![Escena con el plano y la esfera](docs/img/01-escena-plane-sphere.png)

*Figura 3. Escena con los dos objetos 3D.*

![Inspector de la esfera con el material Orange y el script de la tarea](docs/img/02-inspector-sphere.png)

*Figura 4. Esfera: material Orange y script `ScriptTarea11`.*

![Inspector del plano con el material Green](docs/img/03-inspector-plane.png)

*Figura 5. Plano: material Green.*

![Project Settings, Version Control en Visible Meta Files](docs/img/04-settings-version-control.png)

*Figura 6. Control de versiones en modo Visible Meta Files.*

![Project Settings, Asset Serialization en Force Text](docs/img/05-settings-editor-force-text.png)

*Figura 7. Serialización de recursos en Force Text.*

![Vídeo en GitHub almacenado con Git LFS](docs/img/07-github-stored-with-git-lfs.png)

*Figura 8. El vídeo en GitHub, almacenado con Git LFS.*

## Herramientas

Unity 6000.5.11f1 (URP) · Git · Git LFS · Git GUI · GitHub Desktop

## Referencias

- Plantilla `.gitignore` de Unity: [github/gitignore](https://github.com/github/gitignore/blob/main/Unity.gitignore).
- Plantilla `.gitattributes` de Unity: [gitattributes/gitattributes](https://github.com/gitattributes/gitattributes/blob/master/Unity.gitattributes).
- Guion de la práctica y material de la asignatura (campus virtual de la ULL).
