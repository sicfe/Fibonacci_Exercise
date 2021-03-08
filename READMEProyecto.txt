
El proyecto esta construido bajo la arquitectura WebAPI que permite bajo request manejar response con los correspondientes
protocolos HTTP, en este caso vamos a poder utilizar el controlador FibonacciController para manejar las peticiones.

El proyecto utiliza algoritmo recursivos para poder calcular la sucesión de fibonacci desde el número 0,1 hasta infinito.

La api utiliza dos metodos http 
Post : lo utlizamos para poder insertar un dato, para eso debemos utilizar algún programa para testeo de api como puede ser postman.
Get : con el metodo get podemos ingresar un dato en este caso un id y la api nos devuelve el fibonacci del id que ingresamos
	para eso debemos ejecutar el programa y dentro de la url ponemos /api/Fibonacci/id donde id sea un numero que quieramos calcular

EJ localhost:4000/api/Fibonacci/5 ---> esto nos devolvera 5 
