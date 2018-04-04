using MalMaalayak.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MalMaalayak.BL
{
 
    public class CoupleBL
    {
        MalMalayakDbEntities2 dbEntity = new MalMalayakDbEntities2();
        

        public IEnumerable<ClientDetailClassModel> GetCouple()
        {

            //retrive data as list
            var coupleList = (from cpl in dbEntity.ClientDetails

                              join gd in dbEntity.Genders on cpl.GenderId equals gd.GenderId
                              join cst in dbEntity.Casts on cpl.CapptId equals cst.CastId
                              join str in dbEntity.Stars on cpl.StarId equals str.StarId
                              where gd.GenderType=="Male"
                              
                              select new ClientDetailClassModel()
                              {
                                
                                 CastName=cst.CastName,
                                 Job=cpl.Job,
                                 StarName=str.StarName,
                                 GenderType=gd.GenderType

                             }).ToList();

        
            return coupleList;
                        
        }


        public IEnumerable<ClientDetailClassModel> GetCoupleFemale()
        {

            // ClientDetailClassModel clientObj = new ClientDetailClassModel();


            //retrive data as list


            var coupleList = (from cpl in dbEntity.ClientDetails

                              join gd in dbEntity.Genders on cpl.GenderId equals gd.GenderId
                              join cst in dbEntity.Casts on cpl.CapptId equals cst.CastId
                              join str in dbEntity.Stars on cpl.StarId equals str.StarId
                              where gd.GenderType == "Female"

                              select new ClientDetailClassModel()
                              {

                                  CastName = cst.CastName,
                                  Job = cpl.Job,
                                  StarName = str.StarName,
                                  GenderType = gd.GenderType

                              }).ToList();


            return coupleList;

        }

        public IEnumerable<ClientDetailClassModel> GetMoreDetail()
        {


            return null;
        }


    }
}