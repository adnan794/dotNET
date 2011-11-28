using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PluralSightMVC.Models
{
    
    public class FoodDb
    {
        private List<ResturantReview> _reviews;
        public FoodDb()
        {
            _reviews = new List<ResturantReview>();
            _reviews.Add(new ResturantReview{ id = 1, Name = "PizzaHut", Rating=8});
            _reviews.Add(new ResturantReview { id = 2, Name = "KFC", Rating = 9 });
            _reviews.Add(new ResturantReview { id = 3, Name = "PapaNoora", Rating = 10 });

        }
        public List<ResturantReview> getList()
        {
            return _reviews;
        }

        public object getById(int id)
        {
            foreach (var item in _reviews)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return _reviews[2];
        }

        public void addValue(ResturantReview value)
        {
            foreach (var item in _reviews)
            {
                if (item.id == value.id)
                {
                    item.Name = value.Name;
                    
                }
            }
        }

    }
}