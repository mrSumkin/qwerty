using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003D3 RID: 979
[fe("cc_portZenith")]
public sealed class eup : b5g
{
	// Token: 0x06001A56 RID: 6742 RVA: 0x0008E044 File Offset: 0x0008C244
	public eup(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(eup.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x0008E0C4 File Offset: 0x0008C2C4
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x.h.b.aa().Vehicle != null)
			{
				return false;
			}
			double num = 5.0;
			bool flag = false;
			if (serviceOrThrow.aqu().v().Gear.b("bobsSecurityPass") != null)
			{
				num = 3.0;
				flag = true;
			}
			bool flag2 = bui.b(bnx.a(this.Subject.a8().Location.b(), this.Subject.a8().VisualDirection, serviceOrThrow.aqu().v().b().Location.b())) == aiy.b8;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= num && (!flag || flag2) && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_pz_talkedToHero", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x0008E2AC File Offset: 0x0008C4AC
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			j7 aspect = (serviceOrThrow.aqu().v().b() as c5x).GetAspect<j7>();
			j7 aspect2 = this.Subject.a8().GetAspect<j7>();
			if (aspect2 != null && aspect != null)
			{
				return aspect2.a(aspect, true, null, false);
			}
		}
		return null;
	}

	// Token: 0x020003D4 RID: 980
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A5B RID: 6747 RVA: 0x0008E364 File Offset: 0x0008C564
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000EC9 RID: 3785
		public static readonly eup.a a = new eup.a();

		// Token: 0x04000ECA RID: 3786
		public static Func<bool, float> b;
	}
}
