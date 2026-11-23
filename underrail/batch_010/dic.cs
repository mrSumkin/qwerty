using System;
using System.Runtime.Serialization;

// Token: 0x02000FE7 RID: 4071
[eiz("VHLS")]
[Serializable]
public sealed class dic : ISerializable
{
	// Token: 0x060053D1 RID: 21457 RVA: 0x002518D0 File Offset: 0x0024FAD0
	private dic(SerializationInfo A_0, StreamingContext A_1)
	{
		this.h = A_0.GetString("VHLS:C");
		this.i = A_0.GetString("VHLS:N");
		this.j = A_0.GetInt32("VHLS:P");
		this.k = A_0.GetBoolean("VHLS:T");
		this.l = A_0.GetString("VHLS:F");
		this.m = (A_0.GetValue("VHLS:E", typeof(ar7)) as ar7);
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x00251958 File Offset: 0x0024FB58
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VHLS:C", this.h);
		info.AddValue("VHLS:N", this.i);
		info.AddValue("VHLS:P", this.j);
		info.AddValue("VHLS:T", this.k);
		info.AddValue("VHLS:F", this.l);
		info.AddValue("VHLS:E", this.m);
	}

	// Token: 0x060053D3 RID: 21459 RVA: 0x002519CC File Offset: 0x0024FBCC
	public string c()
	{
		return this.h;
	}

	// Token: 0x060053D4 RID: 21460 RVA: 0x002519D4 File Offset: 0x0024FBD4
	public void a(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x060053D5 RID: 21461 RVA: 0x002519E0 File Offset: 0x0024FBE0
	// (set) Token: 0x060053D6 RID: 21462 RVA: 0x002519E8 File Offset: 0x0024FBE8
	public string DisplayName
	{
		get
		{
			return this.i;
		}
		set
		{
			this.i = value;
		}
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x002519F4 File Offset: 0x0024FBF4
	public bool d()
	{
		return this.k;
	}

	// Token: 0x060053D8 RID: 21464 RVA: 0x002519FC File Offset: 0x0024FBFC
	public void a(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x060053D9 RID: 21465 RVA: 0x00251A08 File Offset: 0x0024FC08
	public int e()
	{
		return this.j;
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x00251A10 File Offset: 0x0024FC10
	public void a(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060053DB RID: 21467 RVA: 0x00251A1C File Offset: 0x0024FC1C
	public string a()
	{
		return this.l;
	}

	// Token: 0x060053DC RID: 21468 RVA: 0x00251A24 File Offset: 0x0024FC24
	public void b(string A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060053DD RID: 21469 RVA: 0x00251A30 File Offset: 0x0024FC30
	public ar7 b()
	{
		return this.m;
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x00251A38 File Offset: 0x0024FC38
	public void a(ar7 A_0)
	{
		this.m = A_0;
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x060053DF RID: 21471 RVA: 0x00251A44 File Offset: 0x0024FC44
	public int BuyPriceWithDiscount0
	{
		get
		{
			return Convert.ToInt32((double)this.j * dic.a);
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x060053E0 RID: 21472 RVA: 0x00251A58 File Offset: 0x0024FC58
	public int BuyPriceWithDiscount1
	{
		get
		{
			return Convert.ToInt32((double)this.j * dic.a * (1.0 - dic.b));
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x060053E1 RID: 21473 RVA: 0x00251A7C File Offset: 0x0024FC7C
	public int BuyPriceWithDiscount2
	{
		get
		{
			return Convert.ToInt32((double)this.j * dic.a * (1.0 - dic.c));
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x060053E2 RID: 21474 RVA: 0x00251AA0 File Offset: 0x0024FCA0
	public int BuyPriceWithDiscount3
	{
		get
		{
			return Convert.ToInt32((double)this.j * dic.a * (1.0 - dic.d));
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x060053E3 RID: 21475 RVA: 0x00251AC4 File Offset: 0x0024FCC4
	public int SellPriceWithIncrease0
	{
		get
		{
			return this.j;
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x060053E4 RID: 21476 RVA: 0x00251ACC File Offset: 0x0024FCCC
	public int SellPriceWithIncrease1
	{
		get
		{
			return Convert.ToInt32((double)this.j * (1.0 + dic.e));
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x060053E5 RID: 21477 RVA: 0x00251AEC File Offset: 0x0024FCEC
	public int SellPriceWithIncrease2
	{
		get
		{
			return Convert.ToInt32((double)this.j * (1.0 + dic.f));
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x060053E6 RID: 21478 RVA: 0x00251B0C File Offset: 0x0024FD0C
	public int SellPriceWithIncrease3
	{
		get
		{
			return Convert.ToInt32((double)this.j * (1.0 + dic.g));
		}
	}

	// Token: 0x060053E7 RID: 21479 RVA: 0x00251B2C File Offset: 0x0024FD2C
	public dic()
	{
	}

	// Token: 0x04002230 RID: 8752
	private static readonly double a = 2.0;

	// Token: 0x04002231 RID: 8753
	private static readonly double b = 0.1;

	// Token: 0x04002232 RID: 8754
	private static readonly double c = 0.2;

	// Token: 0x04002233 RID: 8755
	private static readonly double d = 0.3;

	// Token: 0x04002234 RID: 8756
	private static readonly double e = 0.1;

	// Token: 0x04002235 RID: 8757
	private static readonly double f = 0.2;

	// Token: 0x04002236 RID: 8758
	private static readonly double g = 0.3;

	// Token: 0x04002237 RID: 8759
	private string h;

	// Token: 0x04002238 RID: 8760
	private string i;

	// Token: 0x04002239 RID: 8761
	private int j;

	// Token: 0x0400223A RID: 8762
	private bool k;

	// Token: 0x0400223B RID: 8763
	private string l;

	// Token: 0x0400223C RID: 8764
	private ar7 m;
}
