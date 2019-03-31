/**  版本信息模板在安装目录下，可自行修改。
* ExpenseIncomeDetailInfo.cs
*
* 功 能： N/A
* 类 名： ExpenseIncomeDetailInfo
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
	/// ExpenseIncomeDetailInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ExpenseIncomeDetailInfo
	{
		public ExpenseIncomeDetailInfo()
		{}
		#region Model
		private int _edid;
		private int? _eduid;
		private int? _edtid;
		private DateTime? _eddatetime;
		private decimal? _edmoney;
		private bool _edisdelete= false;
		private int? _edtype=2;
		/// <summary>
		/// 
		/// </summary>
		public int edid
		{
			set{ _edid=value;}
			get{return _edid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? eduid
		{
			set{ _eduid=value;}
			get{return _eduid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? edtid
		{
			set{ _edtid=value;}
			get{return _edtid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? eddatetime
		{
			set{ _eddatetime=value;}
			get{return _eddatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? edmoney
		{
			set{ _edmoney=value;}
			get{return _edmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool edisdelete
		{
			set{ _edisdelete=value;}
			get{return _edisdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? edtype
		{
			set{ _edtype=value;}
			get{return _edtype;}
		}
		#endregion Model

	}
}

