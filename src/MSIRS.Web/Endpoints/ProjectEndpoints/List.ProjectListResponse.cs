using System.Collections.Generic;
using MSIRS.Core.ProjectAggregate;

namespace MSIRS.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
