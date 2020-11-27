using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopsDogCatchingStartup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Only use this after you have populated the DogOwner Class, the Dog Class, and the DogBreed/DogDegreeOfPain enums.

            //I want you to create a Dog called rover.(HINT: USE THE NEW KEY WORD)

            //The Dog type will not show b/c you need to reference the PopsDogCatchingStartupPOCOs class library the way you do this is with (control + .) and select using...

            //Access rovers properties :
          
            
            //the first property to access and assign value to is rovers name -> rover.DogName ="".

          
            
            // the second property to access and assign value to is rovers date of birth -> rover.DogDateOfBirth=

           
            
            //the third property to access and assign value to is rovers age -> you need to use  rover.DogAge = rover.CalculateDogAge()  -> this method returns an int value and stores it inside of rover.DogAge

           
            
            //the fourth property to access and assign value to is rovers owners name -> you will need to  instantiate a new DogOwner and use the second constructor to input the owners first and last name

           
            
            //the fifth property to access and assign value to if rover can be identified by his collar -> rover.HasCollarIdentification= 

          
            
            //the sixth property to access and assign value to if rover is injured -> rover.Isinjured=

          
           
            //the seventh property to access and assign value to rovers breed type (use enum) ->rover.DogBreed.(intellesence should display the different types of dog breed w/n the enum to select)

            
            
            //Finally get the console to display rovers inoformation by calling rover.DogCredentials()

            Console.WriteLine("\n************************************USING A CONSTRUCTOR******************************************************\n");

            //create a Dog called spencer
            //inside of its method parameters inside of the parenthesis put a string value for the dogName,
            //a DogBreed,
            //a date of birth,
            //if dog has collar identification,
            //if dog is injured,
            //date when dog was captured

            /*
             * example:
             *                     dogName     dogBreed        dogDateOfBirth      hasCollarIdentification  isInjured  dogCaptureDate
             * Dog sasha = new Dog("Sasha", DogBreed.Husky,  new DateTime(2002,4,12),     false       ,      true ,     DateTime.Now); 
             */



            //give spencer a new DogOwner -> 

            //                                             this references DogOwner but its using its 2nd constructor
            //                                                                  firstName, lastname
            //spencer.DogOwner = new DogOwner("Grace",   "Givens"); 

           
            
            //access spencers DogCredentials -> spencer.DogCredentials(this should only work if hasCollarIdentification is TRUE

           
            
            //access spencers DogDegreeOfPain -> spencer.DogDegreeOfPain.(this is enum so intellesence should display values to select)

          
            
            //get the console to give information about spencers level of pain -> spencer.DisplayDogsPainLevel();


           
            
            
            /* IF YOU NEED ANY HELP PLEASE SLACK ME AND I WILL ASSIST YOU
               IF YOU COMPLETE THIS THEN TRY TO DO THIS WITHOUT THE COMMENTS
               -AFTERWARDS (WHEN YOU HAVE THE TIME) 
               -MAKE A NEW VS SOLUTION
               -ADD A CLASS LIBRARY
               -AND MAKE YOUR OWN POCOs 
               -RT CLICK YOUR SOLUTION [AT THE TOP ITS LABLED SOLUTION]
               -ADD CONSOLE APPLICATION (.NET FRAMEWORK)
               - MAKE INSTANCES OF THE POCOs (DONT PANIC YOU MAY HAVE TO REFERENCE THE C# CLASS LIBRARY THAT HOLDS THE POCOs) to get the need using statements
               -TRY to access and assign values to your C# objects
               -THEN TRY TO RUN METHODS THAT YOUR POCOs contain 
               -RUN THE APP AND MAKE SURE THERE ARE NO ERRORS
             
             */
        }
    }
}
