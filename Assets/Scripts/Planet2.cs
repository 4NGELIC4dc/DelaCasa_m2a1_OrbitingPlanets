using UnityEngine;

public class Planet2 : Planet
{
    void Start()
    {
        gravity = 12f;
    }

    public override void AttractMoons() { } 
}
