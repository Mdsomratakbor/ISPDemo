using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AudioBook : IAudioBook
    {
        public int RuntimeInMinutes { get; set; }
        public string LibraryID { get; set; }
        public string Title { get; set; }
    }
}
