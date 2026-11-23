using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001563 RID: 5475
[eiz("CAX2")]
[Serializable]
public sealed class eyb : d64, ISerializable
{
	// Token: 0x060079EB RID: 31211 RVA: 0x003303F8 File Offset: 0x0032E5F8
	private eyb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079EC RID: 31212 RVA: 0x00330404 File Offset: 0x0032E604
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.FinishPsi);
	}

	// Token: 0x060079ED RID: 31213 RVA: 0x0033040C File Offset: 0x0032E60C
	public eyb()
	{
	}

	// Token: 0x060079EE RID: 31214 RVA: 0x00330418 File Offset: 0x0032E618
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		bke bke = cd.TypedDefinition;
		if (bke != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += 1.0;
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			cwt.k = "Жало";
			bool value = bke.a7().GetPrimitivePropertyValue<bool>("allergy", new bool?(false)).Value;
			awq.a(base.c(), base.b(), cwt, cd, new eyb.a(value));
		}
	}

	// Token: 0x02001564 RID: 5476
	[eiz("CAX2a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060079EF RID: 31215 RVA: 0x00330534 File Offset: 0x0032E734
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() >= 459)
			{
				this.a = A_0.GetBoolean("CAX2a:A");
			}
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x0033055C File Offset: 0x0032E75C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("CAX2a:A", this.a);
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x00330570 File Offset: 0x0032E770
		public a(bool A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x00330584 File Offset: 0x0032E784
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_1.a8() != null && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(eyb.a.a.a.a)), new Func<csk, int>(eyb.a.a.a.b)) > 0)
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
					ddr a_2 = new ddr((A_0 != null) ? A_0.aa() : null, ezx.d * d0u.b, ezx.e);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
					if (this.a)
					{
						int a_3 = euf.n(A_1.aa());
						int a_4 = (int)(80.0 - 40.0 * euf.c(a_3, A_1.aa()));
						bek a_5 = new bek(bek.c * d0u.b, a_4);
						A_1.aa().StatusEffects.a(a_5, false, false, false);
					}
				}
			}
		}

		// Token: 0x040030C6 RID: 12486
		private bool a;

		// Token: 0x02001565 RID: 5477
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060079F5 RID: 31221 RVA: 0x00330744 File Offset: 0x0032E944
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x060079F6 RID: 31222 RVA: 0x00330750 File Offset: 0x0032E950
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030C7 RID: 12487
			public static readonly eyb.a.a a = new eyb.a.a();

			// Token: 0x040030C8 RID: 12488
			public static Func<csk, bool> b;

			// Token: 0x040030C9 RID: 12489
			public static Func<csk, int> c;
		}
	}
}
