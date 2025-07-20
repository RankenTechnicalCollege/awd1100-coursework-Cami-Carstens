using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public interface ICard : IComparable<ICard>
    {
      
         string Name { get; }
        System.Drawing.Image Image { get; }
        double Value { get; }

        void ShowCard(PictureBox picture, Label label);
         
    }
}
