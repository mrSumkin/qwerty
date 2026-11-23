using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200110E RID: 4366
[eiz("S15")]
[Serializable]
public sealed class bi5 : cze, ISerializable
{
	// Token: 0x06005CBD RID: 23741 RVA: 0x00279794 File Offset: 0x00277994
	private bi5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S15:I", typeof(int?)) as int?);
		this.b = (A_0.GetValue("S15:C", typeof(Color?)) as Color?);
		this.c = A_0.GetBoolean("S15:SC");
		this.d = (A_0.GetValue("S15:A", typeof(float?)) as float?);
		this.e = A_0.GetBoolean("S15:SA");
		if (ell.a() >= 286)
		{
			this.f = A_0.GetInt32("S15:FX");
			this.g = A_0.GetInt32("S15:FY");
			this.h = A_0.GetBoolean("S15:SFX");
			this.i = A_0.GetBoolean("S15:SFY");
		}
		else if (ell.a() >= 233)
		{
			Point point = (Point)A_0.GetValue("S15:F", typeof(Point));
			bool boolean = A_0.GetBoolean("S15:SF");
			this.f = point.X;
			this.g = point.Y;
			this.h = boolean;
			this.i = boolean;
		}
		if (ell.a() >= 501)
		{
			this.n = (bvl)A_0.GetValue("S15:XS", typeof(bvl));
			this.o = A_0.GetString("S15:XA");
			this.p = (A_0.GetValue("S15:XI", typeof(Guid?)) as Guid?);
		}
		if (ell.a() >= 526)
		{
			this.j = A_0.GetBoolean("S15:SB");
			this.k = A_0.GetSingle("S15:B");
		}
		if (ell.a() >= 680)
		{
			this.l = A_0.GetBoolean("S15:SM");
			this.m = A_0.GetString("S15:M");
		}
	}

	// Token: 0x06005CBE RID: 23742 RVA: 0x002799BC File Offset: 0x00277BBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S15:I", this.a);
		info.AddValue("S15:C", this.b);
		info.AddValue("S15:SC", this.c);
		info.AddValue("S15:A", this.d);
		info.AddValue("S15:SA", this.e);
		info.AddValue("S15:FX", this.f);
		info.AddValue("S15:SFX", this.h);
		info.AddValue("S15:FY", this.g);
		info.AddValue("S15:SFY", this.i);
		info.AddValue("S15:XS", this.n);
		info.AddValue("S15:XA", this.o);
		info.AddValue("S15:XI", this.p);
		info.AddValue("S15:SB", this.j);
		info.AddValue("S15:B", this.k);
		info.AddValue("S15:SM", this.l);
		info.AddValue("S15:M", this.m);
	}

	// Token: 0x06005CBF RID: 23743 RVA: 0x00279AFC File Offset: 0x00277CFC
	public int? m()
	{
		return this.a;
	}

	// Token: 0x06005CC0 RID: 23744 RVA: 0x00279B04 File Offset: 0x00277D04
	public void a(int? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005CC1 RID: 23745 RVA: 0x00279B10 File Offset: 0x00277D10
	public Color? h()
	{
		return this.b;
	}

	// Token: 0x06005CC2 RID: 23746 RVA: 0x00279B18 File Offset: 0x00277D18
	public void a(Color? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005CC3 RID: 23747 RVA: 0x00279B24 File Offset: 0x00277D24
	public bool p()
	{
		return this.c;
	}

	// Token: 0x06005CC4 RID: 23748 RVA: 0x00279B2C File Offset: 0x00277D2C
	public void e(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005CC5 RID: 23749 RVA: 0x00279B38 File Offset: 0x00277D38
	public float? i()
	{
		return this.d;
	}

	// Token: 0x06005CC6 RID: 23750 RVA: 0x00279B40 File Offset: 0x00277D40
	public void a(float? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005CC7 RID: 23751 RVA: 0x00279B4C File Offset: 0x00277D4C
	public bool k()
	{
		return this.e;
	}

	// Token: 0x06005CC8 RID: 23752 RVA: 0x00279B54 File Offset: 0x00277D54
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005CC9 RID: 23753 RVA: 0x00279B60 File Offset: 0x00277D60
	public int c()
	{
		return this.f;
	}

	// Token: 0x06005CCA RID: 23754 RVA: 0x00279B68 File Offset: 0x00277D68
	public void b(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005CCB RID: 23755 RVA: 0x00279B74 File Offset: 0x00277D74
	public int l()
	{
		return this.g;
	}

	// Token: 0x06005CCC RID: 23756 RVA: 0x00279B7C File Offset: 0x00277D7C
	public void a(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005CCD RID: 23757 RVA: 0x00279B88 File Offset: 0x00277D88
	public bool n()
	{
		return this.h;
	}

	// Token: 0x06005CCE RID: 23758 RVA: 0x00279B90 File Offset: 0x00277D90
	public void b(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005CCF RID: 23759 RVA: 0x00279B9C File Offset: 0x00277D9C
	public bool o()
	{
		return this.i;
	}

	// Token: 0x06005CD0 RID: 23760 RVA: 0x00279BA4 File Offset: 0x00277DA4
	public void c(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06005CD1 RID: 23761 RVA: 0x00279BB0 File Offset: 0x00277DB0
	public bvl j()
	{
		return this.n;
	}

	// Token: 0x06005CD2 RID: 23762 RVA: 0x00279BB8 File Offset: 0x00277DB8
	public void a(bvl A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06005CD3 RID: 23763 RVA: 0x00279BC4 File Offset: 0x00277DC4
	public string f()
	{
		return this.o;
	}

	// Token: 0x06005CD4 RID: 23764 RVA: 0x00279BCC File Offset: 0x00277DCC
	public void b(string A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06005CD5 RID: 23765 RVA: 0x00279BD8 File Offset: 0x00277DD8
	public Guid? g()
	{
		return this.p;
	}

	// Token: 0x06005CD6 RID: 23766 RVA: 0x00279BE0 File Offset: 0x00277DE0
	public void a(Guid? A_0)
	{
		this.p = A_0;
	}

	// Token: 0x06005CD7 RID: 23767 RVA: 0x00279BEC File Offset: 0x00277DEC
	public bool b()
	{
		return this.j;
	}

	// Token: 0x06005CD8 RID: 23768 RVA: 0x00279BF4 File Offset: 0x00277DF4
	public void d(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06005CD9 RID: 23769 RVA: 0x00279C00 File Offset: 0x00277E00
	public float a()
	{
		return this.k;
	}

	// Token: 0x06005CDA RID: 23770 RVA: 0x00279C08 File Offset: 0x00277E08
	public void a(float A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06005CDB RID: 23771 RVA: 0x00279C14 File Offset: 0x00277E14
	public bool e()
	{
		return this.l;
	}

	// Token: 0x06005CDC RID: 23772 RVA: 0x00279C1C File Offset: 0x00277E1C
	public void f(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06005CDD RID: 23773 RVA: 0x00279C28 File Offset: 0x00277E28
	public string d()
	{
		return this.m;
	}

	// Token: 0x06005CDE RID: 23774 RVA: 0x00279C30 File Offset: 0x00277E30
	public void a(string A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06005CDF RID: 23775 RVA: 0x00279C3C File Offset: 0x00277E3C
	public bi5()
	{
	}

	// Token: 0x06005CE0 RID: 23776 RVA: 0x00279C50 File Offset: 0x00277E50
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = this.a(A_0, A_1, A_2);
		if (c5x != null)
		{
			alv alv = c5x.p.b;
			if (alv != null)
			{
				if (this.a == null)
				{
					using (List<cd0>.Enumerator enumerator = alv.a.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							cd0 a_ = enumerator.Current;
							this.a(a_);
						}
						return;
					}
				}
				if (alv.a.Count > this.a.Value)
				{
					this.a(alv.a[this.a.Value]);
				}
			}
		}
	}

	// Token: 0x06005CE1 RID: 23777 RVA: 0x00279D14 File Offset: 0x00277F14
	private void a(cd0 A_0)
	{
		if (this.e)
		{
			A_0.d = this.d;
		}
		if (this.c)
		{
			A_0.c = this.b;
		}
		if (this.j)
		{
			A_0.f = this.k;
		}
		if (this.l)
		{
			A_0.a = this.m;
		}
		if (this.h || this.i)
		{
			Point point = A_0.b;
			if (this.h)
			{
				point.X = this.f;
			}
			if (this.i)
			{
				point.Y = this.g;
			}
			A_0.b = point;
		}
	}

	// Token: 0x06005CE2 RID: 23778 RVA: 0x00279DD4 File Offset: 0x00277FD4
	private c5x a(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x result = null;
		if (this.n == bvl.e)
		{
			aud aud = cze.a(this.o, A_0, A_1, A_2);
			if (aud != null && this.p != null)
			{
				result = (aud.a(this.p.Value) as c5x);
			}
		}
		else if (this.n == bvl.c)
		{
			result = (A_1 as c5x);
		}
		else if (this.n == bvl.b)
		{
			result = (A_0 as c5x);
		}
		else if (this.n == bvl.d)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				result = (serviceOrThrow.aqu().v().b() as c5x);
			}
			else
			{
				result = null;
			}
		}
		else
		{
			result = (A_1 as c5x);
		}
		return result;
	}

	// Token: 0x04002501 RID: 9473
	private new int? a;

	// Token: 0x04002502 RID: 9474
	private Color? b;

	// Token: 0x04002503 RID: 9475
	private bool c;

	// Token: 0x04002504 RID: 9476
	private float? d;

	// Token: 0x04002505 RID: 9477
	private bool e;

	// Token: 0x04002506 RID: 9478
	private int f;

	// Token: 0x04002507 RID: 9479
	private int g;

	// Token: 0x04002508 RID: 9480
	private bool h;

	// Token: 0x04002509 RID: 9481
	private bool i;

	// Token: 0x0400250A RID: 9482
	private bool j;

	// Token: 0x0400250B RID: 9483
	private float k;

	// Token: 0x0400250C RID: 9484
	private bool l;

	// Token: 0x0400250D RID: 9485
	private string m;

	// Token: 0x0400250E RID: 9486
	private bvl n = bvl.c;

	// Token: 0x0400250F RID: 9487
	private string o;

	// Token: 0x04002510 RID: 9488
	private Guid? p;
}
