using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopsDogCatchingStartupPOCOs.Dogs
{
    public class Dog
    {
        //We need PROPERTIES:

        //dog name -> named DogName

        //dog Owner(this is another Class (object) type *DogOwner* -> named DogOwner

       //dog age -> named DogAge
        
        //dog date of birth -> name DogDateOfBirth
        
        //dog Breed -> public DogBreed DogBreedType {get; set;}
        
        //dog degree of pain -> DogDegreeOfPain

        //dog capture date -> named CaptureDate

        //Has Collar Identification -> named HasCollarIdentification

        //Is Injured -> named isInjured

        //We need Two CONSTRUCTORS , a constructor thats empty
        //This is the first CONSTRUCTOR we need:
        public Dog()
        {

        }

        //And we need a CONSTRUCTOR that takes in the dogName, dogBreedType, dogDateOfBirth, hasCollarIdentification, isInjured, dogCapturedDate




        //Now we need ACTIONS(methods) that this Dog can perform *MEHTODs* ALL OF THESE METHODS BELOW WILL BE PUBLIC

        //The first thing we want the dog to do is Bark, so we need to create a Bark method

        /*accessor   return type  Method Name   Parameters       Method signature
         * public      void          Bark          ()         ->     Bark()        
        */
        public void Bark()
        {
            //Make the console print out 'Ruff, Ruff!'
        }

        //The second action we want to preform is to make the console print all of the needed DogCredentials -> the method name will be DogCredentials


        //The third action is to make the console print out how much pain the dog is in if it is injured -> the method name will be DisplayDogsPainLevel
        //inside of this method use a swich statement to 
        //switch(DogsDegreeOfPain)
        /*{
         * case DogDegreeOfPain.LightPain:
           Console.Writeline($"{DogName}, is only experiencing acute signs of pain");
           break;
           case DogDegreeOfPain.MediumPain:
           Console.Writeline($"{DogName}, is only experiencing Medium signs of pain");
           break;
            Console.Writeline($"{DogName}, is only experiencing extreme signs of pain");
           break;
           }
        */


        //The fourth action is to make the console print out if the dog has found a new home -> the method name will be DogHasFoundAHome


        //The fifth action is to make the console print out if the dog has died -> the method name will be DogHasPassedAway



        //The final action is to make the console print out the dogs age as an 'int' -> this method will have a return type of 'int' and the method name will be CalculateDogAge() (use DateTime)
        // but the trick is to subtract the DateTime year by the DateTime now year (remember to return this as an int)


    }
}
