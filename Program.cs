using System;

namespace FactoryMethodPattern
{
    /*
    This real-world code demonstrates the Factory method offering flexibility in creating different documents. 
    The derived Document classes Report and Resume instantiate extended versions of the Document class. 
    Here, the Factory Method is called in the constructor of the Document base class.
    
    This structural code demonstrates the Factory method offering great flexibility in creating different objects. 
    The Abstract class may provide a default object, but each subclass can instantiate an extended version of the object.
    */

    /// <summary>
    /// Program startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // An array of creators -- Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}