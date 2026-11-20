using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AF2 RID: 6898
[eiz("CRDX")]
[Serializable]
public sealed class deu : els, ISerializable
{
	// Token: 0x06009570 RID: 38256 RVA: 0x003A9E98 File Offset: 0x003A8098
	private deu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009571 RID: 38257 RVA: 0x003A9EA8 File Offset: 0x003A80A8
	public deu(int A_0) : base("corroded", "Коррозия", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.Corrosion";
		base.MaxStacks = deu.b;
		base.Stacking = axm.b;
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType a_ = (DamageType)obj;
			base.StaticEffects.Add(new ah(a_, 1.0 - deu.a, true, true, false));
		}
	}

	// Token: 0x06009572 RID: 38258 RVA: 0x003A9F64 File Offset: 0x003A8164
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Corroded", new object[]
		{
			(int)(deu.a * (double)base.Stacks * 100.0)
		});
	}

	// Token: 0x06009573 RID: 38259 RVA: 0x003A9F98 File Offset: 0x003A8198
	protected override void c8()
	{
		foreach (d3e d3e in base.StaticEffects)
		{
			((ah)d3e).Value = 1.0 - deu.a * (double)base.Stacks;
		}
	}

	// Token: 0x0400398A RID: 14730
	public new static readonly double a = 0.075;

	// Token: 0x0400398B RID: 14731
	public static readonly int b = 10;

	// Token: 0x0400398C RID: 14732
	public new static readonly int c = 5;
}
