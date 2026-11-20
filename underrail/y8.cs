using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006DC RID: 1756
[eiz("IGB")]
[Serializable]
public abstract class y8 : aw4, ISerializable
{
	// Token: 0x06002D16 RID: 11542 RVA: 0x00101B68 File Offset: 0x000FFD68
	protected y8(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("IGB:ML");
			this.b = A_0.GetInt32("IGB:ML1");
			if (ell.a() >= 406)
			{
				this.c = (A_0.GetValue("IGB:B", typeof(int?)) as int?);
				this.d = (A_0.GetValue("IGB:D", typeof(int?)) as int?);
				this.e = (A_0.GetValue("IGB:O", typeof(bool)) as bool?);
			}
			if (ell.a() >= 427)
			{
				this.f = (A_0.GetValue("IGB:I", typeof(bool?)) as bool?);
			}
			if (ell.a() >= 553)
			{
				this.g = (A_0.GetValue("IGB:C", typeof(dth)) as dth);
				this.h = A_0.GetString("IGB:DL");
			}
			if (ell.a() >= 585)
			{
				this.j = A_0.GetBoolean("IGB:CH");
			}
			if (ell.a() >= 652)
			{
				this.k = (A_0.GetValue("IGB:IE", typeof(List<dbj>)) as List<dbj>);
			}
			else
			{
				this.k = new List<dbj>();
			}
			if (ell.a() >= 665)
			{
				this.i = A_0.GetBoolean("IGB:DLI");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(y8))
			{
				this.a = A_0.GetInt32("_MinimalLevel");
				this.b = A_0.GetInt32("_MaximalLevel");
				return;
			}
			this.a = A_0.GetInt32("ItemGeneratorBase+_MinimalLevel");
			this.b = A_0.GetInt32("ItemGeneratorBase+_MaximalLevel");
		}
	}

	// Token: 0x06002D17 RID: 11543 RVA: 0x00101D94 File Offset: 0x000FFF94
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IGB:ML", this.a);
		info.AddValue("IGB:ML1", this.b);
		info.AddValue("IGB:B", this.c);
		info.AddValue("IGB:D", this.d);
		info.AddValue("IGB:O", this.e);
		info.AddValue("IGB:I", this.f);
		info.AddValue("IGB:C", this.g);
		info.AddValue("IGB:DL", this.h);
		info.AddValue("IGB:CH", this.j);
		info.AddValue("IGB:IE", this.k);
		info.AddValue("IGB:DLI", this.i);
	}

	// Token: 0x06002D18 RID: 11544 RVA: 0x00101E70 File Offset: 0x00100070
	public int m9()
	{
		return this.a;
	}

	// Token: 0x06002D19 RID: 11545 RVA: 0x00101E78 File Offset: 0x00100078
	public void na(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D1A RID: 11546 RVA: 0x00101E84 File Offset: 0x00100084
	public int nb()
	{
		return this.b;
	}

	// Token: 0x06002D1B RID: 11547 RVA: 0x00101E8C File Offset: 0x0010008C
	public void nc(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002D1C RID: 11548 RVA: 0x00101E98 File Offset: 0x00100098
	public bool f()
	{
		return this.j;
	}

	// Token: 0x06002D1D RID: 11549 RVA: 0x00101EA0 File Offset: 0x001000A0
	public void d(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06002D1E RID: 11550 RVA: 0x00101EAC File Offset: 0x001000AC
	public List<dbj> h()
	{
		return this.k;
	}

	// Token: 0x06002D1F RID: 11551 RVA: 0x00101EB4 File Offset: 0x001000B4
	public void a(List<dbj> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06002D20 RID: 11552 RVA: 0x00101EC0 File Offset: 0x001000C0
	public int? nd()
	{
		return this.c;
	}

	// Token: 0x06002D21 RID: 11553 RVA: 0x00101EC8 File Offset: 0x001000C8
	public void ne(int? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002D22 RID: 11554 RVA: 0x00101ED4 File Offset: 0x001000D4
	public int? nf()
	{
		return this.d;
	}

	// Token: 0x06002D23 RID: 11555 RVA: 0x00101EDC File Offset: 0x001000DC
	public void ng(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002D24 RID: 11556 RVA: 0x00101EE8 File Offset: 0x001000E8
	public bool? nh()
	{
		return this.e;
	}

	// Token: 0x06002D25 RID: 11557 RVA: 0x00101EF0 File Offset: 0x001000F0
	public void ni(bool? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06002D26 RID: 11558 RVA: 0x00101EFC File Offset: 0x001000FC
	public bool? nj()
	{
		return this.f;
	}

	// Token: 0x06002D27 RID: 11559 RVA: 0x00101F04 File Offset: 0x00100104
	public void nk(bool? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06002D28 RID: 11560 RVA: 0x00101F10 File Offset: 0x00100110
	public dth nl()
	{
		return this.g;
	}

	// Token: 0x06002D29 RID: 11561 RVA: 0x00101F18 File Offset: 0x00100118
	public void nm(dth A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06002D2A RID: 11562 RVA: 0x00101F24 File Offset: 0x00100124
	public string nn()
	{
		return this.h;
	}

	// Token: 0x06002D2B RID: 11563 RVA: 0x00101F2C File Offset: 0x0010012C
	public void no(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06002D2C RID: 11564 RVA: 0x00101F38 File Offset: 0x00100138
	public bool g()
	{
		return this.i;
	}

	// Token: 0x06002D2D RID: 11565 RVA: 0x00101F40 File Offset: 0x00100140
	public void c(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06002D2E RID: 11566 RVA: 0x00101F4C File Offset: 0x0010014C
	protected y8()
	{
	}

	// Token: 0x06002D2F RID: 11567 RVA: 0x00101F70 File Offset: 0x00100170
	public List<coh> np()
	{
		if (!string.IsNullOrEmpty(this.h) && !(dk2.b(this.h) ^ this.i))
		{
			return new List<coh>();
		}
		if (this.g != null && !this.g.jh(this))
		{
			return new List<coh>();
		}
		List<coh> list = this.a2();
		if (list != null && (this.j || this.k.Count > 0))
		{
			foreach (coh coh in list)
			{
				if (this.j && coh.Definition.ba() != null && coh.Definition.ba().Value > 0)
				{
					coh.Battery = (double)coh.Definition.ba().Value;
				}
				if (this.k.Count > 0)
				{
					foreach (dbj dbj in this.k)
					{
						coh.ItemEffects.Add(dbj.b());
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06002D30 RID: 11568
	public abstract aw4 a1();

	// Token: 0x06002D31 RID: 11569 RVA: 0x001020F8 File Offset: 0x001002F8
	public void a(y8 A_0)
	{
		A_0.b = this.b;
		A_0.a = this.a;
		A_0.c = this.c;
		A_0.d = this.d;
		A_0.e = this.e;
		A_0.f = this.f;
		ICloneable cloneable = this.g as ICloneable;
		if (cloneable != null)
		{
			A_0.g = (cloneable.Clone() as dth);
		}
		else
		{
			A_0.g = this.g;
		}
		A_0.h = this.h;
		A_0.i = this.i;
		A_0.j = this.j;
	}

	// Token: 0x06002D32 RID: 11570
	protected abstract List<coh> a2();

	// Token: 0x06002D33 RID: 11571 RVA: 0x001021A8 File Offset: 0x001003A8
	protected virtual void rg(y8 A_0)
	{
		czh.a(A_0, "target");
		this.a(A_0);
		A_0.g = d05.SafeClone<dth>(this.g);
		A_0.h = this.h;
		A_0.k = new List<dbj>();
		foreach (dbj obj in this.k)
		{
			A_0.k.Add(d05.SafeClone<dbj>(obj));
		}
	}

	// Token: 0x06002D34 RID: 11572 RVA: 0x00102248 File Offset: 0x00100448
	protected virtual void aj5(out int A_0, out int A_1)
	{
		A_0 = this.a;
		A_1 = this.b;
		if (this.c != null)
		{
			int val;
			if (this.f.GetValueOrDefault())
			{
				val = dk2.d();
			}
			else
			{
				val = dk2.c();
			}
			int num = this.c.Value * Math.Min(this.d.GetValueOrDefault(99), val);
			A_1 += num;
			if (!this.e.GetValueOrDefault())
			{
				A_0 += num;
			}
		}
	}

	// Token: 0x06002D35 RID: 11573 RVA: 0x001022D4 File Offset: 0x001004D4
	protected int i()
	{
		int num;
		int num2;
		this.aj5(out num, out num2);
		if (num > num2)
		{
			return num;
		}
		return zp.a.Next(num, num2 + 1);
	}

	// Token: 0x06002D36 RID: 11574 RVA: 0x00102304 File Offset: 0x00100504
	protected static int a(int A_0)
	{
		return 10 + 5 * A_0 + zp.a.Next(-4, 5);
	}

	// Token: 0x06002D37 RID: 11575 RVA: 0x0010231C File Offset: 0x0010051C
	protected static int a(int A_0, int A_1)
	{
		return Math.Max(1, A_0 - A_1 + zp.a.Next(A_1 * 2));
	}

	// Token: 0x06002D38 RID: 11576 RVA: 0x00102338 File Offset: 0x00100538
	protected static fv a(string A_0, int? A_1 = null)
	{
		fv fv = zp.a(A_0);
		if (fv != null && A_1 != null)
		{
			fv.QualityLevel = A_1.Value;
		}
		return fv;
	}

	// Token: 0x040019A1 RID: 6561
	private int a = 1;

	// Token: 0x040019A2 RID: 6562
	private int b = 1;

	// Token: 0x040019A3 RID: 6563
	private int? c;

	// Token: 0x040019A4 RID: 6564
	private int? d;

	// Token: 0x040019A5 RID: 6565
	private bool? e;

	// Token: 0x040019A6 RID: 6566
	private bool? f;

	// Token: 0x040019A7 RID: 6567
	private dth g;

	// Token: 0x040019A8 RID: 6568
	private string h;

	// Token: 0x040019A9 RID: 6569
	private bool i;

	// Token: 0x040019AA RID: 6570
	private bool j;

	// Token: 0x040019AB RID: 6571
	private List<dbj> k = new List<dbj>();
}
