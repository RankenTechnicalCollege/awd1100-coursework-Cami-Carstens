using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class TestStatistics : TestScoresForm
    {
        
        private int _count;
        private float _sum;
        private float _avg;
        private float _min;
        private float _max;
        

        public TestStatistics()
        {
            _count = 0;
            _sum = 0;
            _min = 100;
            _max = 0;
        }
        public void AddScore(float score)
        {
            if(score < 0 || score > 100)
            {
                throw new ArgumentException("Score must be between 0 and 100.");
            }
            _count++;
            _sum = _sum + score;
            
            if(score < _min)
            {
                _min = score;
            }
            if(score > _max)
            {
                _max = score;
            }
            


        }
        public int Count
        {
            get { return _count; }
        }
        public float Sum
        {
            get { return _sum; }
        }
        public float Average
        {
            get
            {
                if (_count > 0)
                {
                    return _sum / _count;
                }
                else
                {
                    return 0; // Avoid error from division by zero
                }
            }

        }
        public float Min
        {
            get
            {
                if (_count > 0)
                {
                    return _min;
                }
                else
                {
                    return 0;
                }
            }
        }
 
        
        public float Max
        {
            get
            {
                if (_count > 0)
                {
                    return _max;
                }
                else
                {
                    return 0;
                }
            }
        }

        public override string ToString()
        {
            return $"Number of scores: {_count}\nSum of test scores: {_sum}\nAverage test score: {Average:F2}\nLowest test score: {_min}\nHighest test score: {_max}";
        }

    }
}
