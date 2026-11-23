using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016BD RID: 5821
[eiz("SKSBA5")]
[Serializable]
public sealed class amb : a6k, ISerializable
{
	// Token: 0x06007EEA RID: 32490 RVA: 0x0035A3A4 File Offset: 0x003585A4
	private amb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EEB RID: 32491 RVA: 0x0035A3B0 File Offset: 0x003585B0
	public amb()
	{
	}

	// Token: 0x06007EEC RID: 32492 RVA: 0x0035A3BC File Offset: 0x003585BC
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
		cd1 cd = new cd1(new IndependentItemDefinitionProvider<bke>(euf.i(base.vg().q().h.b.aa()).TypedDefinition));
		a1q a_ = d8i.a(base.vg().e());
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, null);
		efk a_2 = base.vg().e().b8();
		efk a_3 = c5x.h.b.aa();
		cmn a_4 = cmn;
		double a_5 = 0.0;
		cd1 a_6 = cd;
		cwt cwt = euf.a(a_2, a_3, a_4, a_5, null, 1.0, a_6, true);
		cwt.f.Clear();
		cwt.f.Add(euf.a(a_, 1.0));
		cwt.k = "Удар щитом";
		awq.a(base.vg().q().h.b, c5x.h.b, cwt, cd, new amb.a(this));
		return dc4.c;
	}

	// Token: 0x020016BE RID: 5822
	[eiz("SKSBA5a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007EED RID: 32493 RVA: 0x0035A554 File Offset: 0x00358754
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SKSBA5a:P", typeof(amb)) as amb);
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x0035A57C File Offset: 0x0035877C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SKSBA5a:P", this.a);
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x0035A590 File Offset: 0x00358790
		public a(amb A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x0035A5A0 File Offset: 0x003587A0
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_0 != null && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(amb.a.a.a.a)), new Func<csk, int>(amb.a.a.a.b)) > 0)
				{
					if (A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Daze))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "дезориентации");
						bey.a(a_, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_);
						return;
					}
					eok a_2 = new eok(d8i.c);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
					A_1.a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
				}
			}
		}

		// Token: 0x04003223 RID: 12835
		private amb a;

		// Token: 0x020016BF RID: 5823
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007EF3 RID: 32499 RVA: 0x0035A6E8 File Offset: 0x003588E8
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007EF4 RID: 32500 RVA: 0x0035A6F4 File Offset: 0x003588F4
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003224 RID: 12836
			public static readonly amb.a.a a = new amb.a.a();

			// Token: 0x04003225 RID: 12837
			public static Func<csk, bool> b;

			// Token: 0x04003226 RID: 12838
			public static Func<csk, int> c;
		}
	}
}
