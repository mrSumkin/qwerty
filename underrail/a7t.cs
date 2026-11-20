using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CB0 RID: 3248
[e79("Lux_Ms_MidsummerianDance")]
public sealed class a7t : dgy
{
	// Token: 0x06004944 RID: 18756 RVA: 0x001E2F1C File Offset: 0x001E111C
	public a7t()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a7t.a a = new a7t.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.a.i.b.a(true, false);
				d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
				if (addon != null)
				{
					a.b = (Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						"randomEvent_lux-ms_midsummerian1"
					})) as c5x);
					a.c = (Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						"randomEvent_lux-ms_midsummerian2"
					})) as c5x);
					a.d = (Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
					{
						"randomEvent_lux-ms_midsummerian3"
					})) as c5x);
					if (a.b != null && a.c != null && a.d != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						btm[] array = new btm[1];
						int num = 0;
						dky dky = new dky();
						dky.a(0.2f);
						dky.IsAsync = false;
						dky.a(false);
						array[num] = dky;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						c8s.IsAsync = false;
						array2[num2] = c8s;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						s5 s = new s5();
						s.a(new ar7(a.a));
						s.a(new bt4("randomEvent_lux-ms_dance4_mid"));
						s.IsAsync = true;
						s.a(true);
						array3[num3] = s;
						base.a(array3);
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.b));
						s2.a(new bt4("randomEvent_lux-ms_dance1_mid"));
						s2.IsAsync = true;
						s2.a(true);
						array4[num4] = s2;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(a.c));
						s3.a(new bt4("randomEvent_lux-ms_dance2_mid"));
						s3.IsAsync = true;
						s3.a(true);
						array5[num5] = s3;
						base.a(array5);
						btm[] array6 = new btm[1];
						int num6 = 0;
						s5 s4 = new s5();
						s4.a(new ar7(a.d));
						s4.a(new bt4("randomEvent_lux-ms_dance3_mid"));
						s4.IsAsync = true;
						s4.a(true);
						array6[num6] = s4;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						s5 s5 = new s5();
						s5.a(new ar7(a.a));
						s5.a(new bt4("randomEvent_lux-ms_dance1"));
						s5.IsAsync = true;
						s5.a(true);
						array7[num7] = s5;
						base.a(array7);
						btm[] array8 = new btm[1];
						int num8 = 0;
						s5 s6 = new s5();
						s6.a(new ar7(a.b));
						s6.a(new bt4("randomEvent_lux-ms_dance2"));
						s6.IsAsync = true;
						s6.a(true);
						array8[num8] = s6;
						base.a(array8);
						btm[] array9 = new btm[1];
						int num9 = 0;
						s5 s7 = new s5();
						s7.a(new ar7(a.c));
						s7.a(new bt4("randomEvent_lux-ms_dance3"));
						s7.IsAsync = true;
						s7.a(true);
						array9[num9] = s7;
						base.a(array9);
						btm[] array10 = new btm[1];
						int num10 = 0;
						s5 s8 = new s5();
						s8.a(new ar7(a.d));
						s8.a(new bt4("randomEvent_lux-ms_dance4"));
						s8.IsAsync = true;
						s8.a(true);
						array10[num10] = s8;
						base.a(array10);
						btm[] array11 = new btm[1];
						int num11 = 0;
						egx egx = new egx();
						egx.a("Брызгун, брызгун...");
						array11[num11] = new ace(egx)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array11);
						btm[] array12 = new btm[1];
						int num12 = 0;
						egx egx2 = new egx();
						egx2.a("Брызгун, брызгун...");
						array12[num12] = new ace(egx2)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array12);
						btm[] array13 = new btm[1];
						int num13 = 0;
						egx egx3 = new egx();
						egx3.a("Брызгун, брызгун...");
						array13[num13] = new ace(egx3)
						{
							TargetRef = new ar7(a.d)
						};
						base.a(array13);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array14 = new btm[1];
						int num14 = 0;
						egx egx4 = new egx();
						egx4.a("Уф... Брызгун!");
						array14[num14] = new ace(egx4)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array14);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array15 = new btm[1];
						int num15 = 0;
						egx egx5 = new egx();
						egx5.a("Что за?!..");
						egx5.a(true);
						array15[num15] = new ace(egx5)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array15);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
						btm[] array16 = new btm[1];
						int num16 = 0;
						s5 s9 = new s5();
						s9.a(new ar7(a.a));
						s9.a(new bt4("randomEvent_lux-ms_dance1_mid"));
						s9.IsAsync = true;
						s9.a(true);
						array16[num16] = s9;
						base.a(array16);
						btm[] array17 = new btm[1];
						int num17 = 0;
						s5 s10 = new s5();
						s10.a(new ar7(a.b));
						s10.a(new bt4("randomEvent_lux-ms_dance2_mid"));
						s10.IsAsync = true;
						s10.a(true);
						array17[num17] = s10;
						base.a(array17);
						btm[] array18 = new btm[1];
						int num18 = 0;
						s5 s11 = new s5();
						s11.a(new ar7(a.c));
						s11.a(new bt4("randomEvent_lux-ms_dance3_mid"));
						s11.IsAsync = true;
						s11.a(true);
						array18[num18] = s11;
						base.a(array18);
						btm[] array19 = new btm[1];
						int num19 = 0;
						s5 s12 = new s5();
						s12.a(new ar7(a.d));
						s12.a(new bt4("randomEvent_lux-ms_dance4_mid"));
						s12.IsAsync = true;
						s12.a(true);
						array19[num19] = s12;
						base.a(array19);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array20 = new btm[1];
						int num20 = 0;
						s5 s13 = new s5();
						s13.a(new ar7(a.a));
						s13.a(new bt4("randomEvent_lux-ms_dance2"));
						s13.IsAsync = true;
						s13.a(true);
						array20[num20] = s13;
						base.a(array20);
						btm[] array21 = new btm[1];
						int num21 = 0;
						s5 s14 = new s5();
						s14.a(new ar7(a.b));
						s14.a(new bt4("randomEvent_lux-ms_dance3"));
						s14.IsAsync = true;
						s14.a(true);
						array21[num21] = s14;
						base.a(array21);
						btm[] array22 = new btm[1];
						int num22 = 0;
						s5 s15 = new s5();
						s15.a(new ar7(a.c));
						s15.a(new bt4("randomEvent_lux-ms_dance4"));
						s15.IsAsync = true;
						s15.a(true);
						array22[num22] = s15;
						base.a(array22);
						btm[] array23 = new btm[1];
						int num23 = 0;
						s5 s16 = new s5();
						s16.a(new ar7(a.d));
						s16.a(new bt4("randomEvent_lux-ms_dance1"));
						s16.IsAsync = true;
						s16.a(true);
						array23[num23] = s16;
						base.a(array23);
						btm[] array24 = new btm[1];
						int num24 = 0;
						egx egx6 = new egx();
						egx6.a("Забавно!");
						egx6.a(true);
						array24[num24] = new ace(egx6)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array24);
						btm[] array25 = new btm[1];
						int num25 = 0;
						egx egx7 = new egx();
						egx7.a("Забавно!");
						egx7.a(true);
						array25[num25] = new ace(egx7)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array25);
						btm[] array26 = new btm[1];
						int num26 = 0;
						egx egx8 = new egx();
						egx8.a("Забавно!");
						egx8.a(true);
						array26[num26] = new ace(egx8)
						{
							TargetRef = new ar7(a.d)
						};
						base.a(array26);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array27 = new btm[1];
						int num27 = 0;
						egx egx9 = new egx();
						egx9.a("Смешно смотреть!");
						egx9.a(true);
						array27[num27] = new ace(egx9)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array27);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.a)
							}
						});
						btm[] array28 = new btm[1];
						int num28 = 0;
						egx egx10 = new egx();
						egx10.a("Вай - вай!");
						egx10.a(true);
						array28[num28] = new ace(egx10)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array28);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array29 = new btm[1];
						int num29 = 0;
						s5 s17 = new s5();
						s17.a(new ar7(a.a));
						s17.a(new bt4("randomEvent_lux-ms_dance2_mid"));
						s17.IsAsync = true;
						s17.a(true);
						array29[num29] = s17;
						base.a(array29);
						btm[] array30 = new btm[1];
						int num30 = 0;
						s5 s18 = new s5();
						s18.a(new ar7(a.b));
						s18.a(new bt4("randomEvent_lux-ms_dance3_mid"));
						s18.IsAsync = true;
						s18.a(true);
						array30[num30] = s18;
						base.a(array30);
						btm[] array31 = new btm[1];
						int num31 = 0;
						s5 s19 = new s5();
						s19.a(new ar7(a.c));
						s19.a(new bt4("randomEvent_lux-ms_dance4_mid"));
						s19.IsAsync = true;
						s19.a(true);
						array31[num31] = s19;
						base.a(array31);
						btm[] array32 = new btm[1];
						int num32 = 0;
						s5 s20 = new s5();
						s20.a(new ar7(a.d));
						s20.a(new bt4("randomEvent_lux-ms_dance1_mid"));
						s20.IsAsync = true;
						s20.a(true);
						array32[num32] = s20;
						base.a(array32);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array33 = new btm[1];
						int num33 = 0;
						s5 s21 = new s5();
						s21.a(new ar7(a.a));
						s21.a(new bt4("randomEvent_lux-ms_dance3"));
						s21.IsAsync = true;
						s21.a(true);
						array33[num33] = s21;
						base.a(array33);
						btm[] array34 = new btm[1];
						int num34 = 0;
						s5 s22 = new s5();
						s22.a(new ar7(a.b));
						s22.a(new bt4("randomEvent_lux-ms_dance4"));
						s22.IsAsync = true;
						s22.a(true);
						array34[num34] = s22;
						base.a(array34);
						btm[] array35 = new btm[1];
						int num35 = 0;
						s5 s23 = new s5();
						s23.a(new ar7(a.c));
						s23.a(new bt4("randomEvent_lux-ms_dance1"));
						s23.IsAsync = true;
						s23.a(true);
						array35[num35] = s23;
						base.a(array35);
						btm[] array36 = new btm[1];
						int num36 = 0;
						s5 s24 = new s5();
						s24.a(new ar7(a.d));
						s24.a(new bt4("randomEvent_lux-ms_dance2"));
						s24.IsAsync = true;
						s24.a(true);
						array36[num36] = s24;
						base.a(array36);
						btm[] array37 = new btm[1];
						int num37 = 0;
						egx egx11 = new egx();
						egx11.a("Зелёная кожа - зелёная кожа!..");
						egx11.a(true);
						array37[num37] = new ace(egx11)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array37);
						btm[] array38 = new btm[1];
						int num38 = 0;
						egx egx12 = new egx();
						egx12.a("Зелёная кожа - зелёная кожа!..");
						egx12.a(true);
						array38[num38] = new ace(egx12)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array38);
						btm[] array39 = new btm[1];
						int num39 = 0;
						egx egx13 = new egx();
						egx13.a("Зелёная кожа - зелёная кожа!..");
						egx13.a(true);
						array39[num39] = new ace(egx13)
						{
							TargetRef = new ar7(a.d)
						};
						base.a(array39);
						btm[] array40 = new btm[1];
						int num40 = 0;
						egx egx14 = new egx();
						egx14.a("Зелёная кожа... зелёная кожа...");
						egx14.a(true);
						array40[num40] = new ace(egx14)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array40);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.5))
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array41 = new btm[1];
						int num41 = 0;
						s5 s25 = new s5();
						s25.a(new ar7(a.a));
						s25.a(new bt4("randomEvent_lux-ms_dance3_mid"));
						s25.IsAsync = true;
						s25.a(true);
						array41[num41] = s25;
						base.a(array41);
						btm[] array42 = new btm[1];
						int num42 = 0;
						s5 s26 = new s5();
						s26.a(new ar7(a.b));
						s26.a(new bt4("randomEvent_lux-ms_dance4_mid"));
						s26.IsAsync = true;
						s26.a(true);
						array42[num42] = s26;
						base.a(array42);
						btm[] array43 = new btm[1];
						int num43 = 0;
						s5 s27 = new s5();
						s27.a(new ar7(a.c));
						s27.a(new bt4("randomEvent_lux-ms_dance1_mid"));
						s27.IsAsync = true;
						s27.a(true);
						array43[num43] = s27;
						base.a(array43);
						btm[] array44 = new btm[1];
						int num44 = 0;
						s5 s28 = new s5();
						s28.a(new ar7(a.d));
						s28.a(new bt4("randomEvent_lux-ms_dance2_mid"));
						s28.IsAsync = true;
						s28.a(true);
						array44[num44] = s28;
						base.a(array44);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array45 = new btm[1];
						int num45 = 0;
						s5 s29 = new s5();
						s29.a(new ar7(a.a));
						s29.a(new bt4("randomEvent_lux-ms_dance4"));
						s29.IsAsync = true;
						s29.a(true);
						array45[num45] = s29;
						base.a(array45);
						btm[] array46 = new btm[1];
						int num46 = 0;
						s5 s30 = new s5();
						s30.a(new ar7(a.b));
						s30.a(new bt4("randomEvent_lux-ms_dance1"));
						s30.IsAsync = true;
						s30.a(true);
						array46[num46] = s30;
						base.a(array46);
						btm[] array47 = new btm[1];
						int num47 = 0;
						s5 s31 = new s5();
						s31.a(new ar7(a.c));
						s31.a(new bt4("randomEvent_lux-ms_dance2"));
						s31.IsAsync = true;
						s31.a(true);
						array47[num47] = s31;
						base.a(array47);
						btm[] array48 = new btm[1];
						int num48 = 0;
						s5 s32 = new s5();
						s32.a(new ar7(a.d));
						s32.a(new bt4("randomEvent_lux-ms_dance3"));
						s32.IsAsync = true;
						s32.a(true);
						array48[num48] = s32;
						base.a(array48);
						btm[] array49 = new btm[1];
						int num49 = 0;
						egx egx15 = new egx();
						egx15.a("И язык, убивает!");
						egx15.a(true);
						array49[num49] = new ace(egx15)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array49);
						btm[] array50 = new btm[1];
						int num50 = 0;
						egx egx16 = new egx();
						egx16.a("И язык, убивает!");
						egx16.a(true);
						array50[num50] = new ace(egx16)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array50);
						btm[] array51 = new btm[1];
						int num51 = 0;
						egx egx17 = new egx();
						egx17.a("И язык, убивает!");
						egx17.a(true);
						array51[num51] = new ace(egx17)
						{
							TargetRef = new ar7(a.d)
						};
						base.a(array51);
						btm[] array52 = new btm[1];
						int num52 = 0;
						egx egx18 = new egx();
						egx18.a("И язык, убивает!");
						egx18.a(true);
						array52[num52] = new ace(egx18)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array52);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.5))
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(new CharacterState?(CharacterState.Die)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(2)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(1)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.2))
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new b16(new int?(0)))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.b)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.c)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.d)
							}
						});
						base.a(new btm[]
						{
							new ace(new epw(null))
							{
								TargetRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array53 = new btm[1];
						int num53 = 0;
						dky dky2 = new dky();
						dky2.a(0.2f);
						dky2.IsAsync = false;
						dky2.a(false);
						array53[num53] = dky2;
						base.a(array53);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						btm[] array54 = new btm[1];
						int num54 = 0;
						c8s c8s2 = new c8s();
						c8s2.a(0.2f);
						c8s2.IsAsync = false;
						array54[num54] = c8s2;
						base.a(array54);
						btm[] array55 = new btm[1];
						int num55 = 0;
						egx egx19 = new egx();
						egx19.a("Ребро!");
						egx19.a(true);
						array55[num55] = new ace(egx19)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array55);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000CB1 RID: 3249
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004946 RID: 18758 RVA: 0x001E5680 File Offset: 0x001E3880
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "randomEvent_lux-ms_dance4", true);
			a0l.a(this.b, "randomEvent_lux-ms_dance1", true);
			a0l.a(this.c, "randomEvent_lux-ms_dance2", true);
			a0l.a(this.d, "randomEvent_lux-ms_dance3", true);
			this.a.VisualDirection = HorizontalDirection.West;
			this.b.VisualDirection = HorizontalDirection.North;
			this.c.VisualDirection = HorizontalDirection.East;
			this.d.VisualDirection = HorizontalDirection.South;
			this.a.h.b.aa().BaseMovementSpeed = 0.7f;
			this.b.h.b.aa().BaseMovementSpeed = 0.7f;
			this.c.h.b.aa().BaseMovementSpeed = 0.7f;
			this.d.h.b.aa().BaseMovementSpeed = 0.7f;
			return true;
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x001E5780 File Offset: 0x001E3980
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "randomEvent_lux-ms_guard4", true);
			a0l.a(this.b, "randomEvent_lux-ms_guard1", true);
			a0l.a(this.c, "randomEvent_lux-ms_guard2", true);
			a0l.a(this.d, "randomEvent_lux-ms_guard3", true);
			this.a.VisualDirection = HorizontalDirection.Northwest;
			this.b.VisualDirection = HorizontalDirection.Northeast;
			this.c.VisualDirection = HorizontalDirection.Southeast;
			this.d.VisualDirection = HorizontalDirection.Southwest;
			this.a.h.b.aa().BaseMovementSpeed = 1f;
			this.b.h.b.aa().BaseMovementSpeed = 1f;
			this.c.h.b.aa().BaseMovementSpeed = 1f;
			this.d.h.b.aa().BaseMovementSpeed = 1f;
			return true;
		}

		// Token: 0x04001CFC RID: 7420
		public c5x a;

		// Token: 0x04001CFD RID: 7421
		public c5x b;

		// Token: 0x04001CFE RID: 7422
		public c5x c;

		// Token: 0x04001CFF RID: 7423
		public c5x d;
	}
}
