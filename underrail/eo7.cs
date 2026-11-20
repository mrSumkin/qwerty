using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200155B RID: 5467
[eiz("PWS")]
[Serializable]
public sealed class eo7 : d64, ISerializable
{
	// Token: 0x060079CE RID: 31182 RVA: 0x0032F7B0 File Offset: 0x0032D9B0
	private eo7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079CF RID: 31183 RVA: 0x0032F7BC File Offset: 0x0032D9BC
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack1);
	}

	// Token: 0x060079D0 RID: 31184 RVA: 0x0032F7C4 File Offset: 0x0032D9C4
	public eo7()
	{
	}

	// Token: 0x060079D1 RID: 31185 RVA: 0x0032F7CC File Offset: 0x0032D9CC
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			int num = (int)((double)base.c().aa().Defense.q().zm() * cbi.a(base.vg().e()) * (1.0 + cmn.b));
			if (cwt.e)
			{
				num = (int)((double)num * (1.0 + base.c().aa().Offense.am()));
			}
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				if (csk.DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(csk.DamageType, Math.Max(1, csk.Amount + num));
				}
			}
			cwt.k = "Вразнос";
			awq.a(base.c(), base.b(), cwt, cd, null);
			if (cwt.b)
			{
				c5x a_ = base.b().a8();
				string a_2 = "SuperSlamHit";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			}
		}
	}
}
