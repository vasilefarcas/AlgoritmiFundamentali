using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_2022
{
    internal class OrderedQueue
    {
        #region Fields
        int[] vector;
        int size;
        #endregion

        #region Constructors
        public OrderedQueue()
        {
            vector = new int[0];
        }
        #endregion

        #region Methods
        public void Push(int valoare_noua)
        {
            if (this.size == 0)
                this.vector = EmptyAdd(valoare_noua);
            else
            if (valoare_noua < this.vector[0])
                this.vector = AddBeggin(valoare_noua);
            else
                if (valoare_noua > this.vector[size - 1])
                this.vector = AddEnd(valoare_noua);
            else
                this.vector = AddMid(valoare_noua);
            size++;
        }
        public int Pop()
        {
            int[] new_vector = new int[size - 1];
            for (int i = 0; i < size - 1; i++)
                new_vector[i] = this.vector[i];
            this.size--;
            return this.vector[size];
        }
        public void view()
        {
            foreach (int item in vector)
            {
                Console.WriteLine(item + " ");
            }
        }
        private int[] EmptyAdd(int valoare_noua)
        {
            int[] new_vector = new int[1];
            new_vector[0] = valoare_noua;
            return new_vector;
        }
        private int[] AddBeggin(int valoare_noua)
        {
            int[] new_vector = new int[size + 1];
            new_vector[0] = valoare_noua;
            for (int i = 0; i < size; i++)
                new_vector[i + 1] = this.vector[i];
            return new_vector;
        }

        private int[] AddMid(int valoare_noua)
        {
            int[] new_vector = new int[size + 1];
            int i = 0;
            while (valoare_noua > this.vector[i])
            {
                new_vector[i] = this.vector[i];
                i++;
            }
            new_vector[i] = valoare_noua;
            for (; i < size; i++)
            {
                new_vector[i + 1] = this.vector[i];
            }
            return new_vector;
        }
        private int[] AddEnd(int valoare_noua)
        {
            int[] new_vector = new int[size + 1];
            for (int i = 0; i < size; i++)
                new_vector[i] = this.vector[i];
            new_vector[size] = valoare_noua;
            return new_vector;
        }
        #endregion
    }
}
