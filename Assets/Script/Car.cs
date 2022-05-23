using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update


    //欄位語法
    //修飾詞 資料類型 欄位自訂名稱 指定 值 結束符號
    //修飾此資料的存取權限

    //兩大基本修飾詞
    //公開:允許外部存取，顯示在屬性面板
    //public
    //私人:不允許外部存取，不顯示在屬性面板(預設值，可省略)
    //private
    //1.Unity 以屬性面板資料為主
    //2.還原到程式內的值必須按 ... > Reset

    //欄位屬性語法
    //[屬性名稱(值)]

    //提示 Tooltip
    //標題 Header
    //範圍 Range 僅限整數與浮點數
    //重量
    [Tooltip("汽車的重量，單位是噸"), Range(1,10)]
    public int weight = 3;
    //高度
   [Header("車輛高度"), Range(1,5)]
    public float height = 3.5f;
    //品牌
    public string brand = "賓士";
    //是否有天窗
    public bool hasskywindow = true;
    private void drivCar()
    {

    }
}

