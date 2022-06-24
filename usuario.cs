string  opcaoDesejada;

Consola . Limpar ();

Consola . WriteLine (" --- Calculadora 4 operações --- \n ");

Consola . WriteLine (" [+] Soma ");
Consola . WriteLine (" [-] Subtração ");
Consola . WriteLine (" [x] Multiplicação ");
Consola . WriteLine (" [%] Porcentagem ");
Consola . WriteLine (" [*] Esponenciação ");
Consola . WriteLine (" [r] Radiciação ");

Consola . Write ( " \n Selecione a operação desejada: " );

opcaoDesejada  =  Console . LeiaLinha () ! ;

switch ( opcaoDesejada )
{
    caso (" + ") ;
        Codigo . CalcularSoma ();
        quebrar ;
    caso  (" - ") 
        Codigo . CalcularSubtração ();
        quebrar ;
    caso  (" x ") ;
        Codigo . CalcularMultiplicacao ();
        quebrar ;)
    caso  (" / ") ;
        Codigo . CalcularDivisão ();
        quebrar ;
    caso  (" * ") ;
        Codigo . CalcularExponenciação ();
        quebrar ;
    padrão :
        Consola . WriteLine ( " Opção inválida. " );
        quebrar ;
    
}

Consola . WriteLine ( " \n Obrigado por usar nosso programa. " );