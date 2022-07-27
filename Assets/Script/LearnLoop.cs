using UnityEngine;
/// <summary>
///  學習迴圈
///  While、for 教學
///  While do、foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        //迴圈 : 重複執行

        //While 迴圈語法 :
        // if (布林值) { 程式 } 執行一次
        //While (布林值) { 程式 } 重複執行直到布林值為 false

        int count = 0;

        while (count < 5)
        {
            print("while 迴圈!" + count);
            count++;
        }

        // for(初始值 ; 條件 ; 迴圈執行後的處理) { 程式 }
        for (int i = 0; i < 5; i++) 
        {
            print("for 迴圈!" + i);
        }
    }
}
