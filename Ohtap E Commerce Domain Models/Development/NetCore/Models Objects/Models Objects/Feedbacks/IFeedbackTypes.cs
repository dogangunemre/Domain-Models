using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.Feedbacks
{
    public interface IFeedbackTypes
    {
        public FeedbackTypes Type { get; set; }
    }
    public enum FeedbackTypes
    {
        Like,
        Dislike,
        Comment,
        Point
    }
}
