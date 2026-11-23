using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001137 RID: 4407
[euj]
public sealed class atb
{
	// Token: 0x06005E41 RID: 24129 RVA: 0x0027F45C File Offset: 0x0027D65C
	[ayh("VolatileAmmoCrate_Tick")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null || A_2 == null)
		{
			return;
		}
		alv aspect = A_1.GetAspect<alv>();
		if (aspect == null || aspect.a == null || aspect.a.Count < 6)
		{
			return;
		}
		object obj;
		A_2.TryGetValue("tickCount", out obj);
		if (obj is int)
		{
			int num = (int)obj;
			string c = null;
			a3f aspect2 = A_1.GetAspect<a3f>();
			if (aspect2 != null && aspect2.a() != null)
			{
				c = aspect2.a().GetClassPropertyValue<string>("AttackerFaction");
			}
			int index = 4 - num;
			cd0 cd = aspect.a[index];
			cd.b.X = cd.b.X + 3;
			cd0 cd2 = aspect.a[4];
			cd2.b.Y = cd2.b.Y + 2;
			cd0 cd3 = aspect.a[5];
			cd3.b.Y = cd3.b.Y + 2;
			aud a_ = A_1.Area;
			Vector3 a_2 = A_1.Location;
			HorizontalDirection? a_3 = null;
			string a_4 = "xphw_BulletBurst";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, null);
			aru aspect3 = A_1.GetAspect<aru>();
			if (aspect3 != null)
			{
				aspect3.a("AmmoCrateExplosion");
			}
			eym.a(A_1, (double)aju.a3);
			Point point = A_1.aj().a();
			atb.a a = new atb.a();
			a.a = A_1.Area.y8();
			a.b = point;
			a.c = c;
			anp anp = new anp(point, A_1.Area, 12f, bcj.a(new long[]
			{
				4L
			}), false, 0L);
			anp.a(a);
			anp.a(new EventHandler<EventArgs>(this.a));
			anp.k();
			if (num >= 3)
			{
				A_1.RemoveAspect<dm>();
				if (aspect3 != null)
				{
					aspect3.a("burning", false);
				}
				aspect.a[0].b.X = 2;
				aspect.a[4].d = new float?(0f);
				aspect.a[5].d = new float?(0f);
				cd0 cd4 = aspect.a[1];
				cd4.b.X = cd4.b.X + 3;
				cd0 cd5 = aspect.a[2];
				cd5.b.X = cd5.b.X + 3;
				cd0 cd6 = aspect.a[3];
				cd6.b.X = cd6.b.X + 3;
			}
		}
	}

	// Token: 0x06005E42 RID: 24130 RVA: 0x0027F704 File Offset: 0x0027D904
	private void a(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		if (anp == null || anp.f() == null || anp.f().Count == 0)
		{
			return;
		}
		atb.a a = anp.a() as atb.a;
		if (a == null || a.a == null)
		{
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() == null)
		{
			return;
		}
		aud aud = serviceOrThrow.aqw().n(a.a);
		if (aud == null)
		{
			return;
		}
		ak1 ak = aud.a(a.b);
		if (ak == null)
		{
			return;
		}
		bpo.GetServiceOrThrow<d02>();
		List<c5x> list = new List<c5x>();
		foreach (b0b b0b in aud.Entities)
		{
			c5x c5x = (c5x)b0b;
			if (c5x.h.b != null || c5x.y.b != null)
			{
				foreach (ak1 ak2 in c5x.l)
				{
					if (anp.f().Contains(ak2.Location))
					{
						list.Add(c5x);
						break;
					}
				}
			}
		}
		double[] array = new double[list.Count];
		double[] array2 = new double[list.Count];
		Vector2 vector = a.b.b() + new Vector2(0.5f, 0.5f);
		Vector2 a_ = vector + new Vector2(0f, -10f);
		for (int i = 0; i < list.Count; i++)
		{
			double num = bnx.a(vector, a_, list[i].aj().b());
			double num2 = aw1.a(list[i], ak);
			array[i] = num;
			array2[i] = num2;
		}
		int num3 = 30;
		AmmoType x = AmmoType.Caliber_762 + cuo.a.Next(1, 4);
		Dictionary<amc, cwt> dictionary = new Dictionary<amc, cwt>();
		for (int j = 0; j < num3; j++)
		{
			int num4 = cuo.a.Next(-18, 18) * 10;
			List<c5x> list2 = new List<c5x>();
			for (int k = 0; k < list.Count; k++)
			{
				double num5 = array[k];
				double num6 = array2[k];
				double num7 = Math.Max(10.0, 45.0 / Math.Max(1.0, num6 / 2.0)) / 2.0;
				if (num5 >= (double)num4 - num7 && num5 <= (double)num4 + num7)
				{
					list2.Add(list[k]);
				}
			}
			if (list2.Count > 0)
			{
				c5x c5x2 = list2[cuo.a.Next(list2.Count)];
				if (c5x2.h.b != null)
				{
					cwt cwt;
					if (!dictionary.TryGetValue(c5x2.h.b, out cwt))
					{
						double num8 = 0.05;
						euf.a(ref num8, null, c5x2.h.b.aa());
						kl.b(ref num8, null, c5x2.h.b.aa());
						cwt = new cwt();
						cwt.i = new ap9("Ящик патронов", a.c);
						cwt.j = new ap9(c5x2.h.b.aa());
						cwt.b = true;
						cwt.e = (cuo.a.NextDouble() < num8);
						cwt.h = ImpactSpeed.Medium;
						cwt.k = "шальная пуля";
						cwt.x = x;
						dictionary[c5x2.h.b] = cwt;
					}
					csk item = euf.a(new a1q(DamageType.Mechanical, 20, 40), (double)(cwt.e ? 2 : 1));
					cwt.f.Add(item);
				}
				else if (c5x2.y.b != null)
				{
					c5x2.y.b.a(null);
				}
			}
		}
		foreach (KeyValuePair<amc, cwt> keyValuePair in dictionary)
		{
			amc key = keyValuePair.Key;
			efk efk = keyValuePair.Key.aa();
			cwt value = keyValuePair.Value;
			string text;
			string text2;
			string text3;
			string text4;
			float num9;
			float num10;
			awq.a(keyValuePair.Key, new esu?(esu.e), out text, out text2, out text3, out text4, out num9, out num10, null, false);
			cru cru = efk.Defense.a(value);
			if (cru == null || cru.a == null || cru.a.Count == 0)
			{
				if (!string.IsNullOrEmpty(text2))
				{
					c5x a_2 = key.a8();
					string a_3 = text2;
					int a_4 = 1;
					double maxValue = double.MaxValue;
					bool a_5 = true;
					bool a_6 = true;
					float? a_7 = dz6.b();
					boj.a(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false);
				}
				if (!string.IsNullOrEmpty(text4))
				{
					keyValuePair.Key.a8().c().a(text4);
				}
			}
			else
			{
				if (!string.IsNullOrEmpty(text))
				{
					c5x a_8 = key.a8();
					string a_9 = text;
					int a_10 = 1;
					double maxValue2 = double.MaxValue;
					bool a_11 = true;
					bool a_12 = true;
					float? a_7 = dz6.b();
					boj.a(a_8, a_9, a_10, maxValue2, a_11, a_12, null, null, null, a_7, false);
				}
				if (!string.IsNullOrEmpty(text3))
				{
					keyValuePair.Key.a8().c().a(text3);
				}
			}
		}
	}

	// Token: 0x06005E43 RID: 24131 RVA: 0x0027FD50 File Offset: 0x0027DF50
	[ayh("VolatileAmmoCrate_Triggered")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Area != null && A_1.Zone != null && A_2 != null && A_2.ContainsKey("killingBlow"))
		{
			cwt cwt = A_2["killingBlow"] as cwt;
			c5x c5x = vq.a("object\\destructables\\Xphw_VolatileAmmoCrateTriggered", A_1.Zone, new bt4(A_1.Area.y8(), A_1.Location), false);
			if (c5x != null)
			{
				c5x.VisualPriority = A_1.VisualPriority;
				a3f a3f = c5x.GetAspect<a3f>();
				if (a3f == null)
				{
					a3f = new a3f(c5x);
					c5x.SetAspect<a3f>(a3f);
				}
				if (cwt.i != null)
				{
					a3f.a()["AttackerFaction"] = cwt.i.b;
				}
			}
		}
	}

	// Token: 0x02001138 RID: 4408
	[eiz("VACEC")]
	[Serializable]
	private sealed class a : ISerializable
	{
		// Token: 0x06005E45 RID: 24133 RVA: 0x0027FE2C File Offset: 0x0027E02C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = A_0.GetString("VACEC:A");
			this.b = (Point)A_0.GetValue("VACEC:E", typeof(Point));
			this.c = A_0.GetString("VACEC:F");
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x0027FE84 File Offset: 0x0027E084
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("VACEC:A", this.a);
			info.AddValue("VACEC:E", this.b);
			info.AddValue("VACEC:F", this.c);
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x0027FEC0 File Offset: 0x0027E0C0
		public a()
		{
		}

		// Token: 0x0400257C RID: 9596
		public string a;

		// Token: 0x0400257D RID: 9597
		public Point b;

		// Token: 0x0400257E RID: 9598
		public string c;
	}
}
