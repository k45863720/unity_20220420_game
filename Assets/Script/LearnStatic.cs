using UnityEngine;
/// <summary>
/// 學習 靜態 API
/// 靜態 static
/// </summary>
public class LearnStatic : MonoBehaviour
{
    private void Start()
    {
        // 靜態屬性 static properties
        // 1. 取得 get
        // 取得靜態屬性語法:
        // 類別名稱.靜態屬性名稱
        print("隨機值:" + Random.value);
        print("螢幕寬度:" + Screen.width);
        print("圓周率:" + Mathf.PI);

        // 2. 設定 set (Read Only 不能設定)
        // 設定靜態屬性語法:
        // 類別名稱.靜態屬性名稱 指定 值;
        Screen.brightness = 0.5f;
        Cursor.visible = false;
    }
}
