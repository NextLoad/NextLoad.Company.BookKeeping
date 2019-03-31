/**  版本信息模板在安装目录下，可自行修改。
* ExpenseIncomeTypeInfo.cs
*
* 功 能： N/A
* 类 名： ExpenseIncomeTypeInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/3/31 18:41:07   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace BookKeeping.Model
{
	/// <summary>
	/// ExpenseIncomeTypeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExpenseIncomeTypeInfo
	{
		public ExpenseIncomeTypeInfo()
		{}
		#region Model
		private int _eid;
		private string _etitle;
		private bool _eisdelete= false;
		/// <summary>
		/// 
		/// </summary>
		public int EId
		{
			set{ _eid=value;}
			get{return _eid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string etitle
		{
			set{ _etitle=value;}
			get{return _etitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool eisdelete
		{
			set{ _eisdelete=value;}
			get{return _eisdelete;}
		}

        public int EIId { get; set; }
        #endregion Model

    }
}

