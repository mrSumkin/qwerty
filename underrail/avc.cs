using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001566 RID: 5478
[eiz("HP0")]
[Serializable]
public sealed class avc : d64, ISerializable
{
	// Token: 0x060079F7 RID: 31223 RVA: 0x0033075C File Offset: 0x0032E95C
	private avc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079F8 RID: 31224 RVA: 0x00330768 File Offset: 0x0032E968
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack1);
	}

	// Token: 0x060079F9 RID: 31225 RVA: 0x00330770 File Offset: 0x0032E970
	public avc()
	{
	}

	// Token: 0x060079FA RID: 31226 RVA: 0x00330778 File Offset: 0x0032E978
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cmn.d += (double)base.c().aa().GetSpecializationValue<cyg>(true) * cyg.a;
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			double num = bs.a(base.vg().e());
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				if (csk.DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * num));
				}
			}
			cwt.k = "Тяжёлая рука";
			awq.a(base.c(), base.b(), cwt, cd, null);
		}
	}
}
