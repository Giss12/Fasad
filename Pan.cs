using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan
{ 

    public void Fry(Ingredient ingredient, float time)
    {
        ingredient.Fry();
        //Debug.Log("Жарим" + ingredient.name);
    }

    public void Boil(Ingredient ingredient, float time)
    {
        ingredient.Boil();
        //Debug.Log("Варим" + ingredient.name);
    }
}
