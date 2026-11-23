using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000EE6 RID: 3814
[e79("Arena/CarnifexFight")]
public sealed class bxy : dgy
{
	// Token: 0x06004E37 RID: 20023 RVA: 0x0022B0A4 File Offset: 0x002292A4
	public bxy()
	{
		bxy.a a = new bxy.a();
		a.b = this;
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			bxy.b b = new bxy.b();
			b.a = (a.a.aqu().v().b() as c5x);
			this.c = new ar7();
			if (b.a != null)
			{
				bxy.c c = new bxy.c();
				c.a = b.a.Zone.n("cc_arena");
				if (c.a != null)
				{
					this.a = (new ar7(new Guid("dabcee2a-6946-4f2a-9402-5e27649c52a4"), c.a).ao() as c5x);
					this.b = (new ar7(new Guid("21336a36-f3b5-4744-80d7-3c227763b6d5"), c.a).ao() as c5x);
					if (this.a != null && this.b != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array = new btm[1];
						int num = 0;
						dky dky = new dky();
						dky.a(0.2f);
						dky.a(false);
						array[num] = dky;
						base.a(array);
						btm[] array2 = new btm[1];
						int num2 = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(c.a));
						array2[num2] = dva;
						base.a(array2);
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = "gladiator1"
							})
							{
								InitiatorRef = new ar7(b.a)
							}
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						kw kw = new kw();
						kw.a(new bt4("announcerCam"));
						kw.a(true);
						array3[num3] = kw;
						base.a(array3);
						btm[] array4 = new btm[1];
						int num4 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(bxy.d.a.a));
						array4[num4] = dva2;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(b.b));
						array5[num5] = dva3;
						base.a(array5);
						btm[] array6 = new btm[1];
						int num6 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						array6[num6] = c8s;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						this.a("Дорогие мои кровожадные маньяки, добро пожаловать на величайший, самый долгожданный матч в новейшей истории!", 9);
						this.a("Мне ли не знать, с каким нетерпением вы ждали его, дорогие маньяки. Вы, кто присутствует здесь, и вы, кто смотрит нас на канале «Арена Сегодня».", 10);
						this.a("Сегодня мы желаем видеть кровопролитие, и эти двое ещё как умеют его показать!", 5);
						this.a("А теперь, момент, которого вы все ждали! Давайте представим наших гладиаторов!", 7);
						this.a("Он неудержим, непоколебим, неуязвим. Все, кто встал у него на пути, превратились в кровавое месиво.", 8);
						this.a("Прошу вас, встречайте текущего инвиктуса... Властелин ужаса!", 4);
						btm[] array7 = new btm[1];
						int num7 = 0;
						kw kw2 = new kw();
						kw2.a(new bt4("carnifexEntrance"));
						kw2.a(false);
						array7[num7] = kw2;
						base.a(array7);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						dva dva4 = new dva(null, null, null, null, null);
						dva4.a(new Func<e6d, bool>(b.a));
						array8[num8] = dva4;
						base.a(array8);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array9 = new btm[1];
						int num9 = 0;
						dva dva5 = new dva(null, null, null, null, null);
						dva5.a(new Func<e6d, bool>(a.a));
						array9[num9] = dva5;
						base.a(array9);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array10 = new btm[1];
						int num10 = 0;
						dva dva6 = new dva(null, null, null, null, null);
						dva6.a(new Func<e6d, bool>(this.c));
						array10[num10] = dva6;
						base.a(array10);
						btm[] array11 = new btm[1];
						int num11 = 0;
						kw kw3 = new kw();
						kw3.a(new bt4("enemyGladiator"));
						kw3.a(false);
						array11[num11] = kw3;
						base.a(array11);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array12 = new btm[1];
						int num12 = 0;
						dva dva7 = new dva(null, null, null, null, null);
						dva7.a(new Func<e6d, bool>(b.c));
						array12[num12] = dva7;
						base.a(array12);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						this.b("Вряд ли Властелин ужаса скоро выйдет. ::Он смеётся.:: Трудновато ему будет без головы.", 7);
						string str = "О, ";
						object obj = a.a.aqu().r()["playerArenaTitle"];
						this.b(str + ((obj != null) ? obj.ToString() : null) + ". Мы встретились снова. На этот раз \u0097 на Арене.", 5);
						btm[] array13 = new btm[1];
						int num13 = 0;
						dva dva8 = new dva(null, null, null, null, null);
						dva8.a(new Func<e6d, bool>(this.b));
						array13[num13] = dva8;
						base.a(array13);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						this.b("Я думаю, это будет хардкорный матч. Я очень... ждал этой схватки с тобой. Мне так наскучило всё это однообразное мясо, которое они бросали передо мной раз за разом. Тоска.", 8);
						string str2 = "Но ты \u0097 из тебя выйдет противник, достойный Карнифекса. *Не* разочаруй меня, ";
						object obj2 = a.a.aqu().r()["playerArenaTitle"];
						this.b(str2 + ((obj2 != null) ? obj2.ToString() : null) + ".", 5);
						this.b("Не заставляй меня пожалеть, что я вернулся из отставки.", 3);
						btm[] array14 = new btm[1];
						int num14 = 0;
						kw kw4 = new kw();
						kw4.a(new bt4("announcerCam"));
						kw4.a(false);
						array14[num14] = kw4;
						base.a(array14);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						this.a("Что... Где Властелин ужаса! Карни... Что здесь творится? Может мне кто-нибудь сказать?!", 6);
						this.a("Что? Мёртв?! В раздевалке?!", 5);
						this.a("Я знаю, что мы живы... Скажи мне, что делать!", 5);
						this.a("Да... Да... Понял.", 3);
						this.a("Маньяки! Как вы можете видеть, произошли некоторые... изменения. Карнифекс решил вернуться на Арену, вот это да!", 7);
						string str3 = "Это великий гладиатор, если не величайший в истории Арены, и сразится с ним... ";
						object obj3 = a.a.aqu().r()["playerArenaTitle"];
						this.a(str3 + ((obj3 != null) ? obj3.ToString() : null) + "!", 9);
						this.a("Что же мне остаётся сказать в такой захватывающей ситуации?", 5);
						this.a("Нам. Покажите. Вы. КРОВОПРОЛИТИЕ!", 3);
						btm[] array15 = new btm[1];
						int num15 = 0;
						kw kw5 = new kw();
						kw5.a(new bt4("arenaCam"));
						kw5.a(false);
						array15[num15] = kw5;
						base.a(array15);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						btm[] array16 = new btm[1];
						int num16 = 0;
						dva dva9 = new dva(null, null, null, null, null);
						dva9.a(new Func<e6d, bool>(this.a));
						array16[num16] = dva9;
						base.a(array16);
						btm[] array17 = new btm[1];
						int num17 = 0;
						dva dva10 = new dva(null, null, null, null, null);
						dva10.a(new Func<e6d, bool>(bxy.d.a.b));
						array17[num17] = dva10;
						base.a(array17);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						base.a(new btm[]
						{
							new ace(new bu0("cp_carnifex"))
						});
					}
				}
			}
		}
	}

	// Token: 0x06004E38 RID: 20024 RVA: 0x0022B80C File Offset: 0x00229A0C
	protected void a(string A_0, int A_1)
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
		btm[] array2 = new btm[1];
		int num2 = 0;
		egx egx2 = new egx();
		egx2.a(A_0);
		array2[num2] = new ace(egx2)
		{
			TargetRef = new ar7(this.b)
		};
		base.a(array2);
		int num3 = Math.Max((int)(ciz.a(A_0) - 250.0), A_1 * 1000);
		base.a(new btm[]
		{
			new os(TimeSpan.FromMilliseconds((double)num3))
		});
	}

	// Token: 0x06004E39 RID: 20025 RVA: 0x0022B8B4 File Offset: 0x00229AB4
	protected void b(string A_0, int A_1)
	{
		btm[] array = new btm[1];
		int num = 0;
		egx egx = new egx();
		egx.a(A_0);
		array[num] = new ace(egx)
		{
			TargetRef = this.c
		};
		base.a(array);
		int num2 = Math.Max((int)(ciz.a(A_0) - 250.0), A_1 * 1000);
		base.a(new btm[]
		{
			new os(TimeSpan.FromMilliseconds((double)num2))
		});
	}

	// Token: 0x06004E3A RID: 20026 RVA: 0x0022B928 File Offset: 0x00229B28
	[CompilerGenerated]
	private bool c(e6d A_0)
	{
		c5x c5x = this.c.ao() as c5x;
		if (c5x != null && c5x.k.b != null)
		{
			c5x.k.b.a(c5x.Zone.g("enemyGladiator").Tile, 0.0, 1, 0, true);
		}
		return true;
	}

	// Token: 0x06004E3B RID: 20027 RVA: 0x0022B990 File Offset: 0x00229B90
	[CompilerGenerated]
	private bool b(e6d A_0)
	{
		c5x c5x = this.c.ao() as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.a("cfx");
		}
		return true;
	}

	// Token: 0x06004E3C RID: 20028 RVA: 0x0022B9DC File Offset: 0x00229BDC
	[CompilerGenerated]
	private bool a(e6d A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.anf(edg.b);
		}
		a3f aspect = this.b.GetAspect<a3f>();
		if (aspect != null)
		{
			aspect.a()["EndCutsceneName"] = "CarnifexFightEnd";
		}
		return true;
	}

	// Token: 0x04001FE1 RID: 8161
	private new c5x a;

	// Token: 0x04001FE2 RID: 8162
	private new c5x b;

	// Token: 0x04001FE3 RID: 8163
	private ar7 c;

	// Token: 0x02000EE7 RID: 3815
	[CompilerGenerated]
	[Serializable]
	private new sealed class d
	{
		// Token: 0x06004E3F RID: 20031 RVA: 0x0022BA38 File Offset: 0x00229C38
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x0022BA5C File Offset: 0x00229C5C
		internal bool b(e6d A_0)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != null && d4n.b.aa().Gear.h().Item != null)
					{
						d4n.b.aa().Defense.a(true);
					}
				}
			}
			return true;
		}

		// Token: 0x04001FE4 RID: 8164
		public static readonly bxy.d a = new bxy.d();

		// Token: 0x04001FE5 RID: 8165
		public static Func<e6d, bool> b;

		// Token: 0x04001FE6 RID: 8166
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000EE8 RID: 3816
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E42 RID: 20034 RVA: 0x0022BB04 File Offset: 0x00229D04
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("carnifexEntrance");
			c5x c5x = vq.a("creatures\\arena\\Carnifex", a_, true);
			if (c5x != null)
			{
				if (c5x.h.b != null)
				{
					c5x.h.b.aa().Defense.a(true);
				}
				this.b.c.a(c5x);
			}
			return true;
		}

		// Token: 0x04001FE7 RID: 8167
		public cnk a;

		// Token: 0x04001FE8 RID: 8168
		public bxy b;
	}

	// Token: 0x02000EE9 RID: 3817
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004E44 RID: 20036 RVA: 0x0022BB84 File Offset: 0x00229D84
		internal bool b(e6d A_0)
		{
			if (this.a.h.b.aa().Gear.h().Item != null)
			{
				this.a.h.b.aa().Defense.a(false);
			}
			return true;
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x0022BBDC File Offset: 0x00229DDC
		internal bool a(e6d A_0)
		{
			crx crx = new crx();
			crx.a("cc_arena");
			crx.c().Add(new Guid("dda07171-3d59-487b-a92a-087f3cb4ce32"));
			crx.c().Add(new Guid("a2340361-87f5-4e57-b87a-bc8f90fabf27"));
			crx.a(bbo.b);
			crx.ym(this.a, null, null);
			return true;
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x0022BC38 File Offset: 0x00229E38
		internal bool c(e6d A_0)
		{
			crx crx = new crx();
			crx.a("cc_arena");
			crx.c().Add(new Guid("dda07171-3d59-487b-a92a-087f3cb4ce32"));
			crx.c().Add(new Guid("a2340361-87f5-4e57-b87a-bc8f90fabf27"));
			crx.a(bbo.c);
			crx.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001FE9 RID: 8169
		public c5x a;
	}

	// Token: 0x02000EEA RID: 3818
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004E48 RID: 20040 RVA: 0x0022BC9C File Offset: 0x00229E9C
		internal bool a(e6d A_0)
		{
			for (int i = 10; i <= this.a.Size.c; i++)
			{
				for (int j = 10; j <= this.a.Size.d; j++)
				{
					ak1 ak = this.a.b(i, j);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
						{
							c5x c5x = (c5x)b0b;
							if (!c5x.IsFloor && c5x.qe() != new Guid("21336a36-f3b5-4744-80d7-3c227763b6d5") && c5x.Layer == aju.x)
							{
								c5x.w();
								c5x.an();
							}
						}
						foreach (bqt bqt in Enumerable.ToList<bqt>(ak.TriggerProxies))
						{
							bqt.Trigger.o();
						}
					}
				}
			}
			return true;
		}

		// Token: 0x04001FEA RID: 8170
		public aud a;
	}
}
