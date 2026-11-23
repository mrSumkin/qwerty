using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010F6 RID: 4342
[eiz("SLSJ1")]
[Serializable]
public sealed class cid : cze, ISerializable
{
	// Token: 0x06005BF6 RID: 23542 RVA: 0x00276B58 File Offset: 0x00274D58
	private cid(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SLSJ1:I", typeof(Guid?));
		this.c = A_0.GetString("SLSJ1:A");
		this.a = A_0.GetBoolean("SLSJ1:L");
		this.d = A_0.GetBoolean("SLSJ1:J");
		this.e = A_0.GetBoolean("SLSJ1:S");
		if (ell.a() >= 234)
		{
			this.f = A_0.GetBoolean("SLSJ1:P");
			return;
		}
		this.f = true;
	}

	// Token: 0x06005BF7 RID: 23543 RVA: 0x00276BFC File Offset: 0x00274DFC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLSJ1:I", this.b);
		info.AddValue("SLSJ1:A", this.c);
		info.AddValue("SLSJ1:L", this.a);
		info.AddValue("SLSJ1:J", this.d);
		info.AddValue("SLSJ1:S", this.e);
		info.AddValue("SLSJ1:P", this.f);
	}

	// Token: 0x06005BF8 RID: 23544 RVA: 0x00276C7C File Offset: 0x00274E7C
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005BF9 RID: 23545 RVA: 0x00276C84 File Offset: 0x00274E84
	public void d(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005BFA RID: 23546 RVA: 0x00276C90 File Offset: 0x00274E90
	public string e()
	{
		return this.c;
	}

	// Token: 0x06005BFB RID: 23547 RVA: 0x00276C98 File Offset: 0x00274E98
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005BFC RID: 23548 RVA: 0x00276CA4 File Offset: 0x00274EA4
	public Guid? d()
	{
		return this.b;
	}

	// Token: 0x06005BFD RID: 23549 RVA: 0x00276CAC File Offset: 0x00274EAC
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005BFE RID: 23550 RVA: 0x00276CB8 File Offset: 0x00274EB8
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06005BFF RID: 23551 RVA: 0x00276CC0 File Offset: 0x00274EC0
	public void c(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005C00 RID: 23552 RVA: 0x00276CCC File Offset: 0x00274ECC
	public bool a()
	{
		return this.e;
	}

	// Token: 0x06005C01 RID: 23553 RVA: 0x00276CD4 File Offset: 0x00274ED4
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005C02 RID: 23554 RVA: 0x00276CE0 File Offset: 0x00274EE0
	public bool f()
	{
		return this.f;
	}

	// Token: 0x06005C03 RID: 23555 RVA: 0x00276CE8 File Offset: 0x00274EE8
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005C04 RID: 23556 RVA: 0x00276CF4 File Offset: 0x00274EF4
	public cid()
	{
	}

	// Token: 0x06005C05 RID: 23557 RVA: 0x00276D00 File Offset: 0x00274F00
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.c);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			d2b aspect = c5x.GetAspect<d2b>();
			if (aspect != null)
			{
				if (!aspect.n() && this.a)
				{
					aspect.b(this.d, this.e);
					if (this.f)
					{
						a7v.a(new jj());
						bmj.a(c5x, new d53("Заперто", adi.h, null, false));
						return;
					}
				}
				else if (aspect.n() && !this.a)
				{
					aspect.a(this.d, this.e);
					if (this.f)
					{
						a7v.a(new jj());
						bmj.a(c5x, new d53("Открыто", adi.h, null, false));
					}
				}
			}
		}
	}

	// Token: 0x040024BC RID: 9404
	private new bool a;

	// Token: 0x040024BD RID: 9405
	private Guid? b;

	// Token: 0x040024BE RID: 9406
	private string c;

	// Token: 0x040024BF RID: 9407
	private bool d;

	// Token: 0x040024C0 RID: 9408
	private bool e;

	// Token: 0x040024C1 RID: 9409
	private bool f;
}
