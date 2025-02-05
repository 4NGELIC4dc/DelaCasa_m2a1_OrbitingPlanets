using UnityEngine;
using System.Collections.Generic;

public abstract class Planet : MonoBehaviour
{
    public float gravity = 9.8f;  
    public List<Moon> moons = new List<Moon>(); // To assign moons

    public virtual void AttractMoons() { }
}
