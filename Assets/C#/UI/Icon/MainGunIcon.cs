using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MainGunIcon : MonoBehaviour
{
    public bool IconMove = false;
    public SpriteRenderer myIcon;
    public GameObject poition; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && IconMove == false)
        {
            Changed();
        }
    }
    void Changed()
    {
        switch (myIcon.sortingOrder)
        {
            case 0:
                IconMove = true;
                myIcon.sortingOrder = 1;
                transform.DOLocalMove(poition.transform.localPosition, 1).SetEase(Ease.OutExpo)
                .OnComplete(() =>
                {

                    IconMove = false;

                });
                break;
            case 1:
                IconMove = true;
                myIcon.sortingOrder = 0;
                transform.DOLocalMove(poition.transform.localPosition, 1).SetEase(Ease.OutExpo)
                .OnComplete(() =>
                {

                    IconMove = false;

                });
                break;
        }
    }
}
