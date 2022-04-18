using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetAndGo.Services
{
    public class BuildingUserSimilarService : ISimilarBuilding
    {
        protected readonly meetGoContext _dbContext;
        protected readonly IMapper _mapper;

        public BuildingUserSimilarService(meetGoContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        Dictionary<int, List<Database.BuildingReview>> buildings = new Dictionary<int, List<Database.BuildingReview>>();

        public List<Model.Building> GetAll(int id)
        {
            LoadProducts(id);
            List<Database.BuildingReview> ratingsOfObservedBuildings = _dbContext.BuildingReview.Where(x => x.BuildingId == id).OrderBy(x => x.UserId).ToList();

            List<Database.BuildingReview> commonMarks1 = new List<Database.BuildingReview>();
            List<Database.BuildingReview> commonMarks2 = new List<Database.BuildingReview>();


            List<Database.Building> recommendedBuildings = new List<Database.Building>();

            foreach (var item in buildings)
            {
                foreach (Database.BuildingReview o in ratingsOfObservedBuildings)
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
                    recommendedBuildings.Add(_dbContext.Building.Where(x => x.BuildingId == item.Key).FirstOrDefault());
                }
                commonMarks1.Clear();
                commonMarks2.Clear();
            }

            return _mapper.Map<List<Model.Building>>(recommendedBuildings);

            throw new System.NotImplementedException();
        }
        private double GetSimilarity(List<Database.BuildingReview> commonMarks1, List<Database.BuildingReview> commonMarks2)
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
            Database.Building building = _dbContext.Building.Find(id);

            if (building == null)
            {
                return;
            }

            List<Database.Building> listOfSimilarBuildings = _dbContext.Building.Where(x => x.Rented == false && x.BuildingId != id).ToList();

            List<Database.BuildingReview> marks;

            foreach (Database.Building building1 in listOfSimilarBuildings)
            {
                marks = _dbContext.BuildingReview.Where(x => x.BuildingId == building1.BuildingId).OrderBy(x => x.UserId).ToList();
                if (marks.Count > 0)
                {
                    buildings.Add(building1.BuildingId, marks);
                }
            }
        }
    }
}
