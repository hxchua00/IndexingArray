using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexingArray idx = new IndexingArray();
            try
            {
                

                for (int i = 0; i < 10; i++)
                {
                    idx[i] = i++;
                    Console.WriteLine("Elements in the indexer " + i + " are : " + idx[i]);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Systen Error! Unable to proceed! {0}" + e.Message);
                Console.WriteLine();
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("Array mismatched! Please check your array type! {0}" + e.Message);
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Unable to access out of range! {0}" + e.Message);
                Console.WriteLine();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Unable to find reference object! {0}" + e.Message);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong! {0}" + e.Message);
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.ReadLine();


        }

        class IndexingArray
        {
            private int[] arr = new int[10];
            public int this[int i]
            {
                get
                {
                    return arr[i];
                }
                set
                {
                    arr[i] = value;
                }
            }
        }

        
    }
}
