using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02000AC8 RID: 2760
[eiz("XPHWEBVMSJ")]
[Serializable]
public sealed class el3 : cze, ISerializable
{
	// Token: 0x06004057 RID: 16471 RVA: 0x00187434 File Offset: 0x00185634
	private el3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (HorizontalDirection?)A_0.GetValue("XPHWEBVMSJ:D", typeof(HorizontalDirection?));
		this.b = A_0.GetString("XPHWEBVMSJ:R");
		this.c = A_0.GetBoolean("XPHWEBVMSJ:A");
	}

	// Token: 0x06004058 RID: 16472 RVA: 0x0018748C File Offset: 0x0018568C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWEBVMSJ:D", this.a);
		info.AddValue("XPHWEBVMSJ:R", this.b);
		info.AddValue("XPHWEBVMSJ:A", this.c);
	}

	// Token: 0x06004059 RID: 16473 RVA: 0x001874DC File Offset: 0x001856DC
	public HorizontalDirection? a()
	{
		return this.a;
	}

	// Token: 0x0600405A RID: 16474 RVA: 0x001874E4 File Offset: 0x001856E4
	public void b(HorizontalDirection? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600405B RID: 16475 RVA: 0x001874F0 File Offset: 0x001856F0
	public string c()
	{
		return this.b;
	}

	// Token: 0x0600405C RID: 16476 RVA: 0x001874F8 File Offset: 0x001856F8
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600405D RID: 16477 RVA: 0x00187504 File Offset: 0x00185704
	public bool b()
	{
		return this.c;
	}

	// Token: 0x0600405E RID: 16478 RVA: 0x0018750C File Offset: 0x0018570C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600405F RID: 16479 RVA: 0x00187518 File Offset: 0x00185718
	public el3()
	{
	}

	// Token: 0x06004060 RID: 16480 RVA: 0x00187520 File Offset: 0x00185720
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					a3f aspect = c5x2.GetAspect<a3f>();
					if (aspect != null)
					{
						if (!this.c)
						{
							c5x c5x3 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
							{
								this.b
							})) as c5x;
							if (c5x3 != null)
							{
								string text = this.b(c5x3);
								if (!text.Equals(""))
								{
									string a_ = "";
									string text2 = this.a(serviceOrThrow, this.a, out a_, text, aspect);
									if (!text2.Equals(""))
									{
										this.a(text2, a_, c5x3);
										return;
									}
								}
							}
						}
						else
						{
							if (this.a == null)
							{
								int num = 0;
								int[] array = new int[]
								{
									4,
									5,
									6,
									7,
									8,
									9,
									10,
									11,
									12,
									13,
									14,
									15,
									2,
									3,
									1
								};
								List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
								{
									"sol"
								});
								list.AddRange(serviceOrThrow.aqw().a().ab4(new string[]
								{
									"med"
								}));
								list.AddRange(serviceOrThrow.aqw().a().ab4(new string[]
								{
									"int"
								}));
								using (List<b0b>.Enumerator enumerator = list.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										b0b b0b = enumerator.Current;
										c5x a_2 = (c5x)b0b;
										this.a("init_" + array[num++].ToString(), null, a_2);
									}
									return;
								}
							}
							if (bpo.GetService<d02>() != null)
							{
								string text3 = this.a(this.a);
								if (!text3.Equals(""))
								{
									int? num2 = null;
									if (!text3.Equals("init"))
									{
										num2 = new int?((int)aspect.a()[text3]);
										if (num2 != null)
										{
											int? num3 = num2;
											int num4 = 3;
											if (num3.GetValueOrDefault() <= num4 & num3 != null)
											{
												using (List<b0b>.Enumerator enumerator = serviceOrThrow.aqw().a().ab4(new string[]
												{
													"voidFighter"
												}).GetEnumerator())
												{
													while (enumerator.MoveNext())
													{
														b0b b0b2 = enumerator.Current;
														c5x c5x4 = (c5x)b0b2;
														a3f aspect2 = c5x4.GetAspect<a3f>();
														if (aspect2 != null && aspect2.a()["position"] != null && aspect2.a()["position"].ToString() == text3)
														{
															string text4 = this.a(serviceOrThrow, this.a, out text3, this.b(c5x4), aspect);
															if (!text4.Equals(""))
															{
																this.a(text4, text3, c5x4);
															}
														}
													}
													return;
												}
											}
										}
										List<b0b> list2 = serviceOrThrow.aqw().a().ab4(new string[]
										{
											"voidFighter"
										});
										string text5 = text3;
										foreach (b0b b0b3 in list2)
										{
											c5x c5x5 = (c5x)b0b3;
											a3f aspect3 = c5x5.GetAspect<a3f>();
											if (aspect3 != null && aspect3.a()["position"] != null && aspect3.a()["position"].ToString() == text5)
											{
												string text6 = this.a(serviceOrThrow, null, out text3, this.b(c5x5), aspect);
												if (!text6.Equals(""))
												{
													this.a(text6, "init", c5x5);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004061 RID: 16481 RVA: 0x00187978 File Offset: 0x00185B78
	private string a(cnk A_0, HorizontalDirection? A_1, out string A_2, string A_3, a3f A_4)
	{
		A_2 = this.a(A_1);
		int? num = null;
		if (!A_2.Equals("init"))
		{
			num = new int?((int)A_4.a()[A_2]);
		}
		string str = A_2;
		int? num2 = num;
		string str2 = str + num2.ToString() + "_";
		if (A_2.Equals("init"))
		{
			str2 = A_2 + "_";
		}
		num2 = num;
		int num3 = 0;
		if ((num2.GetValueOrDefault() >= num3 & num2 != null) || num == null)
		{
			List<int> list = new List<int>();
			if (!(A_3 == "soldier"))
			{
				if (!(A_3 == "medic"))
				{
					if (!(A_3 == "intercessor"))
					{
						return "";
					}
					return str2 + 1.ToString();
				}
				else
				{
					list.AddRange(new int[]
					{
						2,
						3
					});
				}
			}
			else
			{
				list.AddRange(new int[]
				{
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15
				});
			}
			foreach (int num4 in list)
			{
				foreach (csd csd in new List<csd>(A_0.aqw().Waypoints))
				{
					if (csd.Name.Contains(str2 + num4.ToString()))
					{
						bool flag = true;
						foreach (b0b b0b in csd.Tile.c.Values)
						{
							e3l aspect = ((c5x)b0b).GetAspect<e3l>();
							if (aspect != null)
							{
								if (Enumerable.Any<string>(aspect.a, new Func<string, bool>(el3.a.a.b)))
								{
									flag = true;
									break;
								}
							}
							else
							{
								flag = false;
							}
						}
						if (!flag)
						{
							return str2 + num4.ToString();
						}
					}
				}
			}
		}
		return "";
	}

	// Token: 0x06004062 RID: 16482 RVA: 0x00187C50 File Offset: 0x00185E50
	private void a(string A_0, string A_1, c5x A_2)
	{
		el3.b b = new el3.b();
		b.a = A_2;
		a3f aspect = b.a.GetAspect<a3f>();
		if (aspect != null)
		{
			this.a(b.a);
			b.a.b("CurrentPosition" + A_1);
			e3l aspect2 = b.a.GetAspect<e3l>();
			if (aspect2 != null)
			{
				aspect2.a();
			}
			aspect.a()["position"] = A_1;
		}
		csd csd = b.a.Zone.g(A_0);
		if (csd == null)
		{
			return;
		}
		if (b.a.t.b != null)
		{
			b.a.t.b.y6()[ddq.ay] = new bt4(csd.Name);
		}
		b.a.Location;
		c5x a_ = null;
		ak1 ak = b.a.Area.a(b.a.aj().a());
		if (ak != null)
		{
			a_ = (Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.Entities, new Func<b0b, bool>(b.a))) as c5x);
		}
		boj.a(b.a, "xphw_voidTeleportOut", 1, double.MaxValue, false, false, null, null, null, null, true);
		b.a.ae = new float?(0f);
		b.a.Location = csd.Location;
		b.a.ah();
		dtb dtb = new dtb();
		dtb.ad().Add(new bxp(b.a, csd.Direction));
		dtb.ad().Add(new a4s(new bfq("xphw_VoidTeleportOut"), null, new ar7(a_), null));
		dtb.ad().Add(new a7j(b.a, "xphw_voidTeleportIn", 1, double.MaxValue, false, false, null, null, null, null, true, null));
		dtb.ad().Add(new a4s(new bfq("xphw_VoidTeleportOut"), null, new ar7(b.a), null));
		List<auv> list = dtb.ad();
		ad6 ad = new ad6(b.a);
		ad.b(0.0);
		ad.c(1.0);
		ad.a(0.002);
		list.Add(ad);
		b.a.Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
	}

	// Token: 0x06004063 RID: 16483 RVA: 0x00187F24 File Offset: 0x00186124
	private string b(c5x A_0)
	{
		e3l aspect = A_0.GetAspect<e3l>();
		if (aspect == null)
		{
			return "";
		}
		if (Enumerable.Any<string>(aspect.a, new Func<string, bool>(el3.a.a.c)))
		{
			return "soldier";
		}
		if (Enumerable.Any<string>(aspect.a, new Func<string, bool>(el3.a.a.a)))
		{
			return "medic";
		}
		return "intercessor";
	}

	// Token: 0x06004064 RID: 16484 RVA: 0x00187FBC File Offset: 0x001861BC
	public string a(HorizontalDirection? A_0)
	{
		if (A_0 != null)
		{
			switch (A_0.GetValueOrDefault())
			{
			case HorizontalDirection.North:
				return "north";
			case HorizontalDirection.East:
				return "east";
			case HorizontalDirection.South:
				return "south";
			case HorizontalDirection.West:
				return "west";
			}
			return "";
		}
		return "init";
	}

	// Token: 0x06004065 RID: 16485 RVA: 0x00188028 File Offset: 0x00186228
	public HorizontalDirection a(string A_0)
	{
		if (A_0 == "north")
		{
			return HorizontalDirection.North;
		}
		if (A_0 == "east")
		{
			return HorizontalDirection.East;
		}
		if (A_0 == "south")
		{
			return HorizontalDirection.South;
		}
		if (!(A_0 == "west"))
		{
			return HorizontalDirection.North;
		}
		return HorizontalDirection.West;
	}

	// Token: 0x06004066 RID: 16486 RVA: 0x00188084 File Offset: 0x00186284
	private void a(c5x A_0)
	{
		if (A_0 != null)
		{
			e3l aspect = A_0.GetAspect<e3l>();
			if (aspect != null)
			{
				aspect.a.Remove("CurrentPositionnorth");
				aspect.a.Remove("CurrentPositioneast");
				aspect.a.Remove("CurrentPositionsouth");
				aspect.a.Remove("CurrentPositionwest");
				aspect.a.Remove("CurrentPositioninit");
				aspect.a();
			}
		}
	}

	// Token: 0x04001BF4 RID: 7156
	private new HorizontalDirection? a;

	// Token: 0x04001BF5 RID: 7157
	private string b;

	// Token: 0x04001BF6 RID: 7158
	private bool c;

	// Token: 0x02000AC9 RID: 2761
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004069 RID: 16489 RVA: 0x00188114 File Offset: 0x00186314
		internal bool b(string A_0)
		{
			return A_0.Contains("sol") || A_0.Contains("med");
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00188134 File Offset: 0x00186334
		internal bool c(string A_0)
		{
			return A_0.Contains("sol");
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00188144 File Offset: 0x00186344
		internal bool a(string A_0)
		{
			return A_0.Contains("med");
		}

		// Token: 0x04001BF7 RID: 7159
		public static readonly el3.a a = new el3.a();

		// Token: 0x04001BF8 RID: 7160
		public static Func<string, bool> b;

		// Token: 0x04001BF9 RID: 7161
		public static Func<string, bool> c;

		// Token: 0x04001BFA RID: 7162
		public static Func<string, bool> d;
	}

	// Token: 0x02000ACA RID: 2762
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600406D RID: 16493 RVA: 0x0018815C File Offset: 0x0018635C
		internal bool a(b0b A_0)
		{
			return A_0 != this.a;
		}

		// Token: 0x04001BFB RID: 7163
		public c5x a;
	}
}
