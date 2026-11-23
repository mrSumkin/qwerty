using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200111C RID: 4380
[eiz("LSJ")]
[Serializable]
public abstract class dty : cze, ISerializable
{
	// Token: 0x06005D5E RID: 23902 RVA: 0x0027B4B4 File Offset: 0x002796B4
	protected dty(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (bvl)A_0.GetValue("LSJ:AS", typeof(bvl));
		this.b = A_0.GetString("LSJ:CI");
		this.c = A_0.GetString("LSJ:SI");
		this.d = A_0.GetSingle("LSJ:V");
		this.e = (c9z)A_0.GetValue("LSJ:ST", typeof(c9z));
		this.f = A_0.GetBoolean("LSJ:L");
		this.g = A_0.GetBoolean("LSJ:P");
		if (ell.a() >= 14)
		{
			this.h = (A_0.GetValue("LSJ:OASEI", typeof(Guid?)) as Guid?);
			this.i = A_0.GetString("LSJ:OASA");
		}
	}

	// Token: 0x06005D5F RID: 23903 RVA: 0x0027B5B4 File Offset: 0x002797B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LSJ:AS", this.a);
		info.AddValue("LSJ:CI", this.b);
		info.AddValue("LSJ:SI", this.c);
		info.AddValue("LSJ:V", this.d);
		info.AddValue("LSJ:ST", this.e);
		info.AddValue("LSJ:L", this.f);
		info.AddValue("LSJ:P", this.g);
		info.AddValue("LSJ:OASEI", this.h);
		info.AddValue("LSJ:OASA", this.i);
	}

	// Token: 0x06005D60 RID: 23904 RVA: 0x0027B674 File Offset: 0x00279874
	public bvl g()
	{
		return this.a;
	}

	// Token: 0x06005D61 RID: 23905 RVA: 0x0027B67C File Offset: 0x0027987C
	public void a(bvl A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005D62 RID: 23906 RVA: 0x0027B688 File Offset: 0x00279888
	public string m()
	{
		return this.b;
	}

	// Token: 0x06005D63 RID: 23907 RVA: 0x0027B690 File Offset: 0x00279890
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005D64 RID: 23908 RVA: 0x0027B69C File Offset: 0x0027989C
	public string e()
	{
		return this.c;
	}

	// Token: 0x06005D65 RID: 23909 RVA: 0x0027B6A4 File Offset: 0x002798A4
	public void c(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005D66 RID: 23910 RVA: 0x0027B6B0 File Offset: 0x002798B0
	public float h()
	{
		return this.d;
	}

	// Token: 0x06005D67 RID: 23911 RVA: 0x0027B6B8 File Offset: 0x002798B8
	public void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005D68 RID: 23912 RVA: 0x0027B6C4 File Offset: 0x002798C4
	public c9z j()
	{
		return this.e;
	}

	// Token: 0x06005D69 RID: 23913 RVA: 0x0027B6CC File Offset: 0x002798CC
	public void a(c9z A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005D6A RID: 23914 RVA: 0x0027B6D8 File Offset: 0x002798D8
	public bool l()
	{
		return this.f;
	}

	// Token: 0x06005D6B RID: 23915 RVA: 0x0027B6E0 File Offset: 0x002798E0
	public void d(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005D6C RID: 23916 RVA: 0x0027B6EC File Offset: 0x002798EC
	public bool i()
	{
		return this.g;
	}

	// Token: 0x06005D6D RID: 23917 RVA: 0x0027B6F4 File Offset: 0x002798F4
	public void e(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005D6E RID: 23918 RVA: 0x0027B700 File Offset: 0x00279900
	public string f()
	{
		return this.i;
	}

	// Token: 0x06005D6F RID: 23919 RVA: 0x0027B708 File Offset: 0x00279908
	public void a(string A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06005D70 RID: 23920 RVA: 0x0027B714 File Offset: 0x00279914
	public Guid? k()
	{
		return this.h;
	}

	// Token: 0x06005D71 RID: 23921 RVA: 0x0027B71C File Offset: 0x0027991C
	public void a(Guid? A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005D72 RID: 23922 RVA: 0x0027B728 File Offset: 0x00279928
	protected dty()
	{
		this.b = Guid.NewGuid().ToString();
	}

	// Token: 0x06005D73 RID: 23923 RVA: 0x0027B768 File Offset: 0x00279968
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.h != null)
		{
			c1a c1a;
			aud aud;
			if (A_1 != null && A_1.Zone != null)
			{
				c1a = A_1.Zone;
				aud = A_1.Area;
			}
			else if (A_0 != null && A_0.Zone != null)
			{
				c1a = A_0.Zone;
				aud = A_0.Area;
			}
			else
			{
				c1a = null;
				aud = null;
			}
			if (c1a != null)
			{
				aud aud2;
				if (this.i != null)
				{
					aud2 = c1a.n(this.i);
				}
				else
				{
					aud2 = aud;
				}
				if (aud2 != null)
				{
					c5x = (new ar7(this.h.Value, aud2).ao() as c5x);
				}
			}
		}
		else if (this.a == bvl.c || this.a == bvl.a)
		{
			c5x = (A_1 as c5x);
		}
		else if (this.a == bvl.b)
		{
			c5x = (A_0 as c5x);
		}
		else if (this.a == bvl.d)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x = (serviceOrThrow.aqu().v().b() as c5x);
			}
			else
			{
				c5x = null;
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			c5x.c();
			this.xp(c5x);
		}
	}

	// Token: 0x06005D74 RID: 23924
	protected abstract void xp(c5x A_0);

	// Token: 0x06005D75 RID: 23925 RVA: 0x0027B8C8 File Offset: 0x00279AC8
	protected string n()
	{
		if (!string.IsNullOrEmpty(this.b))
		{
			return this.b;
		}
		return Guid.NewGuid().ToString();
	}

	// Token: 0x04002533 RID: 9523
	private new bvl a = bvl.c;

	// Token: 0x04002534 RID: 9524
	private string b;

	// Token: 0x04002535 RID: 9525
	private string c;

	// Token: 0x04002536 RID: 9526
	private float d = 1f;

	// Token: 0x04002537 RID: 9527
	private c9z e;

	// Token: 0x04002538 RID: 9528
	private bool f;

	// Token: 0x04002539 RID: 9529
	private bool g;

	// Token: 0x0400253A RID: 9530
	private Guid? h;

	// Token: 0x0400253B RID: 9531
	private string i;
}
