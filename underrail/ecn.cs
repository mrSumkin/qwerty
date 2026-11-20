using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020003D5 RID: 981
[fe("rahm")]
public sealed class ecn : b5g
{
	// Token: 0x06001A5C RID: 6748 RVA: 0x0008E36C File Offset: 0x0008C56C
	public ecn(bm6 A_0) : base(A_0)
	{
		c96[] array = new c96[1];
		array[0] = new byh("Retract blade", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(ecn.a.a.a), null)
		{
			e = true
		};
		base.a(array);
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x0008E3DC File Offset: 0x0008C5DC
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc.aa().IsInControl && amc.aa().Offense.au() != WeaponKey.Primary)
		{
			amc amc2 = new bzv(this.Subject.y6()).g();
			if (amc2 == null || amc2.a8() == null || amc2.aa().Dead)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x0008E450 File Offset: 0x0008C650
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null && amc.a8().i.b != null)
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("RahmsBladesSheath"), null, null, null);
			a4s.b(new ar7(amc.a8()));
			list.Add(a4s);
			awx.ad().Add(new e4t(amc, CharacterState.Custom1, cux.a, 0, null, 1));
			List<auv> list2 = awx.ad();
			ar ar = new ar();
			ar.a(WeaponKey.Primary);
			a4s a4s2 = new a4s(ar, null, null, null);
			a4s2.b(new ar7(amc.a8()));
			list2.Add(a4s2);
			return awx;
		}
		return null;
	}

	// Token: 0x020003D6 RID: 982
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A61 RID: 6753 RVA: 0x0008E52C File Offset: 0x0008C72C
		internal float a(bool A_0)
		{
			return 0.99f;
		}

		// Token: 0x04000ECB RID: 3787
		public static readonly ecn.a a = new ecn.a();

		// Token: 0x04000ECC RID: 3788
		public static Func<bool, float> b;
	}
}
