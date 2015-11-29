using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class Review
    {
        public static int MAX_RATING_LENGTH = 50;
        public static int MAX_CONTENT_LENGTH = 500;

        public long ID { get; set; }

        public string author { get; set; }
        public string movie { get; set; }

        public string rating { get; set; }
        public string content { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime lastEdited { get; set; }

        public bool valid(List<FormError> errors)
        {
            int errs = errors.Count;

            ID = DataAccess.validateReviewID(ID);

            if(ID == -1)
            {
                errors.Add(new FormError() { err_code = "IDCONFLICT", err_msg = "Cannot create review at this time." });
            }

            if(rating.Length < 1)
            {
                errors.Add(new FormError() { err_code = "NORATING", err_msg = "No Rating Given" });
            }

            if (content.Length > MAX_CONTENT_LENGTH)
            {
                errors.Add(new FormError() { err_code = "CONTENTLEN", err_msg = "Content too long (" + content.Length + "/" + MAX_CONTENT_LENGTH + ")." });
            }
            else if (content.Length < 1)
            {
                errors.Add(new FormError() { err_code = "CONTENTLEN", err_msg = "Content too short (" + content.Length + "/" + MAX_CONTENT_LENGTH + ")." });
            }

            //may add verification for author, movie

            return errs == errors.Count;
        }

        public bool valid(List<FormError> errors, bool NOIDCHECK)
        {
            int errs = errors.Count;

            if (content.Length > MAX_CONTENT_LENGTH)
            {
                errors.Add(new FormError() { err_code = "CONTENTLEN", err_msg = "Content too long (" + content.Length + "/" + MAX_CONTENT_LENGTH + ")." });
            }

            //may add verification for author, movie

            return errs == errors.Count;
        }

        public int getRatingValue()
        {
            int i = 0;

            if(rating.Equals("Terrible"))
            {
                i = 1;
            }
            else if(rating.Equals("Bad"))
            {
                i = 2;
            }
            else if (rating.Equals("Okay"))
            {
                i = 3;
            }
            else if (rating.Equals("Good"))
            {
                i = 4;
            }
            else if (rating.Equals("Awesome"))
            {
                i = 5;
            }

            return i;
        }
    }
}
