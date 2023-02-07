using System.Runtime.CompilerServices;
using System.Security.AccessControl;

int nopeus=0;
int luku;
char kirjain;
bool jatkuu;


Console.WriteLine("Tästä lähtee");
do
{


    
    Console.WriteLine("lisätäänkö vai lasketaanko nopeutta?");
    Console.WriteLine("a/b");
    kirjain=Convert.ToChar(Console.ReadLine());  
    switch (kirjain)
    {
        case 'a':
            NopeudenNosto();
          
            
         break;

        case 'b':
           NopeudenLasku(); 
            break;

        default:
         nopeus = 0; break;
        
       
    }
    do
    {
        if (nopeus>=26)
        
        {
            Console.WriteLine("et saa mennä kovempaa");
            nopeus = 25;
            break;
        }
    } while (nopeus>=26);
    do
    {
        if (nopeus <=-1)

        {
            Console.WriteLine("et voi mennä hiljempaa kuin 0 KM/h");
            nopeus = 0;
            break;
        }
    } while (nopeus <=-1);

    Console.WriteLine("nopeutesi on {0} KM/h",nopeus);
    Console.WriteLine("Jatketaanko? k/e");
    string valinta=Console.ReadLine();
    if (valinta.Contains("k")) 
    {
        jatkuu= true;
    }
    else
    {
        Console.WriteLine("Auto on pysähtynyt.");
        jatkuu= false;
    }

} while (jatkuu) ;


//metodit nostamaan ja laskemaan nopeutta
 int NopeudenNosto()
{
    return nopeus =nopeus+ 5;

}
int NopeudenLasku()
{
    return nopeus = nopeus - 5;

}