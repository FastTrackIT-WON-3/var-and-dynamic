namespace VarAndDynamic
{
    public class CollectionOfIntegers
    {
        private readonly int[] array;

        public CollectionOfIntegers(params int[] elements)
        {
            array = elements ?? new int[0];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }

                return int.MinValue;
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int elem in array)
            {
                sum += elem;
            }

            return sum;
        }
    }
}
