using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    [SerializeField] private TextQueue textQueue;
    [SerializeField] private UnityEngine.UI.Text mainText;
    [SerializeField] private UnityEngine.UI.Text promptText;
    private List<Text>.Enumerator enumerator;
    private Text currentText;

    void Start()
    {
        if (textQueue == null)
            Debug.LogError("TextQueue cannot be null!");
        enumerator = textQueue.texts.GetEnumerator();
        enumerator.MoveNext();
        currentText = enumerator.Current;
        if (currentText == null)
            Debug.LogError("TextQueue is empty");
        else
            mainText.text = currentText.text;
    }

    void Update()
    {
        if (textQueue == null || currentText == null)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            enumerator.MoveNext();
            currentText = enumerator.Current;
            if (currentText != null)
                mainText.text = currentText.text;
            else {
                mainText.text = "";
                promptText.gameObject.SetActive(false);
            }
        }
    }

    public void setText(string message)
    {
        mainText.text = message;
    }
}
