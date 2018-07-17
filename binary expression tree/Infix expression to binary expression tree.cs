using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infixExpressionToBinaryExpressionTree
{
    class Program
    {
        internal class Node{
            public char Operand {get; set;} // operator sometimes;
            public Node Left;
            public Node Right;

            public Node(char val)
            {
                Operand = val;
            }
        }

        static void Main(string[] args)
        {
            //RunTestcase1();
            RunTestcase2(); 
        }

        public static void RunTestcase1()
        {
            var node = InfixExpressionToBinaryExpressionTree("(1+2)");
            Debug.Assert(node.Operand == '+'); 
        }

        public static void RunTestcase2()
        {
            var node = InfixExpressionToBinaryExpressionTree("((1+2)*(3-4))");
            Debug.Assert(node.Operand.CompareTo("*") == 0); 
        }

        public static string Operators = "+-*/";
        public static string Operands = "0123456789"; // make it simple, one digit only first

        /// <summary>
        /// Time complexity: O(N), space complexity: using stack -> at most O(N)
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Node InfixExpressionToBinaryExpressionTree(string expression)
        {
            if (expression == null || expression.Length == 0)
                return null;

            var stack = new Stack<Object>();             

            for (int i = 0; i < expression.Length; i++)
            {
                var current = expression[i];

                var isCloseBracket = current == ')';

                if (!isCloseBracket)
                {
                    stack.Push(current);
                }
                else
                {
                    if (stack.Count < 4)
                        return null;

                    var operand2 = stack.Pop();
                    var operatorChar = stack.Pop();
                    var operand1 = stack.Pop();
                    var openBracket = (char)stack.Pop();

                    if (openBracket != '('      ||
                        !checkOperand(operand2) ||
                        !checkOperand(operand1) ||
                        !checkOperator(operatorChar)
                       )
                    {
                        return null;
                    }

                    var root   = new Node((char)operatorChar);
                    root.Left  = (operand1.GetType() == typeof(Node)) ? (Node)operand1 : new Node((char)operand1);
                    root.Right = (operand2.GetType() == typeof(Node)) ? (Node)operand2 : new Node((char)operand2);

                    stack.Push(root); 
                }
            }

            if (stack.Count > 1 || stack.Count == 0)
                return null;

            return (Node)stack.Pop();
        }

        /// <summary>
        /// code review July 6, 2018
        /// </summary>
        /// <param name="operand"></param>
        /// <returns></returns>
        private static bool checkOperand(Object operand)
        {
            if (operand.GetType() == typeof(Node))
                return true; 

            var number = (char)operand;
            return Operands.IndexOf(number) != -1; 
        }

        private static bool checkOperator(Object operatorChar)
        {
            var arithmetic = (char)operatorChar;

            return Operators.IndexOf(arithmetic) != -1;
        }
    }
}
