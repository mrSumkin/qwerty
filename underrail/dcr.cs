using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001072 RID: 4210
[eiz("SBACSJ")]
[Serializable]
public sealed class dcr : cze, ISerializable
{
	// Token: 0x060057A0 RID: 22432 RVA: 0x0026331C File Offset: 0x0026151C
	private dcr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SBACSJ:I", typeof(Guid?));
		this.c = A_0.GetString("SBACSJ:A");
		this.a = A_0.GetBoolean("SBACSJ:E");
	}

	// Token: 0x060057A1 RID: 22433 RVA: 0x00263374 File Offset: 0x00261574
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBACSJ:I", this.b);
		info.AddValue("SBACSJ:A", this.c);
		info.AddValue("SBACSJ:E", this.a);
	}

	// Token: 0x060057A2 RID: 22434 RVA: 0x002633C4 File Offset: 0x002615C4
	public bool c()
	{
		return this.a;
	}

	// Token: 0x060057A3 RID: 22435 RVA: 0x002633CC File Offset: 0x002615CC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057A4 RID: 22436 RVA: 0x002633D8 File Offset: 0x002615D8
	public string a()
	{
		return this.c;
	}

	// Token: 0x060057A5 RID: 22437 RVA: 0x002633E0 File Offset: 0x002615E0
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060057A6 RID: 22438 RVA: 0x002633EC File Offset: 0x002615EC
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x060057A7 RID: 22439 RVA: 0x002633F4 File Offset: 0x002615F4
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060057A8 RID: 22440 RVA: 0x00263400 File Offset: 0x00261600
	public dcr()
	{
	}

	// Token: 0x060057A9 RID: 22441 RVA: 0x00263408 File Offset: 0x00261608
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null && serviceOrThrow.aqw() != null)
			{
				aud = serviceOrThrow.aqw().n(this.c);
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
			bb2 bb = c5x.s.b as bb2;
			if (bb != null)
			{
				bb.a(this.a);
			}
		}
	}

	// Token: 0x0400236E RID: 9070
	private new bool a;

	// Token: 0x0400236F RID: 9071
	private Guid? b;

	// Token: 0x04002370 RID: 9072
	private string c;
}
