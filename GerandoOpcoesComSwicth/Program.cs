internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("\n\n\n====================================================================================================================================================================================================|");
        Console.Write("\n\nBem-vindo ao frase sortida!\n\n");

        Console.Write("\nQual seu nome: ");
        var nome = Console.ReadLine();

        Console.Write("\n\nDigite uma opção de 1 a 15 " + nome + " :  ");
        var opcoes = Console.ReadLine();

        switch(opcoes)
        {
            case  "1":
            Console.WriteLine("\n\nHabilidade e confiança são um exército invicto.\n\n");
            break;

            case  "2":
            Console.WriteLine("\n\nSuba o primeiro degrau com fé. Não é necessário que você veja toda a escada. Apenas dê o primeiro passo.\n\n");
            break;

            case  "3":
            Console.WriteLine("\n\nO segredo da vida não é ter tudo que você quer, mas amar tudo que você tem.\n\n");
            break;

            case  "4":
            Console.WriteLine("\n\nA sabedoria de um homem não está em não errar, chorar, se angustiar e se fragilizar, mas em usar seu sofrimento como alicerce de sua maturidade.\n\n");
            break;

            case  "5":
            Console.WriteLine("\n\nQuando se sentir triste, para baixo, como se não fosse merecedor das coisas boas que acontecem com você, lembre-se da sua história e de tudo que passou para chegar até aqui.\n\n");
            break;

            case  "6":
            Console.WriteLine("\n\nSó existem dois dias no ano que nada pode ser feito. Um se chama ontem e o outro se chama amanhã, portanto, hoje é o dia certo para amar, acreditar, fazer e principalmente viver.\n\n");
            break;

            case  "7":
            Console.WriteLine("\n\nSe você está andando no caminho certo e está disposto a continuar caminhando, eventualmente, você vai progredir.\n\n");
            break;

            case  "8":
            Console.WriteLine("\n\nAcredite em si próprio e chegará um dia em que os outros não terão outra escolha senão acreditar com você.\n\n");
            break;

            case  "9":
            Console.WriteLine("\n\nMesmo que você não sinta de verdade, afirme a si mesmo que você é digno de todas as coisas boas do universo. Com o tempo, essas palavras farão sentido para você.\n\n");
            break;

            case  "10":
            Console.WriteLine("\n\nA autoconfiança é um superpoder. Quando você começa a acreditar em si mesmo, a magia começa a acontecer.\n\n");
            break;

            case  "11":
            Console.WriteLine("\n\nO otimismo é a fé que nos leva à realização. Nada pode ser feito sem esperança e confiança.\n\n");
            break;

            case  "12":
            Console.WriteLine("\n\nNão se deixe abalar pelas pequenas derrotas ou palavras do dia a dia que machucam. Tenha a certeza de que seu valor é imenso e ninguém pode te dizer o contrário.\n\n");
            break;

            case  "13":
            Console.WriteLine("\n\nSe podemos sonhar, também podemos tornar nossos sonhos realidade.\n\n");
            break;

            case  "14":
            Console.WriteLine("\n\nAcredite em si próprio e chegará um dia em que os outros não terão outra escolha senão acreditar com você.\n\n");
            break;

            case  "15":
            Console.WriteLine("\n\nVocê pode não ser bom o suficiente para todo mundo, mas com certeza vai ser perfeito para alguém.\n\n");
            break;

            default:
            Console.WriteLine("\n\nOpção Invalida.\n\n");
            break;
        }
        Console.Write("===================================================================================================================================================================================================|\n\n\n");
    }
}