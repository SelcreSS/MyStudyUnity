using UnityEngine;

public class Main : MonoBehaviour
{
    void Update()
    {
        if(StackPopupOpener.IsOpened)
        {
            return;
        }

        // �O������f�[�^��n��Popup
        if( Input.GetMouseButtonDown(0))
        {
            var data = new TestPopupData("purchase?", () => StackPopupOpener._Instance.Close(), () => Debug.Log("OK"));
            StackPopupOpener._Instance.Open<TestPopupData>("A_SamplePopup", data);
        }
        // �����Ŋ���
        else if(Input.GetMouseButtonDown(1))
        {
            StackPopupOpener._Instance.Open<TestPopupData2>("B_SamplePopup", new TestPopupData2());
        }
    }
}
