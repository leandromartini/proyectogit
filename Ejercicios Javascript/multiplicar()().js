function multiplicar(a){
    function sum(b){
       a =   a+b;
       return sum;
    }
    sum.toString = function(){return a;}
    return sum;
   }

   console.log(multiplicar(5)(5)(100))