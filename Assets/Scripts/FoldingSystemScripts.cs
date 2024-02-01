using UnityEngine;
using UnityEngine.UI;
public class FoldingSystemScripts : MonoBehaviour
{
    private GameObject FoldinfImage;

    private bool openFold = false;

    private RectTransform button;

    private VerticalLayoutGroup contentLayout;
    
    // Start is called before the first frame update
    void Start()
    {
        FoldinfImage = transform.Find("Image2").gameObject;
        button = transform.Find("image").GetComponent<RectTransform>();
        contentLayout = transform.Find("Content").GetComponent<VerticalLayoutGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
