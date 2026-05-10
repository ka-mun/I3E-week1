using UnityEngine;

public class Collect : MonoBehaviour
{
    // Make sure "Is Trigger" is checked on the Coin's Collider!
    void OnTriggerEnter(Collider other)
    {
        // Make sure your Player object has the Tag "Player" assigned in the Inspector
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin collected!");
            Destroy(gameObject);
        }
    }
}