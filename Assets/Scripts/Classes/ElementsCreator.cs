using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsCreator : IElementsCreator
{
    IObjectsStorage _objectsStorage;

    public ElementsCreator(IObjectsStorage objectsStorage)
    {
        _objectsStorage = objectsStorage;
    }

    public void CreateElement(int x, int y) 
    {          
        Element element = new Element();
        element.Xpos = x;
        element.Ypos = y;
        element.ID = x.ToString() + "-" + y.ToString();
;
        int i = Random.Range(0, 2);
        switch (i)
        {
            case 0:
                {
                    element.ElementType = Type.Circle;
                    break;
                }
            case 1:
                {
                    element.ElementType = Type.Rectangle;
                    break;
                }
        }
        switch (Random.Range(0, 5))
        {
            case 0:
                {
                    element.ElementColor = Color.Blue;
                    break;
                }
            case 1:
                {
                    element.ElementColor = Color.Green;
                    break;
                }
            case 2:
                {
                    element.ElementColor = Color.Red;
                    break;
                }
            case 3:
                {
                    element.ElementColor = Color.Pink;
                    break;
                }
            case 4:
                {
                    element.ElementColor = Color.Purple;
                    break;
                }
        }

        _objectsStorage.AddItem(element, element.Xpos, element.Ypos);
    }
    //public void CreateElement(int x, int y, string name) //придумать решение switch
    //{
    //    ICell cell = new Cell();
    //    cell.Xpos = x;
    //    cell.Ypos = y;
    //    cell.Element = new Element();
    //    cell.Element.ElementGameObject = LoadPrefabs(name);
    //    switch (Random.Range(0, 1))
    //    {
    //        case 0:
    //            {
    //                cell.Element.ElementType = Type.Rectangle;
    //                break;
    //            }
    //        case 1:
    //            {
    //                cell.Element.ElementType = Type.Circle;
    //                break;
    //            }
    //    }
    //    switch (Random.Range(0, 2))
    //    {
    //        case 0:
    //            {
    //                cell.Element.ElementColor = Color.Blue;
    //                break;
    //            }
    //        case 1:
    //            {
    //                cell.Element.ElementColor = Color.Green;
    //                break;
    //            }
    //        case 2:
    //            {
    //                cell.Element.ElementColor = Color.Red;
    //                break;
    //            }
    //    }

    //    _objectsStorage.AddItem(cell);
    //}

}
