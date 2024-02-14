using API_Consume.BAL;
using API_Consume.DAL;

namespace API_Consume.CF
{
    public class CommonFillMethods
    {
        public static List<dbo_PR_AccountDoc_SelectComboBox_Result>? FillDropDownListAccountDocID()
        {
            ACC_AccountVoucherBAL balACC_AccountVoucher = new ACC_AccountVoucherBAL();
            return balACC_AccountVoucher.dbo_PR_ACC_AccountDoc_SelectComboBox(CV.InstituteCode, CV.CompanyID);
        }

		public static List<dbo_PR_ACC_Account_SelectComboBox_Result>? FillDropDownListAccountID()
		{
			ACC_AccountVoucherBAL balACC_AccountVoucher = new ACC_AccountVoucherBAL();
			return balACC_AccountVoucher.dbo_PR_ACC_Account_SelectComboBox();
		}
	}
}
