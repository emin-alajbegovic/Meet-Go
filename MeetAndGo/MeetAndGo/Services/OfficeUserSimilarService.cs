using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetAndGo.Services
{
    public class OfficeUserSimilarService : ISimilarOffice
    {
        protected readonly meetGoContext _dbContext;
        protected readonly IMapper _mapper;

        public OfficeUserSimilarService(meetGoContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        Dictionary<int, List<Database.OfficeReview>> offices = new Dictionary<int, List<Database.OfficeReview>>();

        public List<Model.Office> GetAll(int id)
        {
            LoadProducts(id);
            List<Database.OfficeReview> ratingsOfObservedOffices = _dbContext.OfficeReview.Where(x => x.OfficeId == id).OrderBy(x => x.UserId).ToList();

            List<Database.OfficeReview> commonMarks1 = new List<Database.OfficeReview>();
            List<Database.OfficeReview> commonMarks2 = new List<Database.OfficeReview>();


            List<Database.Office> recommendedOffices = new List<Database.Office>();

            foreach (var item in offices)
            {
                foreach (Database.OfficeReview o in ratingsOfObservedOffices)
                {
                    if (item.Value.Where(x => x.UserId == o.UserId).Count() > 0)
                    {
                        commonMarks1.Add(o);
                        commonMarks2.Add(item.Value.Where(x => x.UserId == o.UserId).First());
                    }
                }

                double similarity = GetSimilarity(commonMarks1, commonMarks2);

                if (similarity > 0.5)
                {
                    recommendedOffices.Add(_dbContext.Office.Where(x => x.OfficeId == item.Key).FirstOrDefault());
                }
                commonMarks1.Clear();
                commonMarks2.Clear();
            }

            return _mapper.Map<List<Model.Office>>(recommendedOffices);

            throw new System.NotImplementedException();
        }
        private double GetSimilarity(List<Database.OfficeReview> commonMarks1, List<Database.OfficeReview> commonMarks2)
        {

            if (commonMarks1.Count != commonMarks2.Count)
            {
                return 0;
            }

            double counter = 0, denominator1 = 0, denominator2 = 0;

            for (int i = 0; i < commonMarks1.Count; i++)
            {
                counter += double.Parse(commonMarks1[i].Mark.ToString()) * double.Parse(commonMarks2[i].Mark.ToString());
                denominator1 += double.Parse(commonMarks1[i].Mark.ToString()) * double.Parse(commonMarks1[i].Mark.ToString());
                denominator2 += double.Parse(commonMarks2[i].Mark.ToString()) * double.Parse(commonMarks2[i].Mark.ToString());
            }

            denominator1 = Math.Sqrt(denominator1);
            denominator2 = Math.Sqrt(denominator2);

            double counter1 = denominator1 * denominator2;

            if (counter1 == 0)
            {
                return 0;
            }
            return counter / counter1;
        }

        private void LoadProducts(int id)
        {
            Database.Office office = _dbContext.Office.Find(id);

            if (office == null)
            {
                return;
            }

            List<Database.Office> listOfSimilarOffices = _dbContext.Office.Where(x => x.Rented == false && x.OfficeId != id).ToList();

            List<Database.OfficeReview> marks;

            foreach (Database.Office office1 in listOfSimilarOffices)
            {
                marks = _dbContext.OfficeReview.Where(x => x.OfficeId == office1.OfficeId).OrderBy(x => x.UserId).ToList();
                if (marks.Count > 0)
                {
                    offices.Add(office1.OfficeId, marks);
                }
            }
        }
    }
}