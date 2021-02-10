using System;

namespace HelloWorldProject {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello World in C#!");
            Console.WriteLine("C# written by Dustin Fox");
            var counter = 0;
            Console.WriteLine(counter);
            counter = counter + 13;
            Console.WriteLine(counter);
            counter = counter - 3;
            Console.WriteLine(counter);
            counter = counter * 5;
            Console.WriteLine(counter);
            counter = counter / 7;
            Console.WriteLine(counter);

            var numerator = 10.0;
            var denominator = 3.0;
            Console.WriteLine(numerator / denominator);

            var modulo = 10 % 3;
            Console.WriteLine(modulo);

            var firstName = "Dustin";
            var lastName = "fox";
            var fullName = firstName + " " + lastName;
            fullName = $"firstName is {firstName}, and lastName is {lastName}";
            Console.WriteLine(fullName);
            // fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            var biggerScopeVariable = 77;
            {
                var scopeVariable = 1;
                Console.WriteLine(scopeVariable);
            }
            biggerScopeVariable = biggerScopeVariable + 1;
            //scopeVariable = scopeVariable + 1;
            // int? nullableInteger = null;
            // int nonnullableInteger = null;

            bool oneEqualsOne = (1 == 1);
            // this would be true becasue 1 is the same as 1
            bool thisIsFalse = !oneEqualsOne;
            // this would mean !oneEqualsOne is not false;

            int[] assessmentScores = new int[2];
            assessmentScores[0] = 120;
            assessmentScores[1] = 95;
            Console.WriteLine($"index 0 is {assessmentScores[0]} and Index 1 is {assessmentScores[1]}");

            var schoolExample = new string [5];
                schoolExample[0] = "git/github";
                schoolExample[1] = "SQL";
                schoolExample[2] = "C#";
                schoolExample[3] = "JavaScript";
                schoolExample[4] = "Angular";

          

        }
    }
}
