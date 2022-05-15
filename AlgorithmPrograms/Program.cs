using AlgorithmPrograms;
class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Algorithm Programs");
        bool end = true;
        Console.WriteLine("1.BinarySearch\n2.BubbleSort\n3.CheckAnagramOrNot\n4.InsertionSort\n5.PrimeNumber\n6.PrimePalindromeAnagram\n7.GuessNumber\n8.MergeSort\n9.End the Program");
        while (end == true)
        {
            Console.WriteLine("\nTake an option to execute ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    const string FILE_PATH = @"E:\VisualPractise\AlgorithmPrograms\AlgorithmPrograms\Data.txt";
                    BinarySearch search = new BinarySearch();
                    string input_String = File.ReadAllText(FILE_PATH);
                    string[] array = input_String.Split(' ');
                    int length = array.Length;
                    Console.WriteLine("Enter the word to Search");
                    string key = Console.ReadLine();
                    int result =search.Binary(array, 0, length - 1, key);
                    if (result == -1)
                    {
                        Console.WriteLine(key + " word is present in the file");
                    }
                    else
                    {
                        Console.WriteLine(key + " Word is  not present ");
                    }
                    break;
                case 2:
                    BubbleSort sort= new BubbleSort();
                    sort.Bubble();
                    break;
                case 3:
                    Anagram anagram = new Anagram();
                    anagram.AnagramOrNot();
                    break;
                case 4:
                    InsertionSort insertionsort= new InsertionSort();
                    insertionsort.Insertion();
                    break;
                case 5:
                    PrimeNumber number= new PrimeNumber();
                    number.PrimeNumberWithinRange();
                    break;
                case 6:
                    PrimePalindrome primePalindrome=new PrimePalindrome();
                    primePalindrome.PrimePalindromNumber();
                    break;
                case 7:
                    GuessGame game = new GuessGame();
                    Console.WriteLine("Guess a number between 0 to 127");
                    Console.WriteLine("Guessed no is :" + game.Find());
                    break;
                case 8:
                    MergeSort mergesort = new MergeSort();
                    int[] arr2 = { 12, 11, 13, 5, 6, 7 };
                    Console.WriteLine("Given Array");
                    mergesort.printArray(arr2);
                    mergesort.Sorting(arr2, 0, arr2.Length - 1);
                    Console.WriteLine("\nSorted array");
                    mergesort.printArray(arr2);
                    break;
                case 9:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}