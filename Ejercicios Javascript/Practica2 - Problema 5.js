//Dado un tablero de ajedrez, calcular la posición de N reinas, tal que ninguna de ellas amenace a otra. La cantidad de reinas será la misma que la cantidad de filas/columnas del tablero (N reinas en un tablero de NxN cuadros). La verificación se hará con N = 15.
//Escribir un algoritmo que calcule y muestre las soluciones a un tamaño de tablero dado por el número N. La forma de mostrar cada solución deberá ser en notación PGN.
//No pueden usarse los algoritmos conocidos de F. Nauck, S. Günther, J.W.L. Glaisher ó E. Dijkstra. Plantear una alternativa innovadora, no es requisito que sea óptima.

    n = 6;// Número de reinas
    x = new Array(n + 1);//posicion  de la reina
    var mensj;
    function backTrack(t) {
        if (t > n) {
            mensj = "";
            for (let a = 1; a <= n; a++) {
                mensj += "( "+a +" "+ x[a]+")";
            }
            console.log(mensj);
        } else {
            for (let i = 1; i <= n; i++) {
                x[t] = i;// La reina t se coloca en la t/esima fila y la i/esima columna del tablero de ajedrez
                // reviso si la posición de la reina t es correcta o no, luego continúa la búsqueda profunda
                if (place(t)) {
                    backTrack(t + 1);
                }
            }
        }
    }
    // Mira si la posición de la reina k es correcta
    function place(k) {
        for (let j = 1; j < k; j++) {
            if (x[j] == x[k] || Math.abs(j - k) == Math.abs(x[j] - x[k]))
                return false;
        }
        return true;
    }
    backTrack(1);
