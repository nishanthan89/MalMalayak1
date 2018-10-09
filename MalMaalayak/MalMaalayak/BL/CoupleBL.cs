using MalMaalayak.Constants;
using MalMaalayak.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MalMaalayak.Constants.ConstantDetail;

namespace MalMaalayak.BL
{
 
    public class CoupleBL
    {
        MalMalayakDbEntities2 db = new MalMalayakDbEntities2();


        public IEnumerable<ClientDetailClassModel> GetAllDetails()
        {

            //retrive data as list
            var coList = (from cpl in db.ClientDetails
                          join cnt in db.ContactDetails on cpl.Id equals cnt.ClientId
                          join jd in db.JothidaDetails on cpl.Id equals jd.ClientId
                          join bd in db.BirthDetails on jd.ClientId equals bd.ClientId


                          select new ClientDetailClassModel()
                              {
                              Id=cpl.Id,
                                  GenderType = (Gender)cpl.Gender,
                                  Lagna = (Lagna)jd.Lagna,
                                  Star= (Star)jd.StarId,
                                  Job = cpl.Job,
                                  //Residence=bd.r
                                 

                              }).ToList();


            return coList;

        }


        public IEnumerable<ClientDetailClassModel> GetMale()
        {

            //retrive data as list
            var coupleList = (from cpl in db.ClientDetails
                              join cnt in db.ContactDetails on cpl.Id equals cnt.ClientId
                              join jd in db.JothidaDetails on cpl.Id equals jd.ClientId
                              join bd in db.BirthDetails on jd.ClientId equals bd.ClientId
                              where cpl.Gender==1 //male
                              
                              select new ClientDetailClassModel()
                              {
                                  GenderType = (Gender)cpl.Gender,
                                  Lagna = (Lagna)jd.Lagna,
                                  StarName = (Star)jd.StarId,
                                  Job = cpl.Job,

                              }).ToList();

        
            return coupleList;
                        
        }


        public IEnumerable<ClientDetailClassModel> GetFemale()
        {

            // ClientDetailClassModel clientObj = new ClientDetailClassModel();


            //retrive data as list


            var coupleList = (from cpl in db.ClientDetails
                              join cnt in db.ContactDetails on cpl.Id equals cnt.ClientId
                              join jd in db.JothidaDetails on cpl.Id equals jd.ClientId
                              join bd in db.BirthDetails on jd.ClientId equals bd.ClientId
                              where cpl.Gender == 2 //female
                              //where gd.GenderType == "Female"

                              select new ClientDetailClassModel()
                              {

                                  GenderType = (Gender)cpl.Gender,
                                  Lagna = (Lagna)jd.Lagna,
                                  Star = (Star)jd.StarId,
                                  Job = cpl.Job,

                              }).ToList();


            return coupleList;

        }

        public IEnumerable<ClientDetailClassModel> GetMoreDetail()
        {


            return null;
        }

        public void CoupleRegister(CoupleRegisterModel modelData, HttpPostedFileBase UploadLagna, HttpPostedFileBase UploadNawamsa)
        {
            // db.ClientDetails clientDetails = null;
            //ClientDetail entity = null;
            if (modelData.Id == 0)
            {
                var clientetail = new ClientDetail()
                {
                    NIC = modelData.NIC,
                    FirstName = modelData.FirstName,
                    LastName = modelData.LastName,
                    Gender = (int)modelData.GenderType,
                    Cast = (int)modelData.CasteName,
                    Religion = (int)modelData.Religion,
                    Job = modelData.Job,
                    Height = modelData.Height,
                    Qualification = (int)modelData.Qualification,
                    Expectation = (int)modelData.Expectation


                };

                var jothidaDetail = new JothidaDetail()
                {
                    ClientId = modelData.Id,
                    Lagna = (int)modelData.Lagna,
                    StarId = (int)modelData.StarName,
                    Paavam = modelData.Paavam,
                    LagnaChart = ConvertToBytes(UploadLagna),
                    NavamsaChart = ConvertToBytes(UploadNawamsa)

            };

                var birthDetail = new BirthDetail()
                {
                    ClientId = modelData.Id,
                    DOB = modelData.BirthOfDate,
                    BirthPlace = modelData.BirthPlace,
                    BirthTime = modelData.BirthTime,
                    FartherPlace = modelData.FartherPlace,
                    MotherPlace = modelData.MotherPlace,

                };

                var contact = new ContactDetail()
                {
                   // NIC = modelData.NIC,
                   ClientId=modelData.Id,
                    Address = modelData.Address,
                    Residence = modelData.Residence,
                    PhoneHome = modelData.HomePhone,
                    PhoneMobile = modelData.MobileNo,
                    Email = modelData.Email,
                    Country = (int)modelData.Country

                };

                db.ClientDetails.Add(clientetail);
                db.JothidaDetails.Add(jothidaDetail);
                db.BirthDetails.Add(birthDetail);
                db.ContactDetails.Add(contact);
                //db.SaveChanges();


            }
            else
            {
                //entity = _db.Resources.Where(x => x.ResourceID == resourceDetails.ResourceID).FirstOrDefault();
                var entity = db.ClientDetails.Where(x => x.Id == modelData.Id).FirstOrDefault();


                entity.NIC = modelData.NIC;
                entity.FirstName = modelData.FirstName;
                entity.LastName = modelData.LastName;
                entity.Gender = (int)modelData.GenderType;
                entity.Cast = (int)modelData.CasteName;
                entity.Religion = (int)modelData.Religion;
                entity.Job = modelData.Job;
                entity.Height = modelData.Height;
                entity.Qualification = (int)modelData.Qualification;
                entity.Expectation = (int)modelData.Expectation;

                var entity1 = db.JothidaDetails.Where(x => x.ClientId == modelData.Id).FirstOrDefault();

               
                entity1.Lagna = (int)modelData.Lagna;
                entity1.StarId = (int)modelData.StarName;
                entity1.Paavam = modelData.Paavam;
                entity1.LagnaChart = modelData.LagnaChart;
                entity1.NavamsaChart = modelData.NavamsaChart;



                    var entity2 = db.BirthDetails.Where(x => x.ClientId == modelData.Id).FirstOrDefault();
               
                entity2.DOB = modelData.BirthOfDate;
                entity2.BirthPlace = modelData.BirthPlace;
                entity2.BirthTime = modelData.BirthTime;
                entity2.FartherPlace = modelData.FartherPlace;
                entity2.MotherPlace = modelData.MotherPlace;



                    var entity3 = db.ContactDetails.Where(x => x.ClientId == modelData.Id).FirstOrDefault();
               
                entity3.Address = modelData.Address;
                entity3.Residence = modelData.Residence;
                entity3.PhoneHome = modelData.HomePhone;
                entity3.PhoneMobile = modelData.MobileNo;
                entity3.Email = modelData.Email;
                entity3.Country = (int)modelData.Country;






            }


            //if (UploadLagna != null || UploadNawamsa != null)
            //{
            //    JothidaDetail chartModel = new JothidaDetail();
            //    if (UploadLagna.ContentType == "image/jpeg" || UploadLagna.ContentType == "image/png" || UploadLagna.ContentType == "image/gif" || UploadNawamsa.ContentType == "image/jpeg" || UploadNawamsa.ContentType == "image/png" || UploadNawamsa.ContentType == "image/gif")
            //    {
            //        chartModel.PhotoType = UploadLagna.ContentType;
            //        chartModel.LagnaChart = ConvertToBytes(UploadLagna);

            //        chartModel.PhotoType = UploadLagna.ContentType;
            //        chartModel.NavamsaChart = ConvertToBytes(UploadNawamsa);
            //    }
            //    else
            //    {
            //        //emsg = "ImageType Should Be 'jpeg' Or 'png' Or 'gif' ";
            //        //return false;
            //    }
            //}

            //db.ClientDetails.Add(clientetail);
            //db.JothidaDetails.Add(jothidaDetail);
            //db.BirthDetails.Add(birthDetail);
            //db.ContactDetails.Add(contact);
            db.SaveChanges();
            
        }

        private byte[] ConvertToBytes(HttpPostedFileBase uploadFile)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(uploadFile.InputStream);
            imageBytes = reader.ReadBytes((int)uploadFile.ContentLength);
            return imageBytes;
        }

        public IEnumerable<CoupleRegisterModel> ViewAllClientData()
        {

            //retrive data as list
            var coList = (from cpl in db.ClientDetails
                          join cnt in db.ContactDetails on cpl.Id equals cnt.ClientId
                          join jd in db.JothidaDetails on cpl.Id equals jd.ClientId
                          join bd in db.BirthDetails on jd.ClientId equals bd.ClientId


                          select new CoupleRegisterModel()
                          {
                             // GenderType = cpl.Gender,
                             // Lagna = jd.Lagna,
                             // Star = jd.Star,
                              Id=cpl.Id,
                              Job = cpl.Job,
                              FirstName=cpl.FirstName,
                              LastName=cpl.LastName,
                              NIC=cpl.NIC,
                              Residence=cnt.Residence
                              //Residence=bd.r


                          }).ToList();


            return coList;
        }

        public CoupleRegisterModel GetClientDetail(long id)
        {
            CoupleRegisterModel clientDetails = (from cpl in db.ClientDetails
                                                 join cnt in db.ContactDetails on cpl.Id equals cnt.ClientId
                                                 join jd in db.JothidaDetails on cpl.Id equals jd.ClientId
                                                 join bd in db.BirthDetails on jd.ClientId equals bd.ClientId
                                                 where id == cpl.Id


                                                 select new CoupleRegisterModel()
                                                 {
                                                     Id = cpl.Id,
                                                     NIC = cpl.NIC.ToString(),
                                                     FirstName = cpl.FirstName,
                                                     LastName = cpl.LastName,
                                                     Height = cpl.Height,
                                                     Job = cpl.Job,

                                                     BirthOfDate = (DateTime)bd.DOB,
                                                     BirthPlace = bd.BirthPlace,
                                                     BirthTime = bd.BirthTime,
                                                     FartherPlace = bd.FartherPlace,
                                                     MotherPlace = bd.MotherPlace,

                                                     Address = cnt.Address,
                                                     Residence = cnt.Residence,
                                                     MobileNo = cnt.PhoneMobile,
                                                     HomePhone = cnt.PhoneHome,
                                                     Email = cnt.Email,

                                                     Paavam = jd.Paavam,

                                                     GenderType =(ConstantDetail.Gender)cpl.Gender,
                                                     StarName = (ConstantDetail.Star)jd.StarId,
                                                     CasteName = (ConstantDetail.Caste)cpl.Cast,
                                                     Lagna = (ConstantDetail.Lagna)jd.Lagna,
                                                     Religion = (ConstantDetail.Religion)cpl.Religion,
                                                     Expectation = (ConstantDetail.Expectation)cpl.Expectation,
                                                     Country = (ConstantDetail.Country)cnt.Country,
                                                     Qualification = (ConstantDetail.Qualification)cpl.Qualification,





                                                 }).FirstOrDefault();
            return clientDetails;

        }


        public JsonResult DeleteClientDetail(long id)
        {


            //var studentbyid = objContext.tbl_Students.Where(x => x.id == studentid).FirstOrDefault();
            var data = db.JothidaDetails.Where(x => x.ClientId == id).FirstOrDefault();
            var data1 = db.ContactDetails.Where(x => x.ClientId == id).FirstOrDefault();
            var data2 = db.BirthDetails.Where(x => x.ClientId == id).FirstOrDefault();
            var data3 = db.ClientDetails.Where(x => x.Id == id).FirstOrDefault();

            if (data3 != null)
            {
                db.Entry(data).State = EntityState.Deleted;
                db.Entry(data1).State = EntityState.Deleted;
                db.Entry(data2).State = EntityState.Deleted;
                db.Entry(data3).State = EntityState.Deleted;
                db.SaveChanges();

            }

            return null;


        }

           


    }
}