using HttpExerciseLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpExerciseWpf.ViewModel
{
    public class UsersViewModel : ViewModelBase
    {
        private List<User> users;

        public List<User> Users { get => users; set => users = value; }
    }
}
