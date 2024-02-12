using Factory;
using Factory.PizzaStores;

PizzaStore indianStore = new IndianPizzaStore();
IPizza pizza = indianStore.OrderPizza("farmhouse");
pizza = indianStore.OrderPizza("paneer");
PizzaStore nyStore = new NYPizzaStore();
pizza = nyStore.OrderPizza("cheese");
pizza = nyStore.OrderPizza("clam");