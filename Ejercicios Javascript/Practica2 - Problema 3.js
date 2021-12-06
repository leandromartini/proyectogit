//En este caso se pide resolver el problema 1 de los ejercicios obligatorios de forma óptima
//considerando las variables de tiempo de ejecución y memoria,
//minimizando el costo total en su relación CT = T + 5 * M, donde T es el tiempo total de ejecución en milisegundos 
//para encontrar la cadena y M es la cantidad de memoria máxima usada medida en KB.
//Ejemplo: Se propone la solución A cuyo tiempo de ejecución promedio es de 1580ms y consume 16K de memoria.
//Luego se propone la solución B cuyo tiempo de ejecución promedio es de 1900ms y consume 8K de memoria. 
//Las relaciones serían:
//CT_A = 1580 + 5 * 16 	= 1580 + 800 	= 2380
//CT_B = 1900 + 5 * 8  	= 1900 + 400 	= 2300
//Es superior la solución B.

console.time('loop');
entero = 1000000
numTerminos = [0]
function secuItera(num) {
    itera = num;
    term = 1
    for (let i = 1; i <= itera; i++) {
        term += 1
        if (num % 2) {
            num = 3 * num + 1;
        } else {
            num = num / 2;
        }
        if (num == 1) {
            break;
        }
    }
    numTerminos.push(term)
}
function maxCantTerm(entero) {
    for (let j = 1; j <= entero; j++) {
        secuItera(j)
        //console.log(numTerminos[j])
    }
}
maxCantTerm(entero)
console.log("El número inicial, por debajo de 1.000.000 que produce la cadena más con mayor cantidad de términos: " + numTerminos.indexOf(numTerminos.reduce((n, m) => Math.max(n, m), -Number.POSITIVE_INFINITY)))

console.timeEnd('loop');
