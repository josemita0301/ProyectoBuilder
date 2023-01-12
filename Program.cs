using ProyectoBuilder;

PizzaBuilder builder = new PizzaItalianaBuilder();
Pizza pizza1 = builder.BuildPizza();

PizzaBuilder builder2 = new PizzaLightBuilder();
Pizza pizza2 = builder2.BuildPizza();

PizzaBuilder builder3 = new PizzaMuzzaBuilder();
Pizza pizza3 = builder3.BuildPizza();


Console.WriteLine(pizza1.ToString());
Console.WriteLine(pizza2.ToString());
Console.WriteLine(pizza3.ToString());


