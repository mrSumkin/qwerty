using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D42 RID: 3394
[e79("Xpbl_Pir_FlingerThrowOff")]
public sealed class bhs : dgy
{
	// Token: 0x06004A96 RID: 19094 RVA: 0x001FBAF4 File Offset: 0x001F9CF4
	public bhs()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bhs.a a = new bhs.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("ddcf0026-3691-4d73-b3df-ed96068b2654"), a.a.Area).ao() as c5x);
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_pir_flinger_charonsBet", new int?(0)).Value;
				bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_flinger_playerWonThrowOff", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_flinger_throwOff_loseIntentionally", new bool?(false)).Value;
				double value3 = 0.15;
				string a_ = null;
				string a_2 = null;
				if (a.b != null)
				{
					if (a.b.h.b != null)
					{
						int num = a.a.h.b.aa().Skills.Get<dei>().g();
						if (num < 20 || value2)
						{
							a_ = "Это... это шутка? Ты можете даже попасть дьявольскую доску!";
							a_2 = "Ха! Можете поверить, как жёстко вы отсосёте! Уха-ха-ха!";
							serviceOrThrow.aqu().r()["npc_xpbl_pir_flinger_playersThrowingSkill"] = 1;
						}
						else if (num >= 20 && num < 60)
						{
							a_ = "Ну, вы можете бросить клинок.";
							a_2 = "Мех.";
							serviceOrThrow.aqu().r()["npc_xpbl_pir_flinger_playersThrowingSkill"] = 2;
						}
						else if (num >= 60 && num < 100)
						{
							a_ = "Неплохо, неплохо...";
							a_2 = "Плохо, но это достаточно хорошо, банга.";
							serviceOrThrow.aqu().r()["npc_xpbl_pir_flinger_playersThrowingSkill"] = 3;
						}
						else if (num >= 100 && num <= 130)
						{
							a_ = "Да... всё нормально.";
							a_2 = "Хорошо. Но не достаточно, банга.";
							serviceOrThrow.aqu().r()["npc_xpbl_pir_flinger_playersThrowingSkill"] = 4;
						}
						else
						{
							a_ = "Ух ты, уе, ух ты... приобретены навыки.";
							a_2 = "Что за?!";
							flag = true;
							serviceOrThrow.aqu().r()["npc_xpbl_pir_flinger_playerWonThrowOff"] = true;
						}
						if (flag)
						{
							a.a.h.b.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<a54>("currency\\StygianCoin"))
							{
								Stacks = value
							}, true);
							a.b.h.b.aa().Bag.a("currency.sc", value);
						}
						else
						{
							a.a.h.b.aa().Bag.a("currency.sc", value);
							a.b.h.b.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<a54>("currency\\StygianCoin"))
							{
								Stacks = value
							}, true);
						}
					}
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("throwOff_thrower"));
					array[num2] = kw;
					base.a(array);
					btm[] array2 = new btm[1];
					int num3 = 0;
					s5 s = new s5();
					s.a(new ar7(a.b));
					s.a(new bt4("throwOff_thrower"));
					s.IsAsync = true;
					s.a(true);
					array2[num3] = s;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array3 = new btm[1];
					int num4 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.a));
					s2.a(new bt4("throwOff_observer"));
					s2.IsAsync = true;
					s2.a(true);
					array3[num4] = s2;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num5 = 0;
					egx egx = new egx();
					egx.a("Стой' и жди', банга.");
					array4[num5] = new ace(egx)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						this.a(a.b)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.b, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						this.a(a.b)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.b, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						this.a(a.b)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.b, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array5 = new btm[1];
					int num6 = 0;
					egx egx2 = new egx();
					egx2.a("Подойдите.");
					array5[num6] = new ace(egx2)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array5);
					btm[] array6 = new btm[1];
					int num7 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(a.b));
					s3.a(new bt4("throwOff_transit"));
					s3.IsAsync = false;
					s3.a(true);
					array6[num7] = s3;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array7 = new btm[1];
					int num8 = 0;
					s5 s4 = new s5();
					s4.a(new ar7(a.a));
					s4.a(new bt4("throwOff_thrower"));
					s4.IsAsync = false;
					s4.a(true);
					array7[num8] = s4;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array8 = new btm[1];
					int num9 = 0;
					s5 s5 = new s5();
					s5.a(new ar7(a.b));
					s5.a(new bt4("throwOff_observer"));
					s5.IsAsync = false;
					s5.a(true);
					array8[num9] = s5;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						this.a(a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.a, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						this.a(a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.a, a.a)
					});
					btm[] array9 = new btm[1];
					int num10 = 0;
					egx egx3 = new egx();
					egx3.a(a_);
					array9[num10] = new ace(egx3)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						this.a(a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.a, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array10 = new btm[1];
					int num11 = 0;
					egx egx4 = new egx();
					egx4.a("Отойдите.");
					array10[num11] = new ace(egx4)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array10);
					btm[] array11 = new btm[1];
					int num12 = 0;
					s5 s6 = new s5();
					s6.a(new ar7(a.a));
					s6.a(new bt4("throwOff_transit"));
					s6.IsAsync = false;
					s6.a(true);
					array11[num12] = s6;
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array12 = new btm[1];
					int num13 = 0;
					s5 s7 = new s5();
					s7.a(new ar7(a.b));
					s7.a(new bt4("throwOff_thrower"));
					s7.IsAsync = false;
					s7.a(true);
					array12[num13] = s7;
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array13 = new btm[1];
					int num14 = 0;
					s5 s8 = new s5();
					s8.a(new ar7(a.a));
					s8.a(new bt4("throwOff_observer"));
					s8.IsAsync = false;
					s8.a(true);
					array13[num14] = s8;
					base.a(array13);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						this.a(a.b)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.b, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						this.a(a.b)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.b, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						this.a(a.b)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.b, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array14 = new btm[1];
					int num15 = 0;
					egx egx5 = new egx();
					egx5.a("Как насчёт этого, а?");
					array14[num15] = new ace(egx5)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array14);
					btm[] array15 = new btm[1];
					int num16 = 0;
					s5 s9 = new s5();
					s9.a(new ar7(a.b));
					s9.a(new bt4("throwOff_transit"));
					s9.IsAsync = false;
					s9.a(true);
					array15[num16] = s9;
					base.a(array15);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array16 = new btm[1];
					int num17 = 0;
					s5 s10 = new s5();
					s10.a(new ar7(a.a));
					s10.a(new bt4("throwOff_thrower"));
					s10.IsAsync = false;
					s10.a(true);
					array16[num17] = s10;
					base.a(array16);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array17 = new btm[1];
					int num18 = 0;
					s5 s11 = new s5();
					s11.a(new ar7(a.b));
					s11.a(new bt4("throwOff_observer"));
					s11.IsAsync = false;
					s11.a(true);
					array17[num18] = s11;
					base.a(array17);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						this.a(a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.a, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						this.a(a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.a, a.a)
					});
					btm[] array18 = new btm[1];
					int num19 = 0;
					egx egx6 = new egx();
					egx6.a(a_2);
					array18[num19] = new ace(egx6)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array18);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						this.a(a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(value3))
					});
					base.a(new btm[]
					{
						this.a(a.a, a.a)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					if (flag)
					{
						btm[] array19 = new btm[1];
						int num20 = 0;
						egx egx7 = new egx();
						egx7.a("Нет, нет, нет. Это была прост' удача. Ещё один раунд.");
						array19[num20] = new ace(egx7)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array19);
						btm[] array20 = new btm[1];
						int num21 = 0;
						s5 s12 = new s5();
						s12.a(new ar7(a.a));
						s12.a(new bt4("throwOff_transit"));
						s12.IsAsync = false;
						s12.a(true);
						array20[num21] = s12;
						base.a(array20);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.3))
						});
						btm[] array21 = new btm[1];
						int num22 = 0;
						s5 s13 = new s5();
						s13.a(new ar7(a.b));
						s13.a(new bt4("throwOff_thrower"));
						s13.IsAsync = false;
						s13.a(true);
						array21[num22] = s13;
						base.a(array21);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.3))
						});
						btm[] array22 = new btm[1];
						int num23 = 0;
						s5 s14 = new s5();
						s14.a(new ar7(a.a));
						s14.a(new bt4("throwOff_observer"));
						s14.IsAsync = false;
						s14.a(true);
						array22[num23] = s14;
						base.a(array22);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							this.a(a.b)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(value3))
						});
						base.a(new btm[]
						{
							this.a(a.b, a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							this.a(a.b)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(value3))
						});
						base.a(new btm[]
						{
							this.a(a.b, a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							this.a(a.b)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(value3))
						});
						base.a(new btm[]
						{
							this.a(a.b, a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
						btm[] array23 = new btm[1];
						int num24 = 0;
						egx egx8 = new egx();
						egx8.a("Вы видели это, а? ТАКТ, ЧТО!");
						array23[num24] = new ace(egx8)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array23);
						btm[] array24 = new btm[1];
						int num25 = 0;
						s5 s15 = new s5();
						s15.a(new ar7(a.b));
						s15.a(new bt4("throwOff_transit"));
						s15.IsAsync = false;
						s15.a(true);
						array24[num25] = s15;
						base.a(array24);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.3))
						});
						btm[] array25 = new btm[1];
						int num26 = 0;
						s5 s16 = new s5();
						s16.a(new ar7(a.a));
						s16.a(new bt4("throwOff_thrower"));
						s16.IsAsync = false;
						s16.a(true);
						array25[num26] = s16;
						base.a(array25);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.3))
						});
						btm[] array26 = new btm[1];
						int num27 = 0;
						s5 s17 = new s5();
						s17.a(new ar7(a.b));
						s17.a(new bt4("throwOff_observer"));
						s17.IsAsync = false;
						s17.a(true);
						array26[num27] = s17;
						base.a(array26);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
						base.a(new btm[]
						{
							this.a(a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(value3))
						});
						base.a(new btm[]
						{
							this.a(a.a, a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							this.a(a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(value3))
						});
						base.a(new btm[]
						{
							this.a(a.a, a.a)
						});
						btm[] array27 = new btm[1];
						int num28 = 0;
						egx egx9 = new egx();
						egx9.a("Нет... НЕТ! НЕ-Е-ЕТ!");
						array27[num28] = new ace(egx9)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array27);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							this.a(a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(value3))
						});
						base.a(new btm[]
						{
							this.a(a.a, a.a)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
					}
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x06004A97 RID: 19095 RVA: 0x001FCFCC File Offset: 0x001FB1CC
	private bb8 a(c5x A_0)
	{
		bb8 bb = new bb8();
		bb.a(CharacterState.Throw);
		bb.a(atp.a);
		bb.IsAsync = true;
		bb.a(new ar7(A_0));
		bb.b(1);
		bb.a(100);
		return bb;
	}

	// Token: 0x06004A98 RID: 19096 RVA: 0x001FD010 File Offset: 0x001FB210
	private c6w a(c5x A_0, c5x A_1)
	{
		bhs.b b = new bhs.b();
		b.a = A_1;
		c6w c6w = new c6w();
		c6w.a = new Func<auv>(b.a);
		c6w.a(new ar7(A_0));
		return c6w;
	}

	// Token: 0x02000D43 RID: 3395
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A9A RID: 19098 RVA: 0x001FD05C File Offset: 0x001FB25C
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001DD2 RID: 7634
		public c5x a;

		// Token: 0x04001DD3 RID: 7635
		public c5x b;
	}

	// Token: 0x02000D44 RID: 3396
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A9C RID: 19100 RVA: 0x001FD098 File Offset: 0x001FB298
		internal auv a()
		{
			dtb dtb = new dtb();
			dtb.ad().Add(new a4s(new bfq("KnifeThrow"), null, new ar7(this.a), null));
			b0b a_;
			dtb.ad().Add(es2.a(new Vector3(6f, 7f, 1.45f), new Vector3(0.65f, 7f, 1.45f), this.a.Area, "ThrowingKnife", null, out a_));
			dtb.ad().Add(new a4s(new bfq("LeatherHit"), null, new ar7(this.a), null));
			dtb.ad().Add(new c7(a_, false, false, true, false));
			return dtb;
		}

		// Token: 0x04001DD4 RID: 7636
		public c5x a;
	}
}
