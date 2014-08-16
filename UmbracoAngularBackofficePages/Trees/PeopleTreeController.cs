using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco;
using umbraco.BusinessLogic.Actions;
using Umbraco.Core;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;

namespace UmbracoAngularBackofficePages.Trees
{
    [Tree("settings", "peopleTree", "People")]
    [PluginController("Example")]
    public class PeopleTreeController: TreeController
    {
        

        protected override Umbraco.Web.Models.Trees.TreeNodeCollection GetTreeNodes(string id, System.Net.Http.Formatting.FormDataCollection queryStrings)
        {
            //check if we're rendering the root node's children
            if (id == Constants.System.Root.ToInvariantString())
            {
                
                var nodes = new TreeNodeCollection();

                foreach (var person in Data.GetAll())
                {
                    var node = CreateTreeNode(
                        person.Id.ToString(),
                        "-1", 
                        queryStrings, 
                        person.ToString(), 
                        "icon-user", 
                        false);

                    nodes.Add(node);

                }
                return nodes;
            }

            //this tree doesn't suport rendering more than 1 level
            throw new NotSupportedException();
        }

        protected override Umbraco.Web.Models.Trees.MenuItemCollection GetMenuForNode(string id, System.Net.Http.Formatting.FormDataCollection queryStrings)
        {
            return new MenuItemCollection();
        }
    }
}