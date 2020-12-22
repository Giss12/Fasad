using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook : MonoBehaviour
{
    Knife _knife;
    Pan _pan;
    private void Start()
    {
        _knife = new Knife();
        _pan = new Pan();
        CookSoup();
        //ComplexIngredient soup = CookSoup();
    }
    public ComplexIngredient CookSandwich()
    {
        SimpleIngredient mayo = new SimpleIngredient("мазик", 20, 5, 109);
        SimpleIngredient kepchuk = new SimpleIngredient("кепчук", 20, 22, 76);
        SimpleIngredient bread = new SimpleIngredient("хлеб", 20, 20, 20);
        SimpleIngredient cheese = new SimpleIngredient("сыр", 20, 20, 20);
        SimpleIngredient kolbasa = new SimpleIngredient("колбаса", 20, 20, 20);

        ComplexIngredient ketchinez = new ComplexIngredient("кетчинез", new List<Ingredient> { mayo, kepchuk });
        ComplexIngredient sandwich = new ComplexIngredient("Сэндвич", new List<Ingredient> { bread, ketchinez, cheese, kolbasa, bread });

        Debug.Log("kall :" + sandwich.GetTotalCalories());
        Debug.Log("Weight :" + sandwich.GetTotalWeight());
        Debug.Log("Coast :" + sandwich.GetTotalCost());
        return sandwich;
    }

    public ComplexIngredient CookSoup()
    {
        SimpleIngredient meat = new SimpleIngredient("говядина", 400, 0, 0);
        _knife.Cut(meat);
        SimpleIngredient water = new SimpleIngredient("вода", 3000, 0, 0);
        SimpleIngredient lavr_lust = new SimpleIngredient("лавровый лист", 3, 0, 0);
        SimpleIngredient salt = new SimpleIngredient("соль", 1, 0, 0);
        SimpleIngredient pepper = new SimpleIngredient("перец", 1, 0, 0);
        ComplexIngredient bylon = new ComplexIngredient("бульон", new List<Ingredient> { meat, water, lavr_lust, salt, pepper });
        _pan.Boil(bylon, 100f);
        bylon.RemoveIngredient(lavr_lust);
        SimpleIngredient morkov = new SimpleIngredient("морковь", 150, 0, 0);
        SimpleIngredient lyk = new SimpleIngredient("лук", 150, 0, 0);
        ComplexIngredient morkov_lyk = new ComplexIngredient("марковь и лук", new List<Ingredient> { morkov, lyk });
        _knife.Cut(morkov_lyk);
        _pan.Fry(morkov_lyk, 2f);
        bylon.AddIngredient(morkov_lyk);
        SimpleIngredient potate = new SimpleIngredient("картошка", 300, 0, 0);
        _knife.Cut(potate);
        bylon.AddIngredient(potate);
        _pan.Boil(bylon, 30f);
        _pan.Fry(bylon, 30f);
        Debug.Log(bylon.GetTotalWeight());
        return bylon;
    }
}
