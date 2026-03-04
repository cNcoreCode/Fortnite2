using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fortnite2.Domain.Entities.PointingLogic;

namespace Fortnite2.Domain.Entities.PointingLogic
{
    public interface IPointer
    {
        void ChangePointing(Pointing pointing);
    }
}
