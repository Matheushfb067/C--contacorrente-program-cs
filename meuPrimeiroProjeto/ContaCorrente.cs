public class ContaCorrente
{
            public string Titular;
            public  int Agencia;
            public int Numero;
            public double Saldo;  

            public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo) {
                this.Titular = Titular;
                this.Agencia = Agencia;
                this.Numero = Numero;
                this.Saldo = Saldo; 

                //O comando this referencia um objeto, especifica qual objeto se quer pegar em determinado momento. 
            }      
}


// CLasse seria a "forma" do bolo.

// C# oferece a possibilidade de termos classes públicas e privadas.
    //Classes Públicas (public class): 
    //Classes Privadas (private class): 