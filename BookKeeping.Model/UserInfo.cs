/**  版本信息模板在安装目录下，可自行修改。
* UserInfo.cs
*
* 功 能： N/A
* 类 名： UserInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/3/31 18:41:08   N/A    初版
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
	/// UserInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region Model
		private int _uid;
		private string _username;
		private string _upassword;
		private bool _uisdelete= false;
		private bool _uisadmin;
		/// <summary>
		/// 
		/// </summary>
		public int UId
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string upassword
		{
			set{ _upassword=value;}
			get{return _upassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool uisdelete
		{
			set{ _uisdelete=value;}
			get{return _uisdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool uisadmin
		{
			set{ _uisadmin=value;}
			get{return _uisadmin;}
		}
		#endregion Model

	}
}

