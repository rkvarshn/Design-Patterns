using builder;

PersonBuilder personBuilder = new();
// you can chain also
personBuilder.WithFirstName("Rishabh").WithLastName("Varshney");
// or you can individually call
personBuilder.WithAddress("Agra Road, Aligarh");
Person person = personBuilder.Build();
Introduce(person);

// calling reset on builder. This way we can reuse the builder to create more objects
personBuilder.Reset();

Person person2 = personBuilder.WithFirstName("Anil").WithAddress("Hathras").Build();
Introduce(person2);

void Introduce(Person person) => Console.WriteLine($"{person.FirstName} {person.LastName} lives near {person.Address}");