using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010EC RID: 4332
[eiz("CCEJ")]
[Serializable]
public sealed class nb : cze, ISerializable
{
	// Token: 0x06005B94 RID: 23444 RVA: 0x00274EB8 File Offset: 0x002730B8
	private nb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (bvl)A_0.GetValue("CCEJ:T", typeof(bvl));
		this.a = (A_0.GetValue("CCEJ:CT", typeof(Guid?)) as Guid?);
		if (ell.a() >= 336)
		{
			this.c = A_0.GetBoolean("CCEJ:B");
		}
	}

	// Token: 0x06005B95 RID: 23445 RVA: 0x00274F3C File Offset: 0x0027313C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCEJ:T", this.b);
		info.AddValue("CCEJ:CT", this.a);
		info.AddValue("CCEJ:B", this.c);
	}

	// Token: 0x06005B96 RID: 23446 RVA: 0x00274F90 File Offset: 0x00273190
	public bvl b()
	{
		return this.b;
	}

	// Token: 0x06005B97 RID: 23447 RVA: 0x00274F98 File Offset: 0x00273198
	public void a(bvl A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B98 RID: 23448 RVA: 0x00274FA4 File Offset: 0x002731A4
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x06005B99 RID: 23449 RVA: 0x00274FAC File Offset: 0x002731AC
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B9A RID: 23450 RVA: 0x00274FB8 File Offset: 0x002731B8
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06005B9B RID: 23451 RVA: 0x00274FC0 File Offset: 0x002731C0
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B9C RID: 23452 RVA: 0x00274FCC File Offset: 0x002731CC
	public nb()
	{
	}

	// Token: 0x06005B9D RID: 23453 RVA: 0x00274FDC File Offset: 0x002731DC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (A_0 != null)
			{
				aud = A_0.Area;
			}
			if (aud == null && A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (aud.a(this.a.Value) as c5x);
			}
		}
		else
		{
			switch (this.b)
			{
			case bvl.b:
				c5x = (A_0 as c5x);
				break;
			case bvl.c:
				c5x = (A_1 as c5x);
				break;
			case bvl.d:
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					c5x = (serviceOrThrow.aqu().v().b() as c5x);
				}
				break;
			}
			}
		}
		if (c5x != null && c5x.h.b != null)
		{
			if (this.c)
			{
				a3f a3f = c5x.GetAspect<a3f>();
				if (a3f == null)
				{
					a3f = new a3f(c5x);
					c5x.SetAspect<a3f>(a3f);
				}
				a3f.a()["BloodlessDeath"] = true;
			}
			c5x.h.b.aa().a(null, null, false);
		}
	}

	// Token: 0x04002491 RID: 9361
	private new Guid? a;

	// Token: 0x04002492 RID: 9362
	private bvl b = bvl.c;

	// Token: 0x04002493 RID: 9363
	private bool c;
}
