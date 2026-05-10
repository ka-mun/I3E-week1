using UnityEngine;

public class PlayerCollision : MonoBehaviour
   {
    public int coinsCollected = 0;
    public int totalCoins = 3;

    // This runs when the Player's Collider touches another Collider set to "Is Trigger"
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // Remove the coin from the game
            Destroy(other.gameObject);
            coinsCollected++;

            // Log the message to the Console
            Debug.Log("You collected a coin!");
        }
    
        if (other.CompareTag("Finish"))
        {
            if (coinsCollected == totalCoins)
            {
                Debug.Log("You collected ALL collectibles!");
            }
            else
            {
                Debug.Log("Collect all coins first!");
            }
        }
    }
    }