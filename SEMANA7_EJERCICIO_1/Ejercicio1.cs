public class VerificadorBalance
{
    public static bool EstanBalanceados(string formula)
    {
        // Crea una pila para almacenar los caracteres
        Stack<char> pilaSimbolos = new Stack<char>();

        // Recorre cada caracter de la fórmula
        foreach (char c in formula)
        {
            // Si el caracter es un paréntesis de apertura, corchete o llave, agregarlo a la pila
            if (c == '(' || c == '[' || c == '{')
            {
                pilaSimbolos.Push(c);
            }
            // Si el caracter es un paréntesis de cierre, corchete o llave
            else if (c == ')' || c == ']' || c == '}')
            {
                // Si la pila se encuentra vacía, significa que no hay un par correspondiente
                if (pilaSimbolos.Count == 0)
                {
                    return false;
                }

                // Saca el elemento que se encuentre en la cima de la pila
                char top = pilaSimbolos.Pop();

                // Verifica si el caracter corresponde a su par de apertura
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false; // No corresponde a su par, es decir la fórmula no es balanceada
                }
            }
        }

        // Si la pila está vacía, la fórmula está balanceada
        return pilaSimbolos.Count == 0;
    }

    public static void Main(string[] args)
    {
        // Se agrega nuevo ejemplo de fórmula matemática
        string formula = "[5+3*(2+1)] + {4*[(2+3)-(5+5)]}"; 
        // Llama a la función para verificar si la fórmula está balanceada
        bool balanceado = EstanBalanceados(formula);
        // Imprime el resultado
        Console.WriteLine($"Formula balanceada: {balanceado}");
    }
}
