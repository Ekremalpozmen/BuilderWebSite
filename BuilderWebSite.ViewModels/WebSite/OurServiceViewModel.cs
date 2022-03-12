using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWebSite.ViewModels.WebSite
{
    public class OurServiceViewModel
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

    }
    public class OurServiceDetailViewModel
    {
        public OurServiceDetailViewModel()
        {
            ImageList = new List<ImageListViewModel>();
        }
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public IEnumerable<ImageListViewModel> ImageList { get; set; }

    }
    public class ImageListViewModel
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public string Alt { get; set; }

    }

}
