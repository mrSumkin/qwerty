using System;
using System.Runtime.Serialization;

// Token: 0x020019BB RID: 6587
[eiz("C83")]
[Serializable]
public sealed class arh : dh6, ISerializable, d7s
{
	// Token: 0x06008CF9 RID: 36089 RVA: 0x00392418 File Offset: 0x00390618
	private arh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008CFA RID: 36090 RVA: 0x00392424 File Offset: 0x00390624
	public arh()
	{
	}

	// Token: 0x06008CFB RID: 36091 RVA: 0x0039242C File Offset: 0x0039062C
	public arh(float A_0) : base(A_0)
	{
	}

	// Token: 0x06008CFC RID: 36092 RVA: 0x00392438 File Offset: 0x00390638
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		A_0.a().Defense.aa += base.c();
	}

	// Token: 0x06008CFD RID: 36093 RVA: 0x00392470 File Offset: 0x00390670
	public override string b2()
	{
		if (base.c() >= 0f)
		{
			return qv.a("StaticEffects/ModifyChanceToAvoidImmobilization_Increased", new object[]
			{
				Math.Round((double)(base.c() * 100f), 2).ToString("0.00")
			});
		}
		return qv.a("StaticEffects/ModifyChanceToAvoidImmobilization_Decreased", new object[]
		{
			Math.Round((double)(Math.Abs(base.c()) * 100f), 2).ToString("0.00")
		});
	}

	// Token: 0x06008CFE RID: 36094 RVA: 0x003924FC File Offset: 0x003906FC
	public override d3e b3()
	{
		arh arh = new arh();
		this.xx(arh);
		return arh;
	}

	// Token: 0x06008CFF RID: 36095 RVA: 0x00392518 File Offset: 0x00390718
	public void cn(d3e A_0)
	{
		arh arh = A_0 as arh;
		if (arh != null)
		{
			base.a(base.c() + arh.c());
		}
	}

	// Token: 0x06008D00 RID: 36096 RVA: 0x00392548 File Offset: 0x00390748
	public bool co(d3e A_0)
	{
		return A_0 is arh;
	}
}
