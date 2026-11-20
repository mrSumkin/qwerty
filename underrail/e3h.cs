using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200022A RID: 554
public sealed class e3h : z6
{
	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000403BC File Offset: 0x0003E5BC
	public Guid Id
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000F60 RID: 3936 RVA: 0x000403C4 File Offset: 0x0003E5C4
	public string Name
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000403CC File Offset: 0x0003E5CC
	// (set) Token: 0x06000F62 RID: 3938 RVA: 0x000403D4 File Offset: 0x0003E5D4
	public etb Schema
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000403E0 File Offset: 0x0003E5E0
	public d4p Settings
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000403E8 File Offset: 0x0003E5E8
	// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000403F0 File Offset: 0x0003E5F0
	public a7o CollisionHandler
	{
		get
		{
			return this.h;
		}
		set
		{
			this.h = value;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000F66 RID: 3942 RVA: 0x000403FC File Offset: 0x0003E5FC
	public List<c1a> Zones
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00040404 File Offset: 0x0003E604
	public ayu LightProcessor
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004040C File Offset: 0x0003E60C
	public ayu SightProcessor
	{
		get
		{
			return this.f;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00040414 File Offset: 0x0003E614
	public ayu PathProcessor
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x0004041C File Offset: 0x0003E61C
	public e3h(string A_0, d4p A_1)
	{
		czh.a(A_0, "name");
		this.c = A_0;
		this.b = A_1;
		this.a();
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00040450 File Offset: 0x0003E650
	public e3h(string A_0, d4p A_1, etb A_2) : this(A_0, A_1)
	{
		this.a = A_2;
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00040464 File Offset: 0x0003E664
	public c1a c(string A_0)
	{
		c1a c1a = new c1a(A_0);
		this.a(c1a);
		return c1a;
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00040480 File Offset: 0x0003E680
	public void a(c1a A_0)
	{
		this.a(A_0, true);
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x0004048C File Offset: 0x0003E68C
	public void a(c1a A_0, bool A_1)
	{
		czh.a(A_0, "zone");
		A_0.Playfield = this;
		this.d.Add(A_0);
		if (A_1)
		{
			A_0.bc(true);
		}
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x000404BC File Offset: 0x0003E6BC
	public c1a b(string A_0)
	{
		e3h.b b = new e3h.b();
		b.a = A_0;
		czh.a(b.a, "name");
		return Enumerable.FirstOrDefault<c1a>(Enumerable.Where<c1a>(this.d, new Func<c1a, bool>(b.a)));
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00040504 File Offset: 0x0003E704
	public c1a a(Guid A_0)
	{
		e3h.a a = new e3h.a();
		a.a = A_0;
		return Enumerable.FirstOrDefault<c1a>(Enumerable.Where<c1a>(this.d, new Func<c1a, bool>(a.a)));
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x0004053C File Offset: 0x0003E73C
	public c1a a(string A_0)
	{
		czh.a(A_0, "name");
		c1a c1a = this.b(A_0);
		if (c1a != null)
		{
			c1a.Playfield = null;
			this.d.Remove(c1a);
		}
		return c1a;
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00040578 File Offset: 0x0003E778
	public void d1(e6d A_0)
	{
		double num;
		if (a88.a != 0.0)
		{
			num = Math.Max(4.0, 13.0 - a88.a);
		}
		else
		{
			num = 4.0;
		}
		List<ayu> list = new List<ayu>(3);
		if (this.f.oy())
		{
			list.Add(this.f);
		}
		if (this.e.oy())
		{
			list.Add(this.e);
		}
		if (this.g.oy())
		{
			list.Add(this.g);
		}
		while (num > 0.0 && list.Count > 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (!list[i].a(ref num))
				{
					list.RemoveAt(i);
					i--;
				}
			}
		}
		foreach (c1a c1a in Enumerable.ToList<c1a>(this.d))
		{
			c1a.a(A_0);
		}
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x000406C0 File Offset: 0x0003E8C0
	private void a()
	{
		if (this.Settings.d().a() > 0U)
		{
			this.e = new ayu(this.Settings.d().a());
		}
		if (this.Settings.b().a() > 0U)
		{
			this.f = new ayu(this.Settings.b().a());
		}
		if (this.Settings.f().a() > 0U)
		{
			this.g = new ayu(this.Settings.f().a());
		}
	}

	// Token: 0x04000926 RID: 2342
	private etb a;

	// Token: 0x04000927 RID: 2343
	private d4p b;

	// Token: 0x04000928 RID: 2344
	private string c;

	// Token: 0x04000929 RID: 2345
	private List<c1a> d = new List<c1a>();

	// Token: 0x0400092A RID: 2346
	private ayu e;

	// Token: 0x0400092B RID: 2347
	private ayu f;

	// Token: 0x0400092C RID: 2348
	private ayu g;

	// Token: 0x0400092D RID: 2349
	private a7o h;

	// Token: 0x0200022B RID: 555
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06000F75 RID: 3957 RVA: 0x0004078C File Offset: 0x0003E98C
		internal bool a(c1a A_0)
		{
			return A_0.y8() == this.a;
		}

		// Token: 0x0400092E RID: 2350
		public string a;
	}

	// Token: 0x0200022C RID: 556
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x000407A8 File Offset: 0x0003E9A8
		internal bool a(c1a A_0)
		{
			return A_0.qe() == this.a;
		}

		// Token: 0x0400092F RID: 2351
		public Guid a;
	}
}
