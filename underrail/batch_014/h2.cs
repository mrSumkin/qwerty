using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020002B0 RID: 688
[apc("burrower")]
public sealed class h2 : cqw
{
	// Token: 0x0600142E RID: 5166 RVA: 0x00056B18 File Offset: 0x00054D18
	public override bool ef()
	{
		return false;
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00056B20 File Offset: 0x00054D20
	public h2()
	{
		this.d = new ej0();
		this.a = new fh(new arr[0]);
		this.b = new ej0();
		this.c = new ej0();
		this.d.a = new Action<ej0>(h2.a.a.a);
		this.d.a = this.c.a;
		this.c.a = this.d;
		fh fh = this.a;
		arr[] array = new arr[3];
		array[0] = new arr(this.c, new Func<e1k, bool>(h2.a.a.a));
		array[1] = new arr(this.b, new Func<e1k, bool>(h2.a.a.b));
		array[2] = new arr(this.p.a, null);
		fh.a(array);
		this.b.a = new Action<ej0>(h2.a.a.b);
		this.b.a = this.d.a;
		this.c.a = new Action<ej0>(h2.a.a.c);
		this.c.a = this.d.a;
		this.p.a = this.a;
	}

	// Token: 0x04000AF6 RID: 2806
	private new fh a;

	// Token: 0x04000AF7 RID: 2807
	private new ej0 b;

	// Token: 0x04000AF8 RID: 2808
	private new ej0 c;

	// Token: 0x04000AF9 RID: 2809
	private new ej0 d;

	// Token: 0x020002B1 RID: 689
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001432 RID: 5170 RVA: 0x00056CF0 File Offset: 0x00054EF0
		internal void a(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("kited");
			int num = A_0.b().d().GetPrimitivePropertyValue<int>("layedEggCD", new int?(0)).Value;
			if (num > 0)
			{
				num--;
			}
			A_0.b().d()["layedEggCD"] = num;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00056D60 File Offset: 0x00054F60
		internal bool a(e1k A_0)
		{
			int? primitivePropertyValue = A_0.d().GetPrimitivePropertyValue<int>("layedEggCD", new int?(0));
			int num = 0;
			return (primitivePropertyValue.GetValueOrDefault() <= num & primitivePropertyValue != null) && A_0.c().y6().GetPrimitivePropertyValue<int>(ddq.a0, new int?(0)).Value < 5 && db8.b(A_0.g().a8()) != null;
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00056DE0 File Offset: 0x00054FE0
		internal bool b(e1k A_0)
		{
			return !A_0.d().GetPrimitivePropertyValue<bool>("kited", null).GetValueOrDefault() && awq.f(A_0.g());
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00056E28 File Offset: 0x00055028
		internal void b(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				ak1 ak = g8.a(A_0.b().c(), amc.a8().t.b, 3, 1.8f, int.MaxValue);
				if (ak != null)
				{
					A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
				}
			}
			A_0.b().d()["kited"] = true;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00056ED0 File Offset: 0x000550D0
		internal void c(ej0 A_0)
		{
			A_0.b().d()["layedEggCD"] = 3;
			ak1 ak = db8.b(A_0.b().g().a8());
			if (ak != null)
			{
				int num = A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.a0, new int?(0)).Value;
				num++;
				A_0.b().c().y6()[ddq.a0] = num;
				awx awx = new awx();
				awx.ad().Add(new fk(A_0.b().g().a8().k.b, ak, null, true, 0));
				List<auv> list = awx.ad();
				a55 a_ = new a55(ak.Zone);
				List<auv> list2 = new List<auv>();
				list2.Add(new bm3(dz6.b(50)));
				aud a_2 = ak.Area;
				Vector3 a_3 = ak.Location.a();
				string a_4 = "RockChipImpact";
				int a_5 = 4;
				double maxValue = double.MaxValue;
				float? a_6 = dz6.b();
				list2.Add(new au0(a_2, a_3, a_4, a_5, maxValue, null, null, a_6));
				list.Add(new ez4(a_, new dtb(list2), atp.a));
				List<auv> list3 = new List<auv>
				{
					new bm3(dz6.b(50))
				};
				string[] array = new string[]
				{
					"RockHit",
					"RockHitHeavy"
				};
				for (int i = 0; i < 6; i++)
				{
					List<auv> list4 = list3;
					bfq bfq = new bfq(Guid.NewGuid().ToString(), array[cuo.a.Next(2)]);
					bfq.a(0.65f);
					a4s a4s = new a4s(bfq, null, null, null);
					a4s.b(new ar7(A_0.b().g().a8()));
					list4.Add(a4s);
					list3.Add(new bm3(dz6.b(140 + cuo.a.Next(40))));
				}
				awx.ad().Add(new ez4(new a55(ak.Zone), new dtb(list3), atp.a));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(75), 0, null, 3));
				ezd ezd = new ezd("locale\\object\\natural\\BurrowerEgg", new bt4(ak.Area.y8(), ak.Location.a()), null, null, null, null, null);
				List<auv> list5 = awx.ad();
				a55 a_7 = new a55(ak.Zone);
				List<auv> list6 = new List<auv>();
				list6.Add(new bm3(dz6.b(125)));
				a4s a4s2 = new a4s(new bfq(Guid.NewGuid().ToString(), "BurrowerLayEgg"), null, null, null);
				a4s2.b(new ar7(A_0.b().g().a8()));
				list6.Add(a4s2);
				list6.Add(new bm3(dz6.b(100)));
				list6.Add(new a4s(ezd, null, null, null));
				list6.Add(new a4s(new elt(ezd.f()), null, null, null));
				aud a_8 = ak.Area;
				Vector3 a_9 = ak.Location.a();
				string a_10 = "SlimeBurst";
				int a_11 = 1;
				double maxValue2 = double.MaxValue;
				a_6 = dz6.b();
				list6.Add(new au0(a_8, a_9, a_10, a_11, maxValue2, null, null, a_6));
				list5.Add(new ez4(a_7, new dtb(list6), atp.a));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom3, dz6.b(115), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x04000AFA RID: 2810
		public static readonly h2.a a = new h2.a();

		// Token: 0x04000AFB RID: 2811
		public static Action<ej0> b;

		// Token: 0x04000AFC RID: 2812
		public static Func<e1k, bool> c;

		// Token: 0x04000AFD RID: 2813
		public static Func<e1k, bool> d;

		// Token: 0x04000AFE RID: 2814
		public static Action<ej0> e;

		// Token: 0x04000AFF RID: 2815
		public static Action<ej0> f;
	}
}
