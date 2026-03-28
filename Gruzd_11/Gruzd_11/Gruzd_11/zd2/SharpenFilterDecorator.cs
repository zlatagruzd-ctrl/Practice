using System;

namespace Gruzd_11
{
    public class SharpenFilterDecorator : ImageDecorator
    {
        public SharpenFilterDecorator(IImage image) : base(image) { }

        public override string GetDescription()
        {
            return image.GetDescription() + " + Повышение резкости";
        }

        public override IImage Process()
        {
            image.Process();
            Console.WriteLine("Применён фильтр повышения резкости.");
            return this;
        }
    }
}