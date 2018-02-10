using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Manager
{
    public class IssueService
    {
        public int NewIssue(Issue issue)
        {
            int rows = 0;
            using (var ctx = new UckLibMgrDbEntities())
            {
                ctx.Issues.Add(issue);
                rows = ctx.SaveChanges();
            }
            return rows;
        }

        public Issue FIndById(int issueId)
        {
            Issue bookIssue = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var i = ctx.Issues.Where(iss => iss.IssueId == issueId);
                if (i != null)
                {
                    bookIssue = (Issue)i.ToList().FirstOrDefault();
                }
            }
            return bookIssue;
        }
        public int UpdateIssue(Issue issue)
        {
            int rows = 0;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var i = ctx.Issues.Where(iss => iss.IssueId == issue.IssueId).ToList().FirstOrDefault();
                i.IssueDate = issue.IssueDate;
                i.ModifiedDate = issue.ModifiedDate;
            }
            return rows;
        }
    }
}
