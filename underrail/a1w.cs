using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020011E9 RID: 4585
[eiz("GTR")]
[Serializable]
public sealed class a1w : ya, ISerializable
{
	// Token: 0x06006266 RID: 25190 RVA: 0x002A8D2C File Offset: 0x002A6F2C
	private a1w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("GTR:R");
		this.b = A_0.GetBoolean("GTR:U");
		this.c = (A_0.GetValue("GTR:C", typeof(dth)) as dth);
		this.d = A_0.GetBoolean("GTR:P");
		di7.ReadList<string>("GTR:G", ref this.e, A_0);
		di7.ReadList<string>("GTR:T", ref this.f, A_0);
		if (ell.a() >= 226)
		{
			di7.ReadList<Guid>("GTR:E", ref this.g, A_0);
		}
		else
		{
			this.g = new List<Guid>();
		}
		if (ell.a() >= 228)
		{
			this.h = A_0.GetInt32("GTR:D");
		}
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x002A8E30 File Offset: 0x002A7030
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GTR:R", this.a);
		info.AddValue("GTR:U", this.b);
		info.AddValue("GTR:C", this.c);
		info.AddValue("GTR:P", this.d);
		info.AddValue("GTR:D", this.h);
		di7.WriteList<string>("GTR:G", this.e, info);
		di7.WriteList<string>("GTR:T", this.f, info);
		di7.WriteList<Guid>("GTR:E", this.g, info);
	}

	// Token: 0x06006268 RID: 25192 RVA: 0x002A8ED0 File Offset: 0x002A70D0
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06006269 RID: 25193 RVA: 0x002A8ED8 File Offset: 0x002A70D8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x002A8EE4 File Offset: 0x002A70E4
	public bool f()
	{
		return this.b;
	}

	// Token: 0x0600626B RID: 25195 RVA: 0x002A8EEC File Offset: 0x002A70EC
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600626C RID: 25196 RVA: 0x002A8EF8 File Offset: 0x002A70F8
	public dth g()
	{
		return this.c;
	}

	// Token: 0x0600626D RID: 25197 RVA: 0x002A8F00 File Offset: 0x002A7100
	public void a(dth A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600626E RID: 25198 RVA: 0x002A8F0C File Offset: 0x002A710C
	public bool h()
	{
		return this.d;
	}

	// Token: 0x0600626F RID: 25199 RVA: 0x002A8F14 File Offset: 0x002A7114
	public void c(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006270 RID: 25200 RVA: 0x002A8F20 File Offset: 0x002A7120
	public List<string> a()
	{
		return this.e;
	}

	// Token: 0x06006271 RID: 25201 RVA: 0x002A8F28 File Offset: 0x002A7128
	public void b(List<string> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006272 RID: 25202 RVA: 0x002A8F34 File Offset: 0x002A7134
	public List<string> b()
	{
		return this.f;
	}

	// Token: 0x06006273 RID: 25203 RVA: 0x002A8F3C File Offset: 0x002A713C
	public void a(List<string> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006274 RID: 25204 RVA: 0x002A8F48 File Offset: 0x002A7148
	public List<Guid> d()
	{
		return this.g;
	}

	// Token: 0x06006275 RID: 25205 RVA: 0x002A8F50 File Offset: 0x002A7150
	public void a(List<Guid> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006276 RID: 25206 RVA: 0x002A8F5C File Offset: 0x002A715C
	public int e()
	{
		return this.h;
	}

	// Token: 0x06006277 RID: 25207 RVA: 0x002A8F64 File Offset: 0x002A7164
	public void a(int A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006278 RID: 25208 RVA: 0x002A8F70 File Offset: 0x002A7170
	public a1w()
	{
	}

	// Token: 0x06006279 RID: 25209 RVA: 0x002A8FA0 File Offset: 0x002A71A0
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		this.a(A_0 as c5x, null);
	}

	// Token: 0x0600627A RID: 25210 RVA: 0x002A8FB8 File Offset: 0x002A71B8
	protected override void tk(b0b A_0)
	{
		base.tk(A_0);
		this.a(A_0 as c5x, null);
	}

	// Token: 0x0600627B RID: 25211 RVA: 0x002A8FD0 File Offset: 0x002A71D0
	protected override void tl(b0b A_0)
	{
		base.tl(A_0);
		this.a(A_0 as c5x, null);
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x002A8FE8 File Offset: 0x002A71E8
	public void a(c5x A_0, c5x A_1 = null)
	{
		if (A_0 != null && (!this.d || (A_0.h.b != null && A_0.h.b.@as())))
		{
			if (this.c != null && !this.c.jh(this))
			{
				if (this.b)
				{
					base.o();
				}
				return;
			}
			if (A_0.h.b != null && this.f.Contains(A_0.h.b.aa().FactionId))
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in service.ahl())
					{
						if (d4n.b != null && d4n.b != A_0.h.b && !d4n.b.aa().Passive && (this.e.Contains(d4n.b.aa().FactionId) || this.g.Contains(d4n.b.a8().qe())) && d4n.b.a8().t.b != null && (d4n.b.a8().t.b.b(A_0.h.b, false) || A_1 == d4n.b.a8()) && (this.h <= 0 || A_1 == d4n.b.a8() || aw1.b(d4n.b.a8(), A_0) <= (double)this.h))
						{
							awq.a(d4n.b, A_0.h.b, false, false, null, true, true, true, false);
						}
					}
				}
				if (!this.a)
				{
					base.o();
				}
			}
		}
	}

	// Token: 0x040029AB RID: 10667
	private bool a = true;

	// Token: 0x040029AC RID: 10668
	private bool b;

	// Token: 0x040029AD RID: 10669
	private dth c;

	// Token: 0x040029AE RID: 10670
	private new bool d;

	// Token: 0x040029AF RID: 10671
	private new List<string> e = new List<string>();

	// Token: 0x040029B0 RID: 10672
	private new List<string> f = new List<string>();

	// Token: 0x040029B1 RID: 10673
	private new List<Guid> g = new List<Guid>();

	// Token: 0x040029B2 RID: 10674
	private new int h;
}
