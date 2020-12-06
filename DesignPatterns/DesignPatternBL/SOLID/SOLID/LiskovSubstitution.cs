using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.SOLID.SOLID
{
    /// <summary>
    /// Необхідно, щоб підкласи могли служити заміною для своїх суперкласів
    /// Щоб функції, які використовують базовий тип, могли використовувати його підтипи
    /// Основна ціль це проектувати таким способом, щоб класи наслідники могли використовуватись
    /// замість класів-батьків. 
    /// </summary>
    interface IFigure
    {
        void setWith(int with);
        void setHeight(int height);
        void areaOf();

    }

    class Rectangle: IFigure
    {
        public void setWith(int with)
        {
            throw new NotImplementedException();
        }

        public void setHeight(int height)
        {
            throw new NotImplementedException();
        }

        public void areaOf()
        {
            throw new NotImplementedException();
        }
    }
    class Square : IFigure
    {
        public void setWith(int with)
        {
            throw new NotImplementedException();
        }

        public void setHeight(int height)
        {
            throw new NotImplementedException();
        }

        public void areaOf()
        {
            throw new NotImplementedException();
        }
    }
}
