using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreFramework.Models;

namespace CoreFramework.Builders
{
    class ConstructorBuilder
    {
        public object build(ComplexTypeModel compType)
        {
            object objToBuild = null;
            ConstructorModel constructorModelAtHand = compType.getConstructorModel();
            if (constructorModelAtHand.hasNoArgConstructor())
            {
                Console.WriteLine("Constructor Info " + 
                    constructorModelAtHand.hasNoArgConstructor() + " " + 
                    constructorModelAtHand.getClassOfContructor() +
                    compType.getActualTypeName());
                Type typeToBuild = Type.GetType(compType.getActualTypeName());
                objToBuild = Activator.CreateInstance(compType.getRepresentationalTypeFromAssembly());
            } else {
                //Logic to handle where no no-arg constructors exist
            } 
            return objToBuild;   
        }
    }
}
