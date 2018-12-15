using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Users;
namespace Account
{
    public class AccountNm
    {
        MSqlConnection sql;
        //conctractor
        public AccountNm(string SerNm, string DBNm, string UserSql, string PassSql)
        {
            if (string.IsNullOrEmpty(UserSql) || string.IsNullOrEmpty(PassSql))
            {
                sql = new MSqlConnection(SerNm, DBNm);
            }
            else
            {
                sql = new MSqlConnection(SerNm, DBNm, UserSql, PassSql);
            }

        }
        #region //Account Main
        /// <summary>
        /// 
        /// ///Get all Acount
        /// </summary>
        /// <returns></returns>
          public string GetUserNmByID(int id)
        {
            string Query = "  select UserName from tblUser where ID=@ID";
        SqlParameter[] parm = new SqlParameter[1];
        parm[0] = new SqlParameter("ID", id);
            return sql.ExcuteQueryValue(Query, parm).ToString();

    }
    public DataTable GetAllAccount()
        {
            string Query = "select * from  tblAccounts";
            return sql.SelectData(Query, null);
            //    string Query = "select AccountNumber as 'قم الحساب',AccountName as 'اسم الحساب',AccountType as 'نوع الحساب',Expr1 as 'الحساب الاب' ,Active as 'النشاط' ,UserName as 'اسم المستخدم',EnterTime as 'تاريخ الادخال' from ViewAccounts";

        }
        /// <summary>
        /// Get ALL Acount
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllAcountnAr()
        {
            //string Query = "select t.AccountNumber as'رقم الحساب' ,t.AccountName as 'اسم الحساب ' ,t.AccountType as'نوع الحساب' ,s.AccountName as'الحساب الاب',s.AccountNumber as 'رقم حساب الاب' ,t.Active as 'تفعيل' ,t.StartEnter as 'تاريخ الادخال' ,Users.Name as 'اسم الموظف' ,t.ID from tblAccounts as s, tblAccounts as t,Users where t.FatherAccount = s.AccountNumber and Users.IDUSER = t.UserID order by ID";
            //  string Query = "select * from ViewAccounts";
            string Query = "select AccountNumber as 'رقم الحساب',AccountName as 'اسم الحساب',AccountType as 'نوع الحساب',Expr1 as 'الحساب الاب' ,fatherNumber as 'رقم الحساب الاب' ,case when Active =1 then 'نشط' when Active=0 then 'غير نشط' end as 'النشاط' ,UserName as 'اسم المستخدم',EnterTime as 'تاريخ الادخال' ,ID from ViewAccounts";

            return sql.SelectData(Query, null);
        }
        /// <summary>
        /// //Update Account
        /// </summary>
        /// <param name="iDAccounNm"></param>
        /// <param name="Name"></param>
        /// <param name="Active"></param>

        public int UpdateAccount(int iD, string Name, bool Active)
        {

            string Query = "update tblAccounts set AccountName=@AccountName,[Active]=@Active where ID=@ID";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ID", iD);
            parm[1] = new SqlParameter("@AccountName", Name);
            parm[2] = new SqlParameter("@Active", Active);
            return sql.ExcuteQuery(Query, parm);
        }



        /// <summary>
        /// 
        /// 
        ///
        /// 
        /// cheak Acconut Have in tblAccountDatiels
        public bool CheckAccounthasEnttity(int AccountNumber)
        {
            bool res;
            string Query = "select top 1 * from tblEnterisDetailes where AccountID=@AccountNumber";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@AccountNumber", AccountNumber);
            DataTable dt = new DataTable();
            dt = sql.SelectData(Query, parm);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;

            }
            return res;
        }
        // Check Account Has Chalid
        public bool CheckAccounthaschalid(int AccountNumber)
        {
            bool res;
            string Query = "select top 1 * from tblAccounts where FatherAccount =@AccountNumber";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@AccountNumber", AccountNumber);
            DataTable dt = new DataTable();
            dt = sql.SelectData(Query, parm);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;

            }
            return res;

        }

        /// GetTYpe Account
        /// </summary>
        /// <param name="IDAccount"></param>
        /// <returns></returns>
        public string TypeAccount(int IDAccount)
        {
            string Query = "select AccountType from tblAccounts where ID=@id ";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", IDAccount);
            return (string)sql.ExcuteQueryValue(Query, parm);
        }
        /// <summary>
        /// Get Check Account
        /// </summary>
        /// <param name="IDAccount"></param>
        /// <returns></returns>
        /// cheak Account is Active or not
        public bool GetCheckAccount(int IDAccount)
        {
            string Query = "select Active from tblAccounts where ID=@id ";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", IDAccount);
            return (bool)sql.ExcuteQueryValue(Query, parm);
        }
        ///       /// <summary>
        ///       chech acount ID is Here
        public bool GetCheckAccountHere(int IDAccount)
        {
            string Query = "select count(ID) from tblAccounts where AccountNumber=@id ";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", IDAccount);
            int i = (int)sql.ExcuteQueryValue(Query, parm);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// /Get Max IDCODde
        /// </summary>
        /// <param name="CodeParent"></param>
        /// <returns></returns>
        public int GetMaxCode(int CodeParent, string Type)
        { int x = 0;
            try
            {
                string Query = "select max(AccountNumber) from tblAccounts where FatherAccount=@id";
                SqlParameter[] parm = new SqlParameter[1];
                parm[0] = new SqlParameter("@id", CodeParent);

                return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));
            }
            catch
            {
                if (Type.Equals("رئيسي"))
                {
                    string s = CodeParent.ToString() + "00";
                    return Convert.ToInt32(s);
                }
                else
                {
                    string s = CodeParent.ToString() + "0";
                    return Convert.ToInt32(s);
                }

            }

        }
        /// <summary>
        /// Add Acount
        /// </summary>
        /// <param name="AccountName"></param>
        /// <param name="AccountNumber"></param>
        /// <param name="IdParnt"></param>
        /// <param name="Type"></param>
        /// <param name="Active"></param>
        /// <param name="DateStart"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public int AddNewAccountName(string AccountName, int AccountNumber, int IdParnt, string Type, int Active, int UserID)
        {
            string Query = "insert into tblAccounts (AccountName,AccountNumber,FatherAccount,AccountType,Active,UserID) values(@AccountName,@AccountNumber,@FatherAccount,@AccountType,@Active,@UserID)";
            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@AccountName", AccountName);
            parm[1] = new SqlParameter("@AccountNumber", AccountNumber);
            parm[2] = new SqlParameter("@FatherAccount", IdParnt);
            parm[3] = new SqlParameter("@AccountType", Type);
            parm[4] = new SqlParameter("@Active", Active);
            parm[5] = new SqlParameter("UserID", UserID);
            return sql.ExcuteQuery(Query, parm);
        }
        ////////////
        /// <summary>
        /// detel Accoumt
        /// </summary>
        /// <param name="IDCount"></param>
        /// <returns></returns>
        /////////////
        public int DelteAccount(int IDCount)
        {
            string Query = "delete from tblAccounts where ID=@id";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", IDCount);
            return sql.ExcuteQuery(Query, parm);
        }
        /// <returns></returns>
        /////////////
        public int DelteAccount2(int AccountNumber)
        {
            string Query = "delete from tblAccounts where AccountNumber=@id";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", AccountNumber);
            return sql.ExcuteQuery(Query, parm);
        }

        /////////
        /// Search AcoutnNm
        /// 
        public DataTable SearchAcount(string name)
        {
            name = "%" + name + "%";
            // string Query = "select t.AccountNumber as'رقم الحساب' ,t.AccountName as 'اسم الحساب ' ,t.AccountType as'نوع الحساب' ,s.AccountName as'الحساب الاب',s.AccountNumber as 'رقم حساب الاب' ,t.Active as 'تفعيل' ,t.StartEnter as 'تاريخ الادخال' ,Users.Name as 'اسم الموظف' ,t.ID from tblAccounts as s, tblAccounts as t,Users where t.FatherAccount = s.AccountNumber and Users.IDUSER = t.UserID and t.AccountName like @name order by ID";
            // string Query = "select * from ViewAccounts where Account  like @name order by [رقم الحساب]";

            string Query = "select AccountNumber as 'رقم الحساب',AccountName as 'اسم الحساب',AccountType as 'نوع الحساب',Expr1 as 'الحساب الاب' ,fatherNumber as 'رقم الحساب الاب' ,case when Active =1 then 'نشط' when Active=0 then 'غير نشط' end as 'النشاط' ,UserName as 'اسم المستخدم',EnterTime as 'تاريخ الادخال' ,ID from ViewAccounts where AccountName like @name order by AccountNumber ";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@name", name);
            return sql.SelectData(Query, parm);

        }
        #endregion//end Account Main
        ////////////////////////////
        //
        // كشف الحساب
        #region 
        //  جلب الحسابات الفرعية لكشف احساب
        public DataTable GETALLAccountSub()
        {
            //string Query = "select tblAccounts.AccountNumber as 'رقم الحساب',tblAccounts.AccountName as'اسم الحساب'  from tblAccounts where AccountType='فرعي' and Active=1";
            string Query = "select ID as'الرقم',AccountName as'الاسم' from tblAccounts where AccountType='فرعي' ";
            return sql.SelectData(Query, null);
        }
        //  جلب الحسابات الفرعية لصرف من حساب
        public DataTable GETALLAccountSubForSpend()
        {
            //string Query = "select tblAccounts.AccountNumber as 'رقم الحساب',tblAccounts.AccountName as'اسم الحساب'  from tblAccounts where AccountType='فرعي' and Active=1";
            string Query = "select ID as'الرقم',AccountName as'الاسم' from tblAccounts where AccountType='فرعي' and [Active]=1 ";
            return sql.SelectData(Query, null);
        }
        //جلب العملات
        public DataTable GetAllCurnncy()
        {
            string Query = "select ID as 'الرقم' ,CurrncyName as 'الاسم' from tblCurrencies";
            return sql.SelectData(Query, null);
        }
        // جلب العملة باستخدام الرقم
        public string GetCurnncyNameByID(int ID)
        {
            string Query = "select CurrncyName from tblCurrencies where ID=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return sql.ExcuteQueryValue(Query, parm).ToString();
        }
        // جلب كشف تفصيلي حساب لحساب معين بعلمة واحده
        public DataTable GetAccountDetalis(int IDAccount, int IDCurnncy, DateTime Dstart, DateTime Dend)
        {  // الحصول الى الرصيد السابق
            double Preiv = GetAccountTotal(IDAccount, IDCurnncy, Dstart);
            DataTable res1 = new DataTable();
            res1.Columns.Add("مدين");
            res1.Columns.Add("دائن");

            res1.Columns.Add("العملة");
            res1.Columns.Add("التاريخ");
            res1.Columns.Add("االعملية");
            res1.Columns.Add("البيان");

            res1.NewRow();
            if (Preiv < 0)
            {
                res1.Rows.Add(new object[] { string.Format("{0:##,##}", Math.Abs(Preiv)), null, GetCurnncyNameByID(IDCurnncy), null, "رصيد سابق", null });

            }
            else if (Preiv > 0)
            {
                res1.Rows.Add(new object[] { null, string.Format("{0:##,##}", Math.Abs(Preiv)), GetCurnncyNameByID(IDCurnncy), null, "رصيد سابق", null });
            }
            else
            {
                res1.Rows.Add(new object[] { "0", "0", GetCurnncyNameByID(IDCurnncy), null, "رصيد سابق", null });

            }



            // الحصول على العمليات خلال تاريخ البحث
            string Query = "select Madeen as'مدين', Daeen as'دائن',CurrncyName As 'العملة',TheDate as'التاريخ',NameDocument as 'العملية',Note as'البيان' from  VewEntity where  AccountID =@AccountID and CurnncyID=@CurnncyID and TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@AccountID", IDAccount);
            parm[1] = new SqlParameter("@CurnncyID", IDCurnncy);
            parm[2] = new SqlParameter("@d1", Dstart);
            parm[3] = new SqlParameter("@d2", Dend);
            DataTable dt = new DataTable();
            dt = sql.SelectData(Query, parm);
            if (dt.Rows.Count > 0) {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    res1.Rows.Add(new object[] { string.Format("{0:##,##}", dt.Rows[i][0]), string.Format("{0:##,##}", dt.Rows[i][1]), dt.Rows[i][2], Convert.ToDateTime(dt.Rows[i][3]).ToShortDateString(), dt.Rows[i][4], dt.Rows[i][5] });
                }
            }
            // جلب اجمالي الحساب
            double Totel = (GetAccountTotal1(IDAccount, IDCurnncy));
            res1.NewRow();
            res1.Rows.Add(new object[] { "#########", "#########", "#########", "#########", "#########", "#########" });
            res1.NewRow();
            if (Totel < 0)
            {
                res1.Rows.Add(new object[] { string.Format("{0:##,##}", Math.Abs(Totel)), null, GetCurnncyNameByID(IDCurnncy), null, "الاجمالي", "اجمالي الرصيد عليكم" });

            }
            else if (Totel > 0)
            {
                res1.Rows.Add(new object[] { null, string.Format("{0:##,##}", Math.Abs(Totel)), GetCurnncyNameByID(IDCurnncy), null, "الاجمالي", "اجمالي الرصيد لكم" });
            }
            else
            {
                res1.Rows.Add(new object[] { "0", "0", GetCurnncyNameByID(IDCurnncy), null, "الاجمالي", "اجمالي الرصيد لكم" });

            }

            return res1;


        }
        //// جلب كشف حساب تفصيلي لحساب معين بكل العملات
        public DataTable GetAccountDetalis(int IDAccount, DateTime Dstart, DateTime Dend)
        {   // جلب  الرصيد السابق
            DataTable dtCurnncy = new DataTable();
            DataTable res1 = new DataTable();
            dtCurnncy = GetAllCurnncy();
            res1.Columns.Add("مدين");
            res1.Columns.Add("دائن");

            res1.Columns.Add("العملة");
            res1.Columns.Add("التاريخ");
            res1.Columns.Add("االعملية");
            res1.Columns.Add("البيان");
            for (int i = 0; i < dtCurnncy.Rows.Count; i++)
            {
                double Preiv = GetAccountTotal(IDAccount, Convert.ToInt32(dtCurnncy.Rows[i][0].ToString()), Dstart);
                res1.NewRow();
                if (Preiv < 0)
                {
                    res1.Rows.Add(new object[] { string.Format("{0:##,##}", Math.Abs(Preiv)), null, GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "رصيد سابق", null });

                }
                else if (Preiv > 0)
                {
                    res1.Rows.Add(new object[] { null, string.Format("{0:##,##}", Math.Abs(Preiv)), GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "رصيد سابق", null });
                }
                else
                {
                    res1.Rows.Add(new object[] { "0", "0", GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "رصيد سابق", null });

                }

            }
            // جلب العمليات حسب تاريخ البحث
            string Query = "select  Madeen as'مدين',Daeen as'دائن',CurrncyName As 'العملة',TheDate as'التاريخ',NameDocument as 'العملية',Note as'البيان' from  VewEntity where  AccountID =@AccountID and TheDate >=@d1 and TheDate<@d2 order by CurrncyName";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@AccountID", IDAccount);
            parm[1] = new SqlParameter("@d1", Dstart);
            parm[2] = new SqlParameter("@d2", Dend);
            DataTable dt = new DataTable();
            dt = sql.SelectData(Query, parm);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    res1.Rows.Add(new object[] { string.Format("{0:##,##}", dt.Rows[i][0]), string.Format("{0:##,##}", dt.Rows[i][1]), dt.Rows[i][2], Convert.ToDateTime(dt.Rows[i][3]).ToShortDateString(), dt.Rows[i][4], dt.Rows[i][5] });
                }
            }
            // جلب الاجمالي
            for (int i = 0; i < dtCurnncy.Rows.Count; i++)
            {
                double Preiv = GetAccountTotal1(IDAccount, Convert.ToInt32(dtCurnncy.Rows[i][0].ToString()));
                res1.NewRow();
                if (Preiv < 0)
                {
                    res1.Rows.Add(new object[] { string.Format("{0:##,##}", Math.Abs(Preiv)), null, GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "الاجمالي", null });

                }
                else if (Preiv > 0)
                {
                    res1.Rows.Add(new object[] { null, string.Format("{0:##,##}", Math.Abs(Preiv)), GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "الاجمالي", null });
                }
                else
                {
                    res1.Rows.Add(new object[] { "0", "0", GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "الاجمالي", null });

                }

            }
            return res1;
        }
        //   جلب حساب اجمالي لحساب معين بعملة واحده
        private double GetAccountTotal1(int IDAccount, int IDCurnncy)
        {
            //  string Query = "select  case WHEN  isnull(Sum(Amount),0) >= 0 then sum(Amount) end  as 'دائن',case WHEN  isnull(Sum(Amount),0) <0 then abs(sum(Amount))end as'مدين',CurrncyName As 'العملة','تاريخ سابق' as'التاريخ','الاجمالي' as 'العملية',null as'البيان' from VewEntity where AccountID=@AccountID and CurnncyID=@CurnncyID   group by CurrncyName";
            string Query = "select isnull(sum(Amount),0) from VewEntity where AccountID=@AccountID and CurnncyID=@CurnncyID";
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@AccountID", IDAccount);
            parm[1] = new SqlParameter("@CurnncyID", IDCurnncy);
            return Convert.ToDouble(sql.ExcuteQueryValue(Query, parm));
        }
        //جلب اجماالي حساب معين لعملة واحده كجدول
        public DataTable GetAccountTotal(int IDAccount, int IDCurnncy)
        {

            double Totel = GetAccountTotal1(IDAccount, IDCurnncy);
            DataTable res1 = new DataTable();
            res1.Columns.Add("مدين");
            res1.Columns.Add("دائن");

            res1.Columns.Add("العملة");
            res1.Columns.Add("التاريخ");
            res1.Columns.Add("االعملية");
            res1.Columns.Add("البيان");
            res1.NewRow();
            if (Totel < 0)
            {
                res1.Rows.Add(new object[] { string.Format("{0:##,##}", Math.Abs(Totel)), null, GetCurnncyNameByID(IDCurnncy), null, "الاجمالي", "اجمالي الرصيد عليكم" });

            }
            else if (Totel > 0)
            {
                res1.Rows.Add(new object[] { null, string.Format("{0:##,##}", Math.Abs(Totel)), GetCurnncyNameByID(IDCurnncy), null, "الاجمالي", "اجمالي الرصيد لكم" });
            }
            else
            {
                res1.Rows.Add(new object[] { "0", "0", GetCurnncyNameByID(IDCurnncy), null, "الاجمالي", "لا يوجد رصيد" });

            }

            return res1;
        }
        // جلب حساب اجمالي لحساب معين بكل العملات
        public DataTable GetAccountTotal(int IDAccount)
        {
            DataTable dtCurnncy = new DataTable();
            DataTable res1 = new DataTable();
            dtCurnncy = GetAllCurnncy();
            res1.Columns.Add("مدين");
            res1.Columns.Add("دائن");

            res1.Columns.Add("العملة");
            res1.Columns.Add("التاريخ");
            res1.Columns.Add("االعملية");
            res1.Columns.Add("البيان");

            for (int i = 0; i < dtCurnncy.Rows.Count; i++)
            {
                double Totel = GetAccountTotal1(IDAccount, Convert.ToInt32(dtCurnncy.Rows[i][0].ToString()));

                res1.NewRow();
                if (Totel < 0)
                {
                    res1.Rows.Add(new object[] { string.Format("{0:##,##}", Math.Abs(Totel)), null, GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "الاجمالي", " اجمالي الرصيد عليكم" });

                }
                else if (Totel > 0)
                {
                    res1.Rows.Add(new object[] { null, string.Format("{0:##,##}", Math.Abs(Totel)), GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "الاجمالي", "اجمالي الرصيد لكم" });
                }
                else
                {
                    res1.Rows.Add(new object[] { "0", "0", GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())), null, "الاجمالي", "لا يوجد رصيد" });

                }

            }
            return res1;
        }
        public DataTable GetAccountTotalBYSpend(int IDAccount)
        {
            DataTable dtCurnncy = new DataTable();
            DataTable res1 = new DataTable();
            dtCurnncy = GetAllCurnncy();
            res1.Columns.Add("مدين");
            res1.Columns.Add("دائن");

            res1.Columns.Add("العملة");
            

            for (int i = 0; i < dtCurnncy.Rows.Count; i++)
            {
                double Totel = GetAccountTotal1(IDAccount, Convert.ToInt32(dtCurnncy.Rows[i][0].ToString()));

                res1.NewRow();
                if (Totel < 0)
                {
                    res1.Rows.Add(new object[] { string.Format("{0:##,##}", Math.Abs(Totel)), null, GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())) });

                }
                else if (Totel > 0)
                {
                    res1.Rows.Add(new object[] { null, string.Format("{0:##,##}", Math.Abs(Totel)), GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())) });
                }
                else
                {
                    res1.Rows.Add(new object[] { "0", "0", GetCurnncyNameByID(Convert.ToInt32(dtCurnncy.Rows[i][0].ToString())) });

                }

            }
            return res1;
        }

        // جلب حساب اجمالي لحساب رئيسي معين بعملة واحده
        public DataTable GetAccountTotal(int IDAccount, int IDCurnncy, string Main)
        {
            return new DataTable();
        }
        // جلب حساب اجمالي لحساب رئيسي معين بعملة بكل العملات
        public DataTable GetAccountTotal(int IDAccount, string MAin)
        {
            return new DataTable();

        }
        // جلب حساب اجمالي لحساب معين بعملة واحد قبل بتاريخ معين
        public Double GetAccountTotal(int IDAccount, int IDCurnncy, DateTime dPrive)
        {
            string Query = "  select isnull(sum(Amount),0) from VewEntity where AccountID=@AccountID and CurnncyID=@CurnncyID and  TheDate <@d2 ";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@AccountID", IDAccount);
            parm[1] = new SqlParameter("@CurnncyID", IDCurnncy);
            parm[2] = new SqlParameter("@d2", dPrive);
            return Convert.ToDouble(sql.ExcuteQueryValue(Query, parm));

        }

        #endregion
        //تحويل بين الحسابات
        #region
        //جلب السنة المالية
        public int GetFiscalyear()
        {
            string Query = "select  isnull(TheYear,0) from tblFiscalyear  where [Active]=1";
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, null));

        }

        // اضافة قسد بسيط جديد
        private int AddNewSimple1(int TheNumber, int IDDaanAccont, int IDMaddenAccount, double Mony, int IDUser, string Note, int IDCurnncy, DateTime TheDate)
        {
            string Query = "insert into tblSimpleConstraint(TheNumber,IDDaanAccont,IDMaddenAccount,Mony,IDUser,Note,IDCurnncy,TheDate) values(@TheNumber,@IDDaanAccont,@IDMaddenAccount,@Mony,@IDUser,@Note,@IDCurnncy,@TheDate)";
            SqlParameter[] parm = new SqlParameter[8];
            parm[0] = new SqlParameter("@TheNumber", TheNumber);
            parm[1] = new SqlParameter("@IDDaanAccont", IDDaanAccont);
            parm[2] = new SqlParameter("@IDMaddenAccount", IDMaddenAccount);
            parm[3] = new SqlParameter("@Mony", Mony);
            parm[4] = new SqlParameter("@IDUser", IDUser);
            parm[5] = new SqlParameter("@Note", Note);
            parm[6] = new SqlParameter("@IDCurnncy", IDCurnncy);
            parm[7] = new SqlParameter("@TheDate", TheDate);
            return sql.ExcuteQuery(Query, parm);
        }
        // جلب اعلى رقم في القيد البسيط
        public int GetMaxSimple()
        {
            string Query = "select isnull( Max(TheNumber),0) from tblSimpleConstraint";
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, null));
        }
        // تعديل قيد بسيط جديد
        private int UpdateSimple1(int ID, int IDDaanAccont, int IDMaddenAccount, double Mony, string Note, int IDCurnncy)
        {
            string Query = "update tblSimpleConstraint set IDDaanAccont=@IDDaanAccont,IDMaddenAccount=@IDMaddenAccount,Mony=@Mony,IDCurnncy=@IDCurnncy,Note=@Note where IDSimpleConstraint=@ID";
            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@IDSimpleConstraint", ID);
            parm[1] = new SqlParameter("@IDDaanAccont", IDDaanAccont);
            parm[2] = new SqlParameter("@IDMaddenAccount", IDMaddenAccount);
            parm[3] = new SqlParameter("@Mony", Mony);
            parm[4] = new SqlParameter("@Note", Note);
            parm[5] = new SqlParameter("@IDCurnncy", IDCurnncy);

            return sql.ExcuteQuery(Query, parm);
        }
        // //اضافة القيد رئيسي  الى جدول الحسابات
        private int AddNewEntity(int DoucmentID, DateTime TheDate, int UserID, int TheYear, int RecorderNumber)
        {
            string Query = "  insert into tblEntries(DoucmentID,TheDate,UserID,TheYear,RecorderNumber) values(@DoucmentID,@TheDate,@UserID,@TheYear,@RecorderNumber)";
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@DoucmentID", DoucmentID);
            parm[1] = new SqlParameter("@TheDate", TheDate);
            parm[2] = new SqlParameter("@UserID", UserID);
            parm[3] = new SqlParameter("@TheYear", TheYear);
            parm[4] = new SqlParameter("@RecorderNumber", RecorderNumber);
            sql.ExcuteQuery(Query, parm);
            Query = "select ID from tblEntries where DoucmentID=@DoucmentID and RecorderNumber=@RecorderNumber";
            parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@DoucmentID", DoucmentID);
            parm[1] = new SqlParameter("@RecorderNumber", RecorderNumber);
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));
        }
        // اضافة القيد التفصيلي
        private int AddNewEntityDetalies(int parentEntityID, double Amount, int CurnncyID, int AccountID, string Note)
        {
            string Query = "insert into tblEnterisDetailes(parentEntityID,Amount,CurnncyID,AccountID,Note) values(@parentEntityID,@Amount,@CurnncyID,@AccountID,@Note)";
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@parentEntityID", parentEntityID);
            parm[1] = new SqlParameter("@Amount", Amount);
            parm[2] = new SqlParameter("@CurnncyID", CurnncyID);
            parm[3] = new SqlParameter("@AccountID", AccountID);
            parm[4] = new SqlParameter("@Note", Note);
            return sql.ExcuteQuery(Query, parm);
        }
        // الغاء القيد الفرعي
        private int DeleteEntityDetalies(int parentEntityID)
        {
            string Query = " delete from tblEnterisDetailes where parentEntityID=@parentEntityID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@parentEntityID", parentEntityID);
            return sql.ExcuteQuery(Query, parm);
        }
        // /جلب رقم القيد الاساسي باستخدام رقم السند ونوعه
        private int GetEntityID(int DoucmnetID, int RecordeNumber)
        {
            string Query = "select ID from tblEntries where DoucmentID=@DoucmentID and RecorderNumber=@RecorderNumber";
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@DoucmentID", DoucmnetID);
            parm[1] = new SqlParameter("@RecorderNumber", RecordeNumber);
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));

        }
        //جلب  الايدي الخاص بالقيد عن طريق الرقم
        private int GetIDSimpleByNumber(int TheNumber)
        {
            string Query = "select isnull(IDSimpleConstraint,0) from tblSimpleConstraint where TheNumber=@TheNumber";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@TheNumber", TheNumber);
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));
        }
        //اضافة القيد جديد واضافة القيود التفصيلية
        public void AddnewSimple(int TheNumber, int IDDaanAccont, int IDMaddenAccount, double Mony, int IDUser, string Note, int IDCurnncy, DateTime TheDate, int Year, string AccountDaan, string AccoutMaden)
        {
            //اضافة القيد الى جدول القيود البسيطة
            AddNewSimple1(TheNumber, IDDaanAccont, IDMaddenAccount, Mony, IDUser, Note, IDCurnncy, TheDate);
            int IDSimple = GetIDSimpleByNumber(TheNumber);
            //اضافة القيد الرئيسي 5 هي المستند تحويل بين الحساباات
            int EntityParent = AddNewEntity(5, TheDate, IDUser, Year, IDSimple);
            //اضافة القيود التفصيلية
            //اضافة قيد الدائن
            AddNewEntityDetalies(EntityParent, Mony, IDCurnncy, IDDaanAccont, " مقابل تحويل من حساب   " + AccoutMaden + " رقم القيد " + TheNumber);
            //اضافة قيد المدين
            AddNewEntityDetalies(EntityParent, (-1 * Mony), IDCurnncy, IDMaddenAccount, "مقابل تحويل الى حساب  " + AccountDaan + " رقم القيد " + TheNumber);

        }
        // جلب القيود حسب تاريخ معين
        public DataTable GetSimpleByDate(DateTime d1, DateTime d2)
        {
            string Query = "select IDSimpleConstraint as'الرقم العام',TheNumber as'الرقم',format(Mony,'N') as'المبلغ',CurrncyName as'العملة',madeen as 'من حساب',daan as'الى حساب',Note as'ملاحطات',TheDate as'التاريخ',UserName as'مستخدم الادخال',EnterTime as'تاريخ الادخال' from VewSimpleConstraint where TheDate>=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@d1", d1);
            parm[1] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        public DataTable GetSimpleByTheNumber(int Number)
        {
            string Query = "select IDSimpleConstraint as'الرقم العام',TheNumber as'الرقم',format(Mony,'N') as'المبلغ',CurrncyName as'العملة',madeen as 'من حساب',daan as'الى حساب',Note as'ملاحطات',TheDate as'التاريخ',UserName as'مستخدم الادخال',EnterTime as'تاريخ الادخال' from VewSimpleConstraint where TheNumber=@Number";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@Number", Number);

            return sql.SelectData(Query, parm);
        }
        //جلب سند قيد ياستخدام شرط
        public DataTable GetSimpleByReson(string  Reson)
        {
            string Query = "select IDSimpleConstraint as'الرقم العام',TheNumber as'الرقم',format(Mony,'N') as'المبلغ',CurrncyName as'العملة',madeen as 'من حساب',daan as'الى حساب',Note as'ملاحطات',TheDate as'التاريخ',UserName as'مستخدم الادخال',EnterTime as'تاريخ الادخال' from VewSimpleConstraint where ";

            Query += Reson;

            return sql.SelectData(Query,null);
        }
        public void UpdateSimple(int IDTransfer, string Note)
        {
            string Query = "update tblSimpleConstraint set Note=@Note where IDSimpleConstraint=@ID";
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@Note", Note);
            parm[1] = new SqlParameter("@ID", IDTransfer);
            sql.ExcuteQuery(Query, parm);
        }
        #endregion
        // حسابات النظام
        #region
        //جلب حسابات النظام

        public DataTable GetAccountSystem()
        {
            string Query = "  select Expr2 as'رقم حساب النظام',AccountNameSystem as'اسم حساب النظام',AccountNumber as'رقم الحساب',AccountName as'اسم الحساب',EnterTime as'تاريخ الادخال',UserName as'مستخدم الادخال' from VewSystemAccounts";
            return sql.SelectData(Query, null);
        }

        #endregion
        //صرف من حساب
        #region
        // جلب رقم الحساب باستخدام الايدي
        public int GetAccountNumberByID(int ID)
        {
            string Query = "  select  isnull(AccountNumber,0) from tblAccounts where ID=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));
        }
        //جلب اسم حساب النظام باستخدام الايدي
        public string GetAccountSystemNameByID(int ID)
        {
            string Query = "  select AccountName from VewSystemAccounts where Expr2=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return sql.ExcuteQueryValue(Query, parm).ToString();
        }
        public DataTable GetAccountSystemByID(int ID)
        {
            string Query = "  select ID as 'الرقم',AccountName as 'الاسم' from VewSystemAccounts where Type=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return sql.SelectData(Query, parm);
        }
        //جلب حسابات النظام 
        //اضافة الى جدول الصرف من حساب
        private int AddNewSpendP(int TheNumber, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, int UserID)
        {
            string Query = "  insert into tblSpend (TheNumber,TheDate,Amount,CurncyID,AccountID,AccountExchangeClient,Note,Delivery,UserID) values(@TheNumber,@TheDate,@Amount,@CurncyID,@AccountID,@AccountExchangeClient,@Note,@Delivery,@UserID)";
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@TheNumber", TheNumber);
            parm[1] = new SqlParameter("@TheDate", TheDate);
            parm[2] = new SqlParameter("@Amount", Amount);
            parm[3] = new SqlParameter("@CurncyID", CurncyID);
            parm[4] = new SqlParameter("@AccountID", AccountID);
            parm[5] = new SqlParameter("@AccountExchangeClient", AccountExchangeClient);
            parm[6] = new SqlParameter("@Note", Note);
            parm[7] = new SqlParameter("@Delivery", Delivery);
            parm[8] = new SqlParameter("@UserID", UserID);
            return sql.ExcuteQuery(Query, parm);
        }
        //اضافة الى جدول الصرف من حساب
        public void AddNewSpend(int TheNumber, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, int UserID, string AccountClientNm, string AccountCashingNm)
        {
            //اضافة في جدول الصرف
            AddNewSpendP(TheNumber, TheDate, Amount, CurncyID, AccountID, AccountExchangeClient, Note, Delivery, UserID);
            // جلب الايدي 
            int IDSpend = GetIDSpendByNumber(TheNumber);
            // اضافة القيد الرئيسي 13 رمظ مستند صرف من حساب
            int ParentEntity = AddNewEntity(13, TheDate, UserID, TheDate.Year, IDSpend);
            //اضافة القيد الدائن حساب الصندوق
            AddNewEntityDetalies(ParentEntity, Amount, CurncyID, AccountID, " مقابل صرف من حساب " + AccountClientNm + " برقم  " + TheNumber + " مناولة " + Delivery);
            //اضافة القيد المدين حساب العميل
            AddNewEntityDetalies(ParentEntity, (-1 * Amount), CurncyID, AccountExchangeClient, "  صرف من حساب  " + AccountCashingNm + " برقم  " + TheNumber + " مناولة " + Delivery);

        }
        //تعديل في جدول الصرف من حساب
        public void UpdateSpend(int ID, int TheNumber, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, int UserID, string AccountClientNm, string AccountCashingNm)
        {
            //تعديل في جدول الصرف من حساب
            UpdateSpend1(ID, TheDate, Amount, CurncyID, AccountID, AccountExchangeClient, Note, Delivery, AccountClientNm, AccountCashingNm);
            // جلب رقم القيد الاساسي باستخد رقم السمتند ونوعه 13 يعني صرف من حساب
            int ParntEntity = GetEntityID(13, ID);
            //حذف القيود التفصلية لاضافتها مره اخرى بعد التعديل
            DeleteEntityDetalies(ParntEntity);
            //اضافة القيد الدائن حساب الصندوق
            AddNewEntityDetalies(ParntEntity, Amount, CurncyID, AccountID, " مقابل صرف من حساب " + AccountClientNm + " برقم  " + TheNumber + " مناولة " + Delivery);
            //اضافة القيد المدين حساب العميل
            AddNewEntityDetalies(ParntEntity, (-1 * Amount), CurncyID, AccountExchangeClient, "  صرف من حساب  " + AccountCashingNm + " برقم  " + TheNumber + " مناولة " + Delivery);

        }
        //تعديل في جدول الصرف من حساب
        private int UpdateSpend1(int ID, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, string AccountClientNm, string AccountCashingNm)
        {
            string Query = "  update tblSpend set TheDate=@TheDate,Amount=@Amount,CurncyID=@CurncyID,AccountID=@AccountID,AccountExchangeClient=@AccountExchangeClient,Note=@Note,Delivery=@Delivery where ID=@ID";
            SqlParameter[] parm = new SqlParameter[8];
            parm[0] = new SqlParameter("@ID", ID);
            parm[1] = new SqlParameter("@TheDate", TheDate);
            parm[2] = new SqlParameter("@Amount", Amount);
            parm[3] = new SqlParameter("@CurncyID", CurncyID);
            parm[4] = new SqlParameter("@AccountID", AccountID);
            parm[5] = new SqlParameter("@AccountExchangeClient", AccountExchangeClient);
            parm[6] = new SqlParameter("@Note", Note);
            parm[7] = new SqlParameter("@Delivery", Delivery);

            return sql.ExcuteQuery(Query, parm);
        }
        //جلب اكبر رقم في جدول صرف من حساب
        public int GetMaxInSpend()
        {
            string Query = "  select ISNULL(max(TheNumber),0) from tblSpend";
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, null));
        }
        //جلب id من جدول من صرف الحساب بساتخدام الرقم
        public int GetIDSpendByNumber(int number)
        {
            string Query = "select ISNULL(ID,0) from tblSpend where TheNumber=@TheNumber";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@TheNumber", number);
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));
        }
        // جلب سحب من حساب باستخدام الرقم
        public DataTable GetSpendByNumber(int Number)
        {
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب الصرف' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'مناولة',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewSpend where TheNumber=@TheNumber";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@TheNumber", Number);
            return sql.SelectData(Query, parm);
        }
        // جلب سحب من حساب باستخدام شرط
        public DataTable GetSpendByReson(string Reson)
        {
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب الصرف' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'مناولة',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewSpend where  ";
            Query += Reson;
            return sql.SelectData(Query, null);
        }
        //جلب سحب من حسابباستخدام تاريخ معين
        public DataTable GetSpendByDate(DateTime d1, DateTime d2)
        {
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب الصرف' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'مناولة',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewSpend where TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@d1", d1);
            parm[1] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        //  جلب حساب الصرف والقبض من جدول جدول حسابات النظام
        public int GetAccountBysystemAccoountID(int ID)
        {
            string Query = "select ISNULL(IDAccount,0) from tblAccountSystem where ID=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));

        }
        // حذف سند صرف
        public void DelelteSpend(int ID)
        {  // حذف سند صرف من جدول الصرف من حساب
            DelelteSpend1(ID);
            // جلب رقم القيد الرئيسي
            int IDEntity = GetEntityID(13, ID);
            // حذف القيد الرئيسي
            DeleteEntity(IDEntity);
            // حذف القيود التفصيلية
            DeleteEntityDetalies(IDEntity);


        }
        // حذف سند صرف من جدول الصرف من حساب
        private int DelelteSpend1(int ID)
        {
            string Query = "delete from tblSpend where ID=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return sql.ExcuteQuery(Query, parm);
        }
        //حذف قيد رئيسي
        private int DeleteEntity(int ID)
        {
            string Query = "  delete from tblEntries where ID=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return sql.ExcuteQuery(Query, parm);
        }
        //جلب سند صرف باستخدام المبلغ
        public DataTable GetSpendByAmount(string Amount,DateTime d1,DateTime d2)
        {
            Amount = "%" + Amount + "%";
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب الصرف' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'مناولة',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewSpend where Amount like @Amount and TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@Amount", Amount);
            parm[1] = new SqlParameter("@d1", d1);
            parm[2] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        // جلب سند صرف باستخدام اسم العملة
        public DataTable GetSpendByCurnncyNm(string CurncyNm, DateTime d1, DateTime d2)
        {
            CurncyNm = CurncyNm + "%";
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب الصرف' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'مناولة',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewSpend where CurrncyName like @CurrncyName and TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@CurrncyName", CurncyNm);
            parm[1] = new SqlParameter("@d1", d1);
            parm[2] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        // جلب سند صرف باستخدام اسم الحساب
        public DataTable GetSpendByAccountNm(string AccountNm, DateTime d1, DateTime d2)
        {
            AccountNm = AccountNm + "%";
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب الصرف' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'مناولة',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewSpend where AccountClient like @AccountClient and TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@AccountClient", AccountNm);
            parm[1] = new SqlParameter("@d1", d1);
            parm[2] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        #endregion
        // قبض الى حساب
        #region
        //اضافة الى جدول قبض الى حساب
        private int AddNewReivceP(int TheNumber, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, int UserID)
        {
            string Query = "  insert into tblRecive (TheNumber,TheDate,Amount,CurncyID,AccountID,AccountExchangeClient,Note,Delivery,UserID) values(@TheNumber,@TheDate,@Amount,@CurncyID,@AccountID,@AccountExchangeClient,@Note,@Delivery,@UserID)";
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@TheNumber", TheNumber);
            parm[1] = new SqlParameter("@TheDate", TheDate);
            parm[2] = new SqlParameter("@Amount", Amount);
            parm[3] = new SqlParameter("@CurncyID", CurncyID);
            parm[4] = new SqlParameter("@AccountID", AccountID);
            parm[5] = new SqlParameter("@AccountExchangeClient", AccountExchangeClient);
            parm[6] = new SqlParameter("@Note", Note);
            parm[7] = new SqlParameter("@Delivery", Delivery);
            parm[8] = new SqlParameter("@UserID", UserID);
            return sql.ExcuteQuery(Query, parm);
        }
        //اضافة الى جدول قبض  الى حساب
        public void AddNewRecive(int TheNumber, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, int UserID, string AccountClientNm, string AccountCashingNm)
        {
            //اضافة في جدول قبض الى حساب
            AddNewReivceP(TheNumber, TheDate, Amount, CurncyID, AccountID, AccountExchangeClient, Note, Delivery, UserID);
            // جلب الايدي 
            int IDReivce = GetIDReviveByNumber(TheNumber);
            // اضافة القيد الرئيس  14 رمز المستند قبض الى حساب
            int ParentEntity = AddNewEntity(14, TheDate, UserID, TheDate.Year, IDReivce);
            //اضافة القيد المدين حساب الصندوق
            AddNewEntityDetalies(ParentEntity, (-1 * Amount), CurncyID, AccountID, " مقابل قبض الى حساب " + AccountClientNm + " برقم  " + TheNumber + " ايداع " + Delivery);
            //اضافة القيد الدائن حساب العميل
            AddNewEntityDetalies(ParentEntity, Amount, CurncyID, AccountExchangeClient, "  قبض الى حسابكم في  " + AccountCashingNm + " برقم  " + TheNumber + " ايداع " + Delivery);

        }
        //جلب id من جدول من قبض الى الحساب بساتخدام الرقم
        public int GetIDReviveByNumber(int number)
        {
            string Query = "select ISNULL(ID,0) from tblRecive where TheNumber=@TheNumber";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@TheNumber", number);
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, parm));
        }
        //تعديل في جدول قبض الى حساب
        public void UpdateRecive(int ID, int TheNumber, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, int UserID, string AccountClientNm, string AccountCashingNm)
        {
            //تعديل في جدول الصرف من حساب
            UpdateRecive1(ID, TheDate, Amount, CurncyID, AccountID, AccountExchangeClient, Note, Delivery, AccountClientNm, AccountCashingNm);
            // جلب رقم القيد الاساسي باستخد رقم السمتند ونوعه 13 يعني صرف من حساب
            int ParntEntity = GetEntityID(14, ID);
            //حذف القيود التفصلية لاضافتها مره اخرى بعد التعديل
            DeleteEntityDetalies(ParntEntity);
            //اضافة القيد المدين حساب الصندوق
            AddNewEntityDetalies(ParntEntity, (-1 * Amount), CurncyID, AccountID, " مقابل قبض الى حساب " + AccountClientNm + " برقم  " + TheNumber + " ايداع " + Delivery);
            //اضافة القيد الدائن حساب العميل
            AddNewEntityDetalies(ParntEntity, Amount, CurncyID, AccountExchangeClient, "  قبض الى حسابكم في  " + AccountCashingNm + " برقم  " + TheNumber + " ايداع " + Delivery);
        }
        //تعديل في جدول قبض الى حساب
        private int UpdateRecive1(int ID, DateTime TheDate, double Amount, int CurncyID, int AccountID, int AccountExchangeClient, string Note, string Delivery, string AccountClientNm, string AccountCashingNm)
        {
            string Query = "  update tblRecive set TheDate=@TheDate,Amount=@Amount,CurncyID=@CurncyID,AccountID=@AccountID,AccountExchangeClient=@AccountExchangeClient,Note=@Note,Delivery=@Delivery where ID=@ID";
            SqlParameter[] parm = new SqlParameter[8];
            parm[0] = new SqlParameter("@ID", ID);
            parm[1] = new SqlParameter("@TheDate", TheDate);
            parm[2] = new SqlParameter("@Amount", Amount);
            parm[3] = new SqlParameter("@CurncyID", CurncyID);
            parm[4] = new SqlParameter("@AccountID", AccountID);
            parm[5] = new SqlParameter("@AccountExchangeClient", AccountExchangeClient);
            parm[6] = new SqlParameter("@Note", Note);
            parm[7] = new SqlParameter("@Delivery", Delivery);

            return sql.ExcuteQuery(Query, parm);
        }
        //جلب اكبر رقم في جدول قبض الى حساب
        public int GetMaxRecive()
        {
            string Query = "  select ISNULL(max(TheNumber),0) from tblRecive";
            return Convert.ToInt32(sql.ExcuteQueryValue(Query, null));
        }
        // جلب قبض الى باستخدام الرقم
        public DataTable GetReciveByNumber(int Number)
        {
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب القبض' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'ايداع',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewRecive where TheNumber=@TheNumber";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@TheNumber", Number);
            return sql.SelectData(Query, parm);
        }
        // جلب قبض الى باستخدام الشرط
        public DataTable GetReciveByReson(string Reson)
        {
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب القبض' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'ايداع',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewRecive where ";
            Query += Reson;
            return sql.SelectData(Query, null);
        }
        //جلب  قبض الى حساب باستخدام تاريخ معين
        public DataTable GetReciveByDate(DateTime d1, DateTime d2)
        {
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب القبض' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'ايداع',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewRecive where TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@d1", d1);
            parm[1] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
      
        // حذف سند قبض الى حساب
        public void DelelteRecive(int ID)
        {  // حذف قبض  من جدول القبض الى حساب
            DelelteRecive1(ID);
            // جلب رقم القيد الرئيسي
            int IDEntity = GetEntityID(14, ID);
            // حذف القيد الرئيسي
            DeleteEntity(IDEntity);
            // حذف القيود التفصيلية
            DeleteEntityDetalies(IDEntity);


        }
        // حذف سند قبض من جدول القبض الى  حساب
        private int DelelteRecive1(int ID)
        {
            string Query = "delete from tblRecive where ID=@ID";
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", ID);
            return sql.ExcuteQuery(Query, parm);
        }
       
        //جلب سند قبض باستخدام المبلغ
        public DataTable GetReicveByAmount(string Amount, DateTime d1, DateTime d2)
        {
            Amount = "%" + Amount + "%";
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب القبض' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'ايداع',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewRecive where Amount like @Amount and TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@Amount", Amount);
            parm[1] = new SqlParameter("@d1", d1);
            parm[2] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        // جلب سند قبض باستخدام اسم العملة
        public DataTable GetReicveByCurnncyNm(string CurncyNm, DateTime d1, DateTime d2)
        {
            CurncyNm = CurncyNm + "%";
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب القبض' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'ايداع',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewRecive where CurrncyName like @CurrncyName and TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@CurrncyName", CurncyNm);
            parm[1] = new SqlParameter("@d1", d1);
            parm[2] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        // جلب سند قبض باستخدام اسم الحساب
        public DataTable GetReicveByAccountNm(string AccountNm, DateTime d1, DateTime d2)
        {
            AccountNm = AccountNm + "%";
            string Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب القبض' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'ايداع',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewRecive where AccountClient like @AccountClient and TheDate >=@d1 and TheDate<@d2";
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@AccountClient", AccountNm);
            parm[1] = new SqlParameter("@d1", d1);
            parm[2] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        #endregion
        //تقرير قبض الى حساب
        #region 
       
        //جلب العملات
        public DataTable GetCurnncyForReports()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("الرقم");
            dt.Columns.Add("الاسم");
            dt.NewRow();
            dt.Rows.Add(new object[] { 0, "<< كل العملات>>" });
            
            DataTable dt1 = new DataTable();
            dt1 = GetAllCurnncy();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dt.Rows.Add(new object[] { dt1.Rows[i][0], dt1.Rows[i][1] });
            }
            return dt;

        }

        // جلب الحسابات الفرعية
        public DataTable GetaccountsForReports()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("الرقم");
            dt.Columns.Add("الحساب");
            dt.NewRow();
            dt.Rows.Add(new object[] { 0, "<<كل الحسابات>>" });
            DataTable dt1 = new DataTable();
            dt1 = GetAccounts();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dt.Rows.Add(new object[] { dt1.Rows[i][0], dt1.Rows[i][1] });
            }
            return dt;

        }
        // get Accounts
        public DataTable GetAccounts()
        {
            string Query = "select ID as'الرقم',AccountName as'الحساب' from tblAccounts where AccountType='فرعي' and Active=1";
            return sql.SelectData(Query, null);
        }
        //جلب تقرير ستد قبض
     public DataTable GetReciveReport(string AccountNmClinet,string AccountCashing,string CurnncyNm,int TYP,DateTime d1,DateTime d2)
        {
            AccountNmClinet = "%" + AccountNmClinet + "%";
            AccountCashing = "%" + AccountCashing + "%";
            CurnncyNm = "%" + CurnncyNm + "%";
            string Query = "";
            if(TYP==0)//اجمالي
            {
                Query = "select AccountClient as 'حساب القبض' , sum(cast( Amount as decimal(18, 2)))as 'المبلغ',CurrncyName as 'العملة' from VewRecive where AccountClient like @AccountClient and CurrncyName like @CurrncyName and Accountcashier like @Accountcashier  and TheDate >=@d1 and TheDate<@d2 group by AccountClient,CurrncyName";
            }
            else // تفصيلي
            {
                 Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب القبض' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'ايداع',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewRecive where AccountClient like @AccountClient and CurrncyName like @CurrncyName and Accountcashier like @Accountcashier  and TheDate >=@d1 and TheDate<@d2";

            }
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@AccountClient", AccountNmClinet);
            parm[1] = new SqlParameter("@CurrncyName", CurnncyNm);
            parm[2] = new SqlParameter("@Accountcashier", AccountCashing);
            parm[3] = new SqlParameter("@d1", d1);
            parm[4] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        #endregion
        // تقرير سند الصرف 
        #region
            // جلب تقرير سند القبض
        public DataTable GetSpendReport(string AccountNmClinet, string AccountCashing, string CurnncyNm, int TYP, DateTime d1, DateTime d2)
        {
            AccountNmClinet = "%" + AccountNmClinet + "%";
            AccountCashing = "%" + AccountCashing + "%";
            CurnncyNm = "%" + CurnncyNm + "%";
            string Query = "";
            if (TYP == 0)//اجمالي
            {
                Query = "select AccountClient as 'حساب الصرف' , sum(cast( Amount as decimal(18, 2)))as 'المبلغ',CurrncyName as 'العملة' from VewSpend where AccountClient like @AccountClient and CurrncyName like @CurrncyName and Accountcashier like @Accountcashier  and TheDate >=@d1 and TheDate<@d2 group by AccountClient,CurrncyName";
            }
            else // تفصيلي
            {
                Query = "select TheNumber as 'الرقم',Amount as 'المبلغ',CurrncyName as 'العملة',AccountClient as 'حساب الصرف' ,Accountcashier as 'الصندوق',TheDate as 'التاريخ' , Delivery as 'مناولة',Note as 'ملاحظات',DateEnter as 'تاريخ الادخال' ,UserName as 'مستخدم الادخال' from VewSpend where AccountClient like @AccountClient and CurrncyName like @CurrncyName and Accountcashier like @Accountcashier  and TheDate >=@d1 and TheDate<@d2";

            }
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@AccountClient", AccountNmClinet);
            parm[1] = new SqlParameter("@CurrncyName", CurnncyNm);
            parm[2] = new SqlParameter("@Accountcashier", AccountCashing);
            parm[3] = new SqlParameter("@d1", d1);
            parm[4] = new SqlParameter("@d2", d2);
            return sql.SelectData(Query, parm);
        }
        #endregion
    }
}
