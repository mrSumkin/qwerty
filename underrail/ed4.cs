using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200038E RID: 910
[fe("psiBeetle")]
public class ed4 : ua
{
	// Token: 0x06001933 RID: 6451 RVA: 0x00084348 File Offset: 0x00082548
	public ed4(bm6 A_0) : base("PsiBeetleBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new efs("CombatNearEnemies", new List<c96>
		{
			new e8n("FocusPrimaryTarget", new List<c96>
			{
				new cta("AutoAttackCurrentTarget"),
				new rv("GiveUpOnTarget", 180, 300000)
			}),
			new chi("ChangeTargetActivity")
		}));
		list.Add(new byh("CloseShell", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(ed4.a.a.a), null));
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

	// Token: 0x06001934 RID: 6452 RVA: 0x000844BC File Offset: 0x000826BC
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8() != null && this.Subject.a8().h.b != null && this.Subject.a8().h.b.aa().Offense.au() == WeaponKey.Secondary;
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x0008451C File Offset: 0x0008271C
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

	// Token: 0x0200041F RID: 1055
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x00097424 File Offset: 0x00095624
		internal float a(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x04000F4E RID: 3918
		public static readonly ed4.a a = new ed4.a();

		// Token: 0x04000F4F RID: 3919
		public static Func<bool, float> b;
	}
}
