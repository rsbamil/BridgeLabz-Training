using System;
interface IMeal
{
    string GetMealType();
}
class VegetarianMeal : IMeal
{
    public string GetMealType()
    {
        return "Vegetarian Meal";
    }
}
class VeganMeal : IMeal
{
    public string GetMealType()
    {
        return "Vegan Meal";
    }
}
class Meal<T> where T : IMeal
{
    public T MealPlan;
    public Meal(T mealPlan)
    {
        MealPlan = mealPlan;
    }
}
class MealGenerator
{
    public static void GenerateMeal<T>(Meal<T> meal) where T : IMeal
    {
        Console.WriteLine("Generated Meal :" + meal.MealPlan.GetMealType());
    }
}
class MealPlan
{
    static void Main()
    {
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>(new VegetarianMeal());
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>(new VeganMeal());
        MealGenerator.GenerateMeal(vegMeal);
        MealGenerator.GenerateMeal(veganMeal);
    }
}