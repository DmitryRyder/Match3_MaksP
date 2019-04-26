using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type { Rectangle, Circle, Empty }
public enum Color { Green, Red, Blue, Purple, Pink }

public struct Element : IElement, ICloneable
{
    public int Xpos { get; set; }
    public int Ypos { get; set; }
    public string ID { get; set; }
    public Color ElementColor { get; set; }
    public Type ElementType { get; set; }
    public object Clone()
    {
        return new Element { Xpos = this.Xpos, Ypos = this.Ypos, ID = this.ID, ElementColor = this.ElementColor, ElementType = this.ElementType };
    }
}
