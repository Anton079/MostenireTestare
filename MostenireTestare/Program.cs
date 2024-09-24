using MostenireTestare.AbstarctizareExemplu;
using MostenireTestare.InterfeteExemplu;

internal class Program
{
    private static void Main(string[] args)
    {
        //ServicePerson person = new ServicePerson();

        //person.CheckWhosPresent();

        Punct x = new Punct(3, 2);

        x.Afisare();

        
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
