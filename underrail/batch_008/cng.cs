using System;
using System.Runtime.Serialization;

// Token: 0x02001B28 RID: 6952
[eiz("PS9")]
[Serializable]
public sealed class cng : els, ISerializable
{
	// Token: 0x0600965C RID: 38492 RVA: 0x003AD5DC File Offset: 0x003AB7DC
	private cng(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600965D RID: 38493 RVA: 0x003AD5E8 File Offset: 0x003AB7E8
	public cng(int A_0) : base(cng.b, "Псионическая синергия", ci8.b)
	{
		base.Icon = "Psi";
		base.MaxStacks = 99;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new dpw("metathermics", cng.a(base.Stacks)));
		base.StaticEffects.Add(new dpw("psychokinesis", cng.a(base.Stacks)));
		base.StaticEffects.Add(new dpw("thought control", cng.a(base.Stacks)));
		base.Duration = A_0;
	}

	// Token: 0x0600965E RID: 38494 RVA: 0x003AD688 File Offset: 0x003AB888
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/psionicSynergy", new object[]
		{
			cng.a(base.Stacks)
		});
	}

	// Token: 0x0600965F RID: 38495 RVA: 0x003AD6B0 File Offset: 0x003AB8B0
	protected override void c8()
	{
		base.c8();
		foreach (d3e d3e in base.StaticEffects)
		{
			((dpw)d3e).a(cng.a(base.Stacks));
		}
	}

	// Token: 0x06009660 RID: 38496 RVA: 0x003AD71C File Offset: 0x003AB91C
	private static int a(int A_0)
	{
		return A_0 * cng.a;
	}

	// Token: 0x040039DF RID: 14815
	private new static readonly int a = 2;

	// Token: 0x040039E0 RID: 14816
	public static readonly string b = "psionicSynergy";
}
