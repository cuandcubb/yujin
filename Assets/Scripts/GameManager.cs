using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //문제점: 오브젝트가 같은 위치에 겹쳐서 생성됨, A를 연타하면 마지막에 생성된 것만 스프라이트가 바뀜 나머지는 안 바뀜
    //bodyplantproject에 만들어두신거 참고하면서 해봤습니다
    
    List<ComponentClass> componentList = new List<ComponentClass>();

    public GameObject imageObject;

    public Sprite unspro;
    public Sprite spro;

    public int i;

    public void Sprouting()
    {
        componentList.Add(new ComponentClass());

        GameObject obj = Instantiate(imageObject);
        componentList[i].realGameobject = obj;

        componentList[i].spriteRenderer = obj.GetComponent<SpriteRenderer>();

        componentList[i].unSproutedSprite = unspro;
        componentList[i].sproutedSprite = spro;

        componentList[i].spriteRenderer.sprite = componentList[i].unSproutedSprite;
        StartCoroutine(SproutingCoroutine());
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Sprouting();
        }
    }
    
    IEnumerator SproutingCoroutine()
    {
        yield return new WaitForSeconds(componentList[i].sproutTime);
        componentList[i].spriteRenderer.sprite = componentList[i].sproutedSprite;
    }
}
