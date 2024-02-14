using API_Consume.Areas.ACCategory.Models;
using API_Consume.CF;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace API_Consume.DAL
{
    public abstract class ACC_AccountCategoryDALBase : DALHelper
    {
       
            #region Method: dbo_PR_ACC_AccountCategory_SelectAll
            public async Task<List<dbo_PR_ACC_AccountCategory_SelectAll_Result>?> dbo_PR_ACC_AccountCategory_SelectAll(ACC_AccountCategoryModel modelACC_AccountCategory)
            {
                try
                {
                    var data = new Dictionary<string, string>()
                {
                    { "InstituteCode", CV.InstituteCode ?? string.Empty},
                    { "PageOffset", modelACC_AccountCategory.F_PageOffset.ToString() ?? string.Empty},
                    { "PageSize", modelACC_AccountCategory.F_PageSize.ToString() ?? string.Empty},
                    { "TotalRecords", modelACC_AccountCategory.F_TotalRecords.ToString() ?? string.Empty},
                    { "AccountCategoryName",modelACC_AccountCategory.F_AccountCategoryName?? string.Empty},
                    { "UserID", CV.UserID.ToString() ?? string.Empty},
                    { "SecOperationID", modelACC_AccountCategory.F_SecOperationID.ToString() ?? string.Empty},
                };

                    string APIURL = "AccountCategorySelectPage/CommonAccount/getAccountCategorySelectPage";
                    List<dbo_PR_ACC_AccountCategory_SelectAll_Result>? resultList = await GetJSONResponseFromAPI<dbo_PR_ACC_AccountCategory_SelectAll_Result>(APIURL, data);
                    if (resultList != null)
                    {
                        DataTable dt = resultList.ToDataTable();
                        return ConvertDataTableToEntity<dbo_PR_ACC_AccountCategory_SelectAll_Result>(dt).ToList();
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    var vExceptionHandler = ExceptionHandler(ex);
                    if (vExceptionHandler.IsToThrowAnyException)
                        throw vExceptionHandler.ExceptionToThrow;
                    return null;
                }
            }
            #endregion

            #region Method: dbo_PR_ACC_AccountCategory_SelectByPk
            //public async Task<List<dbo_PR_ACC_AccountCategory_SelectByPK_Result>?> dbo_PR_ACC_AccountCategory_SelectByPk(int? AccountCategoryID)
            //{
            //	try
            //	{
            //		var data = new Dictionary<string, string>()
            //		{
            //			{ "InstituteCode", CV.InstituteCode.ToString() ?? string.Empty},
            //			{ "AccountCategoryID", AccountCategoryID.ToString() ?? string.Empty},
            //		};

            //		string APIURL = "AccountCategorySelectPK/CommonAccount/getAccountCategorySelectPK";
            //		List<dbo_PR_ACC_AccountCategory_SelectByPK_Result>? result = await GetJSONResponseFromAPI<dbo_PR_ACC_AccountCategory_SelectByPK_Result>(APIURL, data);
            //		return result;
            //	}
            //	catch (Exception ex)
            //	{
            //		var vExceptionHandler = ExceptionHandler(ex);
            //		if (vExceptionHandler.IsToThrowAnyException)
            //			throw vExceptionHandler.ExceptionToThrow;
            //		return null;
            //	}
            //}
            public async Task<ACC_AccountCategoryModel?> dbo_PR_ACC_AccountCategory_SelectByPk(int? AccountCategoryID)
            {
                try
                {
                    var data = new Dictionary<string, string>()
                {
                    { "InstituteCode", CV.InstituteCode.ToString() ?? string.Empty},
                    { "AccountCategoryID", AccountCategoryID.ToString() ?? string.Empty},
                };

                    string APIURL = "AccountCategorySelectPK/CommonAccount/getAccountCategorySelectPK";
                    List<ACC_AccountCategoryModel>? result = await GetJSONResponseFromAPI<ACC_AccountCategoryModel>(APIURL, data);
                    if (result[0] == null)
                    {

                    }
                    return result[0];
                }
                catch (Exception ex)
                {
                    var vExceptionHandler = ExceptionHandler(ex);
                    if (vExceptionHandler.IsToThrowAnyException)
                        throw vExceptionHandler.ExceptionToThrow;
                    return null;
                }
            }
            #endregion

            #region Method: dbo_PR_ACC_AccountCategory_Insert
            public async Task<bool> dbo_PR_ACC_AccountCategory_Insert(ACC_AccountCategoryModel modelACC_AccountCategory)
            {
                try
                {
                    var data = new Dictionary<string, string>()
                {
                    { "InstituteCode", CV.InstituteCode ?? string.Empty},
                    { "AccountCategoryName", modelACC_AccountCategory.AccountCategoryName ?? string.Empty},
                    { "Remarks", modelACC_AccountCategory.Remarks ?? string.Empty},
                    { "UserID", CV.UserID.ToString() ?? string.Empty},
                    { "Created", DateTime.Now.Date.ToString("yyyy-MM-dd") ?? string.Empty},
                    { "Modified", DateTime.Now.Date.ToString("yyyy-MM-dd") ?? string.Empty},
                };

                    string APIURL = "AccountCategoryInsert/CommonAccount/AccountCategoryInsert";
                    bool result = await GetJSONResponseSuccess(APIURL, data);
                    if (result)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    var vExceptionHandler = ExceptionHandler(ex);
                    if (vExceptionHandler.IsToThrowAnyException)
                        throw vExceptionHandler.ExceptionToThrow;
                    return false;
                }
            }
            #endregion SaveIncome

            #region Method: dbo_PR_ACC_AccountCategory_Update
            public async Task<bool> dbo_PR_ACC_AccountCategory_Update(ACC_AccountCategoryModel modelACC_AccountCategory)
            {
                try
                {
                    var data = new Dictionary<string, string>()
                {
                    { "InstituteCode", CV.InstituteCode ?? string.Empty},
                    { "AccountCategoryID", modelACC_AccountCategory.AccountCategoryID.ToString() ?? string.Empty},
                    { "AccountCategoryName", modelACC_AccountCategory.AccountCategoryName ?? string.Empty},
                    { "Remarks", modelACC_AccountCategory.Remarks ?? string.Empty},
                    { "UserID", CV.UserID.ToString() ?? string.Empty},
                    { "Created", DateTime.Now.Date.ToString("MM-dd-yyyy") ?? string.Empty},
                    { "Modified", DateTime.Now.Date.ToString("MM-dd-yyyy") ?? string.Empty},
                };
                    string APIURL = "AccountCategoryUpdate/CommonAccount/AccountCategoryUpdate";
                    bool result = await GetJSONResponseSuccess(APIURL, data);
                    if (result)
                        return true;
                    return false;
                }
                catch (Exception ex)
                {
                    var vExceptionHandler = ExceptionHandler(ex);
                    if (vExceptionHandler.IsToThrowAnyException)
                        throw vExceptionHandler.ExceptionToThrow;
                    return false;
                }
            }
            #endregion SaveIncome

            #region Method: dbo_PR_ACC_AccountCategory_Delete
            public async Task<bool> dbo_PR_ACC_AccountCategory_Delete(int AccountCategoryID)
            {
                try
                {
                    var data = new Dictionary<string, string>()
                {
                    { "AccountCategoryID", AccountCategoryID.ToString() ?? string.Empty},
                    { "UserID", CV.UserID.ToString() ?? string.Empty},
                    { "InstituteCode", CV.InstituteCode ?? string.Empty},
                };

                    string APIURL = "AccountCategoryDelete/CommonAccount/AccountCategoryDelete";
                    bool result = await GetJSONResponseSuccess(APIURL, data);
                    if (result)
                        return true;
                    return false;
                }
                catch (Exception ex)
                {
                    var vExceptionHandler = ExceptionHandler(ex);
                    if (vExceptionHandler.IsToThrowAnyException)
                        throw vExceptionHandler.ExceptionToThrow;
                    return false;
                }
            }
        #endregion DeleteIncome

        //#region Method: dbo_PR_AccountDoc_SelectComboBox_Result
        //public async Task<List<dbo_PR_AccountDoc_SelectComboBox_Result>?> dbo_PR_AccountDoc_SelectComboBox_Result(string InstituteCode, int CompanyID)
        //{
        //    try
        //    {
        //        var data = new Dictionary<string, string>()
        //        {
        //            { "InstituteCode", InstituteCode},
        //            { "CompanyID", CompanyID.ToString()}
        //        };

        //        string APIURl = "AccountDocSelectComboBox/CommonAccount/getAccountDocSelectComboBox";
        //        List<dbo_PR_AccountDoc_SelectComboBox_Result>? result = await GetJSONResponseFromAPI<dbo_PR_AccountDoc_SelectComboBox_Result>(APIURl, data);

        //        DataTable dt = result.ToDataTable();

        //        return ConvertDataTableToEntity<dbo_PR_AccountDoc_SelectComboBox_Result>(dt).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        var vExceptionHandler = ExceptionHandler(ex);
        //        if (vExceptionHandler.IsToThrowAnyException)
        //            throw vExceptionHandler.ExceptionToThrow;
        //        return null;
        //    }
        //}
        //#endregion

        //#region Method: dbo_PR_ACC_Account_SelectComboBox_Result
        //public async Task<List<dbo_PR_ACC_Account_SelectComboBox_Result>?> dbo_PR_ACC_Account_SelectComboBox_Result()
        //{
        //    try
        //    {
        //        var data = new Dictionary<string, string>()
        //        {
        //            { "InstituteCode", CV.InstituteCode ?? string.Empty },
        //            { "CompanyID", CV.CompanyID.ToString() ?? string.Empty },
        //            { "prefixText", "___"?? string.Empty},
        //            { "UserID", CV.UserID.ToString() ?? string.Empty},
        //            { "SecOperationID", "" ?? string.Empty}
        //        };
        //        string APIURl = "AccountSelectAutoCompleteByCompanyID/CommonAccount/getAccountSelectAutoCompleteByCompanyID";
        //        List<dbo_PR_ACC_Account_SelectComboBox_Result>? result = await GetJSONResponseFromAPI<dbo_PR_ACC_Account_SelectComboBox_Result>(APIURl, data);
        //        DataTable dt = result.ToDataTable();

        //        return ConvertDataTableToEntity<dbo_PR_ACC_Account_SelectComboBox_Result>(dt).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        var vExceptionHandler = ExceptionHandler(ex);
        //        if (vExceptionHandler.IsToThrowAnyException)
        //            throw vExceptionHandler.ExceptionToThrow;
        //        return null;
        //    }
        //}
        //#endregion

    }
        #region Entity: dbo_PR_ACC_AccountCategory_SelectAll_Result
    public partial class dbo_PR_ACC_AccountCategory_SelectAll_Result : DALHelper
        {
        #region Properties
        public int TotalRecords { get; set; }
         
        public int AccountCategoryID { get; set; }
        public string? AccountCategoryName { get; set; }
      
        public string? Remarks { get; set; }
      
        public string? UserName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int UserID { get; set; }
        //public int? TotalRecords { get; set; }
        //public int AccountCategoryID { get; set; }
        //public int? AccDocumentID { get; set; }
        //public string? AccountDocName { get; set; }
        //public string? VoucherNo { get; set; }
        //public DateTime? VoucherDate { get; set; }
        //public string? ReferenceNo { get; set; }
        //public DateTime? ReferenceDate { get; set; }
        //public Decimal? Amount { get; set; }
        //public string? Narration { get; set; }
        //public int? DebitAccountID { get; set; }
        //public string DebitAccountName { get; set; }
        //public int? CreditAccountID { get; set; }
        //public string CreditAccountName { get; set; }
        //public string? Remarks { get; set; }
        ////public int? CompanyID { get; set; }
        ////public string? CompanyName { get; set; }
        ////public int? FinYearID { get; set; }
        ////public string? FinYearName { get; set; }
        //public int? UserID { get; set; }
        //public string? UserName { get; set; }
        ////public string? UserName1 { get; set; }
        //public DateTime Created { get; set; }
        //public DateTime Modified { get; set; }
        //public DateTime? VerificationDateTime { get; set; }
        //public int? VerificationByUserID { get; set; }
        //public string? VerificationMessage { get; set; }
        //public string? LockMessage { get; set; }
        //public bool IsLocked { get; set; }
        //public string? RowColor { get; set; }
        //public string NevigateURL { get; set; }
        #endregion

        #region Convert Entity to String
        public override String ToString()
            {
                return EntityToString(this);
            }
            #endregion
        }
        #endregion

        #region Entity: dbo_PR_ACC_AccountCategory_SelectByPK_Result
        public partial class dbo_PR_ACC_AccountCategory_SelectByPK_Result : DALHelper
        {
            #region Properties
            public int? AccountCategoryID { get; set; }
            public int? AccountDocID { get; set; }
            public string? AccountDocName { get; set; }
            public string? VoucherNo { get; set; }
            public DateTime? VoucherDate { get; set; }
            public string? ReferenceNo { get; set; }
            public DateTime? ReferenceDate { get; set; }
            public decimal? Amount { get; set; }
            public string? Narration { get; set; }
            public int? DebitAccountID { get; set; }
            public int? CreditAccountID { get; set; }
            public string? Remarks { get; set; }
            public int? AccDocumentID { get; set; }
            public int? CompanyID { get; set; }
            public int? UserID { get; set; }
            public int? FinYearID { get; set; }
            public DateTime? Created { get; set; }
            public DateTime? Modified { get; set; }
            public int? BankID { get; set; }
            public DateTime? VerificationDateTime { get; set; }
            public int? VerificationByUserID { get; set; }
            public string? FKVoucherNo { get; set; }
            #endregion

            #region Convert Entity to String
            public override String ToString()
            {
                return EntityToString(this);
            }
            #endregion
        }
        #endregion

}
