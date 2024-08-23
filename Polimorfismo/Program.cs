using Polimorfismo;

Animal[] animal = new Animal[2];

animal[0] = new Mamiferos(" Leao ");
animal[1] = new Repteis(" Sapo ");

CaracteristicasAnimal(animal[0]);
CaracteristicasAnimal(animal[1]);

Console.ReadKey();

static void CaracteristicasAnimal(Animal animal)
{
    Console.Write(animal.getTipo());
    animal.caracteristicas();
}