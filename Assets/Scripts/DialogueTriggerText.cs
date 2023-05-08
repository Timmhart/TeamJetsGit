using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTriggerText : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI textComponent;
    [SerializeField] public string[] lines;

    private int index;
    

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = lines[index];
    }

    public void nextDialogue()
    {
         if (index < lines.Length - 1)
        {
            index++;
            Debug.Log("Hier stopt ie");
        }
        else 
        {
            index = 0;
            gameObject.SetActive(false);
            Debug.Log("close it");
        }
    }
}
