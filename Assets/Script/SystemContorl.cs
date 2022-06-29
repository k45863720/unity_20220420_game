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
    #endregion

    #region 事件

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

    }
    /// <summary>
    ///  回收彈珠
    /// </summary>
    private void RecyleMarble()
    {

    }
    #endregion
}
