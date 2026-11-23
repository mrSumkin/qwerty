using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003CC RID: 972
[fe("deepWorm")]
public sealed class dvr : bwv
{
	// Token: 0x06001A43 RID: 6723 RVA: 0x0008DA90 File Offset: 0x0008BC90
	public dvr(bm6 A_0) : base(A_0)
	{
		byh a_ = new byh("burrow", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(dvr.a.a.a), null);
		base.a(base.g().Count - 1, a_);
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x0008DB00 File Offset: 0x0008BD00
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return !base.h().aa().IsInCombat;
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x0008DB18 File Offset: 0x0008BD18
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		c5x c5x = vq.a("Creature\\Critters\\BurrowedDeepWorm", this.Subject.a8().Zone, new bt4(this.Subject.a8().Area.y8(), this.Subject.a8().Location), false);
		if (c5x != null && c5x.h.b != null)
		{
			c5x.ae = new float?(0f);
			c5x.h.b.aa().FactionId = base.h().aa().FactionId;
			awx awx = new awx();
			awx.a(awx.kh() | (m7.b | m7.k));
			awx.ad().Add(new a4s(new bfq("DeepWormBurrow"), null, new ar7(c5x), null));
			awx.ad().Add(new e4t(base.h(), CharacterState.Custom1, 100, 0, null, 1));
			List<auv> list = awx.ad();
			ch3 ch = new ch3();
			ch.a(null);
			list.Add(new a4s(ch, null, new ar7(c5x), null));
			awx.ad().Add(new c7(this.Subject.a8(), false, false, true, false));
			return awx;
		}
		return null;
	}

	// Token: 0x020003CD RID: 973
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A48 RID: 6728 RVA: 0x0008DC78 File Offset: 0x0008BE78
		internal float a(bool A_0)
		{
			if (A_0)
			{
				return float.MaxValue;
			}
			return 0.505f;
		}

		// Token: 0x04000EC1 RID: 3777
		public static readonly dvr.a a = new dvr.a();

		// Token: 0x04000EC2 RID: 3778
		public static Func<bool, float> b;
	}
}
