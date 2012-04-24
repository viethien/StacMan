// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StackExchange.StacMan
{
    public partial class StacManClient : IFilterMethods
    {
        /// <summary>
        /// Stack Exchange API Filters methods
        /// </summary>
        public IFilterMethods Filters
        {
            get { return this; }
        }

        Task<StacManResponse<Filter>> IFilterMethods.Read(IEnumerable<string> filters, string filter = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateEnumerable(filters, "filters");

            var ub = new ApiUrlBuilder(String.Format("/filters/{0}", String.Join(";", filters)), useHttps: false);

            ub.AddParameter("filter", filter);

            return CreateApiTask<Filter>(ub, filterObj);
        }

        Task<StacManResponse<Filter>> IFilterMethods.Create(string filter = null, IEnumerable<string> include = null, IEnumerable<string> exclude = null, string @base = null, bool? @unsafe = null)
        {
            var filterObj = ValidateAndGetFilter(filter);


            var ub = new ApiUrlBuilder("/filters/create", useHttps: false);

            ub.AddParameter("filter", filter);
            ub.AddParameter("include", include);
            ub.AddParameter("exclude", exclude);
            ub.AddParameter("base", @base);
            ub.AddParameter("unsafe", @unsafe);

            return CreateApiTask<Filter>(ub, filterObj);
        }
    }

    public interface IFilterMethods
    {
        /// <summary>
        /// Decode a set of filters, useful for debugging purposes. (API Method: "/filters/{filters}")
        /// </summary>
        Task<StacManResponse<Filter>> Read(IEnumerable<string> filters, string filter = null);

        /// <summary>
        /// Create a new filter. (API Method: "/filters/create")
        /// </summary>
        Task<StacManResponse<Filter>> Create(string filter = null, IEnumerable<string> include = null, IEnumerable<string> exclude = null, string @base = null, bool? @unsafe = null);

    }
}

#pragma warning restore 1591