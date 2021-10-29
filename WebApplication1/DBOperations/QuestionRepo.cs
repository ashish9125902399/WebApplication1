using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Controllers;

namespace WebApplication1.DBOperations
{
    public class QuestionRepo
    {
        string type ="";
        public string GetUserType(string email)
        {
            
            using (var context = new GKHUBEntities())
            {
                var result = context.Logins.FirstOrDefault(x=>x.Email==email);
                type = result.Type;
            }
            return type;
        }

        public PracticeModel GetPhyQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Physics.
                    Where(x=>x.QID==id)
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).FirstOrDefault();
                return result;
            }
        }
        public PracticeModel GetChemQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Chemistries.
                    Where(x => x.QID == id)
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).FirstOrDefault();
                return result;
            }
        }
        public PracticeModel GetBioQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Biologies.
                    Where(x => x.QID == id)
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).FirstOrDefault();
                return result;
            }
        }
        public PracticeModel GetHisQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Histories.
                    Where(x => x.QID == id)
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).FirstOrDefault();
                return result;
            }
        }
        public PracticeModel GetGeoQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Geographies.
                    Where(x => x.QID == id)
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).FirstOrDefault();
                return result;
            }
        }
        public PracticeModel GetPolityQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Polities.
                    Where(x => x.QID == id)
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).FirstOrDefault();
                return result;
            }
        }

        public List<PracticeModel> GetPhysics()
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Physics
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,
                        
                    }).ToList();
                return result;
            }
        }
        public List<PracticeModel> GetChemistry()
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Chemistries
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).ToList();
                return result;
            }
        }
        public List<PracticeModel> GetBiology()
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Biologies
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).ToList();
                return result;
            }
        }
        public List<PracticeModel> GetHistory()
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Histories
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).ToList();
                return result;
            }
        }
        public List<PracticeModel> GetGeography()
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Geographies
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).ToList();
                return result;
            }
        }
        public List<PracticeModel> GetPolity()
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Polities
                    .Select(x => new PracticeModel()
                    {
                        QID = x.QID,
                        Question = x.Question,
                        A = x.A,
                        B = x.B,
                        C = x.C,
                        D = x.D,
                        RightAns = x.RightAns,

                    }).ToList();
                return result;
            }
        }
        public int AddPhysics(PracticeModel model)
        {            
            using (var context = new GKHUBEntities())
            {                
                Physic phy = new Physic() 
                {                   
                    QID = model.QID,
                    Question = model.Question,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAns = model.RightAns,
                };
                context.Physics.Add(phy);
                context.SaveChanges();
                return phy.QID;
            }
        }
        public int AddChemistry(PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {
                Chemistry che = new Chemistry()
                {
                    QID = model.QID,
                    Question = model.Question,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAns = model.RightAns,
                };
                context.Chemistries.Add(che);
                context.SaveChanges();
                return che.QID;
            }
        }
        public int AddBiology(PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {
                Biology phy = new Biology()
                {
                    QID = model.QID,
                    Question = model.Question,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAns = model.RightAns,
                };
                context.Biologies.Add(phy);
                context.SaveChanges();
                return phy.QID;
            }
        }
        public int AddHistory(PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {
                History phy = new History()
                {
                    QID = model.QID,
                    Question = model.Question,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAns = model.RightAns,
                };
                context.Histories.Add(phy);
                context.SaveChanges();
                return phy.QID;
            }
        }
        public int AddPolity(PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {
                Polity phy = new Polity()
                {
                    QID = model.QID,
                    Question = model.Question,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAns = model.RightAns,
                };
                context.Polities.Add(phy);
                context.SaveChanges();
                return phy.QID;
            }
        }
        public int AddGeography(PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {
                Geography phy = new Geography()
                {
                    QID = model.QID,
                    Question = model.Question,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAns = model.RightAns,
                };
                context.Geographies.Add(phy);
                context.SaveChanges();
                return phy.QID;
            }
        }
        public int AddEconomic(PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {
                Economic phy = new Economic()
                {
                    QID = model.QID,
                    Question = model.Question,
                    A = model.A,
                    B = model.B,
                    C = model.C,
                    D = model.D,
                    RightAns = model.RightAns,
                };
                context.Economics.Add(phy);
                context.SaveChanges();
                return phy.QID;
            }
        }                 
         
        public bool UpdatePhyQ(int id, PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {
                
                var result = context.Physics.FirstOrDefault(x => x.QID == id);
                    
                
                if (result != null)
                {
                    result.QID = model.QID;
                    result.Question = model.Question;
                    result.A = model.A;
                    result.B = model.B;
                    result.C = model.C;
                    result.D = model.D;
                    result.RightAns = model.RightAns;
                }        
                context.SaveChanges();
                return true;
            }
        }
        
        public bool UpdateChemQ(int id, PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {

                var result = context.Chemistries.FirstOrDefault(x => x.QID == id);


                if (result != null)
                {
                    result.QID = model.QID;
                    result.Question = model.Question;
                    result.A = model.A;
                    result.B = model.B;
                    result.C = model.C;
                    result.D = model.D;
                    result.RightAns = model.RightAns;
                }
                context.SaveChanges();
                return true;
            }
        }
        public bool UpdateBioQ(int id, PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {

                var result = context.Biologies.FirstOrDefault(x => x.QID == id);


                if (result != null)
                {
                    result.QID = model.QID;
                    result.Question = model.Question;
                    result.A = model.A;
                    result.B = model.B;
                    result.C = model.C;
                    result.D = model.D;
                    result.RightAns = model.RightAns;
                }
                context.SaveChanges();
                return true;
            }
        }
        public bool UpdateHisQ(int id, PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {

                var result = context.Histories.FirstOrDefault(x => x.QID == id);


                if (result != null)
                {
                    result.QID = model.QID;
                    result.Question = model.Question;
                    result.A = model.A;
                    result.B = model.B;
                    result.C = model.C;
                    result.D = model.D;
                    result.RightAns = model.RightAns;
                }
                context.SaveChanges();
                return true;
            }
        }
        public bool UpdateGeoQ(int id, PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {

                var result = context.Geographies.FirstOrDefault(x => x.QID == id);


                if (result != null)
                {
                    result.QID = model.QID;
                    result.Question = model.Question;
                    result.A = model.A;
                    result.B = model.B;
                    result.C = model.C;
                    result.D = model.D;
                    result.RightAns = model.RightAns;
                }
                context.SaveChanges();
                return true;
            }
        }
        public bool UpdatePolityQ(int id, PracticeModel model)
        {
            using (var context = new GKHUBEntities())
            {

                var result = context.Polities.FirstOrDefault(x => x.QID == id);


                if (result != null)
                {
                    result.QID = model.QID;
                    result.Question = model.Question;
                    result.A = model.A;
                    result.B = model.B;
                    result.C = model.C;
                    result.D = model.D;
                    result.RightAns = model.RightAns;
                }
                context.SaveChanges();
                return true;
            }
            
        }

        public bool DeletePhyQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Physics.FirstOrDefault(x => x.QID == id);

                if (result != null)
                {
                    context.Physics.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        public bool DeleteChemQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Chemistries.FirstOrDefault(x => x.QID == id);

                if (result != null)
                {
                    context.Chemistries.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        public bool DeleteBioQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Biologies.FirstOrDefault(x => x.QID == id);

                if (result != null)
                {
                    context.Biologies.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        public bool DeleteHisQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Histories.FirstOrDefault(x => x.QID == id);

                if (result != null)
                {
                    context.Histories.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        public bool DeleteGeoQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Geographies.FirstOrDefault(x => x.QID == id);

                if (result != null)
                {
                    context.Geographies.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        public bool DeletePolityQ(int id)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Polities.FirstOrDefault(x => x.QID == id);

                if (result != null)
                {
                    context.Polities.Remove(result);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

        }
        
    }
}