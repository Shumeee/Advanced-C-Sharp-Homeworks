namespace Task_1.Entities
{
    public class PetStore<T> where T : Pet<T>
    {
        public List<T> Pets { get; set; }

        public PetStore(List<T> pets)
        {
            Pets = pets;
            //Pets = new List<T>();
        }

        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                pet.PrintInfo();
            }
        }
        public void BuyPet(string name)
        {
            if(Pets.FirstOrDefault(p => p.Name == name) != null)
            {
                Pets.Remove(Pets.FirstOrDefault(p => p.Name == name));  
                Console.WriteLine($"Success! We hope {name} enjoys their new home!");
            }
            else Console.WriteLine("No dogs were found with that name!");
        }
    }
}
