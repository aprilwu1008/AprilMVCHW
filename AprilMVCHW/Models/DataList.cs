using System.Collections;

namespace AprilMVCHW.Models
{
    public class DataList
    {
        public ArrayList list = new ArrayList();

        public DataList()
        {
            for (int i = 1; i <= 50; i++)
            {
                var data = new Data();
                data.id = i;
                list.Add(data);
            }
        }
    }
}