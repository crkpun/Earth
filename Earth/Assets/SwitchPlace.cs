using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SwitchPlace : MonoBehaviour
{
    public Transform[] places;

    private int _nowPlace = 2;

    public void MoveToPlace(int index)
    {
        places[_nowPlace].localPosition = new Vector3(0, -1920, 0);
        places[index].localPosition = new Vector3(0, 0, 0);
        _nowPlace = index;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}