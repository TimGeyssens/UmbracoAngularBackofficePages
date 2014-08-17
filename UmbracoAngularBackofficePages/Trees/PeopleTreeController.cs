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
using UmbracoAngularBackofficePages.Controllers;

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
                var ctrl = new PersonApiController();
                var nodes = new TreeNodeCollection();

                foreach (var person in ctrl.GetAll())
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
            var menu = new MenuItemCollection();

            if (id == Constants.System.Root.ToInvariantString())
            {
                // root actions              
                menu.Items.Add<CreateChildEntity, ActionNew>(ui.Text("actions", ActionNew.Instance.Alias));
                menu.Items.Add<RefreshNode, ActionRefresh>(ui.Text("actions", ActionRefresh.Instance.Alias), true);
                return menu;
            }
            else
            {
                
                menu.Items.Add< ActionDelete>(ui.Text("actions", ActionDelete.Instance.Alias));
                
            }
            return menu;
        }
    }
}