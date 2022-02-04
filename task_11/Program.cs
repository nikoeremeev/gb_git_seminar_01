// Задача №18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.

bool X1 = false;
bool Y1 = false;

bool X2 = false;
bool Y2 = true;

bool X3 = true;
bool Y3 = false;

bool X4 = true;
bool Y4 = true;

if ( (!(X1 || Y1) == !X1 && !Y1) && (!(X2 || Y2) == !X2 && !Y2) && (!(X3 || Y3) == !X3 && !Y3) && (!(X4 || Y4) == !X4 && !Y4))
{
    Console.WriteLine("Истинно.");
}
else
{
    Console.WriteLine("Ложно.");
}