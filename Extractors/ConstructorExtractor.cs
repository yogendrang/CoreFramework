using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using CoreFramework.Models;

namespace CoreFramework.Extractors
{
    class ConstructorExtractor : iExtractor
    {
        public ComplexTypeModel extract(ComplexTypeModel compTypeAtHand, Type classAtHand)
        {
            ConstructorModel constructorAtHand = new ConstructorModel(classAtHand.Name);
            constructorAtHand.setNoArgConstructor(true);
            ConstructorInfo constructorInfo = classAtHand.GetConstructor(new Type[] { });
            if (constructorInfo == null)
            {
                //Class doesnt have no-arg constructor,extract other constructors
                constructorAtHand.setNoArgConstructor(false);
                ConstructorInfo[] constructors = classAtHand.GetConstructors();
            }            

            return compTypeAtHand;
        }
    }
}
