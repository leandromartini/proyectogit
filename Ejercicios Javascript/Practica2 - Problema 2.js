//Dada una hora en formato “HH:mm”, donde “HH” es un número entero de 0 a 11, y “mm” es un número entero de 0 a 59,
// obtener los valores para los ángulos de la aguja de las horas y minutos. 
//Debe considerarse el ángulo con respecto a la vertical del cuadrante del reloj, como se indica en la imagen:
//Se espera como resultado de la llamada al programa / método / función los valores para las variables alfa (horas) y beta (minutos).

tiempo = "04:45";
horas = 12
minutos = 60
grados = 360
function calcularGrados(horaMin){
    var parts = horaMin.split(':');
    console.log("El valor para α es: " + gradosHora(parts[0]) +"° y el valor para β es: "+ gradosMin(parts[1]) + "°")
}
function gradosMin(min){
    gradMin = grados/minutos
    return min * gradMin;
}
function gradosHora(hora) {
    gradHor = grados/horas
    return hora * gradHor
}

calcularGrados(tiempo);