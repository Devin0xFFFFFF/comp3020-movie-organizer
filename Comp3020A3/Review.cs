using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class Review
    {
        public static int MAX_TITLE_LENGTH = 50;
        public static int MAX_CONTENT_LENGTH = 500;

        public long ID { get; set; }

        public string author { get; set; }
        public string movie { get; set; }

        public string title { get; set; }
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

            if (title.Length > MAX_TITLE_LENGTH)
            {
                errors.Add(new FormError() { err_code = "TITLELEN", err_msg = "Title too long (" + title.Length + "/" + MAX_TITLE_LENGTH + ")." });
            }

            if (content.Length > MAX_CONTENT_LENGTH)
            {
                errors.Add(new FormError() { err_code = "CONTENTLEN", err_msg = "Content too long (" + content.Length + "/" + MAX_CONTENT_LENGTH + ")." });
            }

            //may add verification for author, movie

            return errs == errors.Count;
        }
    }
}
