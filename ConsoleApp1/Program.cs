namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1).
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);


            #endregion

            #region Q2Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
            //int[,] shelfcopis = 
            //{
            //{3,5 },
            //{1,4 }
            //       };
            //Console.WriteLine(shelfcopis[1, 0]);
            #endregion
            #region Q3 Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main.
            //PrintWelcomeMessage();


            #endregion



            #region Q4 Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            //string title = "clean code";
            //printBookTitle(title);


            #endregion
            #region Q5 Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            // no thing happend the pages is an int=> value type and the method is taking a copy of the value and adding 50 to it, but not changing the original variable.
            #endregion
            #region Q6 Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // the prices is a reference type so the method will change the original array and the output will be 20.5
            #endregion
            #region Q7
            #endregion
            #region Q8
            #endregion
            #region Q9
            #endregion
            #region Q10
            #endregion
            #region Q11
            #endregion
            #region Q12
            #endregion
            #region Q13
            #endregion
            #region Q14
            #endregion

        }
        #region functions
        //q3
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");


        //q4

        //static void printBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}
        //

        //q5
        //static public int AddBonusPages(int pages) { 

        //    return 50+pages;
        //}
        //q6
        //static public void ApplyDiscount(double[] prices) {
        //    prices[0] -= 5;
        //}












        #endregion
    }
}