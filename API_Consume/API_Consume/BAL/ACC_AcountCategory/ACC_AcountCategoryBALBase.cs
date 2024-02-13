using API_Consume.Areas.ACCategory.Models;
using API_Consume.DAL;

namespace API_Consume.BAL.ACC_AccountCategory
{
    public class ACC_AccountCategoryBALBase
    {
        #region Method: dbo_PR_ACC_AccountCategory_SelectAll
        public List<dbo_PR_ACC_AccountCategory_SelectAll_Result>? dbo_PR_ACC_AccountCategory_SelectAll(ACC_AccountCategoryModel modelACC_AccountCategory)
        {
            ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
            return dalACC_AccountModel.dbo_PR_ACC_AccountCategory_SelectAll(modelACC_AccountCategory).Result;
        }
        #endregion

        #region Method: dbo_PR_ACC_AccountCategory_SelectByPk
        //public List<dbo_PR_ACC_AccountCategory_SelectByPK_Result>? dbo_PR_ACC_AccountCategory_SelectByPk(int? AccountCategoryID)
        //      {
        //          ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
        //          return dalACC_AccountModel.dbo_PR_ACC_AccountCategory_SelectByPk(AccountCategoryID).Result;
        //      }
        public ACC_AccountCategoryModel? dbo_PR_ACC_AccountCategory_SelectByPk(int? AccountCategoryID)
        {
            ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
            return dalACC_AccountModel.dbo_PR_ACC_AccountCategory_SelectByPk(AccountCategoryID).Result;
        }
        #endregion

        #region Method: dbo_PR_ACC_AccountCategory_Insert
        public bool dbo_PR_ACC_AccountCategory_Insert(ACC_AccountCategoryModel modelACC_AccountCategory)
        {
            ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
            return dalACC_AccountModel.dbo_PR_ACC_AccountCategory_Insert(modelACC_AccountCategory).Result;
        }
        #endregion

        #region Method: dbo_PR_ACC_AccountCategory_Update
        public bool dbo_PR_ACC_AccountCategory_Update(ACC_AccountCategoryModel modelACC_AccountCategory)
        {
            ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
            return dalACC_AccountModel.dbo_PR_ACC_AccountCategory_Update(modelACC_AccountCategory).Result;
        }
        #endregion

        #region Method: dbo_PR_ACC_AccountCategory_Delete
        public bool dbo_PR_ACC_AccountCategory_Delete(int AccountCategoryID)
        {
            ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
            return dalACC_AccountModel.dbo_PR_ACC_AccountCategory_Delete(AccountCategoryID).Result;
        }
        #endregion

        //#region Method: dbo_PR_ACC_AccountDoc_SelectComboBox
        //public List<dbo_PR_AccountDoc_SelectComboBox_Result>? dbo_PR_ACC_AccountDoc_SelectComboBox(string InstituteCode, int CompanyID)
        //{
        //    ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
        //    return dalACC_AccountModel.dbo_PR_AccountDoc_SelectComboBox_Result(InstituteCode, CompanyID).Result;
        //}
        //#endregion

        //#region Method: dbo_PR_ACC_Account_SelectComboBox
        //public List<dbo_PR_ACC_Account_SelectComboBox_Result>? dbo_PR_ACC_Account_SelectComboBox()
        //{
        //    ACC_AccountCategoryDAL dalACC_AccountModel = new ACC_AccountCategoryDAL();
        //    return dalACC_AccountModel.dbo_PR_ACC_Account_SelectComboBox_Result().Result;
        //}
        //#endregion
    }
}
