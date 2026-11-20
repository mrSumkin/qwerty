using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;

// Token: 0x02000330 RID: 816
[apc("savageHighShaman")]
public sealed class d74 : esk
{
	// Token: 0x06001750 RID: 5968 RVA: 0x00075184 File Offset: 0x00073384
	public d74()
	{
		a6w a6w = new a6w(null);
		fh fh = new fh(new arr[0]);
		fh.a.Add(new arr(a6w, new Func<e1k, bool>(d74.a.a.a)));
		fh.a.Add(new arr(this.h.b, null));
		a6w.a = new Func<a6w, cst>(d74.a.a.a);
		a6w.a = this.c;
		a6w.b = this.c;
		this.h.b = fh;
		this.i.b = fh;
	}

	// Token: 0x02000331 RID: 817
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001753 RID: 5971 RVA: 0x0007526C File Offset: 0x0007346C
		internal bool a(e1k A_0)
		{
			return A_0.g().aa().IsInControl && !bpo.GetServiceOrThrow<cnk>().aqu().r().GetPrimitivePropertyValue<bool>("xpbl_npc_g_savageHighShaman", new bool?(false)).Value;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x000752C0 File Offset: 0x000734C0
		internal cst a(a6w A_0)
		{
			if (A_0.b().g().aa().IsInControl)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				int num;
				switch (serviceOrThrow.aqu().ae())
				{
				case GameDifficulty.Normal:
					num = 4;
					goto IL_5E;
				case GameDifficulty.Hard:
					num = 5;
					goto IL_5E;
				case GameDifficulty.Dominating:
					num = 6;
					goto IL_5E;
				}
				num = 3;
				IL_5E:
				List<csd> list = new List<csd>();
				for (int i = 1; i <= 8; i++)
				{
					csd csd = A_0.b().g().a8().Zone.g("snake" + i.ToString());
					if (csd != null)
					{
						list.Add(csd);
					}
				}
				List<csd> list2 = new List<csd>();
				while (list2.Count < num && list.Count > 0)
				{
					int index = cuo.a.Next(list.Count);
					list2.Add(list[index]);
					list.RemoveAt(index);
				}
				amc amc = new bzv(A_0.b().c().y6()).g();
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | (m7.b | m7.k));
				awx.ad().Add(new a4s(new cct("Штегген, соурмирен - штегген!", true, null, bvl.c), null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new bm3(dz6.b(100)));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(100), 0, null, 1));
				awx.ad().Add(new bm3(dz6.b(300)));
				for (int j = 0; j < list2.Count; j++)
				{
					csd csd2 = list2[j];
					c5x c5x = vq.a("Creature\\Critters\\Xpbl\\SeaWyrm", A_0.b().g().a8().Zone, new bt4(csd2.Name), false);
					if (c5x != null)
					{
						a6p aspect = c5x.GetAspect<a6p>();
						if (aspect != null)
						{
							aspect.d().Add("-system");
						}
						c5x.h.b.aa().FactionId = asp.fx;
						c5x.ae = new float?(0f);
						c5x.VisualDirection = (HorizontalDirection)cuo.a.Next(8);
						awx awx3 = new awx();
						awx awx4 = awx3;
						awx4.a(awx4.kh() | (m7.b | m7.k));
						awx.ad().Add(new bm3(dz6.b(cuo.a.Next(200))));
						awx3.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveOut"), null, new ar7(c5x), null));
						List<auv> list3 = awx3.ad();
						ch3 ch = new ch3();
						ch.a(null);
						list3.Add(new a4s(ch, null, new ar7(c5x), null));
						awx3.ad().Add(new e4t(c5x.h.b, CharacterState.Custom5, dz6.b(80), 0, null, 1));
						awx3.ad().Add(new a4s(new epw(null), null, new ar7(c5x), null));
						awx3.ad().Add(new a4s(new dr5(new Vector3(c5x.Size.X, c5x.Size.Y, 2f)), null, new ar7(c5x), null));
						awx3.ad().Add(new duh(c5x.h.b, new string[]
						{
							ewc.a
						}));
						awx3.ad().Add(new amd(c5x.h.b, new els[]
						{
							new aw3(0)
						}));
						if (amc != null)
						{
							awx3.ad().Add(new a27(c5x.h.b, amc, false, false, false, true));
						}
						awx.ad().Add(new g1(c5x.i.b, awx3, atp.a, true));
					}
				}
				awx.ad().Add(new bm3(dz6.b(2000)));
				A_0.b().i().b(awx, atp.a);
				serviceOrThrow.aqu().r()["xpbl_npc_g_savageHighShaman"] = true;
				return awx;
			}
			return null;
		}

		// Token: 0x04000DDF RID: 3551
		public static readonly d74.a a = new d74.a();

		// Token: 0x04000DE0 RID: 3552
		public static Func<e1k, bool> b;

		// Token: 0x04000DE1 RID: 3553
		public static Func<a6w, cst> c;
	}
}
