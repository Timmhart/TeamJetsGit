using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox; // Reference to the dialogue box game object
    private bool enter = false;

    private void Start()
    {
        Debug.Log("Dialogue staat uit");
        dialogueBox.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Grace") || other.gameObject.CompareTag("Harry"))
        {
            enter = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Grace") || other.gameObject.CompareTag("Harry"))
        {
            enter = false;
            
        }
    }

    void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueBox.SetActive(true); // Show the dialogue box
                Debug.Log("E pressed");
            }
        }
    }
}