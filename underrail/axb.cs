using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002B8 RID: 696
[apc("burrowedGiantWorm")]
public sealed class axb : cqw
{
	// Token: 0x06001454 RID: 5204 RVA: 0x000583B4 File Offset: 0x000565B4
	public override bool ef()
	{
		return false;
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x000583B8 File Offset: 0x000565B8
	public axb()
	{
		ej0 ej = new ej0();
		ej.a = new Action<ej0>(axb.a.a.a);
		ej.a = this.c;
		this.h.b = ej;
		this.i.b = ej;
	}

	// Token: 0x020002B9 RID: 697
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001458 RID: 5208 RVA: 0x00058438 File Offset: 0x00056638
		internal void a(ej0 A_0)
		{
			c5x c5x = vq.a("Creature\\Critters\\DeepWorm", A_0.b().g().a8().Zone, new bt4(A_0.b().g().a8().Area.y8(), A_0.b().g().a8().Location), false);
			if (c5x != null && c5x.h.b != null)
			{
				amc amc = new bzv(A_0.b().c().y6()).g();
				c5x.h.b.aa().FactionId = A_0.b().g().aa().FactionId;
				if (amc != null && amc.a8() != null)
				{
					aw1.b(c5x, amc.a8(), false);
					awq.a(A_0.b().g(), amc, false, false, null, true, true, false, false);
				}
				if (c5x.i.b != null)
				{
					cav cav = new cav();
					cav.a(dz6.b(1000));
					cav.ym(null, null, null);
					c5x.c().a("DeepWormUnburrow");
					c5x.i.b.b(new e4t(c5x.h.b, CharacterState.Custom2, dz6.b(100), 0, null, 1), atp.a);
				}
				c7 a_ = new c7(A_0.b().g().a8(), false, false, true, false);
				A_0.b().g().a8().Zone.ActionManager.g9(a_, atp.a);
				dz6.a(a_);
			}
		}

		// Token: 0x04000B25 RID: 2853
		public static readonly axb.a a = new axb.a();

		// Token: 0x04000B26 RID: 2854
		public static Action<ej0> b;
	}
}
