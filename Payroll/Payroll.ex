using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public class Person
    {
        string name;
        string position;
        int rate;
        int manhour;
        int totalSalary;
    

    public Person()
    {

    }
    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public string getPosition()
    {
        return position;
    }
    public void setPosition(string position)
    {
        this.position = position;
    }
    public int getRate()
    {
        return rate;
    }
    public void setRate(int rate)
    {
        this.rate = rate;
    }
    public int getManhour()
        {
            return manhour;
        }
    public void setManhour(int manhour)
        {
            this.manhour = manhour;
        }
  
}
}
