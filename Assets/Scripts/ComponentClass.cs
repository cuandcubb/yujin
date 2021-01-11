using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentClass
{
    public string name;                 //이름
    public Vector2 position;            //부위의 위치
    public Sprite unSproutedSprite;     //꽃이 피어나지 않았을 때 스프라이트 이미지
    public Sprite sproutedSprite;       //꽃이 피어났을 때의 스프라이트 이미지
    public GameObject realGameobject;   //이 컴포넌트가 가진 실제의 게임오브젝트
    public float sproutTime;            //피어나는 데 걸리는 시간
    public SpriteRenderer spriteRenderer;
    //스프라이트 렌더러 컴포넌트, 나중에 realGameObject.GetComponent<SpriteRenderer>()해야 함

    public ComponentClass()
    {
        position = Vector2.zero;

        sproutTime = 10;
    }
}

