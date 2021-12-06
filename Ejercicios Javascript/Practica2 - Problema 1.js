//Dada la siguiente secuencia iterativa definida por el conjunto de enteros positivos:
//n --> n/2 (si n es par)
//n --> 3*n+1 (si n es impar)

//Usando la regla anterior, y empezando por ejemplo en 13, se genera la siguiente secuencia:
//13, 40, 20, 10, 5, 16, 8, 4, 2, 1
//Puede verse que esta secuencia (comenzando en 13 y finalizando en 1) contiene 10 términos. Se sabe que las secuencias para todos los números terminan en "1". 
//La pregunta a responder es: ¿Cuál número inicial, por debajo de 1.000.000 (un millón) produce la cadena más con mayor cantidad de términos?
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