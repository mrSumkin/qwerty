using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200157F RID: 5503
[eiz("S42")]
[Serializable]
public sealed class bc0 : d64, ISerializable
{
	// Token: 0x06007A54 RID: 31316 RVA: 0x00333188 File Offset: 0x00331388
	private bc0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A55 RID: 31317 RVA: 0x00333194 File Offset: 0x00331394
	public bc0()
	{
	}

	// Token: 0x06007A56 RID: 31318 RVA: 0x003331A0 File Offset: 0x003313A0
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
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			for (int i = 0; i < cwt.f.Count; i++)
			{
				if (cwt.f[i].DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(DamageType.Mechanical, (int)Math.Ceiling((double)cwt.f[i].Amount * d8m.a()));
				}
			}
			awq.a(base.c(), base.b(), cwt, cd, new bc0.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001580 RID: 5504
	[eiz("S42a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A57 RID: 31319 RVA: 0x00333388 File Offset: 0x00331588
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S42a:P", typeof(bc0)) as bc0);
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x003333B0 File Offset: 0x003315B0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S42a:P", this.a);
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x003333C4 File Offset: 0x003315C4
		public a(bc0 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x003333D4 File Offset: 0x003315D4
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(bc0.a.a.a.a)), new Func<csk, int>(bc0.a.a.a.b)) > 0 && this.a.vg().e() != null && this.a.vg().e().b9() is coh)
				{
					if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Poison))
					{
						if (A_0 != null)
						{
							etm a_ = new etm(new ap9(A_1.aa()), "разложению");
							bey.a(a_, A_0.aa(), A_1.aa(), A_1);
							a7v.a(a_);
						}
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					if (A_1.am().StartsWith("rathound"))
					{
						LibraryItemDefinitionProvider<dj3> libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<dj3>("plot\\PutrefiedRathoundTissue");
						if (libraryItemDefinitionProvider != null)
						{
							d48 d = new d48(libraryItemDefinitionProvider);
							d.Lootable = true;
							d.Stealable = false;
							A_1.aa().Bag.z3(d, true);
						}
					}
				}
			}
		}

		// Token: 0x040030EF RID: 12527
		private bc0 a;

		// Token: 0x02001581 RID: 5505
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A5D RID: 31325 RVA: 0x0033357C File Offset: 0x0033177C
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A5E RID: 31326 RVA: 0x00333588 File Offset: 0x00331788
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030F0 RID: 12528
			public static readonly bc0.a.a a = new bc0.a.a();

			// Token: 0x040030F1 RID: 12529
			public static Func<csk, bool> b;

			// Token: 0x040030F2 RID: 12530
			public static Func<csk, int> c;
		}
	}
}
