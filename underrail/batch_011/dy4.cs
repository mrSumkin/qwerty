using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002C9 RID: 713
[apc("savageKingOnThrone")]
public sealed class dy4 : cqw
{
	// Token: 0x0600153F RID: 5439 RVA: 0x000627B4 File Offset: 0x000609B4
	public override bool vz()
	{
		return true;
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x000627B8 File Offset: 0x000609B8
	public dy4()
	{
		a6w a6w = new a6w(null);
		ej0 ej = new ej0();
		a6w.a = new Func<a6w, cst>(dy4.a.a.a);
		a6w.a = ej;
		a6w.b = this.c;
		ej.a = new Action<ej0>(dy4.a.a.a);
		ej.a = this.c;
		this.h.b = a6w;
		this.i.b = a6w;
	}

	// Token: 0x020002CA RID: 714
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001543 RID: 5443 RVA: 0x00062878 File Offset: 0x00060A78
		internal cst a(a6w A_0)
		{
			if (A_0.b().g().aa().IsInControl)
			{
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(100), 0, null, 1));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(100), 0, null, 1));
				awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom2)), null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new a4s(new b16(new int?(A_0.b().g().g.a[CharacterState.Custom2].a - 1)), null, new ar7(A_0.b().g().a8()), null));
				A_0.b().i().b(awx, atp.a);
				return awx;
			}
			return null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000629A0 File Offset: 0x00060BA0
		internal void a(ej0 A_0)
		{
			if (A_0.b().g().aa().IsInControl)
			{
				A_0.b().g().a8().Location += new Vector3(1f, 0f, 0f);
				A_0.b().g().a8().ah();
				A_0.b().g().a(bln.i7);
				A_0.b().g().ap = null;
				A_0.b().g().aq = null;
				ale aspect = new ale(A_0.b().g().a8());
				A_0.b().g().a8().SetAspect<ale>(aspect);
				A_0.b().c().b("humanSoldier");
				A_0.b().c().c("savageKing");
			}
		}

		// Token: 0x04000BFA RID: 3066
		public static readonly dy4.a a = new dy4.a();

		// Token: 0x04000BFB RID: 3067
		public static Func<a6w, cst> b;

		// Token: 0x04000BFC RID: 3068
		public static Action<ej0> c;
	}
}
