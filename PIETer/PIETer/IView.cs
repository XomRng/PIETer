using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PIETer
{
    public interface IView
    {
        void DisplayBottomInfo(string text, Color color);
        void DisplayTopInfo(string text, Color color);
        void Lock();
        void Unlock();
        void ClearTextField();
        void DisplayCurrentUser(string text);
    }
}
