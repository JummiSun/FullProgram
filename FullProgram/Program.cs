
internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();
        program.mainMenu();
    }
    void task1()
    {
        int sum = 0;
        double averageNumber;
        int count = 0;
        bool negativeNumber = false;

        int[] numbers = { 3, 4, -5, 9, 5 };
        Console.Write("The input array is:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        if (numbers[0] < 0)
        {
            Console.WriteLine();
            Console.Write("There is no positive element before first negative element in the array!");

        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeNumber = true;
                    break;
                }
                sum += numbers[i];
                count++;

            }

            if (negativeNumber)
            {
                averageNumber = (double)sum / count;
                Console.WriteLine();
                Console.Write("The sum of numbers before first negative element is: " + sum);
                Console.WriteLine();
                Console.Write("The average number for first negative elements is: " + averageNumber);
                Console.WriteLine();
                Console.WriteLine("The amount of numbers before first negative number is: " + count);
                Console.WriteLine("The negative number is: " + negativeNumber);
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("There is no negative number in the array");
            }

        }
    }

    void task2()
    {

        int[] array = { 3, 5, 1, 2, 0, 9 };
        int maxNum = array[0];
        int minNum = array[0];
        int maxIndex = 0;
        int minIndex = 0;
        bool duplicateMax = false;
        bool duplicateMin = false;

        Console.Write("The input array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            if (array[i] > maxNum)
            {
                maxNum = array[i];
                maxIndex = i;

            }
            if (array[i] < minNum)
            {
                minNum = array[i];
                minIndex = i;
            }

            if (i != maxIndex && array[i] == maxNum)
            {
                duplicateMax = true;
            }
            if (i != minIndex && array[i] == minNum)
            {
                duplicateMin = true;
            }
        }
        Console.WriteLine();

        if (maxIndex == 0 || minIndex == 0)
        {
            Console.WriteLine();
            Console.Write("Can't delete, max or min element is at the beginning of the array!");


        }
        else if (duplicateMax || duplicateMin)
        {
            Console.WriteLine();
            Console.Write("Can't delete, there are duplicates of max or min elements in the array!");

        }
        else
        {
            int deletedBeforeMax = array[maxIndex - 1];
            int deletedBeforeMin = array[minIndex - 1];

            for (int i = maxIndex - 1; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            for (int i = minIndex - 1; i < array.Length - 2; i++)
            {
                array[i] = array[i + 1];
            }
            Console.WriteLine();
            Console.Write("The array after deleting an element before max and an element before min element is:");
            for (int i = 0; i < array.Length - 2; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The max index is: " + maxIndex);
            Console.WriteLine("The min index is: " + minIndex);
            Console.WriteLine("The min element is: " + minNum);
            Console.WriteLine("The max element is: " + maxNum);
            Console.WriteLine("The deleted element before max number is: " + deletedBeforeMax);
            Console.WriteLine("The deleted element before min number is: " + deletedBeforeMin);
        }
    }

    void task3()
    {
        int?[] array = { 5, -1, -6, -5, 1, -2, null, null, null };
        Console.Write("The input array is: ");
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.Write("Enter the number to replace: ");
        int replaceElement = int.Parse(Console.ReadLine());

        int lastPositiveIndex = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                lastPositiveIndex = i;
                break;
            }
        }
        if (lastPositiveIndex == -1)
        {
            Console.WriteLine("There is no positive element in the array!");
        }
        else
        {
            for (var i = array.Length - 4; i > 1; i--)
            {
                if (i < lastPositiveIndex)
                {
                    break;
                }

                if (lastPositiveIndex == i)
                {
                    array[lastPositiveIndex] = replaceElement;
                    array[i + 1] = replaceElement;
                    array[i + 2] = replaceElement;

                    break;
                }

                array[i + 3] = array[i];

            }


            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The number that put to replace is: " + replaceElement);
            Console.WriteLine("The last positive number's index is: " + lastPositiveIndex);

        }
    }

    void task4()
    {

        int[] array = { 9, 8, 4, 0 };
        Console.Write("The input array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        bool descend = true;
        if (array.Length < 2)
        {
            Console.WriteLine("The array has less than 2 elements!");
        }
        else
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1]) //current element with next element
                {
                    descend = false;
                    break; //not order in descend
                }
            }
            if (descend)
            {
                Console.WriteLine("The array is in descending order!");
            }
            else
            {
                Console.WriteLine("The array is not in descending order!");
            }
        }

    }

    void mainMenu()
    {
        while (true)
        {
            Console.Write("\n----Options----\n1) Task1(average number)\n2) Task2(deleting element)\n3) Task3(replaceable element)\n4) Task4(in descend)\n5) Log out \nChoose:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    Console.WriteLine("You logged out of the program!");
                    return;
                default:
                    Console.WriteLine("Choose the correct number!");
                    break;


            }
        }
    }
}