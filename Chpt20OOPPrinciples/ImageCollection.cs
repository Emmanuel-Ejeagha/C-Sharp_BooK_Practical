using System;

namespace Chpt20OOPPrinciples;

public class ImageCollection
{
    private IList<Image> images;

    public ImageCollection(IList<Image> images)
    {
        this.images = images;
    }

    public IList<Thumbnail> CreateThumbnails()
    {
        IList<Thumbnail> thumbnails = new List<Thumbnail>(images.Count);
        foreach (Image thumb in images)
        {
            thumbnails.Add(thumb.CreateThumbnail());
        }
        return thumbnails;
    }
}
