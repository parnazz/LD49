using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager
{
    public static Action TryToInteractEvent = delegate { };
    public static Action<Sprite> OnElementAddToInventoryEvent = delegate { };
    public static Action<ElementType> OnCatInteractEvent = delegate { };
    public static Action OnCorrectElementGivenEvent = delegate { };
}
