using System;
using System.Collections.Generic;
using Ouroboros.Common.Data;

// Token: 0x020002AB RID: 683
public abstract class e1k : ckn
{
	// Token: 0x060013E4 RID: 5092 RVA: 0x000537E4 File Offset: 0x000519E4
	public bm6 c()
	{
		return this.a;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x000537EC File Offset: 0x000519EC
	public ny i()
	{
		return this.c;
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x000537F4 File Offset: 0x000519F4
	public amc g()
	{
		return this.b;
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x000537FC File Offset: 0x000519FC
	public PropertyCollection d()
	{
		return this.d;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00053804 File Offset: 0x00051A04
	protected abg f()
	{
		return this.e;
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x0005380C File Offset: 0x00051A0C
	protected void b(abg A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00053818 File Offset: 0x00051A18
	public d02 h()
	{
		return this.g;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00053820 File Offset: 0x00051A20
	public virtual bool vz()
	{
		return false;
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00053838 File Offset: 0x00051A38
	public virtual void ag8()
	{
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x0005383C File Offset: 0x00051A3C
	public virtual void ag9()
	{
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00053840 File Offset: 0x00051A40
	public virtual void jm()
	{
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00053844 File Offset: 0x00051A44
	public void avf()
	{
		this.a();
		this.f = this.e;
		this.b();
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00053860 File Offset: 0x00051A60
	public virtual void avg(object A_0, object A_1)
	{
		this.g = (A_1 as d02);
		this.a = (A_0 as bm6);
		if (this.a != null && this.a.a8() != null)
		{
			this.b = this.a.a8().h.b;
			this.c = this.a.a8().i.b;
		}
		if (this.e != null)
		{
			this.f = this.e;
			this.b();
		}
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x000538F4 File Offset: 0x00051AF4
	public virtual void avh()
	{
		this.a();
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x00053900 File Offset: 0x00051B00
	public bool avi()
	{
		if (this.a != null && this.b != null && this.f != null)
		{
			abg abg = this.f.f7();
			if (abg != null)
			{
				this.a();
				this.f = abg;
				this.b();
			}
		}
		return this.f == null;
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x0005395C File Offset: 0x00051B5C
	public virtual string[] avj()
	{
		return new string[]
		{
			e6j.a,
			cn8.a
		};
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00053974 File Offset: 0x00051B74
	public virtual string[] avk()
	{
		return new string[]
		{
			e6j.a
		};
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00053984 File Offset: 0x00051B84
	public virtual string[] avl()
	{
		return new string[]
		{
			e6j.a
		};
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00053994 File Offset: 0x00051B94
	public virtual string[] avm()
	{
		return new string[]
		{
			cn8.a
		};
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x000539A4 File Offset: 0x00051BA4
	public HashSet<r0> avn()
	{
		return new bzv(this.a.y6()).i();
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x000539BC File Offset: 0x00051BBC
	public d4n e()
	{
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		d4n d4n = serviceOrThrow.ahu(this.b.aa());
		if (d4n == serviceOrThrow.ahe())
		{
			return d4n;
		}
		return null;
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x000539F0 File Offset: 0x00051BF0
	private void b()
	{
		if (this.f != null)
		{
			this.f.c(this);
			this.f.lt();
		}
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00053A14 File Offset: 0x00051C14
	private void a()
	{
		if (this.f != null)
		{
			this.f.c();
		}
	}

	// Token: 0x04000ABD RID: 2749
	private bm6 a;

	// Token: 0x04000ABE RID: 2750
	private amc b;

	// Token: 0x04000ABF RID: 2751
	private ny c;

	// Token: 0x04000AC0 RID: 2752
	private PropertyCollection d = new PropertyCollection();

	// Token: 0x04000AC1 RID: 2753
	private abg e;

	// Token: 0x04000AC2 RID: 2754
	private abg f;

	// Token: 0x04000AC3 RID: 2755
	private d02 g;
}
