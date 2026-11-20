using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200151D RID: 5405
[eiz("CLA")]
[Serializable]
public sealed class ahl : d64, ISerializable
{
	// Token: 0x060078E8 RID: 30952 RVA: 0x00329CEC File Offset: 0x00327EEC
	private ahl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060078E9 RID: 30953 RVA: 0x00329CF8 File Offset: 0x00327EF8
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack2);
	}

	// Token: 0x060078EA RID: 30954 RVA: 0x00329D04 File Offset: 0x00327F04
	public ahl()
	{
	}

	// Token: 0x060078EB RID: 30955 RVA: 0x00329D10 File Offset: 0x00327F10
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				if (csk.DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(csk.DamageType, Math.Max(1, csk.Amount * p8.a));
				}
			}
			cwt.k = "Расщепление";
			awq.a(base.c(), base.b(), cwt, cd, new ahl.a());
		}
	}

	// Token: 0x0200151E RID: 5406
	[eiz("CLAb")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060078EC RID: 30956 RVA: 0x00329EAC File Offset: 0x003280AC
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x00329EB4 File Offset: 0x003280B4
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x00329EB8 File Offset: 0x003280B8
		public a()
		{
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x00329EC4 File Offset: 0x003280C4
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (awq.a(A_0, A_1, A_2, A_3, true, true, true))
			{
				c5x a_ = A_1.a8();
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
