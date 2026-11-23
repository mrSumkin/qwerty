using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200038B RID: 907
[fe("buffalo")]
public sealed class amt : ua
{
	// Token: 0x06001926 RID: 6438 RVA: 0x00083D44 File Offset: 0x00081F44
	public amt(bm6 A_0) : base("BuffaloBehavior", A_0)
	{
		string b = this.a(base.h());
		List<c96> list = new List<c96>();
		list.Add(new b64("StopCharging", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(amt.a.a.b), null));
		list.Add(new efs("CombatNearEnemies", new List<c96>
		{
			new e8n("FocusPrimaryTarget", new List<c96>
			{
				new cta("AutoAttackCurrentTarget"),
				new rv("GiveUpOnTarget", 180, 300000)
			}),
			new chi("ChangeTargetActivity")
		}));
		string a_ = "IdleMovement";
		List<c96> list2 = new List<c96>();
		list2.Add(new b64("Aggro player", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(amt.a.a.a), null));
		list2.Add(new c1j("Answer")
		{
			c = 1.1f,
			b = b,
			d = new CharacterState?(CharacterState.Custom4),
			a = 40000
		});
		list2.Add(new c1j("Rummage")
		{
			c = 1f,
			b = null,
			d = new CharacterState?(CharacterState.Custom3),
			a = 10000,
			e = "Rummage"
		});
		list2.Add(new e7y("IdleMoveToTile")
		{
			c = 0.75f,
			b = 5,
			c = 3
		});
		list2.Add(new aif("RestActivity"));
		list.Add(new e1y(a_, list2)
		{
			c = 0.75f
		});
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x00083F58 File Offset: 0x00082158
	public string a(amc A_0)
	{
		string result = "xpbl_BuffaloAnswer";
		if (A_0 != null)
		{
			if (A_0.am().StartsWith("xpbl_buffb", StringComparison.OrdinalIgnoreCase))
			{
				result = "xpbl_BuffaloBullAnswer";
			}
			else if (A_0.am().StartsWith("xpbl_buffc", StringComparison.OrdinalIgnoreCase))
			{
				result = "xpbl_BuffaloCalfAnswer";
			}
		}
		return result;
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x00083FB0 File Offset: 0x000821B0
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		return base.h().@as != null;
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x00083FC8 File Offset: 0x000821C8
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		base.h().@as = null;
		base.h().at = null;
		foreach (da6 a_ in Enumerable.ToList<da6>(Enumerable.OfType<da6>(base.h().aa().StatusEffects.d())))
		{
			base.h().aa().StatusEffects.d(a_);
		}
		return ej1.b;
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x0008406C File Offset: 0x0008226C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc.am().StartsWith("xpbl_buffb") && amc.aa().FactionId == asp.f1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				amc aspect = serviceOrThrow.aqu().v().b().GetAspect<amc>();
				if (aspect != null && base.h().a(aspect) != global::h.a && this.Subject.b(aspect, false) && aw1.b(amc.a8(), aspect.a8()) <= 3.0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00084148 File Offset: 0x00082348
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			amc aspect = serviceOrThrow.aqu().v().b().GetAspect<amc>();
			if (aspect != null)
			{
				awq.a(base.h(), aspect, false, false, null, true, true, false, false);
				return ej1.b;
			}
		}
		return ej1.c;
	}

	// Token: 0x0200038C RID: 908
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x000841D4 File Offset: 0x000823D4
		internal float b(bool A_0)
		{
			return 100f;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000841DC File Offset: 0x000823DC
		internal float a(bool A_0)
		{
			return 1.15f;
		}

		// Token: 0x04000E72 RID: 3698
		public static readonly amt.a a = new amt.a();

		// Token: 0x04000E73 RID: 3699
		public static Func<bool, float> b;

		// Token: 0x04000E74 RID: 3700
		public static Func<bool, float> c;
	}
}
