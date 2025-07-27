using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public static class BmiCalculator 
    {
        public static Bmi CalcBmi(float weightInPounds, float heightInInches)
        {

            //BMI standard formula BMI=weightX703/height to the second power

            float bmi = (weightInPounds * 703) / (heightInInches * heightInInches);
            WeightCategory weightCategoryResult = new WeightCategory();

            if (bmi < 18.5f)
                weightCategoryResult = WeightCategory.UNDERWEIGHT;
            else if (bmi < 25f)
                weightCategoryResult = WeightCategory.NORMAL;
            else if (bmi < 30f)
                weightCategoryResult = WeightCategory.OVERWEIGHT;
            else
                weightCategoryResult = WeightCategory.OBESE;

            Bmi result = new Bmi(weightInPounds, heightInInches, bmi, weightCategoryResult);
            return result;
        }
    }
}
