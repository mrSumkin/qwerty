using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A9A RID: 6810
[eiz("CONT")]
[Serializable]
public sealed class a8l : els, ISerializable
{
	// Token: 0x060093CC RID: 37836 RVA: 0x003A3DF4 File Offset: 0x003A1FF4
	private a8l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093CD RID: 37837 RVA: 0x003A3E00 File Offset: 0x003A2000
	public a8l(int A_0) : base(a8l.a, "Заражение", ci8.c)
	{
		base.Duration = a8l.d * d0u.b;
		base.TickPeriod = 0;
		base.Icon = "DamageType.Bio";
		base.MaxStacks = a8l.c;
		base.Stacks = A_0;
		base.Stacking = axm.b;
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			e3r item = new e3r((DamageType)obj, (double)A_0 * a8l.b);
			base.StaticEffects.Add(item);
		}
	}

	// Token: 0x060093CE RID: 37838 RVA: 0x003A3ECC File Offset: 0x003A20CC
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Contaminated", new object[]
		{
			(int)((double)base.Stacks * a8l.b * 100.0)
		});
	}

	// Token: 0x060093CF RID: 37839 RVA: 0x003A3F00 File Offset: 0x003A2100
	protected override void c8()
	{
		foreach (e3r e3r in Enumerable.OfType<e3r>(base.StaticEffects))
		{
			e3r.Value = (double)base.Stacks * a8l.b;
		}
	}

	// Token: 0x040038CA RID: 14538
	public new static readonly string a = "contaminated";

	// Token: 0x040038CB RID: 14539
	public static readonly double b = 0.05;

	// Token: 0x040038CC RID: 14540
	public new static readonly int c = 20;

	// Token: 0x040038CD RID: 14541
	public new static readonly int d = 5;
}
