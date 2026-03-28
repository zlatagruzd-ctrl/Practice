using System;

namespace Gruzd_11
{
    public class BlurFilterDecorator : ImageDecorator
    {
        public BlurFilterDecorator(IImage image) : base(image) { }

        public override string GetDescription()
        {
            return image.GetDescription() + " + Размытие";
        }

        public override IImage Process()
        {
            image.Process();
            Console.WriteLine("Применён эффект размытия.");
            return this;
        }
    }
}