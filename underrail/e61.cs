using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000430 RID: 1072
[fe("Rathound")]
public sealed class e61 : ua
{
	// Token: 0x06001C18 RID: 7192 RVA: 0x00098BB0 File Offset: 0x00096DB0
	public e61(bm6 A_0) : base("RathoundBehavior", A_0)
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
		list.Add(new b64("ReactToBeingAlertedToPlayerStealthing", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(e61.a.a.a), null));
		list.Add(new e1y("IdleMovement", new List<c96>
		{
			new c1j("Howl")
			{
				c = 1f,
				b = "RathoundHowl",
				d = new CharacterState?(CharacterState.FinishPsi)
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

	// Token: 0x06001C19 RID: 7193 RVA: 0x00098D20 File Offset: 0x00096F20
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (ew0.b())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && base.h().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(this.Subject.y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x00098DE8 File Offset: 0x00096FE8
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null && c5x.h.b != null)
			{
				bt4 value = new bt4(c5x.Area.y8(), c5x.Location);
				this.Subject.y6()[ddq.an] = value;
			}
		}
		return ej1.b;
	}

	// Token: 0x02000431 RID: 1073
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C1D RID: 7197 RVA: 0x00098EA4 File Offset: 0x000970A4
		internal float a(bool A_0)
		{
			return 0.751f;
		}

		// Token: 0x04000F92 RID: 3986
		public static readonly e61.a a = new e61.a();

		// Token: 0x04000F93 RID: 3987
		public static Func<bool, float> b;
	}
}
