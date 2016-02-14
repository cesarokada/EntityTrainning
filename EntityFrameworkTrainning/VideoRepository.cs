using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTrainning
{
    class VideoRepository
    {
        MeContext DBContext = new MeContext();

        public void InsertVideo(Video vd)
        {
            DBContext.Videos.Add(vd);
            DBContext.SaveChanges();
        }

        public void UpdateVideo(Video vd)
        {
            Video vdupdate = DBContext.Videos.FirstOrDefault(x => x.ID == vd.ID);
            vdupdate.Title = vd.Title;
            vdupdate.Description = vd.Description;
            vdupdate.PublicationData = vd.PublicationData;
            DBContext.SaveChanges();
        }

        public void DeleteVideo(Video vd)
        {
            Video vdToDelete = DBContext.Videos.FirstOrDefault(x => x.ID == vd.ID);
            DBContext.Videos.Remove(vdToDelete);
            DBContext.SaveChanges();
        }
    }
}
