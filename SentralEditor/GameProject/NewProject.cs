using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentralEditor.GameProject
{
    class NewProject : ViewModelBase
    {
        private string name = "NewProject";
        public string Name
        {
            get => name;
            set
            {
                if( name != value)
                {

                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        private string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\SentralProject\";
        public string Path
        {
            get => path;
            set
            {
                if (path != value)
                {

                    path = value;
                    OnPropertyChanged(nameof(Path));
                }
            }
        }
    }


}