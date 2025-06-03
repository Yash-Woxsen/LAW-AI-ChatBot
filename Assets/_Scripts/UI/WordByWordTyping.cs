using System.Collections;
using TMPro;
using UnityEngine;

public class WordByWordTyping : MonoBehaviour
{
    public float wordsPrintSpeed = 0.05f;
    public void PrintSentence(string textToDisplay, TMP_Text tmpText)
    {
        StartCoroutine(TypeText(textToDisplay,tmpText));
    }

    IEnumerator TypeText(string textToDisplay, TMP_Text tmpText)
    {
        string[] words = textToDisplay.Split(' ');
        // tmpText.text = "";

        for (int i = 0; i < words.Length; i++)
        {
            tmpText.text += words[i] + " ";
            yield return new WaitForSeconds(wordsPrintSpeed);
        }
    }
}