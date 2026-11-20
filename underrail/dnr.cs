using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016E1 RID: 5857
[eiz("DK0")]
[Serializable]
public sealed class dnr : a6k, ISerializable
{
	// Token: 0x06007F64 RID: 32612 RVA: 0x0035F2A4 File Offset: 0x0035D4A4
	private dnr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F65 RID: 32613 RVA: 0x0035F2B0 File Offset: 0x0035D4B0
	public dnr()
	{
	}

	// Token: 0x06007F66 RID: 32614 RVA: 0x0035F2BC File Offset: 0x0035D4BC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		bke bke = euf.i(base.vg().q().h.b.aa()).TypedDefinition;
		cd1 cd = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
		a1q a_ = czi.a(base.vg().e());
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, null);
		cmn.a = c3u.a;
		efk a_2 = base.vg().e().b8();
		efk a_3 = c5x.h.b.aa();
		cmn a_4 = cmn;
		double a_5 = 0.0;
		cd1 a_6 = cd;
		cwt cwt = euf.a(a_2, a_3, a_4, a_5, null, 1.0, a_6, false);
		cwt.f.Clear();
		cwt.f.Add(euf.a(a_, cwt.e ? (1.0 + bke.y()) : 1.0));
		cwt.k = "Низкий удар";
		awq.a(base.vg().q().h.b, c5x.h.b, cwt, cd, new dnr.a(this));
		return dc4.c;
	}

	// Token: 0x020016E2 RID: 5858
	[eiz("DK0a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007F67 RID: 32615 RVA: 0x0035F480 File Offset: 0x0035D680
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("DK0a:P", typeof(dnr)) as dnr);
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x0035F4A8 File Offset: 0x0035D6A8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("DK0a:P", this.a);
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x0035F4BC File Offset: 0x0035D6BC
		public a(dnr A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x0035F4CC File Offset: 0x0035D6CC
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_0 != null && A_2.b)
			{
				if (A_1.aa().Dead)
				{
					if (A_0 != null && A_0.aa() is e3q)
					{
						cxc.c(eyy.an);
						return;
					}
				}
				else if (A_3.a != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(dnr.a.a.a.a)), new Func<csk, int>(dnr.a.a.a.b)) > 0)
					{
						if (A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Stun))
						{
							etm a_ = new etm(new ap9(A_1.aa()), "оглушению");
							bey.a(a_, A_0.aa(), A_1.aa(), A_1);
							a7v.a(a_);
							return;
						}
						int a_2;
						if (A_1.aa().b(d8o.b | d8o.c) && A_1.aa().Gender == Gender.Male && !A_1.aa().d(CharacterImmunities.DirtyKickExtraStun))
						{
							a_2 = czi.d;
						}
						else
						{
							a_2 = czi.c;
						}
						els els = awq.a(A_1.aa(), a_2);
						A_1.aa().StatusEffects.a(els, false, false, false);
						if (A_0.aa() is e3q && !(A_1.aa() is e3q) && els is ab3)
						{
							cxc.a(eyy.by);
						}
						A_1.a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
					}
				}
			}
		}

		// Token: 0x0400323A RID: 12858
		private dnr a;

		// Token: 0x020016E3 RID: 5859
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007F6D RID: 32621 RVA: 0x0035F6C0 File Offset: 0x0035D8C0
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007F6E RID: 32622 RVA: 0x0035F6CC File Offset: 0x0035D8CC
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400323B RID: 12859
			public static readonly dnr.a.a a = new dnr.a.a();

			// Token: 0x0400323C RID: 12860
			public static Func<csk, bool> b;

			// Token: 0x0400323D RID: 12861
			public static Func<csk, int> c;
		}
	}
}
