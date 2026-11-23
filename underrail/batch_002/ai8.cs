using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001C18 RID: 7192
public abstract class ai8 : c6m
{
	// Token: 0x17000297 RID: 663
	// (get) Token: 0x06009DDC RID: 40412 RVA: 0x003E0D94 File Offset: 0x003DEF94
	public string Name
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x06009DDD RID: 40413 RVA: 0x003E0D9C File Offset: 0x003DEF9C
	public int MinimalLevel
	{
		get
		{
			if (this.b == null)
			{
				this.b = this.a();
			}
			return this.b.Value;
		}
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06009DDE RID: 40414 RVA: 0x003E0DC8 File Offset: 0x003DEFC8
	public virtual bool Purchasable
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x06009DDF RID: 40415 RVA: 0x003E0DCC File Offset: 0x003DEFCC
	public virtual bool IsAvailableToMutant
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x003E0DD0 File Offset: 0x003DEFD0
	public virtual bool Enabled
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x06009DE1 RID: 40417 RVA: 0x003E0DD4 File Offset: 0x003DEFD4
	public virtual bool Visible
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x06009DE2 RID: 40418 RVA: 0x003E0DD8 File Offset: 0x003DEFD8
	public virtual bool Veteran
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x003E0DDC File Offset: 0x003DEFDC
	public virtual string DLC
	{
		get
		{
			return null;
		}
	}

	// Token: 0x06009DE4 RID: 40420 RVA: 0x003E0DE0 File Offset: 0x003DEFE0
	protected ai8(string A_0)
	{
		czh.a(A_0, "name");
		this.a = A_0;
	}

	// Token: 0x06009DE5 RID: 40421 RVA: 0x003E0DFC File Offset: 0x003DEFFC
	public virtual List<brl> j0()
	{
		return null;
	}

	// Token: 0x06009DE6 RID: 40422 RVA: 0x003E0E00 File Offset: 0x003DF000
	public bool a(efk A_0, out brl A_1)
	{
		czh.a(A_0, "character");
		A_1 = null;
		if (!this.IsAvailableToMutant && A_0.b(d8o.t))
		{
			return false;
		}
		List<brl> list = this.j0();
		if (list != null)
		{
			foreach (brl brl in list)
			{
				if (!brl.oh(A_0))
				{
					A_1 = brl;
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x06009DE7 RID: 40423 RVA: 0x003E0EA0 File Offset: 0x003DF0A0
	public bool d(efk A_0)
	{
		brl brl;
		return this.a(A_0, out brl);
	}

	// Token: 0x06009DE8 RID: 40424 RVA: 0x003E0EB8 File Offset: 0x003DF0B8
	public ctu e()
	{
		return new ctu(base.GetType());
	}

	// Token: 0x06009DE9 RID: 40425 RVA: 0x003E0EC8 File Offset: 0x003DF0C8
	public virtual void ar(efk A_0)
	{
	}

	// Token: 0x06009DEA RID: 40426 RVA: 0x003E0ECC File Offset: 0x003DF0CC
	public virtual void @as(efk A_0)
	{
	}

	// Token: 0x06009DEB RID: 40427 RVA: 0x003E0ED0 File Offset: 0x003DF0D0
	public virtual object[] at()
	{
		return new object[0];
	}

	// Token: 0x06009DEC RID: 40428 RVA: 0x003E0EDC File Offset: 0x003DF0DC
	public virtual string wn()
	{
		string text = this.nq();
		if (!string.IsNullOrEmpty(text))
		{
			return ck.a(base.GetType()) + "-" + text;
		}
		return ck.a(base.GetType());
	}

	// Token: 0x06009DED RID: 40429 RVA: 0x003E0F20 File Offset: 0x003DF120
	public virtual List<d3e> cy(efk A_0)
	{
		return null;
	}

	// Token: 0x06009DEE RID: 40430 RVA: 0x003E0F24 File Offset: 0x003DF124
	protected virtual string nq()
	{
		return null;
	}

	// Token: 0x06009DEF RID: 40431 RVA: 0x003E0F28 File Offset: 0x003DF128
	private int? a()
	{
		int num = 1;
		List<brl> list = this.j0();
		if (list != null)
		{
			foreach (brl brl in list)
			{
				num = Math.Max(num, brl.og());
			}
		}
		return new int?(num);
	}

	// Token: 0x06009DF0 RID: 40432 RVA: 0x003E0F98 File Offset: 0x003DF198
	public static string a(ai8 A_0)
	{
		if (A_0 == null)
		{
			return "Unknown";
		}
		string text = A_0.Name;
		string text2 = qv.b("FeatNames/" + text);
		if (!string.IsNullOrEmpty(text2))
		{
			text = text2;
		}
		return text;
	}

	// Token: 0x06009DF1 RID: 40433 RVA: 0x003E0FD8 File Offset: 0x003DF1D8
	public static string b(Type A_0)
	{
		d29 d = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(d29), false)) as d29;
		if (d != null)
		{
			string text = d.a();
			string text2 = qv.b("FeatNames/" + text);
			if (!string.IsNullOrEmpty(text2))
			{
				text = text2;
			}
			return text;
		}
		return "Unknown";
	}

	// Token: 0x06009DF2 RID: 40434 RVA: 0x003E1034 File Offset: 0x003DF234
	public static string a(Type A_0)
	{
		d29 d = Enumerable.FirstOrDefault<object>(A_0.GetCustomAttributes(typeof(d29), false)) as d29;
		if (d != null)
		{
			return d.b();
		}
		return "Unknown";
	}

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06009DF3 RID: 40435 RVA: 0x003E1070 File Offset: 0x003DF270
	public string LocalizedName
	{
		get
		{
			return ai8.a(this);
		}
	}

	// Token: 0x04003D45 RID: 15685
	private string a;

	// Token: 0x04003D46 RID: 15686
	private int? b;
}
