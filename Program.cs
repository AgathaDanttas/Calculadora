public class Program {
    public static void Main (String []args){
        
        bool resposta = true;
        do {
              Menu();

            Console.WriteLine(" ");   
            Console.WriteLine("Deseja fazer mais alguma operação? (Digite um número)");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int numero = int.Parse(Console.ReadLine ());
            Console.Clear();
            resposta = numero == 1 ? true : false;

        } while (resposta == true);
      

    }
  
    static void Menu () {
        Console.WriteLine(" -----------------------------------------");
        Console.WriteLine("|           1 - Soma                      |");
        Console.WriteLine("|           2 - Subtração                 |");
        Console.WriteLine("|           3 - Divisão                   |");
        Console.WriteLine("|           4 - Multiplicação             |");
        Console.WriteLine("|           0 - Sair                      |");
        Console.WriteLine(" -----------------------------------------");
        Console.WriteLine("Selecione a Opção:");
       
        short resultado = short.Parse(Console.ReadLine());

        switch (resultado){
             case 1:
                Soma();
                
             break;

             case 2:
                Subtracao();
             break;

             case 3:
                Divisao();
             break;

             case 4:
                Multiplicacao();
             break;

             case 0:
                //para sair da aplicação
                System.Environment.Exit(0);
             break;
        }
    }
    

    static void Soma (){
        Console.WriteLine ("Informe um número:");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine ("Informe um número:");
        int Numero2 = int.Parse(Console.ReadLine());

        int Resultado = Numero1 + Numero2;
        Console.Clear();

        Console.WriteLine ($"Resultado : {Resultado}");

    }

    static void Subtracao (){
        Console.WriteLine ("Informe um número:");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine ("Informe um número:");
        int Numero2 = int.Parse(Console.ReadLine());
         Console.Clear();
        
        int Resultado = Numero1 - Numero2;

        Console.WriteLine ($"Resultado : {Resultado}");
      
    }

    static void Divisao (){
        Console.WriteLine ("Informe um número:");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine ("Informe um número:");
        int Numero2 = int.Parse(Console.ReadLine());
        Console.Clear();
        int Resultado = Numero1 / Numero2;

        Console.WriteLine ($"Resultado : {Resultado}");

    }

    static void Multiplicacao (){
        Console.WriteLine ("Informe um número:");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine ("Informe um número:");
        int Numero2 = int.Parse(Console.ReadLine());
         Console.Clear();
        int Resultado = Numero1 * Numero2;

        Console.WriteLine ($"Resultado : {Resultado}");
       

    }


}