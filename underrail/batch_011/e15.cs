using System;
using System.Runtime.Serialization;

// Token: 0x02001A44 RID: 6724
[eiz("MEPE")]
[Serializable]
public sealed class e15 : dh6, ISerializable
{
	// Token: 0x060091E7 RID: 37351 RVA: 0x0039E058 File Offset: 0x0039C258
	private e15(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060091E8 RID: 37352 RVA: 0x0039E064 File Offset: 0x0039C264
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060091E9 RID: 37353 RVA: 0x0039E070 File Offset: 0x0039C270
	public e15()
	{
		base.Priority = 2;
	}

	// Token: 0x060091EA RID: 37354 RVA: 0x0039E080 File Offset: 0x0039C280
	public e15(float A_0) : base(A_0)
	{
		base.Priority = 2;
	}

	// Token: 0x060091EB RID: 37355 RVA: 0x0039E094 File Offset: 0x0039C294
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		nw nw = A_0.a().Defense;
		nw.a(nw.z() + (int)((float)A_0.a().Defense.z() * base.c()));
	}

	// Token: 0x060091EC RID: 37356 RVA: 0x0039E0DC File Offset: 0x0039C2DC
	public override string b2()
	{
		if (base.c() >= 0f)
		{
			return qv.a("StaticEffects/ModifyEvasionPercentage_Increased", new object[]
			{
				base.c() * 100f
			});
		}
		return qv.a("StaticEffects/ModifyEvasionPercentage_Decreased", new object[]
		{
			-base.c() * 100f
		});
	}

	// Token: 0x060091ED RID: 37357 RVA: 0x0039E144 File Offset: 0x0039C344
	public override d3e b3()
	{
		e15 e = new e15();
		this.xx(e);
		return e;
	}
}
