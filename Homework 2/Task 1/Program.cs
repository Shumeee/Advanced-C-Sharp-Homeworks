using Task_1.Entities;
using Task_1.Enums;

List<Dog> dogs = new List<Dog>() {
    new Dog("Sharko", PetType.Dog, 5, true, "Bone"),
    new Dog("Sparky", PetType.Dog, 2, true, "Dog Treats")
};
List<Cat> cats = new List<Cat>() {
    new Cat("Luna", PetType.Cat, 3, true, 7),
    new Cat("Sam", PetType.Cat, 4, true, 5)
};
List<Fish> fish = new List<Fish>() {
    new Fish("Bubbles", PetType.Fish, 5, "Red", 10),
    new Fish("Fishy", PetType.Fish, 2, "Yellow", 15)
};

PetStore<Dog> dogStore = new PetStore<Dog>(dogs);
PetStore<Cat> catStore = new PetStore<Cat>(cats);
PetStore<Fish> fishStore = new PetStore<Fish>(fish);

dogStore.BuyPet("Sharko");
catStore.BuyPet("Luna");

dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();
