# Práctica 2: Introducción a Scripts, Movimiento y Transformaciones en Unity

Este repositorio recoge las implementaciones de los ejercicios prácticos sobre el manejo del sistema clásico de entradas (`Input`), desplazamientos espaciales (`Transform.Translate`), cálculos vectoriales (`Vector3`) y orientación (`LookAt`, rotaciones locales y globales) en Unity.

---

## Ejercicio 5: Desplazamiento de objetos mediante marcador y eje Jump

Configuración de tres objetos en la escena, cada uno con una posición inicial almacenada en `Start()`. Al pulsar la barra espaciadora (`Input.GetAxis("Jump") > 0`), los objetos se desplazan sumando a su posición original un vector de desplazamiento configurable desde el Inspector.

* **Script:** `Assets/Scripts/05_move_objects_with_marker.cs`

* **Ejecución:**
[](Gifs/Ejercicio_05.gif)


---

## Ejercicio 6: Control de velocidad y lectura de ejes por consola

Se implementa un script en el cubo con una velocidad pública editable en el Inspector. Al pulsar las teclas de dirección (flechas), se detecta la tecla concreta mediante `Input.GetKey()` y se imprime en la consola de depuración el nombre de la flecha pulsada junto con el resultado de multiplicar la velocidad por el valor actual de los ejes `Horizontal` y `Vertical`.

* **Script:** `Assets/Scripts/06_control_cube_velocity.cs`

* **Demostración:**


---

## Ejercicio 7: Mapeo de tecla en el Input Manager (Disparo en tecla H)

Reconfiguración del gestor de entradas clásico en `Edit -> Project Settings -> Input Manager`. Se redefine la acción de disparo (`Fire1`) asignando la tecla `h` en el campo *Positive Button*.

* **Captura de configuración:**


---

## Ejercicio 8: Traslación proporcional a una dirección y velocidad

Traslación continua del cubo mediante `transform.Translate(moveDirection * speed)`. Se evalúan los efectos de variar los parámetros en el Inspector:

* **Duplicar coordenadas de dirección:** El cubo se mueve el doble de rápido, ya que la magnitud del vector resultante por frame se multiplica por 2.
* **Duplicar la velocidad:** Produce exactamente el mismo efecto cinemático que duplicar la dirección, escalando el desplazamiento lineal por dos.
* **Velocidad menor que 1:** El cubo avanza de manera notablemente más lenta, cubriendo fracciones de unidad por iteración.
* **Posición inicial con $y > 0$:** Si el vector de traslación solo actúa en X/Z, el cubo mantiene su elevación suspendido en el aire; si el vector incluye componente en Y, ascenderá o descenderá continuamente.
* **Espacio local vs. mundial (`Space.Self` vs. `Space.World`):** En espacio local, el cubo se desplaza respecto a su propia orientación interna (si está rotado, su eje frontal ya no coincide con el del escenario). En espacio mundial, se mueve rígidamente sobre los ejes cardinales globales de la escena.
* **Script:** `Assets/Scripts/08_traslade_cube.cs`

* **Demostración:**


---

## Ejercicio 9: Control independiente de dos jugadores (Ejes dedicados)

Movimiento simultáneo e independiente de dos entidades separando los ejes en el Input Manager: el cubo responde exclusivamente a las flechas del teclado y la esfera a las teclas WASD, aplicando `transform.Translate` frame a frame.

* **Scripts:**
* `Assets/Scripts/09_cube_player.cs`

* `Assets/Scripts/09_sphere_player.cs`



* **Demostración:**


---

## Ejercicio 10: Movimiento independiente de la tasa de refresco (`Time.deltaTime`)

Adaptación de los controles del ejercicio 9 integrando `Time.deltaTime` en las funciones de traslación. Esto normaliza el desplazamiento para que sea constante en unidades por segundo reales, evitando fluctuaciones de velocidad provocadas por la tasa de fotogramas (FPS) del equipo.

* **Scripts:**
* `Assets/Scripts/10_cube_player_delta_time.cs`

* `Assets/Scripts/10_sphere_player_delta_time.cs`



* **Demostración:**


---

## Ejercicio 11: Cubo persiguiendo a la esfera a velocidad constante

El cubo calcula la dirección hacia la esfera mediante resta de vectores (`esfera - cubo`), anula la componente vertical (`y = 0`) para mantener su altura fija y normaliza el vector con `normalized` para garantizar que la velocidad de persecución sea fija e independiente de la distancia.

* **Script:** `Assets/Scripts/11_cube_moving_to_sphere.cs`

* **Demostración:**


---

## Ejercicio 12: Cubo orientándose y avanzando hacia la esfera (`LookAt`)

El cubo emplea el método `transform.LookAt()` para alinear su eje Z frontal hacia la posición de la esfera en todo momento, avanzando hacia adelante en su sistema local mediante su velocidad escalada en el tiempo.

* **Script:** `Assets/Scripts/12_cube_moving_looking_at_objective.cs`

* **Demostración:**


---

## Ejercicio 13: Giro sobre eje vertical y avance continuo hacia adelante

El objeto avanza sin interrupción a lo largo de su vector frontal global (`transform.forward * speed * Time.deltaTime, Space.World`) mientras rota sobre su eje vertical local (`transform.up`) según la entrada del eje `Horizontal`. Incluye `Debug.DrawRay` para visualizar de forma continua el vector hacia adelante en la vista de escena.

* **Script:** `Assets/Scripts/13_rotation_on_vertical_axis.cs`

* **Demostración:**
