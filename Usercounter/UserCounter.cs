using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usercounter
{
/*
 * Патерны/Шаблоны проектирования
 * 
 * 1. Пораждающие патерны - создание объектов
 * 2. Структурные патерны - организация классов и объектов в структуры
 * 3. Поведенческие паттерны - определние способов взаимодействия между объектами
 * 
 */

// Пораждающие патерны - Singleton/Одиночка

public class UserCounterSingleton
{
    private int userCount;

    private static UserCounterSingleton instance;

    private static readonly object lockObj = new Object();

    public static UserCounterSingleton Instance
    {
        get
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new UserCounterSingleton(0);
                }
            }
            return instance;
        }
    }
    public UserCounterSingleton (int initialCount)
    {
        this.userCount=initialCount;
    }

    public void UserAdd()
    {
        this.userCount++;
        return;
    }
    public void UserRemove()
    {
        if (this.userCount>0)
            this.userCount--;
        else 
            this.userCount=0;
        return;
    }

    public int UserGetCount()
    {
        return userCount;
    }

}
}