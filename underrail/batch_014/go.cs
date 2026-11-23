using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000305 RID: 773
[apc("rahm")]
public sealed class go : esk
{
	// Token: 0x06001644 RID: 5700 RVA: 0x0006BC7C File Offset: 0x00069E7C
	public go()
	{
		this.d = new TryInvokeSpecialAbilityNode<zv>();
		this.d.a = this.p.a;
		this.d.b = this.p.a;
		arr arr = Enumerable.FirstOrDefault<arr>(Enumerable.Where<arr>(this.c.a, new Func<arr, bool>(this.a)));
		if (arr != null)
		{
			this.c.a.Remove(arr);
		}
		this.e = new ej0(new Action<ej0>(go.a.a.b));
		this.e.a = this.c.a;
		this.c.a = this.e;
		this.c = new ej0(new Action<ej0>(go.a.a.d));
		this.c.a = this.b;
		this.a.a.Insert(0, new arr(this.c, new Func<e1k, bool>(go.a.a.c)));
		this.b.a.Insert(0, new arr(this.d, new Func<e1k, bool>(this.a)));
		this.a = new ej0(new Action<ej0>(go.a.a.c));
		this.a.a = this.c;
		this.b = new ej0(new Action<ej0>(go.a.a.a));
		this.b.a = this.c;
		List<arr> list = this.c.a;
		int index = this.c.a.Count - 1;
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(go.a.a.b));
		array[1] = new arr(this.a, new Func<e1k, bool>(go.a.a.a));
		list.InsertRange(index, array);
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0006BEFC File Offset: 0x0006A0FC
	[CompilerGenerated]
	private new bool a(arr A_0)
	{
		return A_0.a == this.g;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x0006BF0C File Offset: 0x0006A10C
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (!this.d.b(A_0))
		{
			return false;
		}
		bzv bzv = new bzv(A_0.c().y6());
		amc amc = bzv.g();
		if (amc != null)
		{
			blk blk = bzv.c(amc.a8().qe());
			double num = aw1.b(A_0.g().a8(), amc.a8());
			cmb classPropertyValue = A_0.c().y6().GetClassPropertyValue<cmb>(cy1.h);
			if (blk != null && blk.b() && (num >= 5.0 || (num > 1.4 && A_0.g().aa().SpecialStates.b && num <= (double)zv.d) || (classPropertyValue != null && (classPropertyValue.b(0) == -1f || classPropertyValue.b(0) > 5f) && classPropertyValue.b(zv.d) != -1f)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000CDD RID: 3293
	private new ej0 a;

	// Token: 0x04000CDE RID: 3294
	private new ej0 b;

	// Token: 0x04000CDF RID: 3295
	private new ej0 c;

	// Token: 0x04000CE0 RID: 3296
	public new TryInvokeSpecialAbilityNode<zv> d;

	// Token: 0x04000CE1 RID: 3297
	private new ej0 e;

	// Token: 0x02000306 RID: 774
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001649 RID: 5705 RVA: 0x0006C03C File Offset: 0x0006A23C
		internal void b(ej0 A_0)
		{
			int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value;
			num = Math.Max(0, num - 1);
			A_0.b().c().y6()[ddq.a8] = num;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0006C09C File Offset: 0x0006A29C
		internal void d(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				List<ak1> list = aw1.b(amc.a8(), true);
				if (list.Count > 0)
				{
					ak1 ak = list[cuo.a.Next(list.Count)];
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					List<auv> list2 = awx.ad();
					a4s a4s = new a4s(new akw(), null, null, null);
					a4s.a(new ar7(A_0.b().g().a8()));
					a4s.b(new ar7(amc.a8()));
					list2.Add(a4s);
					List<auv> list3 = awx.ad();
					a4s a4s2 = new a4s(new bfq("TeleportEnter"), null, null, null);
					a4s2.b(new ar7(A_0.b().g().a8()));
					list3.Add(a4s2);
					List<auv> list4 = awx.ad();
					c5x a_ = A_0.b().g().a8();
					string a_2 = "Teleport";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = false;
					float? a_6 = dz6.b();
					list4.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
					if (A_0.b().g().aa().Offense.au() == WeaponKey.Secondary)
					{
						awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom4, dz6.b(cux.j), 0, null, 1));
					}
					else
					{
						awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom3, dz6.b(cux.j), 0, null, 1));
					}
					List<auv> list5 = awx.ad();
					ad6 ad = new ad6(A_0.b().g().a8());
					ad.b(1.0);
					ad.c(0.0);
					ad.a(dz6.a(0.005));
					list5.Add(ad);
					awx.ad().Add(new bm3(dz6.b(250)));
					awx.ad().Add(new a8v(A_0.b().g().a8(), ak.Location.a()));
					List<auv> list6 = awx.ad();
					a4s a4s3 = new a4s(new akw(), null, null, null);
					a4s3.a(new ar7(A_0.b().g().a8()));
					a4s3.b(new ar7(amc.a8()));
					list6.Add(a4s3);
					List<auv> list7 = awx.ad();
					a4s a4s4 = new a4s(new bfq("TeleportExit"), null, null, null);
					a4s4.b(new ar7(A_0.b().g().a8()));
					list7.Add(a4s4);
					List<auv> list8 = awx.ad();
					c5x a_7 = A_0.b().g().a8();
					string a_8 = "Teleport";
					int a_9 = 1;
					double maxValue2 = double.MaxValue;
					bool a_10 = true;
					bool a_11 = false;
					a_6 = dz6.b();
					list8.Add(new a7j(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false, null));
					awx.ad().Add(new bm3(dz6.b(150)));
					List<auv> list9 = awx.ad();
					ad6 ad2 = new ad6(A_0.b().g().a8());
					ad2.b(0.0);
					ad2.c(1.0);
					ad2.a(dz6.a(0.005));
					list9.Add(ad2);
					awx.ad().Add(new bm3(dz6.b(100)));
					A_0.b().i().b(awx, atp.a);
					A_0.b().c().y6()[ddq.a8] = 3;
				}
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0006C4A4 File Offset: 0x0006A6A4
		internal bool c(e1k A_0)
		{
			if (A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a8, new int?(0)).Value == 0)
			{
				bzv bzv = new bzv(A_0.c().y6());
				amc amc = bzv.g();
				if (amc != null && amc.a8().Area == A_0.g().a8().Area)
				{
					blk blk = bzv.c(amc.a8().qe());
					aw1.b(A_0.g().a8(), amc.a8());
					if (blk != null && !blk.b())
					{
						return aw1.b(amc.a8(), true).Count > 0;
					}
				}
			}
			return false;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0006C568 File Offset: 0x0006A768
		internal void c(ej0 A_0)
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("RahmsBladesSheath"), null, null, null);
			a4s.b(new ar7(A_0.b().g().a8()));
			list.Add(a4s);
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
			List<auv> list2 = awx.ad();
			ar ar = new ar();
			ar.a(WeaponKey.Primary);
			a4s a4s2 = new a4s(ar, null, null, null);
			a4s2.b(new ar7(A_0.b().g().a8()));
			list2.Add(a4s2);
			A_0.b().i().b(awx, atp.a);
			dz6.a(awx);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0006C648 File Offset: 0x0006A848
		internal void a(ej0 A_0)
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("RahmsBladesShing"), null, null, null);
			a4s.b(new ar7(A_0.b().g().a8()));
			list.Add(a4s);
			awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(100), 0, null, 1));
			List<auv> list2 = awx.ad();
			ar ar = new ar();
			ar.a(WeaponKey.Secondary);
			a4s a4s2 = new a4s(ar, null, null, null);
			a4s2.b(new ar7(A_0.b().g().a8()));
			list2.Add(a4s2);
			A_0.b().i().b(awx, atp.a);
			dz6.a(awx);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0006C724 File Offset: 0x0006A924
		internal bool b(e1k A_0)
		{
			if (A_0.g().aa().Offense.au() != WeaponKey.Secondary)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc != null && amc.a8() != null && !amc.aa().Dead)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0006C788 File Offset: 0x0006A988
		internal bool a(e1k A_0)
		{
			if (A_0.g().aa().Offense.au() != WeaponKey.Primary)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc == null || amc.a8() == null || amc.aa().Dead)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000CE2 RID: 3298
		public static readonly go.a a = new go.a();

		// Token: 0x04000CE3 RID: 3299
		public static Action<ej0> b;

		// Token: 0x04000CE4 RID: 3300
		public static Action<ej0> c;

		// Token: 0x04000CE5 RID: 3301
		public static Func<e1k, bool> d;

		// Token: 0x04000CE6 RID: 3302
		public static Action<ej0> e;

		// Token: 0x04000CE7 RID: 3303
		public static Action<ej0> f;

		// Token: 0x04000CE8 RID: 3304
		public static Func<e1k, bool> g;

		// Token: 0x04000CE9 RID: 3305
		public static Func<e1k, bool> h;
	}
}
