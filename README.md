# Practica_3_II
Práctica 3 de la asignatura Interfaces Inteligentes. En esta práctica se profundiza en el uso de las físicas en Unity, realizando una serie ejercicios con el objetivo de aprender a utilizar el motor de físicas de Unity.
## Ejercicio Físicas 3D
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








