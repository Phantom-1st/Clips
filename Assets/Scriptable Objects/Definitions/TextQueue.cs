using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text/TextQueue")]
public class TextQueue : ScriptableObject
{
    public List<Text> texts = new List<Text>();
}
