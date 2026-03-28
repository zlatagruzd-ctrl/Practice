using System;

namespace Gruzd_11
{
    public class BlackWhiteFilterDecorator : ImageDecorator
    {
        public BlackWhiteFilterDecorator(IImage image) : base(image) { }

        public override string GetDescription()
        {
            return image.GetDescription() + " + Чёрно-белый фильтр";
        }

        public override IImage Process()
        {
            image.Process();
            Console.WriteLine("Применён чёрно-белый фильтр.");
            return this;
        }
    }
}