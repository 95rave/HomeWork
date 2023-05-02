using CustomBuilder;
using System;

namespace CustomBuilder
{
    public class CustomStringBuilder
    {
        private char[] _arr;
        private int _capacity = 16;
        private int _length = 0;

        public int Length { get; private set; }

        public CustomStringBuilder()
        {
            _arr = new char[16];
        }

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value cannot be less than zero");
                }
                if (value < Length)
                {
                    throw new Exception($"Capacity must be more than {Length}");
                }
                _capacity = value;
                Array.Resize(ref _arr, _capacity);
            }
        }
        //Append
        //public CustomStringBuilder Append(string str)
        //{

        //    if (str == null)
        //    {
        //        return this;
        //    }


        //    int newLength = Length + str.Length;


        //    if (newLength > Capacity)
        //    {
        //        Capacity = Math.Max(newLength, 2 * Capacity);
        //    }

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        _arr[Length + i] = str[i];
        //    }
        //    Length = newLength;
        //    return this;
        //}


        public override string ToString()
        {
            return new string(_arr, 0, Length);
        }

        // Remove
        //public void Remove(int index, int length)
        //{
        //    if (index < 0 || length < 0 || index + length > Length)
        //    {
        //        throw new ArgumentOutOfRangeException("Invalid start index or length");
        //    }

        //    for (int i = index; i < Length - length; i++)
        //    {
        //        _arr[i] = _arr[i + length];
        //    }

        //    Length -= length;
        //}

        //Replace
        public CustomStringBuilder Replace(string arr1, string newarr)
        {
            if (arr1 == null)
            {
                throw new ArgumentNullException(nameof(arr1));
            }

            if (newarr == null)
            {
                throw new ArgumentNullException(nameof(newarr));
            }

            int index = 0;
            while ((index = IndexOf(arr1, index)) != -1)
            {
                Remove(index, arr1.Length);
                Insert(index, newarr);
                index += newarr.Length;
            }

            return this;
        }

        private void Insert(int index, string newarr)
        {
            throw new NotImplementedException();
        }

        private void Remove(int index, int length)
        {
            throw new NotImplementedException();
        }

        private int IndexOf(string arr1, int index)
        {
            throw new NotImplementedException();
        }
    }
}


