using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLibrary
{
    public class ViewModel
    {
        private ObservableCollection<Dimser> _dimser = new ObservableCollection<Dimser>();

        public ViewModel()
        {
            Dimser.Add(new Dimser(){Name = "robot"});
            Dimser.Add(new Dimser() { Name = "robot" });

            Dimser.Add(new Dimser() { Name = "robot" });
            Dimser.Add(new Dimser() { Name = "robot" });

        }

        public ObservableCollection<Dimser> Dimser
        {
            get { return _dimser; }
            set { _dimser = value; }
        }
    }
}
