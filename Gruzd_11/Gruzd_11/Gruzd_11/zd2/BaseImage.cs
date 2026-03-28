using System;

namespace Gruzd_11
{
    public class BaseImage : IImage
    {
        public string GetDescription()
        {
            return "Исходное изображение";
        }

        public IImage Process()
        {
            Console.WriteLine("Обработка исходного изображения...");
            return this;
        }
    }
}