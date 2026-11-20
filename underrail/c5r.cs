using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003E7 RID: 999
[fe("pig")]
public sealed class c5r : ua
{
	// Token: 0x06001AC7 RID: 6855 RVA: 0x000910B0 File Offset: 0x0008F2B0
	public c5r(bm6 A_0) : base("RathoundBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new b64("StopCharging", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(c5r.a.a.a), null));
		list.Add(new efs("CombatNearEnemies", new List<c96>
		{
			new e8n("FocusPrimaryTarget", new List<c96>
			{
				new cta("AutoAttackCurrentTarget"),
				new rv("GiveUpOnTarget", 180, 300000)
			}),
			new chi("ChangeTargetActivity")
		}));
		list.Add(new e1y("IdleMovement", new List<c96>
		{
			new c1j("Rummage")
			{
				c = 1f,
				b = "PigAnswer",
				d = new CharacterState?(CharacterState.Custom3),
				a = 20000
			},
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 5,
				c = 3
			},
			new aif("RestActivity")
		})
		{
			c = 0.75f
		});
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x0009122C File Offset: 0x0008F42C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return base.h().@as != null;
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x00091240 File Offset: 0x0008F440
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		base.h().@as = null;
		base.h().at = null;
		foreach (da6 a_ in Enumerable.ToList<da6>(Enumerable.OfType<da6>(base.h().aa().StatusEffects.d())))
		{
			base.h().aa().StatusEffects.d(a_);
		}
		return ej1.b;
	}

	// Token: 0x020003E8 RID: 1000
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001ACC RID: 6860 RVA: 0x000912F8 File Offset: 0x0008F4F8
		internal float a(bool A_0)
		{
			return 100f;
		}

		// Token: 0x04000EFB RID: 3835
		public static readonly c5r.a a = new c5r.a();

		// Token: 0x04000EFC RID: 3836
		public static Func<bool, float> b;
	}
}
