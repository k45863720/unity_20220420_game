//單行註解 標記，註記
/*
 * 多行註解
 */
// 藍色是保留字 白色是名稱 綠色是資料種類
using UnityEngine;

// 修飾詞 類別(藍圖) 類別名稱 繼承(物件導向程式 OOP 三大原則)
public class LearnData : MonoBehaviour
{
          //LearnData 類別成員區域
 //資料類型 欄位自訂名稱 指定 值 結束符號
 //  int    自訂名稱    ;
    //欄位名稱 field
 //欄位語法
 int hp;  //定義一個整數資料 名稱叫做hp

    //資料類型 四大基本類型
    //整數 保存正負沒有小數點的資料 int
    //浮點數 保存正負有小數點的資料 float
    //字串 保存文字資料 string
    //布林值 保存有、沒有資料 bool

    int lv = 50;
    //浮點數必須加上f 後綴，大小F皆可
    float exp = 0.005f;
    //字串必須使用雙引號
    string playName = "玩家1";
    //true 有，false沒有
    bool hasCureSkill = true;

    // Clean code 無瑕的程式
}
//非LearnData 類別成員區域