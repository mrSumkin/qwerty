using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200043E RID: 1086
[fe("rnd_danielArda")]
public sealed class ov : b5g
{
	// Token: 0x06001C5F RID: 7263 RVA: 0x0009A6C8 File Offset: 0x000988C8
	public ov(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("AttackOnSight", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(ov.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x0009A748 File Offset: 0x00098948
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			serviceOrThrow.aqu().v().b();
			if (!base.h().aa().SpecialStates.c && !base.h().aa().SpecialStates.h)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001C61 RID: 7265 RVA: 0x0009A81C File Offset: 0x00098A1C
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			string str = "его";
			if (c5x.h.b != null && c5x.h.b.aa().Gender == Gender.Female)
			{
				str = "её";
			}
			this.Subject.a8().u.b.a("ВОТ ПАДЛА! Тот, кто принесёт мне " + str + " голову, получит дозу бесплатно!", true, null, null);
			return new a27(base.h(), c5x.h.b, false, false, false, true);
		}
		return null;
	}

	// Token: 0x0200043F RID: 1087
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C64 RID: 7268 RVA: 0x0009A934 File Offset: 0x00098B34
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000FBE RID: 4030
		public static readonly ov.a a = new ov.a();

		// Token: 0x04000FBF RID: 4031
		public static Func<bool, float> b;
	}
}
