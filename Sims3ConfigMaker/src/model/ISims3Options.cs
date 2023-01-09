using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sims3ConfigMaker.src.model
{
    public interface ISims3Options
    {

        string ReadOptions();

        string ReadProperty(string propertyName);

        void Backup();
    }
}
