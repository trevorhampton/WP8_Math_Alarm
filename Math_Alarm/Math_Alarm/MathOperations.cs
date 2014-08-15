/* The purpose of this class is to make the calling of the math problems available
 * throughout the entirety of the program.This keeps the rest of the app smaller and
 * easier to manage.
 * 
 * 
 * This class is built with 4 different levels of difficulty in mind.  These difficulties
 * go from easy to very hard.  The first two levels start with random values and operators.
 * Hard replaces a value with a the variable x, and asks the user to solve for x.
 * Very hard contains calculus based derivation and integration that can be completed
 * using the power rule.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Alarm
{
    class MathOperations
    {
        Random random = new Random();

        //This method creates and outputs problems with 2 values and 1 operator.
        public String easyProblem()
        {
            int operationNum = random.Next(0, 1), answerNum = 0;
            String operation, problem;

            switch (operationNum)
            {
                case 0:
                    operation = "-";
                    break;
                default:
                    operation = "+";
                    break;
            }

            if (operation.Equals("-"))
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);
                answerNum = firstRand - secondRand;
                problem = firstRand.ToString() + operation + secondRand.ToString();
            }
            else
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);
                answerNum = firstRand - secondRand;
                problem = firstRand.ToString() + operation + secondRand.ToString();
            }

            return answerNum.ToString() + problem;
        }

        //This method creates and outputs problems with 3 values and 2 operations.
        public String normalProblem()
        {
            int operationNum = random.Next(0, 2), answerNum = 0, operationNum2 = random.Next(0, 2);
            String operation, operation2, problem;

            switch (operationNum)
            {
                case 0:
                    operation = "-";
                    break;
                case 1:
                    operation = "*";
                    break;
                default:
                    operation = "+";
                    break;
            }

            switch (operationNum2)
            {
                case 0:
                    operation2 = "-";
                    break;
                case 1:
                    operation2 = "*";
                    break;
                default:
                    operation2 = "+";
                    break;
            }

            if (operation.Equals("-"))
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);
                if (operationNum2.Equals("-"))
                {
                    int thirdRand = random.Next(0, 10);
                    answerNum = firstRand - secondRand - thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
                else if(operationNum2.Equals("*"))
                {
                    int thirdRand = random.Next(0, 10);
                    answerNum = firstRand - secondRand * thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
                else
                {
                    int thirdRand = random.Next(0, 10);
                    answerNum = firstRand - secondRand + thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
            }
            else if (operation.Equals("*"))
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);
                if (operationNum2.Equals("-"))
                {
                    int thirdRand = random.Next(0, 10);
                    answerNum = firstRand * secondRand - thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
                else if(operationNum2.Equals("*"))
                {
                    int thirdRand = random.Next(0, 10);
                    answerNum = firstRand * secondRand * thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
                else
                {
                    int thirdRand = random.Next(0, 10);
                    answerNum = firstRand * secondRand + thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
            }
            else
            {
                int firstRand = random.Next(0, 50), secondRand = random.Next(0, 50);
                if (operationNum2.Equals("-"))
                {
                    int thirdRand = random.Next(0, 50);
                    answerNum = firstRand + secondRand - thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
                else if(operationNum2.Equals("*"))
                {
                    int thirdRand = random.Next(0, 10);
                    answerNum = firstRand + secondRand * thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
                else
                {
                    int thirdRand = random.Next(0, 50);
                    answerNum = firstRand + secondRand + thirdRand;
                    problem = firstRand.ToString() + operation + secondRand.ToString() + operation2 + thirdRand.ToString();
                }
            }

            return answerNum.ToString() + problem;
        }

        //Hard problems contain problems with a single variable X within them.
        //This kind of problem requires the user to solve for that variable.
        public String hardProblem()
        {
            int operationNum = random.Next(0, 3), answerNum = 0;
            String operation, problem;

            switch (operationNum)
            {
                case 0:
                    operation = "-";
                    break;
                case 1:
                    operation = "*";
                    break;
                case 2:
                    operation = "/";
                    break;
                default:
                    operation = "+";
                    break;
            }

            if (operation.Equals("-"))
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);
                answerNum = firstRand + secondRand;
                problem = " = x" + operation + secondRand.ToString();
            }
            else if (operation.Equals("*"))
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);

                while (secondRand % firstRand != 0)
                {
                    firstRand = random.Next(0, 10);
                    secondRand = random.Next(0, 10);
                }

                problem = " = x" + operation + secondRand.ToString();
                answerNum = secondRand / firstRand;
                //This needs to print out the problem so that the user can see it and solve it.
            }
            else if (operation.Equals("/"))
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);
                
                while (firstRand % secondRand != 0)
                {
                    firstRand = random.Next(0, 10);
                    secondRand = random.Next(0, 10);
                }

                problem = " = x" + operation + secondRand.ToString();
                answerNum = firstRand / secondRand;
            }
            else
            {
                int firstRand = random.Next(0, 10), secondRand = random.Next(0, 10);
                answerNum = firstRand - secondRand;
                problem = " = x" + operation + secondRand.ToString();
            }

            return answerNum.ToString() + problem;
        }

        //This method creates a very hard problem, which contains calculus.
        //The two calculus operations are derivation and integration.
        //It creates simple ones that can be down by following the power rule.
        //A string value that contains the answer is output.
        public String veryHardProblem()
        {
            int operationNum = random.Next(0, 1);
            String operation, problem, answerNum;

            switch (operationNum)
            {
                case 0:
                    operation = "S";
                    break;
                default:
                    operation = "d";
                    break;
            }

            if (operation.Equals("S"))
            {
                int randExponent = random.Next(0, 10);
                int newExponent = randExponent ++, divisor = randExponent;
                problem = "S of x^" + randExponent;
                answerNum = "1/" + divisor + "x^" + newExponent;
                return answerNum + problem;
            }

            else
            {
                int randExponent = random.Next(0, 10);
                int newExponent = randExponent--, coefficient = randExponent;
                problem = "d of x^" + randExponent;
                answerNum = coefficient + "x^" + newExponent;
                return answerNum + problem;
            }
        }
    }
}
