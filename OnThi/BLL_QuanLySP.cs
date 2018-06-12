using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    public class BLL_QuanLySP
    {
        ThiASPEntities db = null;
        public BLL_QuanLySP()
        {
            db = new ThiASPEntities();
        }

        public List<tblCat> GetDanhSachDM()
        {
            return db.tblCats.ToList(); 
        }
        public List<tblPro> GetSPWithIDCat(int catID)
        {
            return db.tblProes.Where(x => x.CatID == catID).ToList();
        }
        public List<DT0_SP_DM> GetSPVsCat(int catID)
        {

            var model = db.tblProes.Join(db.tblCats,
                           pro => pro.CatID,
                           cat => cat.CatID,
                           (pro, cat) => new DT0_SP_DM()
                           {       
                               ProID = pro.ProID,
                               ProName = pro.ProName,
                               ProDescription = pro.ProDescription,
                               CatID = pro.CatID,
                               CatName = cat.CatName
                           }
                );
            return model.Where(x=>x.CatID == catID).ToList();           
        }
        public List<tblPro> GetDSSP()
        {
            return db.tblProes.ToList();
        }
        public int GetCatID(string nameCat)
        {
            return db.tblCats.Where(x=>x.CatName == nameCat).Single().CatID;
        }
        public int AddProduct(tblPro pro)
        {
            db.tblProes.Add(pro);
            db.SaveChanges();
            return pro.ProID;
        }
        public bool Edit(tblPro pro)
        {
            try
            {
                var model = db.tblProes.Find(pro.ProID);
                    model.ProName = pro.ProName;
                    model.ProDescription = pro.ProDescription;
                    model.CatID = pro.CatID;
                    db.SaveChanges();
                    return true;
           
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(int proid)
        {
            try
            {
                var model = db.tblProes.Find(proid);
                db.tblProes.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
    }
   
}
