using System;

namespace Gruzd_11
{
    public class zd2
    {
        public static void zd()
        {
            IImage image = new BaseImage();

            // Накладываем фильтры
            image = new BlackWhiteFilterDecorator(image);
            image = new BlurFilterDecorator(image);
            image = new SharpenFilterDecorator(image);

            Console.WriteLine("Описание изображения:");
            Console.WriteLine(image.GetDescription());

            Console.WriteLine("\nПроцесс обработки:");
            image.Process();
        }
    }
}