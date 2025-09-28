using System;

namespace Chpt20OOPPrinciples;

public class Thumbnail
{
    // ...
}

public interface Image
{
    Thumbnail CreateThumbnail();
}

public class GifImage : Image
{
    public Thumbnail CreateThumbnail()
    {
        // ... Create a GIF thumbnail here ...
        return gifThumbnail;
    }
}

public class JpegImage : Image
{
    public Thumbnail CreateThumbnail()
    {
        // ... Create a JPEG thumbnail here ...
        return jpegThumbnail;
    }
}