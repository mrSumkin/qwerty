using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200155F RID: 5471
[eiz("EX")]
[Serializable]
public sealed class cdz : d64, ISerializable
{
	// Token: 0x060079DC RID: 31196 RVA: 0x0032FEAC File Offset: 0x0032E0AC
	private cdz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079DD RID: 31197 RVA: 0x0032FEB8 File Offset: 0x0032E0B8
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack2);
	}

	// Token: 0x060079DE RID: 31198 RVA: 0x0032FEC4 File Offset: 0x0032E0C4
	public cdz()
	{
	}

	// Token: 0x060079DF RID: 31199 RVA: 0x0032FECC File Offset: 0x0032E0CC
	protected override void bf()
	{
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			cwt.k = "Мясорубка";
			int count = base.b().aa().StatusEffects.Get<a5e>().Count;
			if (count > 0)
			{
				for (int i = 0; i < cwt.f.Count; i++)
				{
					csk csk = cwt.f[i];
					if (csk.DamageType == DamageType.Mechanical)
					{
						cwt.f[i] = new csk(csk.DamageType, (int)((double)csk.Amount * (1.0 + bhw.a(base.vg().e()) * (double)count)));
					}
				}
			}
			awq.a(base.c(), base.b(), cwt, cd, new cdz.a());
		}
	}

	// Token: 0x02001560 RID: 5472
	[eiz("EXa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060079E0 RID: 31200 RVA: 0x0033009C File Offset: 0x0032E29C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x003300A4 File Offset: 0x0032E2A4
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x003300A8 File Offset: 0x0032E2A8
		public a()
		{
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x003300B0 File Offset: 0x0032E2B0
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b && A_1 != null)
			{
				if (!A_1.aa().Passive && !A_1.aa().b(d8o.e))
				{
					c5x a_ = A_1.a8();
					string a_2 = "Rend";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = true;
					float? a_6 = dz6.b();
					boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
					A_1.a8().c().a(Guid.NewGuid().ToString(), "Rend", 1f, c9z.a, false, false);
				}
				if (!A_1.aa().Dead)
				{
					foreach (a5e a_7 in A_1.aa().StatusEffects.Get<a5e>())
					{
						A_1.aa().StatusEffects.d(a_7);
					}
				}
			}
		}
	}
}
