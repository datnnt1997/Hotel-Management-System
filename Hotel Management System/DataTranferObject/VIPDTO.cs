using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranferObject
{
    public class VIPDTO
    {
        private int level;
        private int value;
        private float condition;

        public VIPDTO(int level, int value, float condition)
        {
            this.level = level;
            this.value = value;
            this.condition = condition;
        }

        public int Level { get => level; set => level = value; }
        public int Value { get => value; set => this.value = value; }
        public float Condition { get => condition; set => condition = value; }
    }
}
