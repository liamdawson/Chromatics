using System.Collections.Generic;
using System.Drawing;

namespace Chromatics.Devices
{
    public interface IDisplayElement
    {
        IEnumerable<Color> Gradient { get; }
    }
}
