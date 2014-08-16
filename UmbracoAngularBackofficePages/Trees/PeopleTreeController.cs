using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Trees;

namespace UmbracoAngularBackofficePages.Trees
{
    public class PeopleTreeController: TreeController
    {
        protected override Umbraco.Web.Models.Trees.MenuItemCollection GetMenuForNode(string id, System.Net.Http.Formatting.FormDataCollection queryStrings)
        {
            throw new NotImplementedException();
        }

        protected override Umbraco.Web.Models.Trees.TreeNodeCollection GetTreeNodes(string id, System.Net.Http.Formatting.FormDataCollection queryStrings)
        {
            throw new NotImplementedException();
        }
    }
}