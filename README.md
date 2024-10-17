# Practica_3_II
Práctica 3 de la asignatura Interfaces Inteligentes. En esta práctica se profundiza en el uso de las físicas en Unity, realizando una serie ejercicios con el objetivo de aprender a utilizar el motor de físicas de Unity.
## Situaciones Físicas 3D
### Situación 1
En esta situación, el plano sirve como una base estática para el cubo, que se comporta físicamente debido a su Rigidbody, mientras que la esfera, al no tener un Rigidbody, no se moverá ni responderá a la física, actuando simplemente como un objeto de colisión pasivo.
![Situacion_1](https://github.com/user-attachments/assets/34ac921f-6b56-4ff3-af1c-aaabd4ec0182)

### Situación 2
El plano sirve como una base estática con un collider, sin participar en la física. Tanto el cubo como la esfera, al tener Rigidbody, se comportan físicamente: pueden moverse, colisionar y reaccionar a fuerzas. Al chocar entre sí, ambos responderán según sus configuraciones físicas, mientras que el plano solo detectará las colisiones sin moverse.
![Situacion_2](https://github.com/user-attachments/assets/7e70f02d-4e1d-4492-86dd-d1d0918eac8c)

### Situación 3
El plano es estático con un collider. El cubo se mueve y reacciona con física debido a su Rigidbody. La esfera, al ser cinemática, no es afectada por fuerzas, pero puede moverse mediante código y generar colisiones.
![Situacion_3](https://github.com/user-attachments/assets/8d5ecf7a-c4af-4faa-ad9f-5e3b7df00054)

### Situación 4
El plano, el cubo y la esfera tienen Rigidbody, por lo que todos reaccionan a fuerzas y colisiones. Pueden moverse y afectar o ser afectados por los demás según sus propiedades físicas.
![Situacion_4](https://github.com/user-attachments/assets/484023bd-8948-4851-9c05-7e66bc52a2b7)

### Situación 5
El plano, el cubo y la esfera tienen Rigidbody. La esfera, con 10 veces más masa que el cubo, ejercerá más influencia en colisiones, causando que el cubo se desplace más fácilmente al impactar, mientras que la esfera apenas será afectada.
![Situacion_5](https://github.com/user-attachments/assets/7e8d15a5-2b3b-4569-bfd5-3731ca702c05)

### Situación 6
El plano, el cubo y la esfera tienen Rigidbody. La esfera, con 100 veces más masa que el cubo, prácticamente no será afectada en colisiones, mientras que el cubo será desplazado fácilmente por la inercia de la esfera.
![Situacion_6](https://github.com/user-attachments/assets/2ba3950b-5234-4d15-b029-d405cca93352)

### Situación 7
El plano, el cubo y la esfera tienen Rigidbody. La fricción de la esfera afectará su movimiento, haciendo que desacelere más rápido al desplazarse o al colisionar, dependiendo de la superficie de contacto.
![Situacion_7](https://github.com/user-attachments/assets/2cd39713-1f95-4c90-a57c-a677bc0827ee)

### Situación 8
El plano y el cubo tienen Rigidbody y reaccionan a la física. La esfera, al ser Trigger, no genera colisiones físicas pero detecta interacciones, activando eventos al atravesar otros colliders.
![Situacion_8](https://github.com/user-attachments/assets/4938e1ff-1139-43fd-b546-d0125b4b5380)

### Situación 9
El plano, el cubo y la esfera tienen Rigidbody. La esfera, al ser Trigger, no genera colisiones físicas pero puede detectar cuándo otros objetos la atraviesan, activando eventos correspondientes.
![Uploading Situacion_9.gif…]()

## Ejercicios Práctica 3
### Ejercicio 1
Se creó un script para mover un cubo en el eje Z a una velocidad ajustable desde el inspector. Cada vez que se presiona una tecla de flecha (arriba, abajo, izquierda, derecha), se muestra en la consola el nombre de la flecha pulsada y el resultado de multiplicar la velocidad por los valores de los ejes horizontal o vertical usando Input.GetAxis.
![Ejercicio_1](https://github.com/user-attachments/assets/f88cac4b-17c5-40c2-9602-f43ad9fbc0de)

### Ejercicio 2
Establecemos h como el botón de disparo en el Input Manager.
![Ejercicio_2](https://github.com/user-attachments/assets/9350256a-a74d-423f-b483-0fb6ce69857d)

### Ejercicio 3
#### Caso base
El cubo se mueve en la dirección especificada por moveDirection a una velocidad mayor que 1.
![Ejercicio_3_Caso_base](https://github.com/user-attachments/assets/95174c1b-4443-4549-82ea-e06e8cb82e70)

#### Caso A
Si se duplican las coordenadas de moveDirection, el cubo se moverá el doble de lejos en cada actualización, resultando en un movimiento más rápido en esa dirección.
![Uploading Ejercicio_3_a.gif…]()

#### Caso B
Duplicar la velocidad manteniendo la dirección del movimiento:
Al duplicar speed, el cubo se moverá el doble de rápido en la misma dirección especificada por moveDirection, lo que aumentará su velocidad de desplazamiento.
![Ejercicio_3_b](https://github.com/user-attachments/assets/eb5779f4-1aae-4550-bd12-5709c11b9f8c)

#### Caso C
Si la velocidad se establece en un valor menor que 1, el cubo se moverá con la velocidad mínima permitida.
![Ejercicio_3_c](https://github.com/user-attachments/assets/e8111812-4423-481e-8586-824d369301c7)

#### Caso D
Si el cubo comienza en una posición con y > 0, se moverá en la dirección de moveDirection, pero su altura inicial será mayor que 0, lo que afectará su trayectoria en el espacio 3D.
![ejercicio_3_d](https://github.com/user-attachments/assets/bd9c14c0-8f3f-437b-ae1a-3b36aebd4707)

#### Caso E
Si se intercambia el movimiento para ser relativo al sistema de referencia local, el cubo se moverá en relación a su propia rotación y no al mundo. En este caso, no se aprecian cambios.
![ejercicio_3_e (1)](https://github.com/user-attachments/assets/e3116adf-7da8-4ccc-a00b-d6fd2b0e3b90)

### Ejercicio 4
El script Ejercicio_4 permite mover un cubo y una esfera en Unity. Utiliza la velocidad definida en el campo speed y las teclas de flecha para mover el cubo, mientras que las teclas W, A, S, D controlan la esfera. Al presionar las teclas, se actualiza la dirección de movimiento y se aplica el desplazamiento con transform.Translate, permitiendo que ambos objetos se desplacen según la entrada del usuario.
![ejercicio_4](https://github.com/user-attachments/assets/aba5a9bd-45d6-4280-b57d-c4ebaf0374eb)

### Ejercicio 5
Se permite mover un cubo y una esfera en Unity, utilizando una velocidad configurada en el campo speed. Las teclas de flecha controlan el movimiento del cubo, mientras que las teclas W, A, S y D permiten mover la esfera. La dirección de movimiento se actualiza al detectar la entrada del usuario, y se aplica el desplazamiento usando transform.Translate, multiplicando por Time.deltaTime para asegurar que el movimiento sea suave y proporcional al tiempo transcurrido entre frames.
![ejercicio_5](https://github.com/user-attachments/assets/8199f115-3abe-4d48-a634-73f9cccb8e48)

### Ejercicio 6
El cubo se mueve automáticamente hacia la esfera, calculando la dirección entre ellos y normalizándola para mantener un desplazamiento constante. La velocidad de movimiento se establece en el campo speed. La esfera se controla mediante las teclas W, A, S y D, permitiendo que el usuario la mueva. El uso de Time.deltaTime garantiza un movimiento suave y consistente en relación al tiempo transcurrido entre frames.
![ejercicio_6](https://github.com/user-attachments/assets/11314efa-3241-4787-bb59-bce4bcfb8acd)

### Ejercicio 7
El cubo ahora gira hacia la esfera utilizando el método LookAt, orientando su frente hacia ella. Además, se mueve en dirección a la esfera con un desplazamiento constante, calculado y normalizado para asegurar un movimiento uniforme. La esfera se controla con las teclas W, A, S y D, permitiendo al usuario moverla. Se mantiene la suavidad del movimiento aplicando Time.deltaTime para escalar la distancia recorrida en cada frame.
![ejercicio_7](https://github.com/user-attachments/assets/05c78c78-7dfd-400b-82a5-5dd61472a8b0)

### Ejercicio 8
El script hace que el objeto gire y avance continuamente. Utiliza el eje "Horizontal" para controlar la rotación y se desplaza en la dirección hacia adelante con transform.forward. Se multiplica por la velocidad y Time.deltaTime para un movimiento suave. También emplea Debug.DrawRay para visualizar la dirección de avance en la escena.
![ejercicio_8](https://github.com/user-attachments/assets/279590f3-11e0-4102-ad16-0ef9baa7468e)

### Ejercicio 9
El script detecta colisiones del cilindro con otros objetos físicos mediante el método OnCollisionEnter. Cuando ocurre una colisión, se registra un mensaje en la consola que indica la etiqueta del objeto con el que colisionó. No se realizan otras acciones en los métodos Start y Update, ya que se centra únicamente en la detección de colisiones.
![ejercicio_9_2](https://github.com/user-attachments/assets/a3f17083-6eac-4432-8161-338056ec5242)

### Ejercicio 10
El script permite mover un cubo y una esfera en la escena. El cubo, que es cinemático, se mueve usando las teclas de flecha, aplicando un desplazamiento directo. La esfera, configurada como objeto físico, se controla mediante las teclas W, A, S y D, aplicando fuerza a su Rigidbody para moverla. Además, se detectan colisiones del cilindro, mostrando en la consola un mensaje con la etiqueta del objeto que colisionó.
![ejercicio_10](https://github.com/user-attachments/assets/21ba09fd-23cf-4f5e-bba0-217cb530746a)


### Ejercicio 11
El script controla el movimiento de un cubo y una esfera en Unity. El cubo se mueve con las teclas de flecha, mientras que la esfera utiliza W, A, S y D con AddForce para simular física. También detecta colisiones del cilindro, mostrando mensajes en la consola para colisiones físicas y de tipo trigger, permitiendo diferenciar entre ambos tipos de interacciones.
![ejercicio_11](https://github.com/user-attachments/assets/693d4dba-d4df-498a-955b-9fe4dd70142d)

### Ejercicio 12
#### Caso Base
El script permite mover un cilindro utilizando las teclas de flecha, aplicando fuerzas a través de su componente Rigidbody. Se utiliza AddForce para simular el movimiento en la escena, garantizando que el cilindro interactúe físicamente con otros objetos. Si se pulsa la tecla espacio, el cilindro va hacia la esfera

#### Esfera con masa 10 veces mayor que el cilindro:
La esfera se moverá poco al ser empujada por el cilindro debido a su mayor masa. El cilindro se desplazará más rápidamente hacia la esfera, pero la esfera apenas se moverá.

![ejercicio_12_a](https://github.com/user-attachments/assets/8684e18d-f5e4-4440-8487-3f44800a6c16)

#### Esfera con masa 10 veces menor que el cilindro:
El cilindro será capaz de empujar la esfera significativamente, y esta se moverá rápidamente al ser impactada, mostrando una interacción dinámica más notable.

![ejercicio_12_b](https://github.com/user-attachments/assets/a9b92964-9765-4117-904a-dd75cf453a1b)

#### Esfera cinemática:
La esfera no se moverá al ser empujada por el cilindro, pero el cilindro podrá moverse alrededor de ella y tocarla.
![ejercicio_12_c](https://github.com/user-attachments/assets/25c262e5-1cfc-4721-b993-7bf74f28311d)


#### Esfera como trigger:
Similar a la cinemática, el cilindro podrá moverse alrededor de la esfera, y el cilindro atravesará a la esfera.
![ejercicio_12_d](https://github.com/user-attachments/assets/21db788f-d732-4f5c-afb9-1caceaa6eaff)

#### Fricción duplicada
El cilindro tendrá más resistencia al movimiento, por lo que su aceleración y desplazamiento serán más lentos al aplicar fuerza.
![ejercicio_12_e](https://github.com/user-attachments/assets/f7442647-d297-46ae-bef4-9d2a7246c305)




