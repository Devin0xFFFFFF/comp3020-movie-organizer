using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class ReviewManager
    {
        public static List<FormError> createReview(string rauthor, string rmovie, string rtitle, string rcontent)
        {
            List<FormError> errors = new List<FormError>();

            Review review = new Review() { ID = DataAccess.generateID(),
                author = rauthor, movie = rmovie, title = rtitle, content = rcontent,
            createdAt = DateTime.Now, lastEdited = DateTime.Now};

            if (review.valid(errors))
            {
                List<Review> reviews = DataAccess.readReviews();
                reviews.Add(review);
                DataAccess.writeReviews(reviews);
            }

            return errors;
        }

        public static List<Review> getReviewsByAuthor(string author)
        {
            List<Review> reviews = DataAccess.readReviews();
            int i = reviews.Count - 1;

            while (i >= 0)
            {
                if(reviews.ElementAt(i).author == null || !reviews.ElementAt(i).author.Equals(author))
                {
                    reviews.RemoveAt(i);
                }
                i--;
            }

            return reviews;
        }

        public static List<Review> getReviewsByMovie(string movie)
        {
            List<Review> reviews = DataAccess.readReviews();
            int i = reviews.Count - 1;

            while (i >= 0)
            {
                if (reviews.ElementAt(i).movie == null || !reviews.ElementAt(i).movie.Equals(movie))
                {
                    reviews.RemoveAt(i);
                }
                i--;
            }

            return reviews;
        }

        public static Review editReview(long ID)
        {
            List<Review> reviews = DataAccess.readReviews();
            Review review = null;
            int i = 0;

            while (i < reviews.Count && review == null)
            {
                if (reviews.ElementAt(i).ID == ID)
                {
                    review = reviews.ElementAt(i);
                }
                i++;
            }

            return review;
        }

        public static bool saveReview(Review review)
        {
            List<Review> reviews = DataAccess.readReviews();
            int i = 0;

            while (i < reviews.Count && reviews.ElementAt(i).ID != review.ID)
            {
                i++;
            }

            if(i < reviews.Count)
            {
                reviews.ElementAt(i).title = review.title;
                reviews.ElementAt(i).content = review.content;
                reviews.ElementAt(i).lastEdited = DateTime.Now;

                DataAccess.writeReviews(reviews);

                return true;
            }

            return false;
        }

        public static bool destroyReview(long ID)
        {
            List<Review> reviews = DataAccess.readReviews();
            int i = 0;
            bool removed = false;

            while(i < reviews.Count && !removed)
            {
                if(reviews.ElementAt(i).ID == ID)
                {
                    reviews.RemoveAt(i);
                    removed = true;
                }

                i++;
            }

            return removed;
        }

        public static List<Review> getReviews(List<Review> reviews, int amt)
        {
            List<Review> revs = new List<Review>();
            int i;

            for (i = 0; i <= amt && i < reviews.Count; i++)
            {
                revs.Add(reviews.ElementAt(i));
            }

            return revs;
        }

        public static void sortByDateTime(List<Review> reviews)
        {
            reviews.Sort(delegate (Review x, Review y)
            {
                return y.createdAt.CompareTo(x.createdAt);
            });
        }
    }
}
