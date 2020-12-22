using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife
{
    public void Cut(Ingredient ingredient)
    {
        ingredient.Cut();
        //Debug.Log("Режем" + ingredient.name);
    }
}
