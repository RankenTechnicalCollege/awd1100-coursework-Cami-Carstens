using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Bmi
    {
        private float _weightInPounds;
        private float _heightInInches;
        private float _bmi;
        private WeightCategory _weightCategory;

        public Bmi(float weightInPounds, float heightInInches, float bmi, WeightCategory weightCategory)
        {
            _weightInPounds = weightInPounds;
            _heightInInches = heightInInches;
            _bmi = bmi;
            _weightCategory = weightCategory;

        }
        public float WeightInPounds
        {
            get { return _weightInPounds; }
        }
        public float HeightInInches
        {
            get { return _heightInInches; }
        }

        //getting errors bc property cant have the same name as the class. 
        //going to name property BmiValue
        public float BmiValue
        {
            get { return _bmi; }
        }
        public WeightCategory WeightCategory
        {
            get { return _weightCategory; }
}
    }
}
