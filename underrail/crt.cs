using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A7A RID: 6778
[eiz("BTSE0")]
[Serializable]
public sealed class crt : els, ISerializable
{
	// Token: 0x06009332 RID: 37682 RVA: 0x003A17BC File Offset: 0x0039F9BC
	private crt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009333 RID: 37683 RVA: 0x003A17C8 File Offset: 0x0039F9C8
	public crt(int A_0, double A_1, int A_2) : base("bulletTrance", "Пулевой транс", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.125";
		base.MaxStacks = A_2;
		base.Stacking = axm.b;
		base.Power = Convert.ToInt32(A_1 * 1000.0);
		base.StaticEffects.Add(new cuv(A_1, WeaponAggregateSubtype.LMG));
		base.StaticEffects.Add(new cuv(A_1, WeaponAggregateSubtype.Minigun));
		this.a();
	}

	// Token: 0x06009334 RID: 37684 RVA: 0x003A1848 File Offset: 0x0039FA48
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x06009335 RID: 37685 RVA: 0x003A1858 File Offset: 0x0039FA58
	private void a()
	{
		cuv cuv = Enumerable.FirstOrDefault<cuv>(Enumerable.OfType<cuv>(base.StaticEffects));
		if (cuv != null)
		{
			cuv.a((double)base.Power / 1000.0 * (double)base.Stacks);
		}
	}

	// Token: 0x06009336 RID: 37686 RVA: 0x003A189C File Offset: 0x0039FA9C
	public override string cb(ll A_0)
	{
		double num = 0.0;
		cuv cuv = Enumerable.FirstOrDefault<cuv>(Enumerable.OfType<cuv>(base.StaticEffects));
		if (cuv != null)
		{
			num = cuv.b();
		}
		return qv.a("StatusEffects/BulletTrance", new object[]
		{
			Convert.ToInt32(num * 100.0)
		});
	}
}
