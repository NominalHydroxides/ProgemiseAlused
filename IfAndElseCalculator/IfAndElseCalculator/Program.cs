namespace IfAndElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esimene arv.
            Console.WriteLine("Sisesta esimene arv: ");

            string firstInputNumber = Console.ReadLine();
            float firstInputNumberParsedFormat = float.Parse(firstInputNumber);


            // Tehte operaator (tehtemärk).
            Console.WriteLine("Sisesta tehte operaatori märk: ");

            string mathematicalOperator = Console.ReadLine();


            // Teine arv.
            Console.WriteLine("Sisesta teine arv: ");

            string secondInputNumber = Console.ReadLine();
            float secondInputNumberParsedFormat = float.Parse(secondInputNumber);

            // Teine tehte operaator.
            Console.WriteLine("Sisesta teine operaatori märk: ");

            string secondMathematicalOperator = Console.ReadLine();


            // Kolmas arv.
            Console.WriteLine("Sisesta kolmas arv: ");

            string thirdInputNumber = Console.ReadLine();
            float thirdInputNumberParsedFormat = float.Parse(thirdInputNumber);


            if ((mathematicalOperator == "+" || mathematicalOperator == "-") && 
    (secondMathematicalOperator == "*" || secondMathematicalOperator == "/"))
{   
    float rightSideResult = 0;
    bool hasRightError = false;

    if (secondMathematicalOperator == "*")
    {
        rightSideResult = secondInputNumberParsedFormat * thirdInputNumberParsedFormat;
    }
    else if (secondMathematicalOperator == "/")
    {
        if (thirdInputNumberParsedFormat == 0)
        {
            Console.Clear();
            Console.WriteLine("Tekkis viga tehte töötlemisel: Keelatud matemaatiline operatsioon. Nulliga jagamine ei ole võimalik.");
            hasRightError = true;
        }
        else
        {
            rightSideResult = secondInputNumberParsedFormat / thirdInputNumberParsedFormat;
        }
    }

    if (!hasRightError)
    {
        float finalOutput = 0;
        if (mathematicalOperator == "+")
        {
            finalOutput = firstInputNumberParsedFormat + rightSideResult;
        }
        else if (mathematicalOperator == "-")
        {
            finalOutput = firstInputNumberParsedFormat - rightSideResult;
        }
        
        Console.Clear();
        Console.WriteLine($"Tehte tulemus: {finalOutput}");
    }
}
else
{   
    float intermediateResult = 0;
    bool hasLeftError = false;

    if (mathematicalOperator == "*")
    {
        intermediateResult = firstInputNumberParsedFormat * secondInputNumberParsedFormat;
    }
    else if (mathematicalOperator == "/")
    {
        if (secondInputNumberParsedFormat == 0)
        {
            Console.Clear();
            Console.WriteLine("Tekkis viga tehte töötlemisel: Keelatud matemaatiline operatsioon. Nulliga jagamine ei ole võimalik.");
            hasLeftError = true;
        }
        else
        {
            intermediateResult = firstInputNumberParsedFormat / secondInputNumberParsedFormat;
        }
    }
    else if (mathematicalOperator == "+")
    {
        intermediateResult = firstInputNumberParsedFormat + secondInputNumberParsedFormat;
    }
    else if (mathematicalOperator == "-")
    {
        intermediateResult = firstInputNumberParsedFormat - secondInputNumberParsedFormat;
    }
    else
    {
        Console.WriteLine("Tekkis viga tehte töötlemisel.");
        hasLeftError = true;
    }

    if (!hasLeftError)
    {
        float finalOutput = 0;
        bool hasFinalError = false;

        if (secondMathematicalOperator == "*")
        {
            finalOutput = intermediateResult * thirdInputNumberParsedFormat;
        }
        else if (secondMathematicalOperator == "/")
        {
            if (thirdInputNumberParsedFormat == 0)
            {
                Console.Clear();
                Console.WriteLine("Tekkis viga tehte töötlemisel: Keelatud matemaatiline operatsioon. Nulliga jagamine ei ole võimalik.");
                hasFinalError = true;
            }
            else
            {
                finalOutput = intermediateResult / thirdInputNumberParsedFormat;
            }
        }
        else if (secondMathematicalOperator == "+")
        {
            finalOutput = intermediateResult + thirdInputNumberParsedFormat;
        }
        else if (secondMathematicalOperator == "-")
        {
            finalOutput = intermediateResult - thirdInputNumberParsedFormat;
        }
        else
        {
            Console.WriteLine("Tekkis viga tehte töötlemisel teise operaatoriga.");
            hasFinalError = true;
        }

        if (!hasFinalError)
        {
            Console.Clear();
            Console.WriteLine($"Tehte tulemus: {finalOutput}");
        }
    }
}
        }
    }
}
