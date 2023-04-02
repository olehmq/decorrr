using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorrr
{
    abstract class Rain
    {
        public Rain(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class HeavyRain : Rain
    {
        public HeavyRain() : base("Сильний дощ")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
    class LightRain : Rain
    {
        public LightRain()
            : base("Легкий дощ")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }

    abstract class RainDecorator : Rain
    {
        protected Rain rain;
        public RainDecorator(string n, Rain rain) : base(n)
        {
            this.rain = rain;
        }
    }

    class IceRain : RainDecorator
    {
        public IceRain(Rain p)
            : base(p.Name + ", з градом", p)
        { }

        public override int GetCost()
        {
            return rain.GetCost() + 5;
        }
    }

    class ThunderstormRain : RainDecorator
    {
        public ThunderstormRain(Rain p)
            : base(p.Name + ", з грозою", p)
        { }

        public override int GetCost()
        {
            return rain.GetCost() + 5;
        }
    }
}
