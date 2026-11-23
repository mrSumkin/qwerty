using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020003A0 RID: 928
[fe("superPsiBeetle")]
public sealed class bye : ua
{
	// Token: 0x06001986 RID: 6534 RVA: 0x00087188 File Offset: 0x00085388
	public bye(bm6 A_0) : base("SuperPsiBeetleBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new b64("Surrender", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(bye.a.a.b), null));
		list.Add(new efs("CombatNearEnemies", new List<c96>
		{
			new e8n("FocusPrimaryTarget", new List<c96>
			{
				new cta("AutoAttackCurrentTarget"),
				new rv("GiveUpOnTarget", 180, 300000)
			}),
			new chi("ChangeTargetActivity")
		}));
		list.Add(new byh("CloseShell", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(bye.a.a.a), null));
		list.Add(new e1y("IdleMovement", new List<c96>
		{
			new c1j("Howl")
			{
				c = 1f,
				b = "PsiBeetleChitter",
				c = 3,
				a = 30000
			},
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 8,
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

	// Token: 0x06001987 RID: 6535 RVA: 0x00087348 File Offset: 0x00085548
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		return (double)euf.f(amc.aa()) < 0.25 && (amc.aa().SpecialStates.c || amc.aa().SpecialStates.a);
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x000873A4 File Offset: 0x000855A4
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		amc.aa().PersonalAttitudes.Clear();
		new bzv(this.Subject.y6()).e();
		eaq eaq = new eaq();
		eaq.b(asp.a);
		eaq.a(asp.ew);
		eaq.a(global::h.c);
		eaq.a(true);
		eaq.ym(null, null, null);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["npc_tch_superPsiBeetle_incapacitated"] = true;
			if (serviceOrThrow.aqu().v() != null)
			{
				serviceOrThrow.aqu().v().PersonalAttitudes.Remove(asp.ew);
			}
		}
		amc.aa().StatusEffects.a(new ab3(0), true, false, false);
		return ej1.b;
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x00087480 File Offset: 0x00085680
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8() != null && this.Subject.a8().h.b != null && this.Subject.a8().h.b.aa().Offense.au() == WeaponKey.Secondary;
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x000874E0 File Offset: 0x000856E0
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8() != null && this.Subject.a8().h.b != null)
		{
			this.Subject.a8().h.b.aa().Offense.a(WeaponKey.Primary);
			do4.a(this.Subject.a8().h.b.aa(), "closedShell");
			awx awx = new awx();
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom2, cux.a, 0, null, 1));
			return awx;
		}
		return null;
	}

	// Token: 0x020003A1 RID: 929
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600198D RID: 6541 RVA: 0x000875B4 File Offset: 0x000857B4
		internal float b(bool A_0)
		{
			return 100000f;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x000875BC File Offset: 0x000857BC
		internal float a(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x04000E8D RID: 3725
		public static readonly bye.a a = new bye.a();

		// Token: 0x04000E8E RID: 3726
		public static Func<bool, float> b;

		// Token: 0x04000E8F RID: 3727
		public static Func<bool, float> c;
	}
}
