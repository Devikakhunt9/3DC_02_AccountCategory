using System.ComponentModel.DataAnnotations;

namespace API_Consume.Areas.ACCategory.Models
{
    public class ACC_AccountCategoryModel
    {

        /*******************************************************************
         *	FILTERS
         *******************************************************************/
        [Display(Name = "Institute Code", Prompt = "Select Institute Code")]
        public string? F_InstituteCode { get; set; }
		public int F_PageOffset { get; set; } = 0;
        [Display(Name = "F_PageNo")]
        public int? F_PageNo { get; set; }
        [Display(Name = "F_PageSize")]
        public int? F_PageSize { get; set; }
        public int F_TotalRecords { get; set; }
        public int F_AccountCategoryID { get; set; }
        [Display(Name = "Account Category", Prompt = "Select Account Category Name")]
        public string? F_AccountCategoryName { get; set; }
        public int F_SecOperationID { get; set; }
        [Display(Name = "Remarks", Prompt = "Enter Remarks")]
        public string? F_Remarks { get; set; }
        [Display(Name = "User Name", Prompt = "Select User Name")]
        public string? F_UserName { get; set; }
        public int F_UserID { get; set; }


        /*******************************************************************
		 *	ADDEDIT FORM
		 *******************************************************************/
        [Display(Name = "Institute Code", Prompt = "Select Institute Code")]

        public int TotalRecords { get; set; }
        public string? InstituteCode { get; set; }
        public int PageOffset { get; set; }
        public int PageSize { get; set; }
        public int AccountCategoryID { get; set; }
        public string? AccountCategoryName { get; set; }
        [Display(Name = "Remarks", Prompt = "Enter Remarks")]
        public string? Remarks { get; set; }
        [Display(Name = "User Name", Prompt = "Select User Name")]
        public string? UserName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int UserID { get; set; }

    }
    public class ACC_AccountCategoryModelList
    {
        public List<ACC_AccountCategoryModel> ACC_AcountCategoryModelList { get; set; }
    }

    // ModelName: LOC_CityModel

    /*******************************************************************
     *	FILTERS
     *******************************************************************/
    //    [Display(Name = "Account Doc", Prompt = "Select Account Doc")]
    //    public int? F_AccountDocID { get; set; }
    //    [Display(Name = "From", Prompt = "Select From Date")]
    //    public DateTime? F_FromDate { get; set; } = null;
    //    [Display(Name = "To", Prompt = "Select To Date")]
    //    public DateTime? F_ToDate { get; set; } = null;
    //    [Display(Name = "Voucher No.", Prompt = "Enter Voucher No.")]
    //    public string? F_VoucherNo { get; set; }
    //    [Display(Name = "Debit Account", Prompt = "Enter Debit Account")]
    //    public string? F_DebitAccountName { get; set; }
    //    [Display(Name = "Credit Account", Prompt = "Enter Credit Account")]
    //    public string? F_CreditAccountName { get; set; }
    //    [Display(Name = "Narration", Prompt = "Enter Narration")]
    //    public string? F_Narration { get; set; }
    //    [Display(Name = "Remarks", Prompt = "Enter Remarks")]
    //    public string? F_Remarks { get; set; }
    //    public int? F_WarehouseID { get; set; }
    //    public int? F_SecOperationID { get; set; }
    //    [Display(Name = "F_PageNo")]
    //    public int? F_PageNo { get; set; }

    //    [Display(Name = "F_PageSize")]
    //    public int? F_PageSize { get; set; }

    //    [Required, Display(Name = "No. of Rows")]
    //    public int F_NoOfRows { get; set; }
    //    public int F_PageOffset { get; set; } = 0;


    //    /*******************************************************************
    //     *	ADDEDIT FORM
    //     *******************************************************************/
    //    public int AccountVoucherID { get; set; }

    //    [Display(Name = "Account Doc", Prompt = "Select Account Doc")]
    //    public int? AccountDocID { get; set; }
    //    [Display(Name = "Account Document", Prompt = "Select Account Doc")]
    //    public int? DocumentID { get; set; } = 2;
    //    public string? AccountDocName { get; set; }
    //    [Display(Name = "Voucher No.", Prompt = "Enter Voucher No.")]
    //    public string? VoucherNo { get; set; }

    //    [Display(Name = "Voucher Date", Prompt = "Enter Voucher Date")]
    //    public DateTime? VoucherDate { get; set; } = null;

    //    [Display(Name = "Reference No.", Prompt = "Enter Reference No.")]
    //    public string? ReferenceNo { get; set; }

    //    [Display(Name = "Reference Date", Prompt = "Enter Reference Date")]
    //    public DateTime? ReferenceDate { get; set; } = null;

    //    [Display(Name = "Amount", Prompt = "Enter Amount")]
    //    public decimal? Amount { get; set; }

    //    [Display(Name = "Narration", Prompt = "Enter Narration")]
    //    public string? Narration { get; set; }
    //    public int? DebitAccountID { get; set; }
    //    public string? DebitAccountName { get; set; }
    //    public int? CreditAccountID { get; set; }
    //    public string? CreditAccountName { get; set; }
    //    [Display(Name = "Remarks", Prompt = "Enter Remarks")]
    //    public string? Remarks { get; set; }
    //    public string? CompanyName { get; set; }
    //    public string? UserName { get; set; }
    //    public DateTime? Created { get; set; }
    //    public DateTime? Modified { get; set; }
    //    public int? WarehouseID { get; set; }
    //    public int? SecOperationID { get; set; }
    //}
    //public class ACC_AccountVoucherModelList
    //{
    //    public List<ACC_AccountVoucherModel> vACC_AccountVoucherModelList { get; set; }
    //}

}
