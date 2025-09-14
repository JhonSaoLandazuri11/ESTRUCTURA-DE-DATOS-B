using System;
using System.Collections.Generic;

namespace Balanceador
{
    public class ExpresionBalanceada
    {
        public static bool EstaBalanceado(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char caracter in expresion)
            {
                if (caracter == '(' || caracter == '[' || caracter == '{')
                {
                    pila.Push(caracter);
                }
                else if (caracter == ')' || caracter == ']' || caracter == '}')
                {
                    if (pila.Count == 0) return false;

                    char tope = pila.Pop();

                    if ((caracter == ')' && tope != '(') ||
                        (caracter == ']' && tope != '[') ||
                        (caracter == '}' && tope != '{'))
                    {
                        return false;
                    }
                }
            }

            return pila.Count == 0;
        }
    }
}
