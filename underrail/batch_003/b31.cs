using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A91 RID: 6801
[eiz("FESE")]
[Serializable]
public sealed class b31 : els, ISerializable
{
	// Token: 0x060093A3 RID: 37795 RVA: 0x003A358C File Offset: 0x003A178C
	private b31(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093A4 RID: 37796 RVA: 0x003A3598 File Offset: 0x003A1798
	public b31() : base(b31.a, "Морозная среда", ci8.b)
	{
		base.Duration = d0u.b * 4;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.FrigidEnvironment";
		base.MaxStacks = 50;
		base.Stacking = axm.c;
		base.StaticEffects.Add(new e3r(DamageType.Cold, b31.b));
		base.StaticEffects.Add(new ah(DamageType.Cold, 1.0 - b31.c, true, true, true));
	}

	// Token: 0x060093A5 RID: 37797 RVA: 0x003A3624 File Offset: 0x003A1824
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/FrigidEnvironment", new object[]
		{
			Convert.ToInt32(b31.c * 100.0) * base.Stacks,
			Convert.ToInt32(b31.b * 100.0) * base.Stacks
		});
	}

	// Token: 0x060093A6 RID: 37798 RVA: 0x003A3688 File Offset: 0x003A1888
	protected override void c8()
	{
		e3r e3r = Enumerable.FirstOrDefault<e3r>(Enumerable.OfType<e3r>(base.StaticEffects));
		if (e3r != null)
		{
			e3r.Value = b31.b * (double)base.Stacks;
		}
		ah ah = Enumerable.FirstOrDefault<ah>(Enumerable.OfType<ah>(base.StaticEffects));
		if (ah != null)
		{
			ah.Value = Math.Max(0.0, 1.0 - b31.c * (double)base.Stacks);
		}
	}

	// Token: 0x040038BC RID: 14524
	public new static readonly string a = "frigidEnvironment";

	// Token: 0x040038BD RID: 14525
	public static readonly double b = 0.1;

	// Token: 0x040038BE RID: 14526
	public new static readonly double c = 0.05;
}
