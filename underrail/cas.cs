using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020003ED RID: 1005
[fe("plasmaSentry")]
public class cas : am2
{
	// Token: 0x06001AE0 RID: 6880 RVA: 0x00091C60 File Offset: 0x0008FE60
	public cas(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("TransformToMobileMode", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(cas.a.a.b), null));
		list.Add(new byh("TransformToPlasmaMode", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(cas.a.a.a), null));
		base.a(list);
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x00091D18 File Offset: 0x0008FF18
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		return !eth.a(this.Subject) && (this.Subject.a8().h.b.aa().Offense.au() == WeaponKey.Secondary || this.Subject.a8().h.b.ap != null);
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x00091D84 File Offset: 0x0008FF84
	[CompilerGenerated]
	private new cst c(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.aa().Offense.a(WeaponKey.Primary);
		awx awx = new awx();
		awx.a(false);
		awx.a(m7.b | m7.k);
		List<auv> list = awx.ad();
		bfq bfq = new bfq("transformation", "PlasmaSentryDeactivate");
		bfq.a(true);
		list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom2, cux.a, 0, null, 1));
		awx.ad().Add(new a4s(new epw(null), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a4s(new b16(null), null, new ar7(this.Subject.a8()), null));
		return awx;
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x00091E9C File Offset: 0x0009009C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8().h.b.aa().Offense.au() == WeaponKey.Primary && eth.a(this.Subject);
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x00091EE0 File Offset: 0x000900E0
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.aa().Offense.a(WeaponKey.Secondary);
		awx awx = new awx();
		awx.a(false);
		awx.a(m7.b | m7.k);
		List<auv> list = awx.ad();
		bfq bfq = new bfq("transformation", "PlasmaSentryActivate");
		bfq.a(true);
		list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
		awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom1)), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a4s(new b16(new int?(9)), null, new ar7(this.Subject.a8()), null));
		return awx;
	}

	// Token: 0x020003EE RID: 1006
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x00092010 File Offset: 0x00090210
		internal float b(bool A_0)
		{
			return float.MaxValue;
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00092018 File Offset: 0x00090218
		internal float a(bool A_0)
		{
			return float.MaxValue;
		}

		// Token: 0x04000F05 RID: 3845
		public static readonly cas.a a = new cas.a();

		// Token: 0x04000F06 RID: 3846
		public static Func<bool, float> b;

		// Token: 0x04000F07 RID: 3847
		public static Func<bool, float> c;
	}
}
