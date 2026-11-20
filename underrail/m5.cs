using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001015 RID: 4117
[eiz("YABS")]
[Serializable]
public sealed class m5 : cze
{
	// Token: 0x060054F5 RID: 21749 RVA: 0x002595A8 File Offset: 0x002577A8
	private m5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060054F6 RID: 21750 RVA: 0x002595B4 File Offset: 0x002577B4
	public m5()
	{
	}

	// Token: 0x060054F7 RID: 21751 RVA: 0x002595BC File Offset: 0x002577BC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (cuo.a.Next(101) < 70)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.IsPlayer && c5x.h.b != null && c5x.Area != null && c5x.Zone != null)
			{
				List<m5.a> list = new List<m5.a>();
				foreach (object obj in Enum.GetValues(typeof(m5.a)))
				{
					m5.a item = (m5.a)obj;
					list.Add(item);
				}
				if (list.Count > 0)
				{
					int index = cuo.a.Next(list.Count);
					m5.a a_ = list[index];
					this.a(c5x, a_);
				}
			}
		}
	}

	// Token: 0x060054F8 RID: 21752 RVA: 0x002596B4 File Offset: 0x002578B4
	private void a(c5x A_0, m5.a A_1)
	{
		if (A_1 <= m5.a.s)
		{
			switch (A_1)
			{
			case m5.a.a:
				this.a(A_0, "Frighten");
				return;
			case m5.a.b:
				this.a(A_0, "MetalDoorOpen");
				return;
			case m5.a.c:
				this.a(A_0, "DarkSecretReveal");
				return;
			case m5.a.d:
				this.a(A_0, "EnterStealth");
				return;
			case m5.a.e:
				this.a(A_0, "PistolReload");
				return;
			case m5.a.f:
				this.a(A_0, "CameraWarning");
				return;
			case m5.a.g:
				this.a(A_0, "TurretActivate");
				return;
			case m5.a.h:
				this.a(A_0, "BladelingAttack");
				return;
			case m5.a.i:
				this.a(A_0, "PantingLoopMale");
				return;
			case m5.a.j:
				this.a(A_0, "ArmFragMine");
				return;
			default:
				switch (A_1)
				{
				case m5.a.k:
					this.a(A_0, "bur", "mv", null, 8, true, l9.a);
					return;
				case m5.a.l:
					this.a(A_0, "psibt", "mv", "PsiBeetleChitter1", 8, true, l9.a);
					return;
				case m5.a.m:
					this.a(A_0, "rh", "mv", "RathoundHowl", 8, true, l9.a);
					return;
				case m5.a.n:
					this.a(A_0, "rh_a", "mv", "RathoundHowl", 8, true, l9.a);
					return;
				case m5.a.o:
					this.a(A_0, "rh_an", "mv", "RathoundHowl", 8, true, l9.a);
					return;
				case m5.a.p:
					this.a(A_0, "mh" + cuo.a.Next(1, 4).ToString(), (cuo.a.Next(2) == 0) ? "mv" : "id", "MutatedHumanGrowl", 8, true, l9.a);
					return;
				case m5.a.q:
					this.a(A_0, "plsen", "mv", null, 8, true, l9.a);
					return;
				case m5.a.r:
					this.a(A_0, "glrv", "di", "GiantGrubDie", 8, true, l9.a);
					return;
				case m5.a.s:
					if (dk2.b("xpbl"))
					{
						this.a(A_0, "xpbl_ssrp" + cuo.a.Next(1, 4).ToString(), "c1", null, 8, true, l9.b);
						return;
					}
					break;
				default:
					return;
				}
				break;
			}
		}
		else
		{
			switch (A_1)
			{
			case m5.a.t:
				this.a(A_0, "rg" + ((cuo.a.Next(2) == 0) ? "" : "_f") + cuo.a.Next(1, 3).ToString(), this.a((cuo.a.Next(1, 101) <= 70) ? "id" : "mv"), null, 8, true, l9.a);
				return;
			case m5.a.u:
				this.a(A_0, "punk" + ((cuo.a.Next(2) == 0) ? "" : "_f") + cuo.a.Next(1, 3).ToString(), this.a((cuo.a.Next(1, 101) <= 70) ? "id" : "mv"), null, 8, true, l9.a);
				return;
			case m5.a.v:
				this.a(A_0, "cmd" + ((cuo.a.Next(2) == 0) ? cuo.a.Next(1, 3).ToString() : "_f1"), this.a((cuo.a.Next(1, 101) <= 70) ? "id" : "mv"), null, 8, true, l9.a);
				return;
			case m5.a.w:
				this.a(A_0, "ag" + ((cuo.a.Next(2) == 0) ? "" : "_f") + cuo.a.Next(1, 3).ToString(), this.a((cuo.a.Next(1, 101) <= 70) ? "id" : "mv"), null, 8, true, l9.a);
				return;
			case m5.a.x:
				this.a(A_0, "scavle" + ((cuo.a.Next(2) == 0) ? "" : "_f") + cuo.a.Next(1, 3).ToString(), this.a((cuo.a.Next(1, 101) <= 70) ? "id" : "mv"), null, 8, true, l9.a);
				return;
			case m5.a.y:
				this.a(A_0, "pl" + ((cuo.a.Next(2) == 0) ? "" : "_f") + "_rb", this.a((cuo.a.Next(1, 101) <= 70) ? "id" : "mv"), null, 8, true, l9.a);
				return;
			case m5.a.z:
				this.a(A_0, "orb", "id", "Frighten", 8, true, l9.a);
				return;
			default:
				switch (A_1)
				{
				case m5.a.aa:
					this.a(A_0, 1);
					return;
				case m5.a.ab:
					this.a(A_0, 2);
					return;
				case m5.a.ac:
					this.a(A_0, 3);
					return;
				case m5.a.ad:
					this.a(A_0, 2);
					break;
				default:
					return;
				}
				break;
			}
		}
	}

	// Token: 0x060054F9 RID: 21753 RVA: 0x00259BFC File Offset: 0x00257DFC
	private void a(c5x A_0, string A_1, string A_2, string A_3 = null, int A_4 = 8, bool A_5 = true, l9 A_6 = l9.a)
	{
		long d = bpo.GetServiceOrThrow<cnk>().aqu().v().a().d;
		List<ak1> list = new List<ak1>();
		for (int i = 0; i < A_0.Area.Size.c; i++)
		{
			for (int j = 0; j < A_0.Area.Size.d; j++)
			{
				ak1 ak = A_0.Area.b(i, j);
				if (ak.b(d) && !aw1.a(ak, false, null, A_6))
				{
					list.Add(ak);
				}
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		Vector3 a_ = list[cuo.a.Next(list.Count)].Location.a();
		c5x c5x = new c5x();
		c5x.Layer = aju.x;
		c5x.Location = a_;
		c5x.Size = Vector3.One;
		c5x.ad = new Color?(new Color(25, 25, 25));
		c5x.ae = new float?(0f);
		etz etz = new etz(c5x);
		etz.a = string.Format("Creatures\\{0}\\{1}", A_1, A_2);
		etz.d(80);
		etz.c(A_4);
		if (A_5)
		{
			etz.b = new Point(0, cuo.a.Next(8));
		}
		c5x.SetAspect<cd0>(etz);
		do6 aspect = new do6(c5x);
		c5x.SetAspect<do6>(aspect);
		A_0.Area.a(c5x);
		int num = 2000 + cuo.a.Next(1500);
		int num2 = num / 3;
		double num3 = 0.55;
		dtb dtb = new dtb();
		List<auv> list2 = dtb.ad();
		ad6 ad = new ad6(c5x);
		ad.b(0.0);
		ad.c(num3);
		ad.a(num3 / (double)num2);
		list2.Add(ad);
		dtb.ad().Add(new bm3(num2));
		List<auv> list3 = dtb.ad();
		ad6 ad2 = new ad6(c5x);
		ad2.b(num3);
		ad2.c(0.0);
		ad2.a(num3 / (double)num2);
		list3.Add(ad2);
		dtb.ad().Add(new c7(c5x, false, false, true, false));
		A_0.Zone.ActionManager.g9(dtb, atp.a);
		if (!string.IsNullOrEmpty(A_3))
		{
			ak1 ak2 = Enumerable.FirstOrDefault<ak1>(c5x.l);
			if (ak2 != null)
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(m5.b.a.a))) as c5x;
				if (c5x2 != null)
				{
					int a_2 = (int)((double)num * 0.3);
					dtb dtb2 = new dtb();
					dtb2.ad().Add(new bm3(a_2));
					dtb2.ad().Add(new a4s(new bfq(A_3), null, new ar7(c5x2), null));
					A_0.Zone.ActionManager.g9(dtb2, atp.a);
				}
			}
		}
	}

	// Token: 0x060054FA RID: 21754 RVA: 0x00259F24 File Offset: 0x00258124
	private string a(string A_0)
	{
		List<string> list = new List<string>
		{
			"",
			"_k",
			"_p",
			"_ra",
			"_ep",
			"_rs",
			"_s",
			"_sm",
			"_s"
		};
		if (dk2.b("xpbl"))
		{
			list.Add("_xpblm");
			list.Add("_xpblsa");
			list.Add("_xpblsg");
		}
		if (dk2.b("xphw"))
		{
			list.Add("_xphwg");
			list.Add("_xphwgg");
			list.Add("_xphwmg");
		}
		A_0 += list[cuo.a.Next(0, list.Count)];
		return A_0;
	}

	// Token: 0x060054FB RID: 21755 RVA: 0x0025A01C File Offset: 0x0025821C
	private void a(c5x A_0, string A_1)
	{
		if (A_0 == null)
		{
			return;
		}
		A_0.c().a(Guid.NewGuid().ToString(), A_1, 0.5f, c9z.a, false, false);
	}

	// Token: 0x060054FC RID: 21756 RVA: 0x0025A058 File Offset: 0x00258258
	private void a(c5x A_0, int A_1 = 1)
	{
		List<string> list = null;
		switch (A_1)
		{
		case 1:
			list = new List<string>
			{
				"А?",
				"А, что?",
				"Хм-м-м...",
				"О...",
				"А-а!",
				"НЕТ!",
				"Ха!",
				"Платье!"
			};
			break;
		case 2:
			list = new List<string>
			{
				"ТИХО!",
				"Кто это сказал?",
				"Кто тут?",
				"Не лезь не в своё дело!",
				"Заткнись!",
				"Проваливай!"
			};
			break;
		case 3:
			list = new List<string>
			{
				"Где ты прячешься?",
				"А, вот и ты!",
				"Этот запах...",
				"Мои ноги!",
				"Вверху...",
				"Что это было?"
			};
			break;
		case 4:
			list = new List<string>
			{
				"Я не знаю.",
				"Что-что-что?",
				"М-м-м... м-м-м...",
				"Н-н-н...",
				"Нет, нет, этого не может быть!",
				"Я так и знал!",
				"Не-е сейчас. Не сейчас."
			};
			break;
		}
		if (A_0.u.b != null)
		{
			A_0.u.b.a(list[cuo.a.Next(0, list.Count)], false, new Color?(Color.MediumPurple), null);
		}
	}

	// Token: 0x02001016 RID: 4118
	private new enum a
	{
		// Token: 0x04002290 RID: 8848
		a,
		// Token: 0x04002291 RID: 8849
		b,
		// Token: 0x04002292 RID: 8850
		c,
		// Token: 0x04002293 RID: 8851
		d,
		// Token: 0x04002294 RID: 8852
		e,
		// Token: 0x04002295 RID: 8853
		f,
		// Token: 0x04002296 RID: 8854
		g,
		// Token: 0x04002297 RID: 8855
		h,
		// Token: 0x04002298 RID: 8856
		i,
		// Token: 0x04002299 RID: 8857
		j,
		// Token: 0x0400229A RID: 8858
		k = 100,
		// Token: 0x0400229B RID: 8859
		l,
		// Token: 0x0400229C RID: 8860
		m,
		// Token: 0x0400229D RID: 8861
		n,
		// Token: 0x0400229E RID: 8862
		o,
		// Token: 0x0400229F RID: 8863
		p,
		// Token: 0x040022A0 RID: 8864
		q,
		// Token: 0x040022A1 RID: 8865
		r,
		// Token: 0x040022A2 RID: 8866
		s,
		// Token: 0x040022A3 RID: 8867
		t = 200,
		// Token: 0x040022A4 RID: 8868
		u,
		// Token: 0x040022A5 RID: 8869
		v,
		// Token: 0x040022A6 RID: 8870
		w,
		// Token: 0x040022A7 RID: 8871
		x,
		// Token: 0x040022A8 RID: 8872
		y,
		// Token: 0x040022A9 RID: 8873
		z,
		// Token: 0x040022AA RID: 8874
		aa = 300,
		// Token: 0x040022AB RID: 8875
		ab,
		// Token: 0x040022AC RID: 8876
		ac,
		// Token: 0x040022AD RID: 8877
		ad
	}

	// Token: 0x02001017 RID: 4119
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x060054FF RID: 21759 RVA: 0x0025A234 File Offset: 0x00258434
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor || A_0.IsGround;
		}

		// Token: 0x040022AE RID: 8878
		public static readonly m5.b a = new m5.b();

		// Token: 0x040022AF RID: 8879
		public static Func<b0b, bool> b;
	}
}
