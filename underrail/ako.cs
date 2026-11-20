using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001035 RID: 4149
[eiz("CENJ")]
[Serializable]
public sealed class ako : cze, ISerializable
{
	// Token: 0x060055AC RID: 21932 RVA: 0x0025C30C File Offset: 0x0025A50C
	private ako(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (bvl)A_0.GetValue("CENJ:T", typeof(bvl));
		this.a = (A_0.GetValue("CENJ:CT", typeof(Guid?)) as Guid?);
		this.c = A_0.GetString("CENJ:N");
	}

	// Token: 0x060055AD RID: 21933 RVA: 0x0025C380 File Offset: 0x0025A580
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CENJ:T", this.b);
		info.AddValue("CENJ:CT", this.a);
		info.AddValue("CENJ:N", this.c);
	}

	// Token: 0x060055AE RID: 21934 RVA: 0x0025C3D4 File Offset: 0x0025A5D4
	public bvl a()
	{
		return this.b;
	}

	// Token: 0x060055AF RID: 21935 RVA: 0x0025C3DC File Offset: 0x0025A5DC
	public void a(bvl A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060055B0 RID: 21936 RVA: 0x0025C3E8 File Offset: 0x0025A5E8
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x060055B1 RID: 21937 RVA: 0x0025C3F0 File Offset: 0x0025A5F0
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060055B2 RID: 21938 RVA: 0x0025C3FC File Offset: 0x0025A5FC
	public string c()
	{
		return this.c;
	}

	// Token: 0x060055B3 RID: 21939 RVA: 0x0025C404 File Offset: 0x0025A604
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060055B4 RID: 21940 RVA: 0x0025C410 File Offset: 0x0025A610
	public ako()
	{
	}

	// Token: 0x060055B5 RID: 21941 RVA: 0x0025C420 File Offset: 0x0025A620
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
		if (c5x != null)
		{
			c5x.q(this.c);
			amc aspect = c5x.GetAspect<amc>();
			if (aspect != null)
			{
				aspect.aa().Name = this.c;
			}
		}
	}

	// Token: 0x040022D8 RID: 8920
	private new Guid? a;

	// Token: 0x040022D9 RID: 8921
	private bvl b = bvl.c;

	// Token: 0x040022DA RID: 8922
	private string c;
}
