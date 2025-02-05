using UnityEngine;

public class Planet1 : Planet
{
    void Start()
    {
        gravity = 10f;
    }

    public override void AttractMoons() { } // Assign moon
}
