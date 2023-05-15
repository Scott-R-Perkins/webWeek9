// using backend.Data;

// public static class Seed{
//     public static List<Manufacturers> GetManufacturers(int count 10){
//         var ManucaturerId = 1;
//         var faker = new Faker<Manufaturer>().Rules((f, m) =>
//         {
//             m.Id = ManucaturerId++,
//             m.Name = f.Company.CompanyName();
//             m.Location = f.Address.Country();
//         });    
//         return Faker.Generate(count);
//     }
    
//     public static List<Vehicle> GetVehicles(List<Manufacturer> manufacturers, int count 10){
//         var vehicleId = 1;
//         var faker = new Faker<Vehicle>()
//         .Rules((f, v) =>
//         {
//             v.Id = vehicleId++,
//             v.Name = f.Vehicle.Model();
//             v.Speed - f.Vehicle.Random.Int(20, 100);
//             v.ManucaturerId = f.PickRandom(manufacturers).Id;
//         });  
//         return faker.Generate(count);
//     }
//     public static List<Food> GetFood(int count 10){
//         var FoodId = 1;
//         var faker = new Faker<Food>().Rules((f, food) =>
//         {
//             food.Id = FoodId++,
//             food.Name = f.Lorem.Word();
//             food.Location = f.Lorem.Paragraph();
//         });    
//         return Faker.Generate(count);
//     }
//     public static List<ManufacturersFood> ManufacturerFoods(List<Manufacturer> manufacturers, List<Food> foods ,int count 10)
//     {
//         var mfList = new List<ManufacturerFood>();
//         var ManufacturerFoodId = 0;
//         foreach(var food in foods)
//         {
//             ManufacturerFoodId++;
//             mfList.Add(new ManufacturerFood(Id = ManufacturerFoodId, FoodId = food.id, ManucaturerId = Random.Shared.Next(manufacturers.count)+1));   might be {} after new ManufacturerFood
//         }
//         return mfList;
//     }
// }