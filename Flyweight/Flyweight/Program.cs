using Flyweight;
double x = 0, y = 0;
int i = 0, j = 0;
FlyweightFactory factory = new FlyweightFactory();
while (i < 100)
{
    Board white = factory.GetParticle("White");
    if (white != null)
        white.Create(x, y);
    x += 1;
    Board black = factory.GetParticle("Black");
    if (black != null)
        black.Create(x, y);
    y += 1;
    i++;
}