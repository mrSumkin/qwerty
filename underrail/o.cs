using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003B9 RID: 953
[fe("xpbl_wumb_greySolider")]
public class o : b5g
{
	// Token: 0x060019F9 RID: 6649 RVA: 0x0008B598 File Offset: 0x00089798
	public o(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToPlayer", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(o.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x0008B618 File Offset: 0x00089818
	private static string a(string A_0, bool A_1, bool A_2)
	{
		string text = "loc_" + A_0 + "_greyArmyTalk";
		if (A_1)
		{
			text += "_sbjOfficer";
		}
		else
		{
			text += "_sbjSoldier";
		}
		if (A_2)
		{
			text += "_plOfficer";
		}
		else
		{
			text += "_plSoldier";
		}
		return text;
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x0008B680 File Offset: 0x00089880
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Zone != null && c5x.h.b != null && c5x.Area == this.Subject.a8().Area)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				if (blk != null && blk.b() && blk.f() != global::h.a)
				{
					bool flag = base.h().am() == bln.hb;
					bool flag2 = c5x.h.b.aa().Gear.l().Item.fu().e() == "xpbl_rao";
					bool flag3 = c5x.h.b.aa().Gear.l().Item.fu().e() == "xpbl_ras";
					if (flag2 || flag3)
					{
						bool flag4 = false;
						bool flag5 = false;
						string text = c5x.Zone.y8();
						if (text == "xpbl_wumb1")
						{
							if (flag2)
							{
								if (flag)
								{
									flag4 = true;
									flag5 = true;
								}
								else
								{
									flag4 = true;
									flag5 = true;
								}
							}
							else if (flag)
							{
								flag4 = true;
								flag5 = true;
							}
							else
							{
								flag4 = true;
								flag5 = true;
							}
						}
						else if (text == "xpbl_wumb2")
						{
							if (flag2)
							{
								if (flag)
								{
									flag4 = false;
								}
								else
								{
									flag4 = true;
									flag5 = false;
								}
							}
							else if (flag)
							{
								flag4 = false;
							}
							else
							{
								flag4 = true;
								flag5 = true;
							}
						}
						else if (text == "xpbl_wumb3")
						{
							if (flag2)
							{
								if (flag)
								{
									flag4 = true;
									flag5 = true;
								}
								else
								{
									flag4 = true;
									flag5 = true;
								}
							}
							else if (flag)
							{
								flag4 = true;
								flag5 = false;
							}
							else
							{
								flag4 = true;
								flag5 = false;
							}
						}
						else if (text == "xpbl_wumb4")
						{
							if (flag2)
							{
								if (flag)
								{
									flag4 = true;
									flag5 = true;
								}
								else
								{
									flag4 = true;
									flag5 = false;
								}
							}
							else if (flag)
							{
								flag4 = true;
								flag5 = true;
							}
							else
							{
								flag4 = true;
								flag5 = true;
							}
						}
						if (flag4)
						{
							string name = o.a(text, flag, flag2);
							TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>(name, null);
							if (primitivePropertyValue == null || primitivePropertyValue.Value < serviceOrThrow.aqu().o())
							{
								double num = 5.0;
								bool flag6 = true;
								if (!flag5 || this.Subject.y6().GetPrimitivePropertyValue<bool>("GreySoldierAlwaysInitDialog", new bool?(false)).Value)
								{
									num = 10.0;
									flag6 = false;
								}
								bool flag7 = bui.b(bnx.a(this.Subject.a8().Location.b(), this.Subject.a8().VisualDirection, serviceOrThrow.aqu().v().b().Location.b())) == aiy.b8;
								if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= num && (!flag6 || flag7))
								{
									return true;
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x0008BA88 File Offset: 0x00089C88
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			j7 aspect = c5x.GetAspect<j7>();
			j7 aspect2 = this.Subject.a8().GetAspect<j7>();
			if (aspect2 != null && aspect != null)
			{
				bool a_ = base.h().am() == bln.hb;
				bool a_2 = c5x.h.b.aa().Gear.l().Item.fu().e() == "xpbl_rao";
				c5x.h.b.aa().Gear.l().Item.fu().e() == "xpbl_ras";
				bool flag = c5x.Zone.y8() == "xpbl_wumb3";
				string name = o.a(c5x.Zone.y8(), a_, a_2);
				c4f c4f = new c4f();
				if (flag && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("xpbl_loc_wumb3_soldier_passOff", new bool?(false)).Value)
				{
					c4f.Properties[name] = serviceOrThrow.aqu().o() + TimeSpan.FromSeconds(10.0);
				}
				else
				{
					c4f.Properties[name] = serviceOrThrow.aqu().o() + TimeSpan.FromDays(1000000.0);
				}
				awx awx = new awx();
				awx.a(m7.b);
				awx.b(true);
				awx.c(true);
				awx.ad().Add(new e1i(this.Subject.a8().k.b, c5x, aju.q));
				awx.ad().Add(new a4s(c4f, null, null, null));
				awx.ad().Add(new c9m(aspect2, aspect, true, null, false));
				return awx;
			}
		}
		return null;
	}

	// Token: 0x020003BA RID: 954
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060019FF RID: 6655 RVA: 0x0008BCEC File Offset: 0x00089EEC
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000EA4 RID: 3748
		public static readonly o.a a = new o.a();

		// Token: 0x04000EA5 RID: 3749
		public static Func<bool, float> b;
	}
}
