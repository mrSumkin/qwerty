using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CAA RID: 3242
[e79("lux_uwa_transformationRitual")]
public sealed class bx : dgy
{
	// Token: 0x0600492B RID: 18731 RVA: 0x001DFB04 File Offset: 0x001DDD04
	public bx()
	{
		bx.a a = new bx.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			a.c = (new ar7(new Guid("71caa8ca-9af4-4eb5-afb0-da93ba11500c"), a.b.Area).ao() as c5x);
			a.d = (new ar7(new Guid("1fe6221c-8d96-4487-9626-3a1387ab20ec"), a.b.Area).ao() as c5x);
			a.e = (new ar7(new Guid("7716efe2-600e-4a60-b662-5f4dc125866a"), a.b.Area).ao() as c5x);
			a.f = (new ar7(new Guid("f4eedc64-e18b-4aa7-b1ef-58ad8ba948b9"), a.b.Area).ao() as c5x);
			a.g = (new ar7(new Guid("9c7d9d58-ae9e-4dca-9b30-14725e92a2e3"), a.b.Area).ao() as c5x);
			e5g.b(a.a.aqw().Areas[1]);
			if (a.b != null && a.c != null && a.d != null && a.e != null && a.f != null && a.g != null)
			{
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.e), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("CameraMid"));
				kw.a(false);
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx = new egx();
				egx.a("Шаг вперёд, все, кто хочет ответить на вызов Трансмерности \u0097 шаг вперёд!");
				array4[num4] = new ace(egx)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.ChannelPsi)))
					{
						TargetRef = new ar7(a.f)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.ChannelPsi)))
					{
						TargetRef = new ar7(a.c)
					}
				});
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.ChannelPsi)))
					{
						TargetRef = new ar7(a.d)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				base.a(new btm[]
				{
					new ace(new bfq("DarkSecretReveal", "DarkSecretReveal"))
					{
						TargetRef = new ar7(a.b)
					}
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.f));
				array5[num5] = dva;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx2 = new egx();
				egx2.a("Сделайте шаг вперёд и откажитесь от своей несовершенной формы конечностей \u0097 шаг вперёд!");
				egx2.a(true);
				array6[num6] = new ace(egx2)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				s5 s = new s5();
				s.a(new ar7(a.g));
				s.a(new bt4("Climb_2"));
				s.IsAsync = false;
				s.a(true);
				array7[num7] = s;
				base.a(array7);
				btm[] array8 = new btm[1];
				int num8 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4("Climb_2"));
				kw2.a(false);
				array8[num8] = kw2;
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				egx egx3 = new egx();
				egx3.a("Напрягите свой разум и следуйте линиям \u0097 пересекающими! А острые углы - направляющими!");
				egx3.a(true);
				array9[num9] = new ace(egx3)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				egx egx4 = new egx();
				egx4.a("О-о-оооо, линии...");
				egx4.a(true);
				array10[num10] = new ace(egx4)
				{
					TargetRef = new ar7(a.g)
				};
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				egx egx5 = new egx();
				egx5.a("Там, наверху, они невидимы! Но если вы объедините свои чувства \u0097 это достижимо!");
				egx5.a(true);
				array11[num11] = new ace(egx5)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array11);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				btm[] array12 = new btm[1];
				int num12 = 0;
				egx egx6 = new egx();
				egx6.a("Я их вижу! Я ИХ ВИЖУ!");
				egx6.a(true);
				array12[num12] = new ace(egx6)
				{
					TargetRef = new ar7(a.g)
				};
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				c6w c6w = new c6w();
				c6w.a(new ar7(a.g));
				c6w.IsAsync = true;
				c6w.a = new Func<auv>(a.d);
				array13[num13] = c6w;
				base.a(array13);
				btm[] array14 = new btm[1];
				int num14 = 0;
				egx egx7 = new egx();
				egx7.a("Шаг вперёд! В этом и заключается Трансмерность! Сделайте шаг вперёд \u0097 и приготовьтесь...");
				egx7.a(true);
				array14[num14] = new ace(egx7)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array14);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				btm[] array15 = new btm[1];
				int num15 = 0;
				egx egx8 = new egx();
				egx8.a("...чтобы трансформироваться! Трансформироваться!");
				egx8.a(true);
				array15[num15] = new ace(egx8)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array15);
				btm[] array16 = new btm[1];
				int num16 = 0;
				c6w c6w2 = new c6w();
				c6w2.a(new ar7(a.b));
				c6w2.IsAsync = false;
				c6w2.a = new Func<auv>(a.c);
				array16[num16] = c6w2;
				base.a(array16);
				btm[] array17 = new btm[1];
				int num17 = 0;
				c6w c6w3 = new c6w();
				c6w3.a(new ar7(a.b));
				c6w3.IsAsync = true;
				c6w3.a = new Func<auv>(a.b);
				array17[num17] = c6w3;
				base.a(array17);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array18 = new btm[1];
				int num18 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.IsAsync = true;
				dva2.a(new Func<e6d, bool>(a.a));
				array18[num18] = dva2;
				base.a(array18);
				btm[] array19 = new btm[1];
				int num19 = 0;
				c6w c6w4 = new c6w();
				c6w4.a(new ar7(a.g));
				c6w4.IsAsync = false;
				c6w4.a = new Func<auv>(a.a);
				array19[num19] = c6w4;
				base.a(array19);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d), null, null, null)
				});
				btm[] array20 = new btm[1];
				int num20 = 0;
				kw kw3 = new kw();
				kw3.a(new bt4("medic_up2"));
				kw3.a(false);
				array20[num20] = kw3;
				base.a(array20);
				btm[] array21 = new btm[1];
				int num21 = 0;
				s5 s2 = new s5();
				s2.a(new ar7(a.e));
				s2.a(new bt4("medic_up2"));
				s2.IsAsync = false;
				s2.a(true);
				array21[num21] = s2;
				base.a(array21);
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Operating)))
					{
						TargetRef = new ar7(a.e)
					}
				});
				btm[] array22 = new btm[1];
				int num22 = 0;
				egx egx9 = new egx();
				egx9.a("Ещё один трансформированный...");
				egx9.a(true);
				array22[num22] = new ace(egx9)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array22);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array23 = new btm[1];
				int num23 = 0;
				egx egx10 = new egx();
				egx10.a("Поднимите. Всё дело сделано.");
				egx10.a(true);
				array23[num23] = new ace(egx10)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array23);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000CAB RID: 3243
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600492D RID: 18733 RVA: 0x001E0570 File Offset: 0x001DE770
		internal bool e(e6d A_0)
		{
			a0l.a(this.b, "Climb_2", true);
			a0l.a(this.b, "player_up", true);
			a0l.a(this.c, "zealot_1", true);
			a0l.a(this.d, "zealot_2", true);
			a0l.a(this.e, "medic_up1", true);
			a0l.a(this.f, "syn_up", true);
			a0l.a(this.g, "ritualist_up", true);
			return true;
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x001E05F8 File Offset: 0x001DE7F8
		internal bool f(e6d A_0)
		{
			this.a.aqu().r()["npc_lux_uwa_formedicatorMet"] = true;
			this.a.aqu().r()["npc_lux_lunaticSynesthete_startRitual"] = true;
			this.c.t.b.y6()["VigilanceSettings"] = new exw(d6n.a, 0.0, false, null);
			this.d.t.b.y6()["VigilanceSettings"] = new exw(d6n.a, 0.0, false, null);
			this.e.t.b.y6()["VigilanceSettings"] = new exw(d6n.a, 0.0, false, null);
			this.f.t.b.y6()["VigilanceSettings"] = new exw(d6n.a, 0.0, false, null);
			this.g.t.b.y6()["VigilanceSettings"] = new exw(d6n.a, 0.0, false, null);
			this.d.t.b.y6()[ddq.k] = "";
			this.e.t.b.y6()[ddq.k] = "";
			this.c.t.b.y6()[ddq.ay] = "zealot_1";
			this.d.t.b.y6()[ddq.ay] = "zealot_2";
			this.e.t.b.y6()[ddq.ay] = "medic_up1";
			this.f.t.b.y6()[ddq.ay] = "syn_up";
			this.g.t.b.y6()[ddq.ay] = "";
			List<b0b> list = this.a.aqw().a().ab4(new string[]
			{
				"lux-uwa_forceField"
			});
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				c5x.c().a("forceField", "ForceField", 1f, c9z.b, true, false);
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(0.0005);
				ad6 a_ = ad;
				c5x.Zone.ActionManager.g9(a_, atp.a);
			}
			ah7 ah = this.a.aqw().i("ForceWallLantern");
			if (ah != null)
			{
				ah.Enabled = true;
				ah.d();
			}
			list.Clear();
			return true;
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x001E0958 File Offset: 0x001DEB58
		internal auv d()
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new epw(new CharacterState?(CharacterState.Throw)), null, null, null);
			a4s.b(new ar7(this.g));
			list.Add(a4s);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new b16(new int?(2)), null, null, null);
			a4s2.b(new ar7(this.g));
			list2.Add(a4s2);
			for (int i = 0; i <= 20; i++)
			{
				if (i % 2 == 1)
				{
					List<auv> list3 = awx.ad();
					a4s a4s3 = new a4s(new b16(new int?(2)), null, null, null);
					a4s3.b(new ar7(this.g));
					list3.Add(a4s3);
				}
				else
				{
					List<auv> list4 = awx.ad();
					a4s a4s4 = new a4s(new b16(new int?(3)), null, null, null);
					a4s4.b(new ar7(this.g));
					list4.Add(a4s4);
				}
				awx.ad().Add(new bm3(400));
			}
			return awx;
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x001E0A6C File Offset: 0x001DEC6C
		internal auv c()
		{
			this.a.aqw().a();
			c5x c5x = new ar7(new Guid("05fe33af-352e-4b6e-afed-5d54f0a1756d"), this.b.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d6c9586d-75cf-45de-bf50-20f0325febc7"), this.b.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("1bee869f-3fa5-4d25-811a-65f086c5a51c"), this.b.Area).ao() as c5x;
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			if (c5x != null && c5x2 != null && c5x3 != null)
			{
				ah7 ah = this.a.aqw().i("ForceWallLantern");
				if (ah != null)
				{
					ah.Light = new ae8(ah.Light.d(), 0.45f, ah.Light.a());
					ah.LightFadeRate = 0.1f;
					ah.d();
				}
				ah7 ah2 = this.a.aqw().i("OculusFlash");
				if (ah2 != null)
				{
					ah2.Enabled = true;
					ah2.d();
				}
				List<auv> list = awx.ad();
				a4s a4s = new a4s(new bfq("OculusThunder"), null, null, null);
				a4s.b(new ar7(this.b));
				list.Add(a4s);
				new Vector3(this.b.Location.X, this.b.Location.Y, this.b.Location.Z - 0.6f);
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(0.3);
				ad6 item = ad;
				bm3 item2 = new bm3(35);
				awx.ad().Add(item);
				ad6 ad2 = new ad6(c5x3);
				ad2.b(0.0);
				ad2.c(1.0);
				ad2.a(0.5);
				item = ad2;
				awx.ad().Add(item);
				awx.ad().Add(item2);
				ad6 ad3 = new ad6(c5x2);
				ad3.b(0.0);
				ad3.c(1.0);
				ad3.a(0.3);
				item = ad3;
				awx.ad().Add(item);
				List<auv> list2 = awx.ad();
				a4s a4s2 = new a4s(new bfq("OculusThunder"), null, null, null);
				a4s2.b(new ar7(this.b));
				list2.Add(a4s2);
			}
			return awx;
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x001E0D24 File Offset: 0x001DEF24
		internal auv b()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("PlasmaHit"), null, null, null);
			a4s.b(new ar7(this.b));
			list.Add(a4s);
			Vector3 a_ = new Vector3(this.g.Location.X, this.g.Location.Y, this.g.Location.Z);
			awx.ad().Add(new au0(this.b.Area, a_, "ExplosionHE_O_Weak_Flame1", 1, double.MaxValue, new float?(0.9f), null, null));
			this.g.h.b.ao = new Color?(new Color(128, 64, 0, 255));
			return awx;
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x001E0E1C File Offset: 0x001DF01C
		internal bool a(e6d A_0)
		{
			this.a.aqw().a();
			c5x c5x = new ar7(new Guid("05fe33af-352e-4b6e-afed-5d54f0a1756d"), this.b.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d6c9586d-75cf-45de-bf50-20f0325febc7"), this.b.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("1bee869f-3fa5-4d25-811a-65f086c5a51c"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x2 != null && c5x3 != null)
			{
				c5x.ae = new float?(0f);
				c5x2.ae = new float?(0f);
				c5x3.ae = new float?(0f);
				ah7 ah = this.a.aqw().i("ForceWallLantern");
				if (ah != null)
				{
					ah.Light = new ae8(ah.Light.d(), 1f, ah.Light.a());
					ah.d();
				}
				ah7 ah2 = this.a.aqw().i("OculusFlash");
				if (ah2 != null)
				{
					ah2.Enabled = false;
					ah2.d();
				}
			}
			return true;
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x001E0F6C File Offset: 0x001DF16C
		internal auv a()
		{
			this.g.Size = new Vector3(0.1f, 0.1f, 0f);
			int num = 35;
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new epw(new CharacterState?(CharacterState.Die)), null, null, null);
			a4s.b(new ar7(this.g));
			list.Add(a4s);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new b16(new int?(1)), null, null, null);
			a4s2.b(new ar7(this.g));
			list2.Add(a4s2);
			awx.ad().Add(new a8v(this.g, new Vector3(12.5430565f, 11.184723f, 4f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(12.806944f, 11.0875f, 4f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(12.723612f, 10.643056f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new au0(this.g.Area, new Vector3(13.181946f, 10.740276f, 3.5f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			awx.ad().Add(new a8v(this.g, new Vector3(13.181946f, 10.740276f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(13.695833f, 10.976389f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(14.154167f, 11.101388f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(15.147223f, 11.441666f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new au0(this.g.Area, new Vector3(15.598613f, 11.601389f, 3.5f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			awx.ad().Add(new a8v(this.g, new Vector3(15.598613f, 11.601389f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(16.084724f, 11.754166f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(16.501389f, 11.920833f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(17.043056f, 12.212499f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(17.26528f, 12.268055f, 3.5f)));
			List<auv> list3 = awx.ad();
			a4s a4s3 = new a4s(new b16(new int?(2)), null, null, null);
			a4s3.b(new ar7(this.g));
			list3.Add(a4s3);
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(17.806946f, 12.615277f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new au0(this.g.Area, new Vector3(18.404167f, 12.990277f, 3.5f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			awx.ad().Add(new a8v(this.g, new Vector3(18.404167f, 12.990277f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(18.931942f, 13.3236f, 3.5f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(16.702782f, 10.941668f, 1f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(17.209724f, 11.240278f, 1f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(16.86111f, 10.916667f, 0.55f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(17f, 11f, 0.2f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.g, new Vector3(17f, 11f, 0f)));
			List<auv> list4 = awx.ad();
			a4s a4s4 = new a4s(new bfq("body", "HumanDie"), null, null, null);
			a4s4.b(new ar7(this.b));
			list4.Add(a4s4);
			awx.ad().Add(new au0(this.b.Area, new Vector3(17f, 11f, 0f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			List<auv> list5 = awx.ad();
			a4s a4s5 = new a4s(new bfq("rocks", "QuietRockCrash"), null, null, null);
			a4s5.b(new ar7(this.b));
			list5.Add(a4s5);
			List<auv> list6 = awx.ad();
			a4s a4s6 = new a4s(new b16(new int?(3)), null, null, null);
			a4s6.b(new ar7(this.g));
			list6.Add(a4s6);
			awx.ad().Add(new bm3(num - 10));
			List<auv> list7 = awx.ad();
			a4s a4s7 = new a4s(new b16(new int?(4)), null, null, null);
			a4s7.b(new ar7(this.g));
			list7.Add(a4s7);
			awx.ad().Add(new bm3(num - 10));
			List<auv> list8 = awx.ad();
			a4s a4s8 = new a4s(new b16(new int?(5)), null, null, null);
			a4s8.b(new ar7(this.g));
			list8.Add(a4s8);
			awx.ad().Add(new bm3(num - 10));
			List<auv> list9 = awx.ad();
			a4s a4s9 = new a4s(new b16(new int?(6)), null, null, null);
			a4s9.b(new ar7(this.g));
			list9.Add(a4s9);
			awx.ad().Add(new bm3(num - 10));
			List<auv> list10 = awx.ad();
			a4s a4s10 = new a4s(new b16(new int?(7)), null, null, null);
			a4s10.b(new ar7(this.g));
			list10.Add(a4s10);
			return awx;
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x001E17D0 File Offset: 0x001DF9D0
		internal bool d(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("580c1c49-b9a9-432a-881a-0a0fb3cd3abd"), this.b.Area).ao() as c5x;
			if (c5x != null)
			{
				this.g.w();
				this.g.an();
				c5x.s.b.g(true);
				c5x.ae = new float?((float)1);
				c5x c5x2 = new ar7(new Guid("53e85130-0ad5-44b4-aae0-e2fbcaf992ce"), this.b.Area).ao() as c5x;
				if (c5x2 != null && c5x2.s != null)
				{
					c5x2.s.b.g(true);
				}
				foreach (b0b b0b in this.a.aqw().a().ab4(new string[]
				{
					"lux-uwa_usables"
				}))
				{
					c5x c5x3 = (c5x)b0b;
					if (c5x3.s != null)
					{
						ad6 ad = new ad6(c5x3);
						ad.b(0.0);
						ad.c(1.0);
						ad.a(0.0005);
						ad6 a_ = ad;
						c5x3.Zone.ActionManager.g9(a_, atp.a);
						bb2 bb = c5x3.GetAspect<bim>() as bb2;
						if (bb != null)
						{
							bb.a(true);
						}
					}
				}
				c5x c5x4 = new ar7(new Guid("07823e37-6686-46bf-addb-4b85311ed77f"), this.b.Area).ao() as c5x;
				if (c5x4 != null && c5x4.s != null)
				{
					ad6 ad2 = new ad6(c5x4);
					ad2.b(0.0);
					ad2.c(1.0);
					ad2.a(0.0005);
					ad6 a_2 = ad2;
					c5x4.Zone.ActionManager.g9(a_2, atp.a);
					bb2 bb2 = c5x4.GetAspect<bim>() as bb2;
					if (bb2 != null)
					{
						bb2.a(true);
					}
				}
			}
			return true;
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x001E1A00 File Offset: 0x001DFC00
		internal bool c(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.f.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x001E1A30 File Offset: 0x001DFC30
		internal bool b(e6d A_0)
		{
			this.f.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x04001CEE RID: 7406
		public cnk a;

		// Token: 0x04001CEF RID: 7407
		public c5x b;

		// Token: 0x04001CF0 RID: 7408
		public c5x c;

		// Token: 0x04001CF1 RID: 7409
		public c5x d;

		// Token: 0x04001CF2 RID: 7410
		public c5x e;

		// Token: 0x04001CF3 RID: 7411
		public c5x f;

		// Token: 0x04001CF4 RID: 7412
		public c5x g;
	}
}
