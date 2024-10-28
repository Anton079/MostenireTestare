using MostenireTestare.AbstarctizareExemplu;
using MostenireTestare.InterfeteExemplu;

internal class Program
{
    private static void Main(string[] args)
    {

        //Punct x1 = new Punct(3, 2);
        //Punct x2 = new Punct(3, 2);

        //Punct p1 = new Punct(3, 2);
        //Punct p2 = new Punct(3, 2);

        //if (x1.Equals(x2))
        //{
        //    Console.WriteLine("Sunt egale!");
        //}
        //else
        //{
        //    Console.WriteLine("Nu sunt egale!");
        //}

        //x1.Afisare();





        //Linie line1 = new Linie(x1,x2);

        //if (line1.Equals(new Linie(p1, p2)))
        //{
        //    Console.WriteLine("Sunt egale!");
        //}
        //else
        //{
        //    Console.WriteLine("Nu sunt egale!");
        //}

        //line1.Afisare();





        //Cerc cerc1 = new Cerc(x1, 2);

        //if(cerc1.Equals(new Cerc(p1, 2)))
        //{
        //    Console.WriteLine("Sunt egale!");
        //}
        //else
        //{
        //    Console.WriteLine("Nu sunt egale!");
        //}





        //Dreptunghi dreptunghi1 = new Dreptunghi(x1, x2);

        //if (dreptunghi1.Equals(new Dreptunghi(p1, p2)))
        //{
        //    Console.WriteLine("Sunt egale!");
        //}
        //else
        //{
        //    Console.WriteLine("Nu sunt egale!");
        //}

        //dreptunghi.Afisare();







        Punct p1 = new Punct(3, 2);
        Punct p2 = new Punct(4, 6);

        Linie line = new Linie(p1, p2);

        Cerc cerc = new Cerc(p1, 2);

        Dreptunghi dreptunghi = new Dreptunghi(p1, p2);




        Desen desen = new Desen();


        desen.AdaugaFiguri(dreptunghi);

        desen.Afisare();








    }
}

//==================================Cuvantul cheie abstract=============
//Implicatii
//->intro clasa abstarcta putem avea atat metode concrete cat si metode abststract
//->o clasa abstracta nu poate fi instantiata 
//->orice clasa ce mosteneste o classa abstracta  este obligata sa suprascrie  metodele abstracte
//============================INTERFETE==================================================
//Implicatii
//daca intro clasa abstracta decidem ca nu avem noie de nimi cocncret cream o interfata


//interface ITest{


//adaugam doar metode abstracte  

//void test() // by default este public abstract 

//}

//o interafat nu poate fi instantiata 

// o clasa poate implementa mai multe interfete

//orice clasa ce extinde o interfata este obligata sa implementeze metodele din interfata


//Orice clasa din c# mosteneste by default clasa Object 
//-> ce are 2 metode virtuale importante -->EQUALS  --> TOSTRING
