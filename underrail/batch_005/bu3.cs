using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003B4 RID: 948
[fe("seaSerpent")]
public class bu3 : bwv
{
	// Token: 0x060019EB RID: 6635 RVA: 0x0008B08C File Offset: 0x0008928C
	public bu3(bm6 A_0) : base(A_0)
	{
		byh byh = new byh("diveIn", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(bu3.a.a.a), null);
		base.a(base.g().Count - 1, new c96[]
		{
			byh
		});
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x0008B104 File Offset: 0x00089304
	public static string b(amc A_0)
	{
		if (A_0.am() == bln.gn)
		{
			return "Xpbl_SplashSnake1";
		}
		if (A_0.am() == bln.go)
		{
			return "Xpbl_SplashSnake2";
		}
		return "Xpbl_SplashSnake3";
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x0008B144 File Offset: 0x00089344
	public static float a(amc A_0)
	{
		if (A_0.am() == bln.gn)
		{
			return 1.55f;
		}
		if (A_0.am() == bln.go)
		{
			return 1.55f;
		}
		return 1.65f;
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x0008B184 File Offset: 0x00089384
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		return !amc.aa().IsInCombat && amc.ap == null;
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x0008B1B8 File Offset: 0x000893B8
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | (m7.b | m7.k));
		awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveIn"), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a7j(this.Subject.a8(), bu3.b(base.h()), 1, double.MaxValue, false, false, null, null, null, null, false, null));
		awx.ad().Add(new e4t(base.h(), CharacterState.Custom4, 80, 0, null, 1));
		awx.ad().Add(new e4t(base.h(), CharacterState.Custom3, 80, 0, null, 1));
		awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom1)), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a4s(new dr5(new Vector3(this.Subject.a8().Size.X, this.Subject.a8().Size.Y, 0.2f)), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new duh(base.h(), new string[]
		{
			bk9.a
		}));
		awx.ad().Add(new duh(base.h(), new string[]
		{
			aw3.a
		}));
		awx.ad().Add(new amd(base.h(), new els[]
		{
			new ewc(0)
		}));
		return awx;
	}

	// Token: 0x020003B5 RID: 949
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060019F2 RID: 6642 RVA: 0x0008B3C0 File Offset: 0x000895C0
		internal float a(bool A_0)
		{
			if (A_0)
			{
				return float.MaxValue;
			}
			return 0.515f;
		}

		// Token: 0x04000E9F RID: 3743
		public static readonly bu3.a a = new bu3.a();

		// Token: 0x04000EA0 RID: 3744
		public static Func<bool, float> b;
	}
}
