using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    public int[] planetPostions;

    public Transform earths;

    private int _nowPlace = 0;

    public void MoveToLeft()
    {
        if (_nowPlace == 0)
            return;
        
        _nowPlace--;
        earths.DOLocalMoveX(planetPostions[_nowPlace], 0.5f).SetEase(Ease.OutBack);
    }

    public void MoveToRight()
    {
        if (_nowPlace == 4)
            return;
        _nowPlace++;
        earths.DOLocalMoveX(planetPostions[_nowPlace], 0.5f).SetEase(Ease.OutBack);
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
