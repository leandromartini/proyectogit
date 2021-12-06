//Conocimientos Teoricos
//1.Escribir una función que permita multiplicar dos números y obtener el resultado, pero de esta forma:  multiplicar(a)(b); 
function multiplicar(a){
    function sum(b){
       a =   a*b;
       return sum;
    }
    sum.toString = function(){return a;}
    return sum;
   }
   console.log(multiplicar(5)(5))

//2.	¿Cuál es la diferencia entre “==” e “===”?
   //El operador [==]  comprueba si sus dos operandos son iguales y devuelve un resultado booleano. 
   //El operador ( === ) comprueba si sus dos operandos son de igual tipo y valor y devuelve un resultado booleano.

//3.	¿Cómo se verifica que un número es un entero?
   //Existe varias formas pero comprobando que el resto de la división del numero a analizar entre 1 sea igual a 0 es una solucion.

//4.	¿Cómo se hace posible que el siguiente código funcione?  
   var arr = {       
      values: [1, 2, 3, 4, 5],   
      promedio: function() {  
         var suma = 0 
         arr.values.forEach(Element =>
             suma = suma + Element
         )
         return suma/arr.values.length
      }   
    };
   var avg = arr.promedio();
   console.log(avg);
   
//5.	Explicar que es una función de callback y dar un ejemplo.
   //Una función de callback es una función que se pasa a otra función como un argumento, que luego se invoca dentro de la función externa para completar algún tipo de rutina
   function alta(nombre) {
      alert('Se agrego el usuario ' + nombre);
    }
    
    function NuevoUsuario(callback) {
      var nombre = prompt('Ingrese un nombre');
      callback(nombre);
    }    
    NuevoUsuario(alta);

//6.¿Por qué motivo la siguiente comparación arroja “false” como resultado y a que se debe?
//0.1 + 0.2 == 0.3
//0.1 + 0.2 = 0.30000000000000004 (un patrón que se repite después del punto decimal es indefinido)

//7.	¿Cuál es el resultado del siguiente código, y por qué motivo? Pista: No es el mismo motivo que el anterior.
//123456789101112.00 + 0.01
//