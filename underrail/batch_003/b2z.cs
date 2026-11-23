using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;

// Token: 0x02000CC3 RID: 3267
[e79("Xpbl_Dun_Cvw_Hr_RaceStart")]
public sealed class b2z : dgy
{
	// Token: 0x06004982 RID: 18818 RVA: 0x001E9E54 File Offset: 0x001E8054
	public b2z()
	{
		b2z.b b = new b2z.b();
		base..ctor();
		b.a = this;
		b.b = bpo.GetServiceOrThrow<cnk>();
		if (b.b != null && b.b.aqu() != null && b.b.aqw() != null)
		{
			b2z.a a = new b2z.a();
			a.g = b;
			a.g.b.aqu().r()["loc_xpbl_dun_cvw_hr_raceStatus"] = "ongoing";
			a.a = (a.g.b.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.a.i.b.a(true, false);
				d60 d = a.g.b.aqw().a();
				a.b = d.ab4(new string[]
				{
					"xpbl_dun_cvw_hr_hopper"
				});
				a.c = (new ar7(new Guid("b021eff5-b87e-441e-a4cc-62218a6daeba"), a.a.Area).ao() as c5x);
				a.d = (new ar7(new Guid("c72c2337-980a-4109-8030-d86c7f5f9342"), a.a.Area).ao() as c5x);
				a.e = (new ar7(new Guid("7a22d4a1-0b24-4c40-9f62-2176e70e7591"), a.a.Area).ao() as c5x);
				a.f = (new ar7(new Guid("35c35884-c90e-43c0-b135-dd0d31984882"), a.a.Area).ao() as c5x);
				if (a.b != null && a.c != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
					a.g.b.aqu().r()["loc_dun_lup-a_captured"] = true;
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					kw kw = new kw();
					kw.a(new bt4("speechCamera"));
					kw.a(false);
					array3[num3] = kw;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.g.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.g.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.g.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.g.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x06004983 RID: 18819 RVA: 0x001EA300 File Offset: 0x001E8500
	private void a(c5x A_0, int A_1, cnk A_2)
	{
		List<string> list = new List<string>();
		int? primitivePropertyValue = A_2.aqu().r().GetPrimitivePropertyValue<int>("frag_xpbl_dun_cvw_hr_raceType", new int?(0));
		int num = 0;
		if (primitivePropertyValue.GetValueOrDefault() == num & primitivePropertyValue != null)
		{
			for (int i = 1; i <= 5; i++)
			{
				list.Add("hopper" + (A_1 + 1).ToString() + "_w" + i.ToString());
			}
		}
		else
		{
			for (int j = 1; j <= 5; j++)
			{
				if (j == 3)
				{
					list.Add("hopper" + (A_1 + 1).ToString() + "_rt1_w" + j.ToString());
				}
				else
				{
					list.Add("hopper" + (A_1 + 1).ToString() + "_w" + j.ToString());
				}
			}
		}
		A_0.t.b.y6().RemoveProperty(ddq.ay);
		A_0.RemoveAspect<j7>();
		A_0.t.b.y6()[ddq.k] = list;
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x001EA430 File Offset: 0x001E8630
	private void a(cnk A_0, string A_1)
	{
		if (A_0.aqu() != null)
		{
			d60 d = A_0.aqw().a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"xpbl_dun_cvw_hr_speaker"
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.u.b != null)
						{
							c5x.u.b.a(A_1, true, null, null);
						}
					}
				}
			}
		}
	}

	// Token: 0x02000CC4 RID: 3268
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004986 RID: 18822 RVA: 0x001EA4FC File Offset: 0x001E86FC
		internal bool b(e6d A_0)
		{
			this.a.a(this.b, "Любители острых ощущений и отважные любители риска, добро пожаловать на \"Пещерникодром\"! Сегодня вы станете свидетелями финального дня скачек, это не сравнится с тем, что вы когда-либо видели!");
			return true;
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x001EA518 File Offset: 0x001E8718
		internal bool a(e6d A_0)
		{
			this.a.a(this.b, "Надеюсь вы запаслись *Кор-чипсами*! Хрустящими и наполненными удивительными ингредиентами, не отказывайте себе в удовольствии насладится во время гонки удивительными *Кор-чипсами!*");
			return true;
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x001EA534 File Offset: 0x001E8734
		internal bool c(e6d A_0)
		{
			this.a.a(this.b, "Хорошо, я надеюсь, что все готовы! Устраивайтесь по удобнее и наслаждайтесь тем, что будет дальше, когда наши славные пещерники устремятся к победе!");
			return true;
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x001EA550 File Offset: 0x001E8750
		internal bool d(e6d A_0)
		{
			this.a.a(this.b, "По моему обратному отсчёту гонка начнётся! ПЯТЬ... ЧЕТЫРЕ... ТРИ... ДВА... ОДИН, ВПЕРЁД! *Все*, смотрите, как они рванули!");
			return true;
		}

		// Token: 0x04001D17 RID: 7447
		public b2z a;

		// Token: 0x04001D18 RID: 7448
		public cnk b;
	}

	// Token: 0x02000CC5 RID: 3269
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600498B RID: 18827 RVA: 0x001EA574 File Offset: 0x001E8774
		internal bool a(e6d A_0)
		{
			for (int i = 0; i < Enumerable.Count<b0b>(this.b); i++)
			{
				a0l.a(this.b[i] as c5x, "start" + (i + 1).ToString(), true);
				this.g.a.a(this.b[i] as c5x, i, this.g.b);
			}
			if (this.c.t.b != null)
			{
				a0l.a(this.c, "commentatorSpot", true);
				this.c.t.b.y6()[ddq.ay] = new bt4("commentatorSpot");
			}
			if (this.d != null && this.d.t.b != null)
			{
				a0l.a(this.d, "bet1", true);
				this.d.t.b.y6()[ddq.ay] = new bt4("bet1");
			}
			if (this.e != null && this.e.t.b != null)
			{
				a0l.a(this.e, "bet2", true);
				this.e.t.b.y6()[ddq.ay] = new bt4("bet2");
			}
			if (this.f != null && this.f.t.b != null)
			{
				a0l.a(this.f, "bet3", true);
				this.f.t.b.y6()[ddq.ay] = new bt4("bet3");
			}
			this.a.VisualDirection = HorizontalDirection.South;
			this.c.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x001EA76C File Offset: 0x001E896C
		internal bool b(e6d A_0)
		{
			this.g.a.a(this.g.b, string.Concat(new string[]
			{
				"Узрите, как ",
				this.b[0].y8(),
				", ",
				this.b[1].y8(),
				", ",
				this.b[2].y8(),
				", и ",
				this.b[3].y8(),
				" выходят на старт! Я уже не могу дождаться, когда увижу, как эти удивительные соперники зажгут эту трассу!"
			}));
			return true;
		}

		// Token: 0x04001D19 RID: 7449
		public c5x a;

		// Token: 0x04001D1A RID: 7450
		public List<b0b> b;

		// Token: 0x04001D1B RID: 7451
		public c5x c;

		// Token: 0x04001D1C RID: 7452
		public c5x d;

		// Token: 0x04001D1D RID: 7453
		public c5x e;

		// Token: 0x04001D1E RID: 7454
		public c5x f;

		// Token: 0x04001D1F RID: 7455
		public b2z.b g;
	}
}
