using UnityEngine;

public class Moon : MonoBehaviour
{
    // Note: You can manually adjust the orbit radius and orbit speed of each moon in Unity

    public Transform orbitCenter;  // To assign planet
    public float orbitSpeed = 5f;  
    public float orbitRadius = 5f; 
    private float angle = 0f;      

    void FixedUpdate()
    {
        if (orbitCenter != null)
        {
            angle += orbitSpeed * Time.deltaTime; 

            float x = orbitCenter.position.x + Mathf.Cos(angle) * orbitRadius;
            float z = orbitCenter.position.z + Mathf.Sin(angle) * orbitRadius;

            transform.position = new Vector3(x, transform.position.y, z);
        }
    }
}
