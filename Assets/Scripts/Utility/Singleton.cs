using System;
using UnityEngine;

public class Singleton<T> where T : Singleton<T>, new()
{
	private static T instance;

    public static T Instance
    {
        get
        {
            try
            {
	            if (instance == null)
		            instance = new T();
				return instance;
            }
            catch (Exception e)
            {
	            Debug.LogError(string.Format("游戏内部错误。单例 Singleton<{0}> 创建失败：{1}", typeof (T).Name, e));
	            return null;
            }
        }
    }
}