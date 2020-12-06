using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.SOLID
{
    /// <summary>
    /// У модуля повинна бути лише 1 причина для його зміни, або клас повинен
    /// відповідати тільки за щось 1. Основна ідея, це організувати код таким способом,
    /// щоб у випадку внесення змін  задіяти найменшу кількість модулів, в ідеалі тільки 1 клас
    /// </summary>
    class Auto
    {
        Auto(string model){}
        void getCarModel(){}
        void setCarModel(){}
    }

    class CustomerAuto
    {
        void saveCustomerOrder(Auto saveAuto){}
        void removeCustomerOrder(string id) { }
        void getCustomerOrder(string Id) { }
    }

    class AutoDB
    {
        void updateCatSet(object set){}
    }
}
