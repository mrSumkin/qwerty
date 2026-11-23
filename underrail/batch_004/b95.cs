using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02000BB0 RID: 2992
[euj]
public sealed class b95
{
	// Token: 0x0600440A RID: 17418 RVA: 0x001ADCE8 File Offset: 0x001ABEE8
	[ayh("XPHWIJGFCB")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			egb egb = new egb();
			egb.a("fusionCannon");
			egb.ym(A_0, A_1, A_2);
			bmj.a(A_0, new ccq(ScrollingCombatTextOptions.Mandatory, "Успешно проведено обучение созданию термоядерной пушки.", Color.LightGreen, null, false));
			a7v.a(new h0("Успешно проведено обучение созданию термоядерной пушки.", new Color?(Color.LightGreen)));
			foreach (coh coh in serviceOrThrow.aqu().v().Bag.z2())
			{
				if (coh.Definition.a5() == "fusionCannonFrame")
				{
					coh.Definition.a2().RemoveAll(new Predicate<aia>(b95.a.a.a));
					coh.Definition.a7().RemoveProperty("UsageJob");
				}
			}
		}
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x001ADE18 File Offset: 0x001AC018
	[ayh("XPHWIJGFEB")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			egb egb = new egb();
			egb.a("fusionEmitter");
			egb.ym(A_0, A_1, A_2);
			bmj.a(A_0, new ccq(ScrollingCombatTextOptions.Mandatory, "Успешно воспроизведена разработка термоядерного излучателя.", Color.LightGreen, null, false));
			a7v.a(new h0("Успешно воспроизведена разработка термоядерного излучателя.", new Color?(Color.LightGreen)));
			foreach (coh coh in serviceOrThrow.aqu().v().Bag.z2())
			{
				if (coh.Definition.a5() == "fusionEmitter")
				{
					coh.Definition.a2().RemoveAll(new Predicate<aia>(b95.a.a.b));
					coh.Definition.a7().RemoveProperty("UsageJob");
				}
			}
		}
	}

	// Token: 0x02000BB1 RID: 2993
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600440F RID: 17423 RVA: 0x001ADF64 File Offset: 0x001AC164
		internal bool a(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "genericUseJobItem";
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x001ADF78 File Offset: 0x001AC178
		internal bool b(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "genericUseJobItem";
		}

		// Token: 0x04001C4E RID: 7246
		public static readonly b95.a a = new b95.a();

		// Token: 0x04001C4F RID: 7247
		public static Predicate<aia> b;

		// Token: 0x04001C50 RID: 7248
		public static Predicate<aia> c;
	}
}
