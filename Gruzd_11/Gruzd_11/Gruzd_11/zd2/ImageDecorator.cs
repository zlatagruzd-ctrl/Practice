namespace Gruzd_11
{
    public abstract class ImageDecorator : IImage
    {
        protected IImage image;

        public ImageDecorator(IImage image)
        {
            this.image = image;
        }

        public virtual string GetDescription()
        {
            return image.GetDescription();
        }

        public virtual IImage Process()
        {
            return image.Process();
        }
    }
}