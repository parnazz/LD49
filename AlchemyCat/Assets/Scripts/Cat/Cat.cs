using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Cat : MonoBehaviour
{
    [SerializeField] ElementType correctElement; // �������, ������� ������� ����� ��� �������� �����
    List<IAbility> abilities = new List<IAbility>(); 

    void Start()
    {
        EventManager.OnCatInteractEvent += CheckElement;
    }

    private void CheckElement(ElementType elementType)
    {
        if (elementType == correctElement)
        {
            EventManager.OnCorrectElementGivenEvent?.Invoke();
            return;
        }

        switch(elementType)
        {
            case ElementType.Fire:
                Debug.Log("������� �����");
                // abilities.Add(FireAbility)
                // abilities.Last().CastAbility()
                break;
            case ElementType.Water:
                Debug.Log("������� ��� �����");
                // abilities.Add(WaterAbility)
                // abilities.Last().CastAbility()
                break;
            case ElementType.Air:
                Debug.Log("������ �����");
                // abilities.Add(AirAbility)
                // abilities.Last().CastAbility()
                break;
        }
    }

    private void OnDisable()
    {
        EventManager.OnCatInteractEvent -= CheckElement;
    }
}
