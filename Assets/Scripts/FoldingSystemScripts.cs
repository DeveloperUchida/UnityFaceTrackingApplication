using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class FoldingSystemScripts : MonoBehaviour
{
    private GameObject FoldinfImage;

    private bool openFold;

    private RectTransform button;

    private VerticalLayoutGroup contentLayout;
    
    // Start is called before the first frame update
    void Start()
    {
        FoldinfImage = transform.Find("UnityButtonimage").gameObject;
        button = transform.Find("image").GetComponent<RectTransform>();
        contentLayout = transform.Find("Content").GetComponent<VerticalLayoutGroup>();
    }

    // Update is called once per frame
    /* void Update()  //使用していない関数はコメント化しています
    {
         
     }
     */

    public void OnclicksetInfo()
    {
        if (openFold)
        {
            button.localRotation = Quaternion.Euler(0, 0, -90);
            FoldinfImage.SetActive(false);

            StartCoroutine("LayoutRenewal");

            openFold = true;
        }
        else
        {
            button.localRotation = Quaternion.Euler(0,0,90);
            FoldinfImage.SetActive(true);

            StartCoroutine("LayoutRenewal");
        }

        contentLayout.enabled = !contentLayout.enabled;
    }

    IEnumerator LayoutRenewal()
    {
        //1フレーム停止
        yield return null;
        
        //再スタート後の処理
        contentLayout.enabled = !contentLayout.enabled;
    }
}