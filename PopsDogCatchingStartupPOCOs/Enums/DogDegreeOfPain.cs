using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopsDogCatchingStartupPOCOs.Enums
{
    //Note: this is not a class but an enum -> this type returns numeric values that represent something
    //Ex: 
    /*
     * public enum MovieGenre
     * {
     *   Horror =0,
     *   Suspense,
     *   Drama
     * }
     * 
     * the numeric value 0 = Horror
     * the numeric value 1 = Suspense
     */
    public enum DogDegreeOfPain
    {
        
        LightPain =1,
        MediumPain,
        HarshPain
    }
}
