using UnityEngine;

public class Main : MonoBehaviour
{
    void Update()
    {
        if(StackPopupOpener.IsOpened)
        {
            return;
        }

        // 外部からデータを渡すPopup
        if( Input.GetMouseButtonDown(0))
        {
            var data = new TestPopupData("purchase?", () => StackPopupOpener._Instance.Close(), () => Debug.Log("OK"));
            StackPopupOpener._Instance.Open<TestPopupData>("A_SamplePopup", data);
        }
        // 内部で完結Popup
        else if(Input.GetMouseButtonDown(1))
        {
            StackPopupOpener._Instance.Open("B_SamplePopup");
        }
    }
}
