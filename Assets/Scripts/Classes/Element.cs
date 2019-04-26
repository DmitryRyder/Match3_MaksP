using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type { Rectangle, Circle, Empty}
public enum Color { Green, Red, Blue, Purple, Pink }

public struct Element : IElement
{
    public int Xpos { get; set; }
    public int Ypos { get; set; }
    public string ID { get; set; }
    public Color ElementColor { get; set; }
    public Type ElementType { get; set; }
}
