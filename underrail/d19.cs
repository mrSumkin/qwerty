using System;
using System.Runtime.Serialization;

// Token: 0x02001A45 RID: 6725
[eiz("MDPE")]
[Serializable]
public sealed class d19 : dh6, ISerializable
{
	// Token: 0x060091EE RID: 37358 RVA: 0x0039E160 File Offset: 0x0039C360
	private d19(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060091EF RID: 37359 RVA: 0x0039E16C File Offset: 0x0039C36C
	public d19()
	{
	}

	// Token: 0x060091F0 RID: 37360 RVA: 0x0039E174 File Offset: 0x0039C374
	public d19(float A_0) : base(A_0)
	{
	}

	// Token: 0x060091F1 RID: 37361 RVA: 0x0039E180 File Offset: 0x0039C380
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		nw nw = A_0.a().Defense;
		nw.c(nw.v() + (int)((float)A_0.a().Defense.v() * base.c()));
	}

	// Token: 0x060091F2 RID: 37362 RVA: 0x0039E1C8 File Offset: 0x0039C3C8
	public override string b2()
	{
		if (base.c() >= 0f)
		{
			return qv.a("StaticEffects/ModifyDodgePercentage_Increased", new object[]
			{
				base.c() * 100f
			});
		}
		return qv.a("StaticEffects/ModifyDodgePercentage_Decreased", new object[]
		{
			-base.c() * 100f
		});
	}

	// Token: 0x060091F3 RID: 37363 RVA: 0x0039E230 File Offset: 0x0039C430
	public override d3e b3()
	{
		d19 d = new d19();
		this.xx(d);
		return d;
	}
}
