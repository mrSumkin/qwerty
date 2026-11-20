using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001552 RID: 5458
[eiz("SCPB2")]
[Serializable]
public sealed class cl4 : d64, ISerializable
{
	// Token: 0x060079AC RID: 31148 RVA: 0x0032EC44 File Offset: 0x0032CE44
	private cl4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079AD RID: 31149 RVA: 0x0032EC50 File Offset: 0x0032CE50
	public cl4()
	{
	}

	// Token: 0x060079AE RID: 31150 RVA: 0x0032EC58 File Offset: 0x0032CE58
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
			awq.a(base.c(), base.b(), a_3, cd, new cl4.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001553 RID: 5459
	[eiz("SCPB2a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060079AF RID: 31151 RVA: 0x0032EDCC File Offset: 0x0032CFCC
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SCPB2a:P", typeof(cl4)) as cl4);
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x0032EDF4 File Offset: 0x0032CFF4
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SCPB2a:P", this.a);
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x0032EE08 File Offset: 0x0032D008
		public a(cl4 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x0032EE1C File Offset: 0x0032D01C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(cl4.a.a.a.a)), new Func<csk, int>(cl4.a.a.a.b)) > 0 && this.a.vg().e() != null && this.a.vg().e().b9() is coh)
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
					dns a_2 = new dns(ezx.g * d0u.b);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x040030B9 RID: 12473
		private cl4 a;

		// Token: 0x02001554 RID: 5460
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060079B5 RID: 31157 RVA: 0x0032EF9C File Offset: 0x0032D19C
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x060079B6 RID: 31158 RVA: 0x0032EFA8 File Offset: 0x0032D1A8
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030BA RID: 12474
			public static readonly cl4.a.a a = new cl4.a.a();

			// Token: 0x040030BB RID: 12475
			public static Func<csk, bool> b;

			// Token: 0x040030BC RID: 12476
			public static Func<csk, int> c;
		}
	}
}
