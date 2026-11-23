using System;
using System.Runtime.Serialization;

// Token: 0x02001A43 RID: 6723
[eiz("MRPE")]
[Serializable]
public sealed class cly : dh6, ISerializable
{
	// Token: 0x060091E1 RID: 37345 RVA: 0x0039DF68 File Offset: 0x0039C168
	private cly(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060091E2 RID: 37346 RVA: 0x0039DF74 File Offset: 0x0039C174
	public cly()
	{
	}

	// Token: 0x060091E3 RID: 37347 RVA: 0x0039DF7C File Offset: 0x0039C17C
	public cly(float A_0) : base(A_0)
	{
	}

	// Token: 0x060091E4 RID: 37348 RVA: 0x0039DF88 File Offset: 0x0039C188
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		nw nw = A_0.a().Defense;
		nw.b(nw.ae() + (int)((float)A_0.a().Defense.ae() * base.c()));
	}

	// Token: 0x060091E5 RID: 37349 RVA: 0x0039DFD0 File Offset: 0x0039C1D0
	public override string b2()
	{
		if (base.c() >= 0f)
		{
			return qv.a("StaticEffects/ModifyResolvePercentage_Increased", new object[]
			{
				base.c() * 100f
			});
		}
		return qv.a("StaticEffects/ModifyResolvePercentage_Decreased", new object[]
		{
			Math.Abs(base.c()) * 100f
		});
	}

	// Token: 0x060091E6 RID: 37350 RVA: 0x0039E03C File Offset: 0x0039C23C
	public override d3e b3()
	{
		cly cly = new cly();
		this.xx(cly);
		return cly;
	}
}
