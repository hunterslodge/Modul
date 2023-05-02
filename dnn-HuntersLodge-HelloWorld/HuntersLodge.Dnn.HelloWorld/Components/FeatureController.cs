/*
' Copyright (c) 2023 Vasponik
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace Dnn.HuntersLodge.HuntersLodge.Dnn.HelloWorld.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for HuntersLodge.Dnn.HelloWorld
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<HuntersLodge.Dnn.HelloWorldInfo> colHuntersLodge.Dnn.HelloWorlds = GetHuntersLodge.Dnn.HelloWorlds(ModuleID);
        //if (colHuntersLodge.Dnn.HelloWorlds.Count != 0)
        //{
        //    strXML += "<HuntersLodge.Dnn.HelloWorlds>";

        //    foreach (HuntersLodge.Dnn.HelloWorldInfo objHuntersLodge.Dnn.HelloWorld in colHuntersLodge.Dnn.HelloWorlds)
        //    {
        //        strXML += "<HuntersLodge.Dnn.HelloWorld>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objHuntersLodge.Dnn.HelloWorld.Content) + "</content>";
        //        strXML += "</HuntersLodge.Dnn.HelloWorld>";
        //    }
        //    strXML += "</HuntersLodge.Dnn.HelloWorlds>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlHuntersLodge.Dnn.HelloWorlds = DotNetNuke.Common.Globals.GetContent(Content, "HuntersLodge.Dnn.HelloWorlds");
        //foreach (XmlNode xmlHuntersLodge.Dnn.HelloWorld in xmlHuntersLodge.Dnn.HelloWorlds.SelectNodes("HuntersLodge.Dnn.HelloWorld"))
        //{
        //    HuntersLodge.Dnn.HelloWorldInfo objHuntersLodge.Dnn.HelloWorld = new HuntersLodge.Dnn.HelloWorldInfo();
        //    objHuntersLodge.Dnn.HelloWorld.ModuleId = ModuleID;
        //    objHuntersLodge.Dnn.HelloWorld.Content = xmlHuntersLodge.Dnn.HelloWorld.SelectSingleNode("content").InnerText;
        //    objHuntersLodge.Dnn.HelloWorld.CreatedByUser = UserID;
        //    AddHuntersLodge.Dnn.HelloWorld(objHuntersLodge.Dnn.HelloWorld);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<HuntersLodge.Dnn.HelloWorldInfo> colHuntersLodge.Dnn.HelloWorlds = GetHuntersLodge.Dnn.HelloWorlds(ModInfo.ModuleID);

        //foreach (HuntersLodge.Dnn.HelloWorldInfo objHuntersLodge.Dnn.HelloWorld in colHuntersLodge.Dnn.HelloWorlds)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objHuntersLodge.Dnn.HelloWorld.Content, objHuntersLodge.Dnn.HelloWorld.CreatedByUser, objHuntersLodge.Dnn.HelloWorld.CreatedDate, ModInfo.ModuleID, objHuntersLodge.Dnn.HelloWorld.ItemId.ToString(), objHuntersLodge.Dnn.HelloWorld.Content, "ItemId=" + objHuntersLodge.Dnn.HelloWorld.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
