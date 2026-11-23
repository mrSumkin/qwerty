using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002F4 RID: 756
[apc("deepWorm")]
public sealed class chn : cqw
{
	// Token: 0x060015F2 RID: 5618 RVA: 0x00068BCC File Offset: 0x00066DCC
	public override bool vz()
	{
		return true;
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00068BD0 File Offset: 0x00066DD0
	public override bool ef()
	{
		return false;
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00068BD4 File Offset: 0x00066DD4
	public chn()
	{
		this.e = new ej0();
		this.f = new ej0();
		this.i.a = this.f;
		this.d = new ej0(new Action<ej0>(chn.a.a.b));
		this.d.a = this.c.a;
		this.c.a = this.d;
		this.c = new fh(new arr[0]);
		this.a = new ej0(new Action<ej0>(chn.a.a.d));
		this.a.a = this.i.b;
		this.b = new ej0(new Action<ej0>(chn.a.a.c));
		this.b.a = this.i.b;
		fh fh = this.c;
		arr[] array = new arr[3];
		array[0] = new arr(this.e, new Func<e1k, bool>(this.a));
		array[1] = new arr(this.a, new Func<e1k, bool>(chn.a.a.a));
		array[2] = new arr(this.b, null);
		fh.a(array);
		this.i.b = this.c;
		this.h.b = this.c;
		this.e.a = new Action<ej0>(this.a);
		this.e.a = this.c;
		this.f.a = new Action<ej0>(chn.a.a.a);
		this.f.a = this.c;
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00068DEC File Offset: 0x00066FEC
	private new List<ak1> a(amc A_0, amc A_1)
	{
		List<ak1> list = new List<ak1>();
		if (A_1 != null && A_1.a8() != null && A_1.a8().t.b != null && A_1.a8().Area == A_0.a8().Area)
		{
			HashSet<r0> hashSet = A_1.a8().t.b.b(bpo.GetServiceOrThrow<d02>());
			if (hashSet != null)
			{
				foreach (r0 r in hashSet)
				{
					ak1 ak = A_0.a8().Area.b((int)r.a.X, (int)r.a.Y);
					if (ak != null && !aw1.a(null, ak, false, null) && aw1.a(A_1.a8(), ak) < (double)A_0.aa().Offense.b(WeaponKey.Secondary).TypedDefinition.ad())
					{
						list.Add(ak);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00068F1C File Offset: 0x0006711C
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value == 0)
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && amc.a8().Area == A_0.g().a8().Area)
			{
				blk blk = bzv.c(amc.a8().qe());
				double num = aw1.b(A_0.g().a8(), amc.a8());
				if (!blk.b() || num > (double)((int)A_0.g().aa().Offense.b(WeaponKey.Secondary).TypedDefinition.ad() - 1))
				{
					return this.a(A_0.g(), amc).Count > 0;
				}
			}
		}
		return false;
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00069004 File Offset: 0x00067204
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		amc amc = new bzv(A_0.b().c().y6()).g();
		if (amc != null)
		{
			List<ak1> list = this.a(A_0.b().g(), amc);
			if (list.Count > 0)
			{
				ak1 ak = list[cuo.a.Next(list.Count)];
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | (m7.b | m7.k));
				List<auv> list2 = awx.ad();
				a4s a4s = new a4s(new akw(), null, null, null);
				a4s.a(new ar7(A_0.b().g().a8()));
				a4s.b(new ar7(amc.a8()));
				list2.Add(a4s);
				awx.ad().Add(new a4s(new bfq("DeepWormBurrow"), null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(100), 0, null, 1));
				List<auv> list3 = awx.ad();
				ch3 ch = new ch3();
				ch.a(new float?(0f));
				list3.Add(new a4s(ch, null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new duh(A_0.b().g(), new string[]
				{
					bk9.a
				}));
				awx.ad().Add(new bm3(dz6.b(500)));
				awx.ad().Add(new a8v(A_0.b().g().a8(), ak.Location.a()));
				List<auv> list4 = awx.ad();
				a4s a4s2 = new a4s(new akw(), null, null, null);
				a4s2.a(new ar7(A_0.b().g().a8()));
				a4s2.b(new ar7(amc.a8()));
				list4.Add(a4s2);
				awx.ad().Add(new a4s(new bfq("DeepWormUnburrow"), null, new ar7(A_0.b().g().a8()), null));
				List<auv> list5 = awx.ad();
				cav cav = new cav();
				cav.a(dz6.b(1000));
				list5.Add(new a4s(cav, null, null, null));
				List<auv> list6 = awx.ad();
				ch3 ch2 = new ch3();
				ch2.a(null);
				list6.Add(new a4s(ch2, null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(100), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}
		A_0.b().c().y6()[ddq.a8] = 1;
	}

	// Token: 0x04000C89 RID: 3209
	private new ej0 a;

	// Token: 0x04000C8A RID: 3210
	private new ej0 b;

	// Token: 0x04000C8B RID: 3211
	private new fh c;

	// Token: 0x04000C8C RID: 3212
	private new ej0 d;

	// Token: 0x04000C8D RID: 3213
	private new ej0 e;

	// Token: 0x04000C8E RID: 3214
	private new ej0 f;

	// Token: 0x020002F5 RID: 757
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015FA RID: 5626 RVA: 0x00069324 File Offset: 0x00067524
		internal void b(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a8] = num;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00069384 File Offset: 0x00067584
		internal void d(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000693AC File Offset: 0x000675AC
		internal void c(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000693D4 File Offset: 0x000675D4
		internal bool a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && aw1.b(A_0.g().a8(), amc.a8()) <= 1.5;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00069424 File Offset: 0x00067624
		internal void a(ej0 A_0)
		{
			c5x c5x = vq.a("Creature\\Critters\\BurrowedDeepWorm", A_0.b().g().a8().Zone, new bt4(A_0.b().g().a8().Area.y8(), A_0.b().g().a8().Location), false);
			if (c5x != null && c5x.h.b != null)
			{
				c5x.ae = new float?(0f);
				c5x.h.b.aa().FactionId = A_0.b().g().aa().FactionId;
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | (m7.b | m7.k));
				awx.ad().Add(new a4s(new bfq("DeepWormBurrow"), null, new ar7(c5x), null));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(100), 0, null, 1));
				List<auv> list = awx.ad();
				ch3 ch = new ch3();
				ch.a(null);
				list.Add(new a4s(ch, null, new ar7(c5x), null));
				awx.ad().Add(new c7(A_0.b().g().a8(), false, false, true, false));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x04000C8F RID: 3215
		public static readonly chn.a a = new chn.a();

		// Token: 0x04000C90 RID: 3216
		public static Action<ej0> b;

		// Token: 0x04000C91 RID: 3217
		public static Action<ej0> c;

		// Token: 0x04000C92 RID: 3218
		public static Action<ej0> d;

		// Token: 0x04000C93 RID: 3219
		public static Func<e1k, bool> e;

		// Token: 0x04000C94 RID: 3220
		public static Action<ej0> f;
	}
}
