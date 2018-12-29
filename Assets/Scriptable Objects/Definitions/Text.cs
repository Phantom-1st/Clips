using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text/Text")]
public class Text : ScriptableObject
{
    [TextArea]
    public string text;
}
