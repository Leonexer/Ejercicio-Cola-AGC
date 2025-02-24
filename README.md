# Instrucciones
### Desarrolla un sistema de atención de clientes basado en colas, donde:
- Los clientes lleguen a una fila de espera de manera secuencial.
- Se atiendan en el orden en que llegaron (FIFO).
- Se permita agregar nuevos clientes a la cola y atender al siguiente en turno.
- Se muestre el estado actual de la cola en todo momento.
# Procedimiento
Mediante un nodo que almacene un dato y apunte a un nodo siguiente:
- Se crea una clase Queue donde definimos la función Enqueue que almacenará el dato dado en los parametros en un nodo, actualizando las referencias del nodo siguiente si este existe
- Definimos la función Dequeue que retorne el valor de la posición primera de la Queue y recorra los nodos actualizando las referencias del tope y el siguiente.
- Definimos una función Print para mostrar la Queue
- El resto del procedimiento sería crear un menú con switch que llame a las funciones de forma adecuada al igual que solicite al usuario los datos usados en funciones como Enqueue.
