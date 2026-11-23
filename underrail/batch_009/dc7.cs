using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001549 RID: 5449
[eiz("SBPB")]
[Serializable]
public sealed class dc7 : d64, ISerializable
{
	// Token: 0x0600798C RID: 31116 RVA: 0x0032E184 File Offset: 0x0032C384
	private dc7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600798D RID: 31117 RVA: 0x0032E190 File Offset: 0x0032C390
	public dc7()
	{
	}

	// Token: 0x0600798E RID: 31118 RVA: 0x0032E19C File Offset: 0x0032C39C
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		awq.a(base.c().aa());
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cwt a_3 = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			awq.a(base.c(), base.b(), a_3, cd, new dc7.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0200154A RID: 5450
	[eiz("SBPBa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600798F RID: 31119 RVA: 0x0032E310 File Offset: 0x0032C510
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SBPBa:P", typeof(dc7)) as dc7);
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x0032E338 File Offset: 0x0032C538
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SBPBa:P", this.a);
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x0032E34C File Offset: 0x0032C54C
		public a(dc7 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x0032E360 File Offset: 0x0032C560
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(dc7.a.a.a.a)), new Func<csk, int>(dc7.a.a.a.b)) > 0 && this.a.vg().e() != null && this.a.vg().e().b9() is coh)
				{
					if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Poison))
					{
						if (A_0 != null)
						{
							etm a_ = new etm(new ap9(A_1.aa()), "яду");
							bey.a(a_, A_0.aa(), A_1.aa(), A_1);
							a7v.a(a_);
						}
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					int num = ezx.l;
					if (A_0 != null && A_0.aa().Feats.Contains<dt>())
					{
						num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
					}
					vs a_2 = new vs((A_0 != null) ? A_0.aa() : null, ezx.o * d0u.b, num);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x040030AE RID: 12462
		private dc7 a;

		// Token: 0x0200154B RID: 5451
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007995 RID: 31125 RVA: 0x0032E530 File Offset: 0x0032C730
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007996 RID: 31126 RVA: 0x0032E53C File Offset: 0x0032C73C
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030AF RID: 12463
			public static readonly dc7.a.a a = new dc7.a.a();

			// Token: 0x040030B0 RID: 12464
			public static Func<csk, bool> b;

			// Token: 0x040030B1 RID: 12465
			public static Func<csk, int> c;
		}
	}
}
