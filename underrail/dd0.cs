using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A79 RID: 6777
[eiz("DRSE0")]
[Serializable]
public sealed class dd0 : els, ISerializable
{
	// Token: 0x0600932D RID: 37677 RVA: 0x003A167C File Offset: 0x0039F87C
	private dd0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600932E RID: 37678 RVA: 0x003A1688 File Offset: 0x0039F888
	public dd0(int A_0, double A_1, int A_2) : base("demolitionRage", "Ярость разрушений", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.136";
		base.MaxStacks = A_2;
		base.Stacking = axm.b;
		base.Power = Convert.ToInt32(A_1 * 1000.0);
		base.StaticEffects.Add(new cuv(A_1, WeaponAggregateSubtype.GrenadeLauncher));
		base.StaticEffects.Add(new cuv(A_1, WeaponAggregateSubtype.RocketLauncher));
		this.a();
	}

	// Token: 0x0600932F RID: 37679 RVA: 0x003A1708 File Offset: 0x0039F908
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x06009330 RID: 37680 RVA: 0x003A1718 File Offset: 0x0039F918
	private void a()
	{
		cuv cuv = Enumerable.FirstOrDefault<cuv>(Enumerable.OfType<cuv>(base.StaticEffects));
		if (cuv != null)
		{
			cuv.a((double)base.Power / 1000.0 * (double)base.Stacks);
		}
	}

	// Token: 0x06009331 RID: 37681 RVA: 0x003A175C File Offset: 0x0039F95C
	public override string cb(ll A_0)
	{
		double num = 0.0;
		cuv cuv = Enumerable.FirstOrDefault<cuv>(Enumerable.OfType<cuv>(base.StaticEffects));
		if (cuv != null)
		{
			num = cuv.b();
		}
		return qv.a("StatusEffects/DemolitionRage", new object[]
		{
			Convert.ToInt32(num * 100.0)
		});
	}
}
