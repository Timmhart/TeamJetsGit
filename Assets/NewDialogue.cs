using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewDialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public GameObject dialogueBox;
    public string[] lines;

    public float textSpeed;
    public float invokeTime;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.gameObject.SetActive(false);
        textComponent.text = string.Empty;
        Invoke("StartDialogue",invokeTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartDialogue();
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else 
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

void StartDialogue()
 {
    if(dialogueBox.gameObject.activeInHierarchy == false)
    {
        dialogueBox.gameObject.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }
 }




 IEnumerator TypeLine()
 {
    foreach (char c in lines[index].ToCharArray())
    {
        textComponent.text += c;
        yield return new WaitForSeconds(textSpeed);
    }
 }






    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}