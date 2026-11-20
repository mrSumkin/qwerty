using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B67 RID: 2919
[eiz("XPBLDCHRFH")]
[Serializable]
public sealed class e47 : cze, ISerializable
{
	// Token: 0x060042CF RID: 17103 RVA: 0x0019F96C File Offset: 0x0019DB6C
	private e47(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("XPBLDCHRFH:F");
		this.b = (Guid?)A_0.GetValue("XPBLDCHRFH:T", typeof(Guid?));
	}

	// Token: 0x060042D0 RID: 17104 RVA: 0x0019F9B4 File Offset: 0x0019DBB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLDCHRFH:F", this.a);
		info.AddValue("XPBLDCHRFH:T", this.b);
	}

	// Token: 0x060042D1 RID: 17105 RVA: 0x0019F9E8 File Offset: 0x0019DBE8
	public string a()
	{
		return this.a;
	}

	// Token: 0x060042D2 RID: 17106 RVA: 0x0019F9F0 File Offset: 0x0019DBF0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060042D3 RID: 17107 RVA: 0x0019F9FC File Offset: 0x0019DBFC
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x060042D4 RID: 17108 RVA: 0x0019FA04 File Offset: 0x0019DC04
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060042D5 RID: 17109 RVA: 0x0019FA10 File Offset: 0x0019DC10
	public e47()
	{
	}

	// Token: 0x060042D6 RID: 17110 RVA: 0x0019FA1C File Offset: 0x0019DC1C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				c5x c5x = new c5x();
				if (this.b() == null)
				{
					c5x = (new ar7(A_1.qe(), aud).ao() as c5x);
				}
				if (this.b() != null)
				{
					c5x = (new ar7(this.b.Value, aud).ao() as c5x);
				}
				if (c5x != null)
				{
					a3f aspect = c5x.GetAspect<a3f>();
					if (aspect != null)
					{
						List<string> classPropertyValue = aspect.a().GetClassPropertyValue<List<string>>("Characteristics");
						int value = aspect.a().GetPrimitivePropertyValue<int>("MindCapacity", new int?(0)).Value;
						int value2 = aspect.a().GetPrimitivePropertyValue<int>("GutsCapacity", new int?(0)).Value;
						int value3 = aspect.a().GetPrimitivePropertyValue<int>("HeartCapacity", new int?(0)).Value;
						string text = this.a();
						if (text != null)
						{
							switch (text.Length)
							{
							case 5:
							{
								char c = text[0];
								if (c != 'a')
								{
									if (c != 'j')
									{
										return;
									}
									if (!(text == "juice"))
									{
										return;
									}
									if (this.a(value, aspect, "MindCapacity"))
									{
										this.a(classPropertyValue[1], aspect);
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								}
								else
								{
									if (!(text == "aegis"))
									{
										return;
									}
									if (this.a(value2, aspect, "GutsCapacity"))
									{
										this.e(classPropertyValue[0], aspect, 3);
										this.d(classPropertyValue[0], aspect, 15);
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								}
								break;
							}
							case 6:
							{
								char c = text[0];
								if (c != 'c')
								{
									if (c != 't')
									{
										return;
									}
									if (!(text == "twitch"))
									{
										return;
									}
									if (this.a(value2, aspect, "GutsCapacity"))
									{
										this.e(classPropertyValue[0], aspect, 8);
										this.d(classPropertyValue[0], aspect, cuo.a.Next(-9, -4));
										this.a(classPropertyValue, aspect, classPropertyValue[0]);
										this.a(classPropertyValue, aspect, classPropertyValue[1]);
										dqg dqg = c5x.h.b.aa().BaseAbilities.Get<dqg>();
										dqg.a(dqg.f() + 1);
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								}
								else
								{
									if (!(text == "coffee"))
									{
										return;
									}
									if (this.a(value, aspect, "MindCapacity"))
									{
										this.f(classPropertyValue[0], aspect, cuo.a.Next(0, 25));
										this.a(classPropertyValue, aspect, classPropertyValue[2]);
										this.e(classPropertyValue[1], aspect, cuo.a.Next(5, 15));
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								}
								break;
							}
							case 7:
								if (!(text == "irongut"))
								{
									return;
								}
								if (this.a(value2, aspect, "GutsCapacity") && this.a(value3, aspect, "HeartCapacity"))
								{
									this.d(classPropertyValue[0], aspect, 25);
									this.a(classPropertyValue, aspect, classPropertyValue[0]);
									this.e(classPropertyValue[0], aspect, cuo.a.Next(-3, 3));
									return;
								}
								serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
								return;
							case 8:
							{
								char c = text[0];
								if (c != 'b')
								{
									if (c != 'r')
									{
										if (c != 't')
										{
											return;
										}
										if (!(text == "thirdEye"))
										{
											return;
										}
										if (this.a(value, aspect, "MindCapacity"))
										{
											this.e(classPropertyValue[1], aspect, 20);
											this.a(classPropertyValue, aspect, classPropertyValue[1]);
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									}
									else
									{
										if (!(text == "rootSoda"))
										{
											return;
										}
										if (this.a(value2, aspect, "GutsCapacity"))
										{
											this.f(classPropertyValue[0], aspect, cuo.a.Next(-5, 15));
											this.a(classPropertyValue, aspect, classPropertyValue[0]);
											this.e(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-10, 30));
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									}
								}
								else
								{
									if (!(text == "bullhead"))
									{
										return;
									}
									if (this.a(value, aspect, "MindCapacity") && this.a(value2, aspect, "GutsCapacity"))
									{
										this.c(classPropertyValue[1], aspect, 60);
										this.a(classPropertyValue, aspect, classPropertyValue[1]);
										this.e(classPropertyValue[0], aspect, cuo.a.Next(0, 5));
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								}
								break;
							}
							case 9:
								switch (text[0])
								{
								case 'b':
									if (!(text == "bisonMilk"))
									{
										return;
									}
									if (this.a(value, aspect, "MindCapacity"))
									{
										this.f(classPropertyValue[0], aspect, cuo.a.Next(0, 10));
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								case 'c':
									if (!(text == "coreChips"))
									{
										return;
									}
									if (this.a(value2, aspect, "GutsCapacity") && this.a(value3, aspect, "HeartCapacity"))
									{
										this.d(classPropertyValue[2], aspect, 8);
										this.a(classPropertyValue, aspect, classPropertyValue[0]);
										this.a(classPropertyValue, aspect, classPropertyValue[2]);
										this.e(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-5, 10));
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								case 'd':
								case 'e':
									break;
								case 'f':
									if (!(text == "focusStim"))
									{
										return;
									}
									if (this.a(value, aspect, "MindCapacity"))
									{
										this.e(classPropertyValue[1], aspect, 15);
										this.a(classPropertyValue[2], aspect, 3);
										this.b(classPropertyValue[0], aspect, -2);
										this.a(classPropertyValue, aspect, classPropertyValue[0]);
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								default:
									return;
								}
								break;
							case 10:
								if (!(text == "marshHoney"))
								{
									return;
								}
								if (this.a(value, aspect, "MindCapacity"))
								{
									this.a(classPropertyValue, aspect, classPropertyValue[0]);
									this.b(c5x);
									return;
								}
								serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
								return;
							case 11:
								if (!(text == "jumpingBean"))
								{
									return;
								}
								if (this.a(value3, aspect, "HeartCapacity"))
								{
									this.f(classPropertyValue[2], aspect, 12);
									this.e(classPropertyValue[1], aspect, cuo.a.Next(-10, -3));
									this.d(classPropertyValue[0], aspect, cuo.a.Next(-6, -3));
									this.a(classPropertyValue, aspect, classPropertyValue[2]);
									return;
								}
								serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
								return;
							case 12:
							{
								char c = text[1];
								if (c != 'e')
								{
									if (c != 'o')
									{
										if (c != 'y')
										{
											return;
										}
										if (!(text == "mysteryCandy"))
										{
											return;
										}
										if (this.a(value, aspect, "MindCapacity"))
										{
											dqg dqg2 = c5x.h.b.aa().BaseAbilities.Get<dqg>();
											dqg2.a(dqg2.f() + cuo.a.Next(-2, 2));
											this.e(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-30, 30));
											this.a(classPropertyValue, aspect, classPropertyValue[1]);
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									}
									else
									{
										if (!(text == "morphineShot"))
										{
											return;
										}
										if (this.a(value2, aspect, "GutsCapacity") && this.a(value3, aspect, "HeartCapacity"))
										{
											this.d(classPropertyValue[2], aspect, 25);
											this.d(classPropertyValue[0], aspect, 25);
											this.a(classPropertyValue, aspect, classPropertyValue[0]);
											this.a(classPropertyValue, aspect, classPropertyValue[2]);
											this.e(classPropertyValue[0], aspect, cuo.a.Next(-15, -5));
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									}
								}
								else
								{
									if (!(text == "herculesDrug"))
									{
										return;
									}
									this.a(c5x);
									return;
								}
								break;
							}
							case 13:
							{
								char c = text[0];
								if (c != 'h')
								{
									if (c != 'm')
									{
										if (c != 'n')
										{
											return;
										}
										if (!(text == "nervosomnifer"))
										{
											return;
										}
										if (this.a(value2, aspect, "GutsCapacity") && this.a(value3, aspect, "HeartCapacity"))
										{
											this.d(classPropertyValue[2], aspect, 30);
											this.d(classPropertyValue[0], aspect, 30);
											this.a(classPropertyValue, aspect, classPropertyValue[0]);
											this.a(classPropertyValue, aspect, classPropertyValue[2]);
											this.e(classPropertyValue[0], aspect, cuo.a.Next(-10, -2));
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									}
									else
									{
										if (!(text == "mushroomSalad"))
										{
											return;
										}
										if (this.a(value2, aspect, "GutsCapacity"))
										{
											this.a(classPropertyValue[cuo.a.Next(0, 2)], aspect, 10);
											this.b(classPropertyValue[cuo.a.Next(0, 2)], aspect, 20);
											this.a(classPropertyValue, aspect, classPropertyValue[0]);
											this.e(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(10, 30));
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									}
								}
								else
								{
									if (!(text == "hypercerebrix"))
									{
										return;
									}
									if (this.a(value2, aspect, "GutsCapacity"))
									{
										this.e(classPropertyValue[0], aspect, 15);
										this.a(classPropertyValue[2], aspect, -2);
										this.b(classPropertyValue[0], aspect, 5);
										this.a(classPropertyValue, aspect, classPropertyValue[0]);
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								}
								break;
							}
							case 14:
								if (!(text == "adrenalineShot"))
								{
									return;
								}
								if (this.a(value3, aspect, "HeartCapacity"))
								{
									this.f(classPropertyValue[2], aspect, 40);
									this.e(classPropertyValue[1], aspect, cuo.a.Next(-15, -7));
									this.d(classPropertyValue[0], aspect, cuo.a.Next(-9, -4));
									this.a(classPropertyValue, aspect, classPropertyValue[2]);
									this.a(classPropertyValue, aspect, classPropertyValue[1]);
									return;
								}
								serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
								return;
							case 15:
							case 17:
							case 18:
								break;
							case 16:
							{
								char c = text[0];
								if (c != 'j')
								{
									if (c != 's')
									{
										return;
									}
									if (!(text == "superSoldierDrug"))
									{
										return;
									}
									if (this.a(value3, aspect, "HeartCapacity") && this.a(value2, aspect, "GutsCapacity"))
									{
										aspect.a()["ImmuneStacks"] = 5;
										this.f(classPropertyValue[2], aspect, 15);
										axa axa = c5x.h.b.aa().BaseAbilities.Get<axa>();
										axa.a(axa.f() + 2);
										dqg dqg3 = c5x.h.b.aa().BaseAbilities.Get<dqg>();
										dqg3.a(dqg3.f() + 2);
										return;
									}
									serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
									return;
								}
								else
								{
									if (!(text == "junkyardSurprise"))
									{
										return;
									}
									switch (cuo.a.Next(0, 2))
									{
									case 0:
										if (this.a(value2, aspect, "GutsCapacity"))
										{
											this.a(classPropertyValue[cuo.a.Next(0, 2)], aspect, 10);
											this.b(classPropertyValue[cuo.a.Next(0, 2)], aspect, 20);
											this.a(classPropertyValue, aspect, classPropertyValue[0]);
											this.e(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-15, 10));
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									case 1:
										if (this.a(value, aspect, "MindCapacity"))
										{
											this.f(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(0, 25));
											this.a(classPropertyValue, aspect, classPropertyValue[1]);
											this.e(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-15, 10));
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									case 2:
										if (this.a(value3, aspect, "HeartCapacity"))
										{
											this.d(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-25, 25));
											this.c(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-45, 45));
											this.a(classPropertyValue, aspect, classPropertyValue[2]);
											this.e(classPropertyValue[cuo.a.Next(0, 2)], aspect, cuo.a.Next(-15, 10));
											return;
										}
										serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
										return;
									default:
										return;
									}
								}
								break;
							}
							case 19:
								if (!(text == "regenerativeMixture"))
								{
									return;
								}
								if (this.a(value2, aspect, "GutsCapacity") && this.a(value3, aspect, "HeartCapacity"))
								{
									this.a(classPropertyValue[2], aspect, 10);
									this.a(classPropertyValue, aspect, classPropertyValue[0]);
									this.a(classPropertyValue, aspect, classPropertyValue[2]);
									this.b(classPropertyValue[0], aspect, 20);
									return;
								}
								serviceOrThrow.aqu().r()["npc_xpbl_dun_cvw_hr_killCurrentHopper"] = true;
								return;
							default:
								return;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060042D7 RID: 17111 RVA: 0x001A0B48 File Offset: 0x0019ED48
	private bool a(int A_0, a3f A_1, string A_2)
	{
		A_0--;
		A_1.a()[A_2] = A_0;
		return A_0 >= 0;
	}

	// Token: 0x060042D8 RID: 17112 RVA: 0x001A0B6C File Offset: 0x0019ED6C
	private void a(List<string> A_0, a3f A_1, string A_2)
	{
		if (cuo.a.Next(0, 2) == 0)
		{
			string text = "";
			if (!(A_2 == "GoodMind"))
			{
				if (!(A_2 == "NeutralMind"))
				{
					if (!(A_2 == "GoodGuts"))
					{
						if (!(A_2 == "NeutralGuts"))
						{
							if (!(A_2 == "GoodHeart"))
							{
								if (A_2 == "NeutralHeart")
								{
									text = "BadHeart";
								}
							}
							else
							{
								text = "NeutralHeart";
							}
						}
						else
						{
							text = "BadGuts";
						}
					}
					else
					{
						text = "NeutralGuts";
					}
				}
				else
				{
					text = "BadMind";
				}
			}
			else
			{
				text = "NeutralMind";
			}
			if (text.Contains("Guts"))
			{
				A_0[0] = text;
				A_1.a()["Characteristics"] = A_0;
			}
			if (text.Contains("Mind"))
			{
				A_0[1] = text;
				A_1.a()["Characteristics"] = A_0;
			}
			if (text.Contains("Heart"))
			{
				A_0[2] = text;
				A_1.a()["Characteristics"] = A_0;
			}
		}
	}

	// Token: 0x060042D9 RID: 17113 RVA: 0x001A0CB0 File Offset: 0x0019EEB0
	private void b(c5x A_0)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			aspect.ao = new Color?(new Color(255, cuo.a.Next(125, 175), cuo.a.Next(125, 175), cuo.a.Next(225, 255)));
			aspect.an = new float?((float)cuo.a.Next(12, 18) * 0.1f);
		}
	}

	// Token: 0x060042DA RID: 17114 RVA: 0x001A0D38 File Offset: 0x0019EF38
	private void a(c5x A_0)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			int? num = new int?(255);
			int? num2 = new int?(255);
			int? num3 = new int?(255);
			int? num4 = new int?(255);
			if (aspect.ao != null)
			{
				num = new int?((int)aspect.ao.Value.R);
				if (num == null)
				{
					num = new int?(255);
				}
				num2 = new int?((int)aspect.ao.Value.G);
				if (num2 == null)
				{
					num2 = new int?(255);
				}
				num3 = new int?((int)aspect.ao.Value.B);
				if (num3 == null)
				{
					num3 = new int?(255);
				}
				num4 = new int?((int)aspect.ao.Value.A);
				if (num4 == null)
				{
					num4 = new int?(255);
				}
			}
			float num5 = aspect.am;
			float num6 = aspect.al;
			int num7 = 55;
			dtb dtb = new dtb();
			for (int i = 0; i < 100; i++)
			{
				d9m d9m = new d9m();
				d9m.a(num7);
				num7 += 55;
				ck6 ck = new ck6();
				ck.a().Add(A_0.qe().ToString());
				aspect.ao = new Color?(new Color(num.Value, num2.Value, num3.Value, num4.Value));
				ck.a(aspect.ao.Value);
				dnz dnz = new dnz();
				dnz.a(new Guid?(A_0.qe()));
				dnz.a("xpbl_dun_cvw_hr");
				num5 += 0.005f;
				num6 += 0.005f;
				dnz.b(num5);
				dnz.a(num6);
				d9m.c().Add(dnz);
				num = new int?((int)MathHelper.Clamp((float)(num.Value + 4), 0f, 255f));
				num3 = new int?((int)MathHelper.Clamp((float)(num3.Value - 2), 0f, 255f));
				num2 = new int?((int)MathHelper.Clamp((float)(num2.Value - 2), 0f, 255f));
				ck.a(new Color(num.Value, num2.Value, num3.Value, num4.Value));
				d9m.c().Add(ck);
				dtb.ad().Add(new a4s(d9m, new ar7(A_0), new ar7(A_0), null));
			}
			d9m d9m2 = new d9m();
			d9m2.a(num7 + 1000);
			nb nb = new nb();
			nb.a(false);
			nb.a(bvl.e);
			nb.a(new Guid?(A_0.qe()));
			d9m2.c().Add(nb);
			dtb.ad().Add(new a4s(d9m2, new ar7(A_0), new ar7(A_0), null));
			A_0.Zone.ActionManager.g9(dtb, atp.a);
			this.a(A_0, num7 + 3300);
		}
	}

	// Token: 0x060042DB RID: 17115 RVA: 0x001A10BC File Offset: 0x0019F2BC
	private void a(c5x A_0, int A_1)
	{
		dtb dtb = new dtb();
		d9m d9m = new d9m();
		d9m.a(A_1);
		A_0.Zone.ActionManager.g9(dtb, atp.a);
		ak1 ak = A_0.Area.a(A_0.s().a());
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					int num = -1;
					if ((i == 1 || i == -1) && j == 0)
					{
						num = cuo.a.Next(0, 2);
					}
					else if ((j == 1 || j == -1) && i == 0)
					{
						num = cuo.a.Next(3, 5);
					}
					if (num >= 0)
					{
						bool flag = ak.Area.b(ak.Location.X + i, ak.Location.Y + j) != null;
						Vector3 a_ = new Vector3(A_0.Location.X + (float)i, A_0.Location.Y + (float)j, A_0.Location.Z);
						if (flag)
						{
							List<cze> list = d9m.c();
							string a_2 = "Locale\\Floor\\SmearedBlood";
							bt4 a_3 = new bt4(A_0.Area.y8(), a_);
							int? a_4 = new int?(num);
							list.Add(new ezd(a_2, a_3, null, null, null, a_4, null));
							dtb.ad().Add(new a4s(d9m, new ar7(A_0), new ar7(A_0), null));
						}
					}
				}
			}
		}
		A_0.Zone.ActionManager.g9(dtb, atp.a);
	}

	// Token: 0x060042DC RID: 17116 RVA: 0x001A126C File Offset: 0x0019F46C
	private void a(string A_0, a3f A_1)
	{
		int num = A_1.a().GetPrimitivePropertyValue<int>("JuiceTeleportChance", new int?(0)).Value;
		if (!(A_0 == "GoodMind"))
		{
			if (!(A_0 == "NeutralMind"))
			{
				if (A_0 == "BadMind")
				{
					num += 2;
				}
			}
			else
			{
				num = num;
			}
		}
		else
		{
			num++;
		}
		A_1.a()["JuiceTeleportChance"] = num;
	}

	// Token: 0x060042DD RID: 17117 RVA: 0x001A12F8 File Offset: 0x0019F4F8
	private void f(string A_0, a3f A_1, int A_2)
	{
		int num = A_1.a().GetPrimitivePropertyValue<int>("SpeedModifier", new int?(0)).Value;
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 7:
			{
				char c = A_0[3];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "BadMind")
						{
							num += -35 - Math.Abs(A_2);
						}
					}
				}
				else if (A_0 == "BadGuts")
				{
					num += -30 - Math.Abs(A_2);
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'G')
				{
					if (c != 'M')
					{
						if (c == 'e')
						{
							if (A_0 == "BadHeart")
							{
								num += -40 - Math.Abs(A_2);
							}
						}
					}
					else if (A_0 == "GoodMind")
					{
						num += 1 + A_2;
					}
				}
				else if (A_0 == "GoodGuts")
				{
					num += 3 + A_2;
				}
				break;
			}
			case 9:
				if (A_0 == "GoodHeart")
				{
					num += 8 + A_2;
				}
				break;
			case 11:
			{
				char c = A_0[7];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "NeutralMind")
						{
							num += A_2;
						}
					}
				}
				else if (A_0 == "NeutralGuts")
				{
					num += 1 + A_2;
				}
				break;
			}
			case 12:
				if (A_0 == "NeutralHeart")
				{
					num += 2 + A_2;
				}
				break;
			}
		}
		A_1.a()["SpeedModifier"] = num;
	}

	// Token: 0x060042DE RID: 17118 RVA: 0x001A14F8 File Offset: 0x0019F6F8
	private void e(string A_0, a3f A_1, int A_2)
	{
		int num = A_1.a().GetPrimitivePropertyValue<int>("NegativeTriggerModifier", new int?(0)).Value;
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 7:
			{
				char c = A_0[3];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "BadMind")
						{
							num += -30 - Math.Abs(A_2);
						}
					}
				}
				else if (A_0 == "BadGuts")
				{
					num += -15 - Math.Abs(A_2);
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'G')
				{
					if (c != 'M')
					{
						if (c == 'e')
						{
							if (A_0 == "BadHeart")
							{
								num += -20 - Math.Abs(A_2);
							}
						}
					}
					else if (A_0 == "GoodMind")
					{
						num += 10 + A_2;
					}
				}
				else if (A_0 == "GoodGuts")
				{
					num += 5 + A_2;
				}
				break;
			}
			case 9:
				if (A_0 == "GoodHeart")
				{
					num += A_2;
				}
				break;
			case 11:
			{
				char c = A_0[7];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "NeutralMind")
						{
							num += -5 + A_2;
						}
					}
				}
				else if (A_0 == "NeutralGuts")
				{
					num += -20 + A_2;
				}
				break;
			}
			case 12:
				if (A_0 == "NeutralHeart")
				{
					num += -5 + A_2;
				}
				break;
			}
		}
		A_1.a()["NegativeTriggerModifier"] = num;
	}

	// Token: 0x060042DF RID: 17119 RVA: 0x001A16FC File Offset: 0x0019F8FC
	private void d(string A_0, a3f A_1, int A_2)
	{
		int num = A_1.a().GetPrimitivePropertyValue<int>("DamageResistModifier", new int?(0)).Value;
		int num2 = A_1.a().GetPrimitivePropertyValue<int>("DamageChanceModifier", new int?(0)).Value;
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 7:
			{
				char c = A_0[3];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "BadMind")
						{
							num += 5 - Math.Abs(A_2);
							num2 -= 25;
						}
					}
				}
				else if (A_0 == "BadGuts")
				{
					num += -5 - Math.Abs(A_2);
					num2 -= 25;
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'G')
				{
					if (c != 'M')
					{
						if (c == 'e')
						{
							if (A_0 == "BadHeart")
							{
								num += -1 - Math.Abs(A_2);
								num2 -= 30;
							}
						}
					}
					else if (A_0 == "GoodMind")
					{
						num += 1 + A_2;
						num2 += 15;
					}
				}
				else if (A_0 == "GoodGuts")
				{
					num += 3 + A_2;
					num2 += 10;
				}
				break;
			}
			case 9:
				if (A_0 == "GoodHeart")
				{
					num += 2 + A_2;
					num2 += 25;
				}
				break;
			case 11:
			{
				char c = A_0[7];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "NeutralMind")
						{
							num += 2 + A_2;
							num2 += 10;
						}
					}
				}
				else if (A_0 == "NeutralGuts")
				{
					num += 1 + A_2;
					num2 += 5;
				}
				break;
			}
			case 12:
				if (A_0 == "NeutralHeart")
				{
					num += 1 + A_2;
					num2 += 10;
				}
				break;
			}
		}
		A_1.a()["DamageResistModifier"] = num;
		A_1.a()["DamageChanceModifier"] = num2;
	}

	// Token: 0x060042E0 RID: 17120 RVA: 0x001A1968 File Offset: 0x0019FB68
	private void c(string A_0, a3f A_1, int A_2)
	{
		int num = A_1.a().GetPrimitivePropertyValue<int>("StunModifier", new int?(0)).Value;
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 7:
			{
				char c = A_0[3];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "BadMind")
						{
							num += -15 - Math.Abs(A_2);
						}
					}
				}
				else if (A_0 == "BadGuts")
				{
					num += -10 - Math.Abs(A_2);
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'G')
				{
					if (c != 'M')
					{
						if (c == 'e')
						{
							if (A_0 == "BadHeart")
							{
								num += -20 - Math.Abs(A_2);
							}
						}
					}
					else if (A_0 == "GoodMind")
					{
						num += 10 + A_2;
					}
				}
				else if (A_0 == "GoodGuts")
				{
					num += 5 + A_2;
				}
				break;
			}
			case 9:
				if (A_0 == "GoodHeart")
				{
					num += 2 + A_2;
				}
				break;
			case 11:
			{
				char c = A_0[7];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "NeutralMind")
						{
							num += A_2;
						}
					}
				}
				else if (A_0 == "NeutralGuts")
				{
					num += A_2;
				}
				break;
			}
			case 12:
				if (A_0 == "NeutralHeart")
				{
					num += -10 + A_2;
				}
				break;
			}
		}
		A_1.a()["StunModifier"] = num;
	}

	// Token: 0x060042E1 RID: 17121 RVA: 0x001A1B68 File Offset: 0x0019FD68
	private void b(string A_0, a3f A_1, int A_2)
	{
		int num = A_1.a().GetPrimitivePropertyValue<int>("HealChanceModifier", new int?(0)).Value;
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 7:
			{
				char c = A_0[3];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "BadMind")
						{
							num += 1 - Math.Abs(A_2);
						}
					}
				}
				else if (A_0 == "BadGuts")
				{
					num += -15 - Math.Abs(A_2);
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'G')
				{
					if (c != 'M')
					{
						if (c == 'e')
						{
							if (A_0 == "BadHeart")
							{
								num += -35 - Math.Abs(A_2);
							}
						}
					}
					else if (A_0 == "GoodMind")
					{
						num += 3 + A_2;
					}
				}
				else if (A_0 == "GoodGuts")
				{
					num += 15 + A_2;
				}
				break;
			}
			case 9:
				if (A_0 == "GoodHeart")
				{
					num += 20 + A_2;
				}
				break;
			case 11:
			{
				char c = A_0[7];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "NeutralMind")
						{
							num += 2 + A_2;
						}
					}
				}
				else if (A_0 == "NeutralGuts")
				{
					num += 5 + A_2;
				}
				break;
			}
			case 12:
				if (A_0 == "NeutralHeart")
				{
					num += 15 + A_2;
				}
				break;
			}
		}
		A_1.a()["HealChanceModifier"] = num;
	}

	// Token: 0x060042E2 RID: 17122 RVA: 0x001A1D6C File Offset: 0x0019FF6C
	private void a(string A_0, a3f A_1, int A_2)
	{
		int num = A_1.a().GetPrimitivePropertyValue<int>("healValueModifier", new int?(0)).Value;
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 7:
			{
				char c = A_0[3];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "BadMind")
						{
							num += -8 - Math.Abs(A_2);
						}
					}
				}
				else if (A_0 == "BadGuts")
				{
					num += -5 - Math.Abs(A_2);
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'G')
				{
					if (c != 'M')
					{
						if (c == 'e')
						{
							if (A_0 == "BadHeart")
							{
								num += -10 - Math.Abs(A_2);
							}
						}
					}
					else if (A_0 == "GoodMind")
					{
						num += 4 + A_2;
					}
				}
				else if (A_0 == "GoodGuts")
				{
					num += 2 + A_2;
				}
				break;
			}
			case 9:
				if (A_0 == "GoodHeart")
				{
					num += 6 + A_2;
				}
				break;
			case 11:
			{
				char c = A_0[7];
				if (c != 'G')
				{
					if (c == 'M')
					{
						if (A_0 == "NeutralMind")
						{
							num += 2 + A_2;
						}
					}
				}
				else if (A_0 == "NeutralGuts")
				{
					num += 1 + A_2;
				}
				break;
			}
			case 12:
				if (A_0 == "NeutralHeart")
				{
					num += 3 + A_2;
				}
				break;
			}
		}
		A_1.a()["healValueModifier"] = num;
	}

	// Token: 0x04001C2F RID: 7215
	private new string a;

	// Token: 0x04001C30 RID: 7216
	private Guid? b;
}
