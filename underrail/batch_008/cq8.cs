using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000F03 RID: 3843
[e79("Xphw_ExoBase_Trg2_VoidBattle")]
public sealed class cq8 : dgy
{
	// Token: 0x06004E9C RID: 20124 RVA: 0x00233330 File Offset: 0x00231530
	public cq8()
	{
		cq8.h h = new cq8.h();
		h.a = bpo.GetServiceOrThrow<cnk>();
		if (h.a != null && h.a.aqu() != null)
		{
			h.b = (h.a.aqu().v().b() as c5x);
			h.d = h.a.aqw().a();
			h.c = new aow();
			if (h.b != null && h.a != null)
			{
				cq8.i i = new cq8.i();
				i.d = h;
				i.c = i.d.b.Location;
				i.a = DateTime.Now + TimeSpan.FromSeconds(10.0);
				i.b = (new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), i.d.b.Area).ao() as c5x);
				if (i.b != null)
				{
					cq8.g g = new cq8.g();
					g.b = i;
					base.a(new btm[]
					{
						new c6w(new Func<auv>(g.b.d.a))
					});
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(new Func<e6d, bool>(g.b.a), null, null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					g.a = g.b.b.GetAspect<a3f>();
					int j = 1;
					string text = "";
					while (j < 5)
					{
						switch (j)
						{
						case 1:
							text = "north";
							break;
						case 2:
							text = "east";
							break;
						case 3:
							text = "south";
							break;
						case 4:
							text = "west";
							break;
						}
						if ((int)g.a.a()[text] < 4)
						{
							if (g.b.b.a("killSpecialSquad") && text.Equals("north"))
							{
								e3l aspect = g.b.b.GetAspect<e3l>();
								if (aspect != null)
								{
									aspect.a.Remove("killSpecialSquad");
									aspect.a.Remove("specialSquadAlive");
									aspect.a();
									g.b.b.b("specialSquadDead");
								}
								List<b0b> list = g.b.d.a.aqw().a().ab4(new string[]
								{
									"special"
								});
								btm[] array = new btm[1];
								int num = 0;
								kw kw = new kw();
								kw.a(new bt4("Camnorth_1"));
								kw.a(false);
								kw.a(new float?(9f));
								kw.b(true);
								array[num] = kw;
								base.a(array);
								base.a(new btm[]
								{
									new os(TimeSpan.FromSeconds(1.0))
								});
								int num2 = 0;
								using (List<b0b>.Enumerator enumerator = list.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										cq8.d d = new cq8.d();
										d.b = g;
										d.a = (c5x)enumerator.Current;
										num2++;
										if (num2 == 1)
										{
											btm[] array2 = new btm[1];
											int num3 = 0;
											egx egx = new egx();
											egx.a("Наша смерть... не будет напрасной...");
											array2[num3] = new ace(egx)
											{
												TargetRef = new ar7(d.a)
											};
											base.a(array2);
										}
										if (num2 == 2)
										{
											btm[] array3 = new btm[1];
											int num4 = 0;
											egx egx2 = new egx();
											egx2.a("Мы потерпели неудачу...");
											array3[num4] = new ace(egx2)
											{
												TargetRef = new ar7(d.a)
											};
											base.a(array3);
										}
										else if (num2 == 4)
										{
											btm[] array4 = new btm[1];
											int num5 = 0;
											egx egx3 = new egx();
											egx3.a("::Захлёбывается кровью.::");
											array4[num5] = new ace(egx3)
											{
												TargetRef = new ar7(d.a)
											};
											base.a(array4);
										}
										btm[] array5 = new btm[1];
										int num6 = 0;
										bb8 bb = new bb8();
										bb.a(CharacterState.Stunned);
										bb.a(atp.a);
										bb.IsAsync = true;
										bb.a(new ar7(d.a));
										bb.b(0);
										array5[num6] = bb;
										base.a(array5);
										btm[] array6 = new btm[1];
										int num7 = 0;
										dva dva = new dva(null, null, null, null, null);
										dva.a(new Func<e6d, bool>(d.a));
										array6[num7] = dva;
										base.a(array6);
									}
								}
								base.a(new btm[]
								{
									new os(TimeSpan.FromSeconds(3.0))
								});
							}
							else if (g.b.b.a("specialSquadAlive") && text.Equals("north"))
							{
								int num8 = 25;
								List<b0b> list2 = g.b.d.a.aqw().a().ab4(new string[]
								{
									"special"
								});
								btm[] array7 = new btm[1];
								int num9 = 0;
								kw kw2 = new kw();
								kw2.a(new bt4("Camnorth_1"));
								kw2.a(false);
								kw2.b(true);
								array7[num9] = kw2;
								base.a(array7);
								base.a(new btm[]
								{
									new os(TimeSpan.FromSeconds(1.0))
								});
								foreach (b0b b0b in list2)
								{
									c5x a_ = (c5x)b0b;
									btm[] array8 = new btm[1];
									int num10 = 0;
									bb8 bb2 = new bb8();
									bb2.a(CharacterState.ChannelPsi);
									bb2.a(atp.a);
									bb2.IsAsync = true;
									bb2.a(new ar7(a_));
									bb2.b(3);
									array8[num10] = bb2;
									base.a(array8);
									if (cuo.a.Next(0, 101) < num8)
									{
										num8 = -5000;
										btm[] array9 = new btm[1];
										int num11 = 0;
										egx egx4 = new egx();
										egx4.a("Линия фронта под защитой.");
										array9[num11] = new ace(egx4)
										{
											TargetRef = new ar7(a_)
										};
										base.a(array9);
									}
									else
									{
										num8 += 25;
									}
								}
								base.a(new btm[]
								{
									new os(TimeSpan.FromSeconds(3.0))
								});
							}
							else
							{
								btm[] array10 = new btm[1];
								int num12 = 0;
								kw kw3 = new kw();
								kw3.a(new bt4("Cam" + text + "_" + ((int)g.a.a()[text]).ToString()));
								kw3.a(new float?(9f));
								kw3.a(false);
								kw3.b(true);
								array10[num12] = kw3;
								base.a(array10);
								List<b0b> list3 = g.b.d.a.aqw().a().ab4(new string[]
								{
									"voidFighter"
								});
								List<c5x> list4 = new List<c5x>();
								foreach (b0b b0b2 in list3)
								{
									c5x c5x = (c5x)b0b2;
									if (c5x.GetAspect<a3f>().a()["position"].Equals(text))
									{
										list4.Add(c5x);
									}
								}
								if (g.b.b.a("victory" + text))
								{
									using (List<c5x>.Enumerator enumerator2 = list4.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											cq8.b b = new cq8.b();
											b.b = g;
											b.a = enumerator2.Current;
											if (b.a.a("sol"))
											{
												btm[] array11 = new btm[1];
												int num13 = 0;
												bb8 bb3 = new bb8();
												bb3.a(CharacterState.Attack1);
												bb3.a(atp.a);
												bb3.IsAsync = true;
												bb3.a(new ar7(b.a));
												bb3.b(3);
												array11[num13] = bb3;
												base.a(array11);
												btm[] array12 = new btm[1];
												int num14 = 0;
												dva dva2 = new dva(null, null, null, null, null);
												dva2.a(new Func<e6d, bool>(b.a));
												array12[num14] = dva2;
												base.a(array12);
											}
											if (b.a.a("med"))
											{
												btm[] array13 = new btm[1];
												int num15 = 0;
												bb8 bb4 = new bb8();
												bb4.a(CharacterState.Operating);
												bb4.a(atp.a);
												bb4.IsAsync = true;
												bb4.a(new ar7(b.a));
												bb4.b(3);
												array13[num15] = bb4;
												base.a(array13);
												btm[] array14 = new btm[1];
												int num16 = 0;
												dva dva3 = new dva(null, null, null, null, null);
												dva3.a(new Func<e6d, bool>(b.c));
												array14[num16] = dva3;
												base.a(array14);
											}
											if (b.a.a("int"))
											{
												btm[] array15 = new btm[1];
												int num17 = 0;
												bb8 bb5 = new bb8();
												bb5.a(CharacterState.ChannelPsi);
												bb5.a(atp.a);
												bb5.IsAsync = true;
												bb5.a(new ar7(b.a));
												bb5.b(3);
												array15[num17] = bb5;
												base.a(array15);
												btm[] array16 = new btm[1];
												int num18 = 0;
												dva dva4 = new dva(null, null, null, null, null);
												dva4.a(new Func<e6d, bool>(b.b));
												array16[num18] = dva4;
												base.a(array16);
											}
										}
									}
									if (g.b.b.a(text + "ShouldAttack"))
									{
										cq8.c c = new cq8.c();
										c.b = g;
										c.a = text;
										base.a(new btm[]
										{
											new os(TimeSpan.FromSeconds(2.0))
										});
										if ((int)c.b.a.a()[c.a] + 1 <= 3)
										{
											btm[] array17 = new btm[1];
											int num19 = 0;
											egx egx5 = new egx();
											egx5.a("Вперёд!");
											array17[num19] = new ace(egx5)
											{
												TargetRef = new ar7(Enumerable.FirstOrDefault<c5x>(list4))
											};
											base.a(array17);
											btm[] array18 = new btm[1];
											int num20 = 0;
											kw kw4 = new kw();
											kw4.a(new bt4("Cam" + c.a + "_" + ((int)c.b.a.a()[c.a] + 1).ToString()));
											kw4.a(false);
											kw4.a(new float?(9f));
											kw4.b(true);
											array18[num20] = kw4;
											base.a(array18);
										}
										else if ((int)c.b.a.a()[c.a] + 1 == 4)
										{
											btm[] array19 = new btm[1];
											int num21 = 0;
											egx egx6 = new egx();
											egx6.a("Задача выполнена! Возвращаемся на исходные позиции!");
											array19[num21] = new ace(egx6)
											{
												TargetRef = new ar7(Enumerable.FirstOrDefault<c5x>(list4))
											};
											base.a(array19);
											btm[] array20 = new btm[1];
											int num22 = 0;
											kw kw5 = new kw();
											kw5.a(new bt4(c.a + "BrazierCam"));
											kw5.a(false);
											kw5.a(new float?(9f));
											kw5.b(true);
											array20[num22] = kw5;
											base.a(array20);
											base.a(new btm[]
											{
												new os(TimeSpan.FromSeconds(1.5))
											});
										}
										btm[] array21 = new btm[1];
										int num23 = 0;
										dva dva5 = new dva(null, null, null, null, null);
										dva5.a(new Func<e6d, bool>(c.b));
										array21[num23] = dva5;
										base.a(array21);
										if ((int)c.b.a.a()[c.a] + 1 == 4)
										{
											base.a(new btm[]
											{
												new os(TimeSpan.FromSeconds(3.0))
											});
											btm[] array22 = new btm[1];
											int num24 = 0;
											kw kw6 = new kw();
											kw6.a(new bt4("cmd2"));
											kw6.a(false);
											kw6.a(new float?(9f));
											kw6.b(true);
											array22[num24] = kw6;
											base.a(array22);
										}
										base.a(new btm[]
										{
											new os(TimeSpan.FromSeconds(0.5))
										});
										btm[] array23 = new btm[1];
										int num25 = 0;
										dva dva6 = new dva(null, null, null, null, null);
										dva6.a(new Func<e6d, bool>(c.a));
										array23[num25] = dva6;
										base.a(array23);
									}
									base.a(new btm[]
									{
										new os(TimeSpan.FromSeconds(1.0))
									});
								}
								else if (g.b.b.a("defeat" + text))
								{
									using (List<c5x>.Enumerator enumerator2 = list4.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											cq8.f f = new cq8.f();
											f.b = g;
											f.a = enumerator2.Current;
											if (f.a != null)
											{
												if (f.a.a("sol"))
												{
													btm[] array24 = new btm[1];
													int num26 = 0;
													bb8 bb6 = new bb8();
													bb6.a(CharacterState.Attack1);
													bb6.a(atp.a);
													bb6.IsAsync = true;
													bb6.a(new ar7(f.a));
													bb6.b(3);
													array24[num26] = bb6;
													base.a(array24);
													btm[] array25 = new btm[1];
													int num27 = 0;
													dva dva7 = new dva(null, null, null, null, null);
													dva7.a(new Func<e6d, bool>(f.b));
													array25[num27] = dva7;
													base.a(array25);
												}
												if (f.a.a("med"))
												{
													btm[] array26 = new btm[1];
													int num28 = 0;
													bb8 bb7 = new bb8();
													bb7.a(CharacterState.Stunned);
													bb7.a(atp.a);
													bb7.IsAsync = true;
													bb7.a(new ar7(f.a));
													bb7.b(3);
													array26[num28] = bb7;
													base.a(array26);
													btm[] array27 = new btm[1];
													int num29 = 0;
													dva dva8 = new dva(null, null, null, null, null);
													dva8.a(new Func<e6d, bool>(f.a));
													array27[num29] = dva8;
													base.a(array27);
												}
												if (f.a.a("int"))
												{
													btm[] array28 = new btm[1];
													int num30 = 0;
													bb8 bb8 = new bb8();
													bb8.a(CharacterState.Stunned);
													bb8.a(atp.a);
													bb8.IsAsync = true;
													bb8.a(new ar7(f.a));
													bb8.b(3);
													array28[num30] = bb8;
													base.a(array28);
													btm[] array29 = new btm[1];
													int num31 = 0;
													dva dva9 = new dva(null, null, null, null, null);
													dva9.a(new Func<e6d, bool>(f.c));
													array29[num31] = dva9;
													base.a(array29);
												}
											}
										}
									}
									base.a(new btm[]
									{
										new os(TimeSpan.FromSeconds(2.0))
									});
								}
								using (List<c5x>.Enumerator enumerator2 = list4.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										cq8.e e = new cq8.e();
										e.b = g;
										e.a = enumerator2.Current;
										if (e.a != null && e.a.a("MarkedForDeath"))
										{
											btm[] array30 = new btm[1];
											int num32 = 0;
											bb8 bb9 = new bb8();
											bb9.a(CharacterState.Stunned);
											bb9.a(atp.a);
											bb9.IsAsync = true;
											bb9.a(new ar7(e.a));
											bb9.b(0);
											array30[num32] = bb9;
											base.a(array30);
											btm[] array31 = new btm[1];
											int num33 = 0;
											dva dva10 = new dva(null, null, null, null, null);
											dva10.a(new Func<e6d, bool>(e.a));
											array31[num33] = dva10;
											base.a(array31);
										}
									}
								}
								base.a(new btm[]
								{
									new os(TimeSpan.FromSeconds(2.0))
								});
							}
						}
						j++;
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array32 = new btm[1];
					int num34 = 0;
					kw kw7 = new kw();
					kw7.a(new bt4("cmd2"));
					kw7.a(false);
					kw7.a(new float?(10f));
					kw7.b(true);
					array32[num34] = kw7;
					base.a(array32);
					using (List<b0b>.Enumerator enumerator = g.b.d.a.aqw().a().ab4(new string[]
					{
						"voidFighter"
					}).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							cq8.a a = new cq8.a();
							a.b = g;
							a.a = (c5x)enumerator.Current;
							if (a.a != null && a.a.a("MarkedForDeath"))
							{
								btm[] array33 = new btm[1];
								int num35 = 0;
								bb8 bb10 = new bb8();
								bb10.a(CharacterState.Stunned);
								bb10.a(atp.a);
								bb10.IsAsync = true;
								bb10.a(new ar7(a.a));
								bb10.b(0);
								array33[num35] = bb10;
								base.a(array33);
								btm[] array34 = new btm[1];
								int num36 = 0;
								dva dva11 = new dva(null, null, null, null, null);
								dva11.a(new Func<e6d, bool>(a.a));
								array34[num36] = dva11;
								base.a(array34);
							}
						}
					}
					btm[] array35 = new btm[1];
					int num37 = 0;
					dva dva12 = new dva(null, null, null, null, null);
					dva12.a(new Func<e6d, bool>(g.a));
					array35[num37] = dva12;
					base.a(array35);
					btm[] array36 = new btm[1];
					int num38 = 0;
					dva dva13 = new dva(null, null, null, null, null);
					dva13.a(new Func<e6d, bool>(g.b.b));
					array36[num38] = dva13;
					base.a(array36);
					base.a(new btm[]
					{
						new c6w(new Func<auv>(g.b.d.b))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000F04 RID: 3844
	[CompilerGenerated]
	private sealed class h
	{
		// Token: 0x06004E9E RID: 20126 RVA: 0x00234600 File Offset: 0x00232800
		internal auv a()
		{
			ad6 ad = new ad6(this.b);
			ad.b(1.0);
			ad.c(0.0);
			ad.a(0.009999999776482582);
			return ad;
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x0023463C File Offset: 0x0023283C
		internal auv b()
		{
			ad6 ad = new ad6(this.b);
			ad.b(0.0);
			ad.c(1.0);
			ad.a(0.009999999776482582);
			return ad;
		}

		// Token: 0x0400201E RID: 8222
		public cnk a;

		// Token: 0x0400201F RID: 8223
		public c5x b;

		// Token: 0x04002020 RID: 8224
		public aow c;

		// Token: 0x04002021 RID: 8225
		public d60 d;
	}

	// Token: 0x02000F05 RID: 3845
	[CompilerGenerated]
	private sealed class i
	{
		// Token: 0x06004EA1 RID: 20129 RVA: 0x00234680 File Offset: 0x00232880
		internal bool a(e6d A_0)
		{
			if (DateTime.Now > this.a)
			{
				return true;
			}
			d02 service = bpo.GetService<d02>();
			return service == null || !service.ahd();
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x002346C0 File Offset: 0x002328C0
		internal bool b(e6d A_0)
		{
			this.d.b.Location = this.c;
			this.d.b.ah();
			return true;
		}

		// Token: 0x04002022 RID: 8226
		public DateTime a;

		// Token: 0x04002023 RID: 8227
		public c5x b;

		// Token: 0x04002024 RID: 8228
		public Vector3 c;

		// Token: 0x04002025 RID: 8229
		public cq8.h d;
	}

	// Token: 0x02000F06 RID: 3846
	[CompilerGenerated]
	private new sealed class g
	{
		// Token: 0x06004EA4 RID: 20132 RVA: 0x002346F8 File Offset: 0x002328F8
		internal bool a(e6d A_0)
		{
			this.b.d.c.e(this.b.b);
			this.b.d.c.c();
			if ((int)this.a.a()["north"] > 3 && (int)this.a.a()["east"] > 3 && (int)this.a.a()["south"] > 3 && (int)this.a.a()["west"] > 3)
			{
				this.b.d.a.aqu().r()["loc_xphw_exobase_finalVictory"] = true;
				c5x c5x = this.b.d.d.ab5("pool") as c5x;
				if (c5x != null && c5x.o.b != null)
				{
					c5x.o.b.b.X = 1;
				}
			}
			return true;
		}

		// Token: 0x04002026 RID: 8230
		public a3f a;

		// Token: 0x04002027 RID: 8231
		public cq8.i b;
	}

	// Token: 0x02000F07 RID: 3847
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004EA6 RID: 20134 RVA: 0x0023483C File Offset: 0x00232A3C
		internal bool a(e6d A_0)
		{
			this.b.b.d.c.b(this.a, true);
			return true;
		}

		// Token: 0x04002028 RID: 8232
		public c5x a;

		// Token: 0x04002029 RID: 8233
		public cq8.g b;
	}

	// Token: 0x02000F08 RID: 3848
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004EA8 RID: 20136 RVA: 0x0023486C File Offset: 0x00232A6C
		internal bool a(e6d A_0)
		{
			if (this.a.a("traitor"))
			{
				this.b.b.d.c.a(this.a, "sol", "soldierTraitorKill");
			}
			else if (this.a.a("martyr"))
			{
				this.b.b.d.c.a(this.a, "sol", "soldierMartyrSave");
			}
			else if (cuo.a.Next(0, 101) > 33)
			{
				this.b.b.d.c.a(this.a, "sol", "soldierFightWin");
			}
			return true;
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x00234940 File Offset: 0x00232B40
		internal bool c(e6d A_0)
		{
			if (this.a.a("negativeAffliction"))
			{
				this.b.b.d.c.a(this.a, "med", "medicSabotage");
			}
			else if (cuo.a.Next(0, 101) > 40)
			{
				this.b.b.d.c.a(this.a, "med", "medicHeal");
			}
			return true;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x002349D0 File Offset: 0x00232BD0
		internal bool b(e6d A_0)
		{
			if (this.a.a("depressed"))
			{
				this.b.b.d.c.a(this.a, "int", "intDepressed");
			}
			else if (this.a.a("courageous"))
			{
				this.b.b.d.c.a(this.a, "int", "intCourageous");
			}
			else if (this.a.a("abusive"))
			{
				this.b.b.d.c.a(this.a, "int", "intBuffNegated");
			}
			else if (this.a.a("paranoid"))
			{
				this.b.b.d.c.a(this.a, "int", "intHalved");
			}
			return true;
		}

		// Token: 0x0400202A RID: 8234
		public c5x a;

		// Token: 0x0400202B RID: 8235
		public cq8.g b;
	}

	// Token: 0x02000F09 RID: 3849
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004EAC RID: 20140 RVA: 0x00234AF8 File Offset: 0x00232CF8
		internal bool b(e6d A_0)
		{
			int num = (int)this.b.a.a()[this.a.ToString()];
			this.b.a.a()[this.a.ToString()] = ++num;
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.b.b.d.d.ab4(new string[]
			{
				this.a + "Eye_" + num.ToString()
			})) as c5x;
			if (c5x != null)
			{
				this.b.b.d.c.c(c5x, false);
			}
			this.b.b.d.c.b(this.a, num);
			this.b.b.d.c.a(this.a, num);
			el3 el = new el3();
			el.a(true);
			el.b(new HorizontalDirection?(el.a(this.a)));
			el.ym(this.b.b.d.b, this.b.b.d.b, null);
			if (this.b.b.b.a(this.a + "ET"))
			{
				this.b.b.d.c.a(this.a, false);
			}
			return true;
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00234CA0 File Offset: 0x00232EA0
		internal bool a(e6d A_0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.b.b.d.d.ab4(new string[]
			{
				this.a + "Eye_" + ((int)this.b.a.a()[this.a.ToString()] - 1).ToString()
			})) as c5x;
			if (c5x != null)
			{
				this.b.b.d.c.c(c5x, true);
			}
			return true;
		}

		// Token: 0x0400202C RID: 8236
		public string a;

		// Token: 0x0400202D RID: 8237
		public cq8.g b;
	}

	// Token: 0x02000F0A RID: 3850
	[CompilerGenerated]
	private new sealed class f
	{
		// Token: 0x06004EAF RID: 20143 RVA: 0x00234D4C File Offset: 0x00232F4C
		internal bool b(e6d A_0)
		{
			if (cuo.a.Next(0, 101) > 22)
			{
				this.b.b.d.c.a(this.a, "sol", "soldierFightLose");
			}
			return true;
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x00234D98 File Offset: 0x00232F98
		internal bool a(e6d A_0)
		{
			if (this.a.a("negativeAffliction"))
			{
				this.b.b.d.c.a(this.a, "med", "medicSabotage");
			}
			else if (cuo.a.Next(0, 101) > 40)
			{
				this.b.b.d.c.a(this.a, "med", "medicHeal");
			}
			return true;
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x00234E28 File Offset: 0x00233028
		internal bool c(e6d A_0)
		{
			if (this.a.a("depressed"))
			{
				this.b.b.d.c.a(this.a, "int", "intDepressed");
			}
			else if (this.a.a("courageous"))
			{
				this.b.b.d.c.a(this.a, "int", "intCourageous");
			}
			else if (this.a.a("abusive"))
			{
				this.b.b.d.c.a(this.a, "int", "intBuffNegated");
			}
			else if (this.a.a("paranoid"))
			{
				this.b.b.d.c.a(this.a, "int", "intHalved");
			}
			return true;
		}

		// Token: 0x0400202E RID: 8238
		public c5x a;

		// Token: 0x0400202F RID: 8239
		public cq8.g b;
	}

	// Token: 0x02000F0B RID: 3851
	[CompilerGenerated]
	private new sealed class e
	{
		// Token: 0x06004EB3 RID: 20147 RVA: 0x00234F4C File Offset: 0x0023314C
		internal bool a(e6d A_0)
		{
			this.b.b.d.c.b(this.a, true);
			return true;
		}

		// Token: 0x04002030 RID: 8240
		public c5x a;

		// Token: 0x04002031 RID: 8241
		public cq8.g b;
	}

	// Token: 0x02000F0C RID: 3852
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EB5 RID: 20149 RVA: 0x00234F78 File Offset: 0x00233178
		internal bool a(e6d A_0)
		{
			this.b.b.d.c.b(this.a, true);
			return true;
		}

		// Token: 0x04002032 RID: 8242
		public c5x a;

		// Token: 0x04002033 RID: 8243
		public cq8.g b;
	}
}
