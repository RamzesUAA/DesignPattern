using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.CreationalDesignPatterns
{
    public interface iClonablePrototype
    {
        iClonablePrototype ShallowCopy();
        iClonablePrototype DeepClone();
    }
    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------
    public class Robot: iClonablePrototype
    {
        public string Name;
        public DateTime CreationDate;
        public RobotInfo RobotInfo;
        public iClonablePrototype ShallowCopy()
        {
            return (Robot)this.MemberwiseClone();
        }
        public iClonablePrototype DeepClone()
        {
            Robot cloneRobot = (Robot) this.MemberwiseClone();
            cloneRobot.RobotInfo = new RobotInfo(RobotInfo.IdNumber);
            cloneRobot.Name = String.Copy(Name);
            return cloneRobot;
        }
    }
    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------
    public class RobotInfo
    {
        public int IdNumber;

        public RobotInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

}
