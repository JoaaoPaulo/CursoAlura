class Animal
{
    public virtual string EmitirSom()
    {
        return "Som de animal";
    }
}

class Mamifero : Animal
{
    public override string EmitirSom()
    {
        return "Som de mamífero";
    }
}

class Ave : Animal
{
    public override string EmitirSom()
    {
        return "Som de Ave";
    }
}

class Peixe : Animal
{
    public override string EmitirSom()
    {
        return "Som de Peixe";
    }
}