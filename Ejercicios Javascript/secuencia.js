function secuencia (n){
    console.log(n)
    for (let i = 0; i < n; i++) {
        if (n % 2) {
            n = 3*n+1; 
            }else{
            n = n/2;
            }
         console.log(n)
        }        
    }
secuencia(13)