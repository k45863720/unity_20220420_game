using UnityEngine;

// 命名空間 namespace 空間名稱 { 該空間的內容 }
namespace 潘
{
 /// <summary>
 ///  玩家控制系統
 ///  物件旋轉、發射彈珠
 ///  </summary>
}
public class SystemContorl : MonoBehaviour
{
    #region 資料
    // GameObject 遊戲物件
    // 存放階層面板內或者專案內的物件
    // 箭頭
    [Header("箭頭")]
    public GameObject arrow;
    // 旋轉速度
    [Header("旋轉速度"), Range(0, 500)]
    public float speedTurn = 10.5f;
    //彈珠預製物
    [Header("彈珠預製物")]
    public GameObject marble;
    //彈珠可以發射的總數
    [Header("可發射的總數"),Range(0,100)]
    public int canShootMarbleTotal = 15;
    [Header("彈珠生成點")]
    public Transform traSpawnPoint;
    [Header("攻擊參數名稱")]
    public string parAttack = "觸發攻擊";
    [Header("彈珠發射速度"), Range(0, 5000)]
    public float speedMarble = 1000;
    
    public Animator ani;
    #endregion

    #region 事件
    private void Update()
    {
        ShootMarble();
    }
    #endregion

    #region 方法
    /// <summer>
    /// 旋轉角色， 讓角色面相滑鼠位置
    /// </summer>
    private void TrunCharacter()
    {

    }
    /// <summer>
    /// 發射彈珠，根據總數發射彈珠物件
    /// </summer>
    private void ShootMarble()
    {
        // 按下 滑鼠左鍵 顯示 箭頭
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            arrow.SetActive(true);
        }
        // 放開 滑鼠左鍵 隱藏箭頭 生成並發射彈珠
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            print("放開左鍵!");

            // Objecct 類別可省略不寫
            // 直接透過 Objecct 成員名稱使用
            // 生成(彈珠) ;
            // Quaternion.identity 零度角
            GameObject tempMarble = Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
            // 暫存彈珠 取得鋼體元件 添加推力 (腳色.前方 * 速度)
            // transform.forward 腳色的前方
            tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * 700);
        }
    }
    /// <summary>
    ///  回收彈珠
    /// </summary>
    private void RecyleMarble()
    {

    }
    #endregion
}
