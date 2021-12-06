//Escribir un programa tal que, dada la matriz de la imagen y dos números que indican filas y 
//columnas como parámetro, se arme una sub-matriz y se muestre el contenido recorriendo sus 
//celdas en el sentido de las agujas del reloj, desde el exterior hacia el centro, comenzando por la celda [0,0].
//La matriz dada puede ser considerada constante y no -es parte del problema la generación de números primos. La submatriz deberá contener los valores correspondientes a la matriz dada.

filaColumna = "4,5" //Ingresar valor fila columna en el formato [F,C]
items = [[2, 3, 5, 7, 11, 13],
[47, 53, 59, 61, 67, 71],
[109, 113, 127, 131, 137, 139],
[191, 193, 197, 199, 211, 293]];
var parts = filaColumna.split(',');
function esSub(fil, col) {
    return (fil <= items.length) && (col <= items[0].length)
}
function filasElement(element,index) {
    if (index  > parts[0]) { return }
    console.log(element)
}
function indexElement(element,index,arr) {
    if (index + 1 > parts[0]) { return }
    arr[index].forEach(filasElement)    
}
if (esSub(parts[0], parts[1])) {
    items.forEach(indexElement)
};

