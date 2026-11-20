using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020004C5 RID: 1221
[eiz("T132")]
[Serializable]
public sealed class b50 : esc, ISerializable
{
	// Token: 0x06001F1E RID: 7966 RVA: 0x000AC39C File Offset: 0x000AA59C
	private b50(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("T132:II", typeof(Guid?)) as Guid?);
		this.b = A_0.GetString("T132:IC");
		this.c = A_0.GetInt32("T132:S");
		this.d = A_0.GetBoolean("T132:I");
		this.e = A_0.GetBoolean("T132:SG");
		this.f = (A_0.GetValue("T132:N", typeof(Guid?)) as Guid?);
		this.g = A_0.GetBoolean("T132:P");
		this.h = (A_0.GetValue("T132:ST", typeof(bool?)) as bool?);
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x000AC484 File Offset: 0x000AA684
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T132:II", this.a);
		info.AddValue("T132:IC", this.b);
		info.AddValue("T132:S", this.c);
		info.AddValue("T132:I", this.d);
		info.AddValue("T132:SG", this.e);
		info.AddValue("T132:N", this.f);
		info.AddValue("T132:P", this.g);
		info.AddValue("T132:ST", this.h);
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x000AC530 File Offset: 0x000AA730
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x000AC538 File Offset: 0x000AA738
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x000AC544 File Offset: 0x000AA744
	public string d()
	{
		return this.b;
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x000AC54C File Offset: 0x000AA74C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x000AC558 File Offset: 0x000AA758
	public int a()
	{
		return this.c;
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x000AC560 File Offset: 0x000AA760
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x000AC56C File Offset: 0x000AA76C
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x000AC574 File Offset: 0x000AA774
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x000AC580 File Offset: 0x000AA780
	public bool f()
	{
		return this.e;
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x000AC588 File Offset: 0x000AA788
	public void c(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x000AC594 File Offset: 0x000AA794
	public Guid? e()
	{
		return this.f;
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x000AC59C File Offset: 0x000AA79C
	public void b(Guid? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x000AC5A8 File Offset: 0x000AA7A8
	public bool h()
	{
		return this.g;
	}

	// Token: 0x06001F2D RID: 7981 RVA: 0x000AC5B0 File Offset: 0x000AA7B0
	public void a(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06001F2E RID: 7982 RVA: 0x000AC5BC File Offset: 0x000AA7BC
	public bool? g()
	{
		return this.h;
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x000AC5C4 File Offset: 0x000AA7C4
	public void a(bool? A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x000AC5D0 File Offset: 0x000AA7D0
	public b50()
	{
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x000AC5E8 File Offset: 0x000AA7E8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if ((this.b != null || this.a != null) && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
		{
			c5x c5x;
			if (this.f != null)
			{
				c5x = (serviceOrThrow.aqu().v().b().Area.a(this.f.Value) as c5x);
			}
			else
			{
				c5x = (serviceOrThrow.aqu().v().b() as c5x);
			}
			if (c5x == null)
			{
				return 1;
			}
			c5x c5x2;
			if (this.d)
			{
				c5x2 = c5x;
				c5x = (serviceOrThrow.aqu().v().b() as c5x);
			}
			else
			{
				c5x2 = (serviceOrThrow.aqu().v().b() as c5x);
			}
			if (c5x == null || c5x2 == null)
			{
				return 1;
			}
			dcw dcw = null;
			if (c5x2.h.b != null)
			{
				dcw = c5x2.h.b.aa().Bag;
			}
			else
			{
				c7j c7j = c5x2.s.b as c7j;
				if (c7j != null)
				{
					dcw = (c7j.ItemContainer as dcw);
				}
			}
			if (dcw == null)
			{
				return 1;
			}
			coh coh = null;
			if (c5x.h.b != null)
			{
				if (this.a != null)
				{
					coh = c5x.h.b.aa().c(this.a.Value);
				}
				else
				{
					coh = c5x.h.b.aa().a(this.b, this.c, this.e);
				}
			}
			else
			{
				c7j c7j2 = c5x.s.b as c7j;
				if (c7j2 != null)
				{
					if (this.a != null)
					{
						coh = Enumerable.FirstOrDefault<coh>(Enumerable.Where<coh>(c7j2.ItemContainer.z2(), new Func<coh, bool>(this.a)));
						if (coh != null)
						{
							c7j2.ItemContainer.z2().Remove(coh);
						}
					}
					else
					{
						coh = c7j2.ItemContainer.a(this.b, this.c);
					}
				}
			}
			if (coh != null)
			{
				if (this.g)
				{
					if (this.d)
					{
						a7v.a(new aub(coh));
					}
					else
					{
						a7v.a(new bou(coh));
					}
				}
				if (this.h != null)
				{
					coh.Stealable = this.h.Value;
				}
				dcw.z3(coh, true);
			}
		}
		return 1;
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x000AC8D0 File Offset: 0x000AAAD0
	[CompilerGenerated]
	private bool a(coh A_0)
	{
		return A_0.Id == this.a.Value;
	}

	// Token: 0x040013B0 RID: 5040
	private Guid? a;

	// Token: 0x040013B1 RID: 5041
	private string b;

	// Token: 0x040013B2 RID: 5042
	private int c = 1;

	// Token: 0x040013B3 RID: 5043
	private bool d;

	// Token: 0x040013B4 RID: 5044
	private bool e = true;

	// Token: 0x040013B5 RID: 5045
	private Guid? f;

	// Token: 0x040013B6 RID: 5046
	private bool g;

	// Token: 0x040013B7 RID: 5047
	private bool? h;
}
