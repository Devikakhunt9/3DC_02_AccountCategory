
using API_Consume.Areas.ACCategory.Models;
using API_Consume.BAL.ACC_AcountCategory;
using API_Consume.CF;
using API_Consume.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace API_Consume.Areas.ACCategory.Controllers
{
    [CheckAccess]
    [Area("ACCategory")]
    [Route("[Controller]/[action]")]
    public class ACC_AccountCategoryController : Controller
    {
        #region 10.0 Local Variables
        ACC_AccountCategoryrBAL balACC_AccountCategory = new ACC_AccountCategoryrBAL();
        #endregion 10.0 Local Variables

        #region Constructor
        #endregion Constructor

        #region List Page Methods

        #region 11.0 Page Load Event - Index - List Page
        public IActionResult Index()
        {
            FillDropDownList();
            return View();
        }
        #endregion

        #region Search Result
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _SearchResult(ACC_AccountCategoryModel modelACC_AccountCategory)
        {
            UserOperationRightsModel vUserOperationRightsModel = UserOperationRights.CheckForOperation(ControllerContext);
            ViewBag.UserOperationRights = vUserOperationRightsModel;

            #region 12.2 Set Default Value
            ViewBag.SearchResultHeaderText = CV.SearchResultHeaderText;

            modelACC_AccountCategory.F_PageNo = modelACC_AccountCategory.F_PageNo == null ? 1 : modelACC_AccountCategory.F_PageNo;
            modelACC_AccountCategory.F_PageSize = modelACC_AccountCategory.F_PageSize == null ? 25 : modelACC_AccountCategory.F_PageSize;
            #endregion 12.2 Set Default Value            

            //modelACC_AccountCategory.F_PageNo = 1;
            //modelACC_AccountCategory.F_PageSize = 25;

            var vChapterList = balACC_AccountCategory.dbo_PR_ACC_AccountCategory_SelectAll(modelACC_AccountCategory);

            PagedListPagerModel vPagedListPager = new PagedListPagerModel(vChapterList.First().TotalRecords, Convert.ToInt32(modelACC_AccountCategory.F_PageNo), Convert.ToInt32(modelACC_AccountCategory.F_PageSize));
            vPagedListPager.PageInfo = Pagination.GetPageInformation(vPagedListPager);
            vPagedListPager.PageSizeList = Pagination.GetPagedListPageSizes();

            var vModel = new Tuple<ACC_AccountCategoryModel, PagedListPagerModel, List<dbo_PR_ACC_AccountCategory_SelectAll_Result>>(modelACC_AccountCategory, vPagedListPager, vChapterList);

            return PartialView("_ACC_AccountCategoryList", vModel);
        }
        #endregion Search Result

        #region ExportExcel
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExportExcel(ACC_AccountCategoryModel modelACC_AccountCategory, int TotalRecords)
        {
            UserOperationRightsModel vUserOperationRightsModel = UserOperationRights.CheckForOperation(ControllerContext);
            ViewBag.UserOperationRights = vUserOperationRightsModel;

            //modelACC_AccountCategory.F_PageNo = 1;
            modelACC_AccountCategory.F_PageSize = TotalRecords;
            var vAccountCategoryList = balACC_AccountCategory.dbo_PR_ACC_AccountCategory_SelectAll(modelACC_AccountCategory);

            DataTable dt = EntityToDataTable.ConvertToDataTable(vAccountCategoryList);

            var contentType = "application/vnmodelACC_AccountCategory.openxmlformats-officedocument.spreadsheetml.sheet";
            var fileName = "AccountCategoryList.xlsx";

            return File(CommonFunctions.DownloadExcel(dt, "Chapter").ToArray(), contentType, fileName);
        }
        #endregion ExportExcel

        #region _Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Delete(int AccountCategoryID)
        {
            bool vReturen = balACC_AccountCategory.dbo_PR_ACC_AccountCategory_Delete(AccountCategoryID);
            return RedirectToAction("Index");
        }
        #endregion

        #endregion List Page Methods

        #region FillLabels
        private void FillLabels(ControllerContext controllerContext)
        {
            var CurrentArea = controllerContext.RouteData.Values["area"].ToString();
            var CurrentController = controllerContext.RouteData.Values["controller"].ToString();
            var CurrentAction = controllerContext.RouteData.Values["action"].ToString();
            ViewBag.lblAccountCategoryName = "Account Voucher";
        }
        #endregion FillLabels

        #region Fill DropDown List
        private void FillDropDownList()
        {
            ViewBag.AccountList = CommonFillMethods.FillDropDownListAccountID();
            ViewBag.AccountDocList = CommonFillMethods.FillDropDownListAccountDocID();
        }
        #endregion

        #region 11.0 Page Load Event - Add/Edit
        public IActionResult AddEdit(int? AccountCategoryID)
        {
            #region 11.2 IsAdd, IsEdit Rights
            UserOperationRightsModel vUserOperationRightsModel = UserOperationRights.CheckForOperation(ControllerContext);
            ViewBag.UserOperationRights = vUserOperationRightsModel;

            if (!vUserOperationRightsModel.IsAdd && !vUserOperationRightsModel.IsEdit)
            {
                return RedirectToAction("Index", "Error", new { Area = "" });
            }
            else if (vUserOperationRightsModel.IsAdd && !vUserOperationRightsModel.IsEdit && AccountCategoryID != null)
            {
                return RedirectToAction("Index", "Error", new { Area = "" });
            }
            else if (!vUserOperationRightsModel.IsAdd && vUserOperationRightsModel.IsEdit && AccountCategoryID == null)
            {
                return RedirectToAction("Index", "Error", new { Area = "" });
            }
            #endregion 11.2 IsAdd, IsEdit Rights    

            #region 11.2 Fill Lables
            FillLabels(ControllerContext);
            #endregion 11.2 Fill Lables            

            #region 11.3 Dropdown List Fill Section
            FillDropDownList();
            #endregion 11.3 Dropdown List Fill Section

            #region 11.4 Set Control Default Value
            ACC_AccountCategoryModel AccountCategoryModel = new ACC_AccountCategoryModel();
            #endregion 11.4 Set Control Default Value

            if (AccountCategoryID != null || AccountCategoryID > 0)
            {
                ViewBag.Action = "Edit";

                //var d = modelACC_AccountCategory.dbo_PR_ACC_AccountCategory_SelectByPk(AccountCategoryID).SingleOrDefault();
                var d = balACC_AccountCategory.dbo_PR_ACC_AccountCategory_SelectByPk(AccountCategoryID);

                //Mapper.Initialize(config => config.CreateMap<API_Consume.DAL.dbo_PR_ACC_AccountCategory_SelectByPK_Result, ACC_AccountCategoryModel>());
                //var vModel = AutoMapper.Mapper.Map<API_Consume.DAL.dbo_PR_ACC_AccountCategory_SelectByPK_Result, ACC_AccountCategoryModel>(d);

                return View("ACC_AccountCategoryAddEdit", d);
                //var data = await modelACC_AccountCategory.ACC_AccountCategory_SelectByPk(AccountCategoryID);
                //return View("ACC_AccountCategoryAddEdit", data);
            }
            ViewBag.Action = "Add";
            return View("ACC_AccountCategoryAddEdit", AccountCategoryModel);
            //ViewBag.Action = "Add";
            //return View("ACC_AccountCategoryAddEdit",null);
        }
        #endregion 11.0 Page Load Event - Add/Edit

        #region 15.0 Save Button Event
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Save(ACC_AccountCategoryModel modelACC_AccountCategory)
        {
            try
            {
                #region Validate Field
                string errorMsg = "";
                //if (modelACC_AccountCategory.AccountCategoryID == null)
                //{
                //    errorMsg += "<li>Select Account ID</li>";
                //}
                if (modelACC_AccountCategory.AccountCategoryName == null)
                {
                    errorMsg += "<li>Enter AccountCategory Name</li>";
                }
                if (modelACC_AccountCategory.Remarks == null)
                {
                    errorMsg += "<li>Enter Remarks</li>";
                }
                if (errorMsg != "")
                {
                    TempData["ErrorMessage"] = errorMsg;
                    return View("ACC_AccountCategoryAddEdit", modelACC_AccountCategory);
                }
                #endregion Validate Field

                #region Gather Data
                #endregion Gather Data

                if (modelACC_AccountCategory.AccountCategoryID == 0)
                {
                    bool vReturn = balACC_AccountCategory.dbo_PR_ACC_AccountCategory_Insert(modelACC_AccountCategory);
                    if (vReturn)
                    {
                        TempData["SuccessMessage"] = "Record Inserted Successfully..!";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Some Error Has Occured..!";
                    }
                }
                else
                {
                    bool vReturn = balACC_AccountCategory.dbo_PR_ACC_AccountCategory_Update(modelACC_AccountCategory);
                    if (vReturn)
                    {
                        TempData["SuccessMessage"] = "Record Updated Successfully..!";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Some Error Has Occured..!";
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return View("ACC_AccountCategoryAddEdit", modelACC_AccountCategory);
            }
        }
        #endregion 15.0 Save Button Event
    }
}
