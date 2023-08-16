using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.DataAccessLayer.EntityFramework
{
    public interface EfWriterDal:IGenericDal<Writer>,IWriterDal
    {

    }
}
