using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;

// Token: 0x02000DA8 RID: 3496
[e79("TchortIntro")]
public sealed class b4o : dgy
{
	// Token: 0x06004B84 RID: 19332 RVA: 0x0020AE30 File Offset: 0x00209030
	public b4o()
	{
		b4o.c c = new b4o.c();
		c.a = bpo.GetServiceOrThrow<cnk>();
		if (c.a != null && c.a.aqu() != null)
		{
			b4o.a a = new b4o.a();
			a.c = c;
			a.a = a.c.a.aqu().r().GetPrimitivePropertyValue<bool>("dc_tchortPoisoned", new bool?(false)).Value;
			a.b = (a.c.a.aqu().v().b() as c5x);
			if (a.b != null && a.b.Zone != null)
			{
				this.a = (new ar7(new Guid("24146c99-969c-4e34-a3f8-783684060623"), a.b.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array[num] = dva;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(b4o.b.a.a));
				array2[num2] = dva2;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(a.b));
				array3[num3] = dva3;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				kw kw = new kw();
				kw.a(new bt4("tchortCam"));
				kw.a(false);
				kw.IsAsync = true;
				kw.a(new float?(3.5f));
				array4[num4] = kw;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(6.0))
				});
				if (this.a != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s = new s5();
					s.a(new ar7(this.a));
					s.a(new bt4("moc1"));
					s.IsAsync = false;
					s.a(true);
					array5[num5] = s;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					this.a("Это Тень мы ждали.");
					this.a("Мы голодали многие дни, мы надеялись, что он придёт за своим вожделенным.");
					this.a("Такое восхитительное пиршество ждало нас. Буря ощущений после долгого предвкушения.");
					this.a("Плоть Высоких... так обильна.");
					this.a("Их мысли \u0097 как чистая и быстрая вода древних ледниковых потоков.");
					this.a("А-а-ах...");
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					this.a("Но теперь я знаю, что он не осмелится встретиться с нами.");
					this.a("А вместо него у нас есть ты \u0097 ещё одна плешивая туннельная крыса.");
					this.a("Роющаяся в мусоре, вонючая, уродливая, дисгеническая полукровка!");
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					if (a.a)
					{
						this.a("А что до яда, которым ты отравила наш колодец, шавка...");
						this.a("Он тебе не поможет... ты только задержала нас.");
						this.a("За эту дерзость ты будешь страшно страдать в нашем лоне.");
						this.a("Как букашку, мы порвём тебя на части и соберём тебя снова и снова.");
						this.a("Ты узнаешь, какую боль может причинить бог.");
					}
					else
					{
						this.a("Но мы долго не ели, поэтому ты подойдёшь.");
						this.a("Подойди, маленькая, мы проведём тебя вглубь через коридоры боли.");
						this.a("Не унывай, ибо на той стороне тебя ждёт великая судьба.");
						this.a("Тебе придётся упасть, чтобы вознестись.");
						this.a("Гордо восстать в покорности.");
						this.a("Подойди... направь свою реку в наше море и стань плотью бога.");
					}
				}
				base.a(new btm[]
				{
					new ace(new boh(true))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4("FromLadder"));
				kw2.a(false);
				kw2.a(new float?(7f));
				array6[num6] = kw2;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(a.c.a));
				array7[num7] = dva4;
				base.a(array7);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new ace(new bu0("cp_tchort"))
				});
			}
		}
	}

	// Token: 0x06004B85 RID: 19333 RVA: 0x0020B314 File Offset: 0x00209514
	private void a(string A_0)
	{
		btm[] array = new btm[1];
		int num = 0;
		egx egx = new egx();
		egx.a(A_0);
		array[num] = new ace(egx)
		{
			TargetRef = new ar7(this.a)
		};
		base.a(array);
		base.a(new btm[]
		{
			new os(TimeSpan.FromMilliseconds(ciz.a(A_0)))
		});
	}

	// Token: 0x04001E5C RID: 7772
	private new c5x a;

	// Token: 0x02000DA9 RID: 3497
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004B88 RID: 19336 RVA: 0x0020B38C File Offset: 0x0020958C
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x04001E5D RID: 7773
		public static readonly b4o.b a = new b4o.b();

		// Token: 0x04001E5E RID: 7774
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000DAA RID: 3498
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004B8A RID: 19338 RVA: 0x0020B3BC File Offset: 0x002095BC
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["loc_dc_tchb_tentacleTrueDeathTime"] = false;
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001E5F RID: 7775
		public cnk a;
	}

	// Token: 0x02000DAB RID: 3499
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B8C RID: 19340 RVA: 0x0020B40C File Offset: 0x0020960C
		internal bool a(e6d A_0)
		{
			this.c.a.aqu().r()["loc_dc_tchb_tentacleTrueDeathTime"] = true;
			if (this.a)
			{
				d60 d = this.c.a.aqw().a();
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"primeTentacle"
					});
					Random random = new Random(this.c.a.aqu().l());
					int num = Math.Min(list.Count, 4);
					for (int i = 0; i < num; i++)
					{
						int index = random.Next(list.Count);
						c5x c5x = list[index] as c5x;
						list.RemoveAt(index);
						if (c5x.h.b != null)
						{
							c5x.h.b.aa().a(null, null, false);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x0020B508 File Offset: 0x00209708
		internal bool b(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x04001E60 RID: 7776
		public bool a;

		// Token: 0x04001E61 RID: 7777
		public c5x b;

		// Token: 0x04001E62 RID: 7778
		public b4o.c c;
	}
}
