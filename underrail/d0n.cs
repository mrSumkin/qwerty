using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules;

// Token: 0x02000F8B RID: 3979
[eiz("TZCEA")]
[Serializable]
public sealed class d0n : Aspect<c5x>, c98, chb
{
	// Token: 0x06005118 RID: 20760 RVA: 0x00248270 File Offset: 0x00246470
	private d0n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.e = A_0.GetInt32("TZCEA:T");
		this.d = A_0.GetDouble("TZCEA:C");
		this.f = A_0.GetBoolean("TZCEA:E");
		if (ell.a() >= 322)
		{
			this.h = A_0.GetInt32("TZCEA:S");
		}
		di7.ReadList<string>("TZCEA:I", ref this.g, A_0);
	}

	// Token: 0x06005119 RID: 20761 RVA: 0x002482FC File Offset: 0x002464FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TZCEA:T", this.e);
		info.AddValue("TZCEA:C", this.d);
		info.AddValue("TZCEA:E", this.f);
		info.AddValue("TZCEA:S", this.h);
		di7.WriteList<string>("TZCEA:I", this.g, info);
	}

	// Token: 0x0600511A RID: 20762 RVA: 0x00248368 File Offset: 0x00246568
	public bool e()
	{
		return this.f;
	}

	// Token: 0x0600511B RID: 20763 RVA: 0x00248370 File Offset: 0x00246570
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600511C RID: 20764 RVA: 0x0024837C File Offset: 0x0024657C
	public int f()
	{
		return this.e;
	}

	// Token: 0x0600511D RID: 20765 RVA: 0x00248384 File Offset: 0x00246584
	public List<string> d()
	{
		return this.g;
	}

	// Token: 0x0600511E RID: 20766 RVA: 0x0024838C File Offset: 0x0024658C
	public void a(List<string> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600511F RID: 20767 RVA: 0x00248398 File Offset: 0x00246598
	public d0n(c5x A_0) : base(A_0)
	{
		this.d = 0.0;
	}

	// Token: 0x06005120 RID: 20768 RVA: 0x002483C4 File Offset: 0x002465C4
	public void r7(eds A_0)
	{
		if (this.f && !dz6.e())
		{
			if ((this.d -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.d += (double)d0u.b;
				this.a(false);
				return;
			}
		}
		else
		{
			this.d = (double)d0u.b;
		}
	}

	// Token: 0x06005121 RID: 20769 RVA: 0x00248438 File Offset: 0x00246638
	public void c()
	{
		if (this.f)
		{
			this.a(true);
		}
	}

	// Token: 0x06005122 RID: 20770 RVA: 0x00248450 File Offset: 0x00246650
	private void a(bool A_0 = false)
	{
		if (base.a8().GetAspect<bja>() == null)
		{
			bja bja = new bja(base.a8());
			bja.c(5);
			bja.a("tchortlingSurger");
			base.a8().SetAspect<bja>(bja);
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				v7 v = Enumerable.FirstOrDefault<v7>(c5x.h.b.aa().StatusEffects.Get<v7>());
				aav aav = Enumerable.FirstOrDefault<aav>(c5x.h.b.aa().StatusEffects.Get<aav>());
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
				bool flag = false;
				if (value)
				{
					if (v != null)
					{
						c5x.h.b.aa().StatusEffects.d(v);
					}
					if (aav != null)
					{
						c5x.h.b.aa().StatusEffects.d(aav);
					}
				}
				else if (aav != null)
				{
					if (c5x.Area == base.a8().Area)
					{
						aav a_ = new aav(2 * d0u.b + 1000);
						c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
					}
					flag = true;
				}
				else if (v != null && v.Stacks == v7.c && c5x.Area == base.a8().Area)
				{
					c5x.h.b.aa().StatusEffects.d(v);
					aav a_2 = new aav(2 * d0u.b + 1000);
					c5x.h.b.aa().StatusEffects.a(a_2, false, false, false);
				}
				else if (c5x.Area == base.a8().Area)
				{
					int num = this.a(c5x.h.b.aa().Feats.Contains<a5x>(), serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("feat_echoingSoliloquy_persuasionLevel", new int?(0)).Value);
					if (num > 0)
					{
						v7 v2 = new v7(2 * d0u.b + 1000);
						v2.Stacks = num;
						c5x.h.b.aa().StatusEffects.a(v2, false, false, false);
					}
					else if (v != null)
					{
						v.TimeLeft = (double)(2 * d0u.b + 1000);
					}
				}
				d60 d = base.a8().Zone.a();
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"tchortlingSurger"
					});
					HashSet<string> hashSet = new HashSet<string>();
					foreach (b0b b0b in list)
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2 != null && c5x2.t.b != null)
						{
							string classPropertyValue = c5x2.t.b.y6().GetClassPropertyValue<string>("TchortlingOriginWaypoint");
							if (!string.IsNullOrEmpty(classPropertyValue))
							{
								hashSet.Add(classPropertyValue);
								if (flag)
								{
									c5x2.t.b.y6().RemoveProperty(ddq.ay);
									c5x2.t.b.y6().RemoveProperty(ddq.bg);
									c5x2.t.b.y6()[ddq.ae] = base.a8().qe();
									c5x2.t.b.y6()[ddq.af] = base.a8().Area.y8();
									c5x2.t.b.y6()[ddq.bo] = 5;
									c5x2.t.b.y6()[ddq.bn] = 40;
									c5x2.t.b.y6()[ddq.bm] = true;
								}
								else
								{
									c5x2.t.b.y6()[ddq.ay] = new bt4(classPropertyValue);
									c5x2.t.b.y6()[ddq.bg] = true;
									c5x2.t.b.y6().RemoveProperty(ddq.ae);
									c5x2.t.b.y6().RemoveProperty(ddq.af);
									c5x2.t.b.y6().RemoveProperty(ddq.bo);
									c5x2.t.b.y6().RemoveProperty(ddq.bn);
									c5x2.t.b.y6().RemoveProperty(ddq.bm);
								}
							}
						}
					}
					if (flag)
					{
						if (this.h > 0)
						{
							this.h--;
						}
						if (this.h <= 0 && list.Count < this.a())
						{
							List<string> list2 = new List<string>(this.g);
							while (list2.Count > 0)
							{
								int index = cuo.a.Next(list2.Count);
								string text = list2[index];
								list2.RemoveAt(index);
								if (hashSet.Count >= this.g.Count || !hashSet.Contains(text))
								{
									csd csd = base.a8().Zone.g(text);
									if (csd != null && csd.Tile != null && !aw1.a(null, csd.Tile, false, null) && !this.a(c5x.t.b, csd.Tile))
									{
										c5x c5x3 = vq.a(d0n.c[cuo.a.Next(d0n.c.Length)], csd, false);
										if (c5x3 != null)
										{
											if (c5x3.t.b != null)
											{
												c5x3.t.b.y6()["TchortlingOriginWaypoint"] = text;
												c5x3.t.b.y6()[ddq.ae] = base.a8().qe();
												c5x3.t.b.y6()[ddq.af] = base.a8().Area.y8();
												c5x3.t.b.y6()[ddq.bo] = 5;
												c5x3.t.b.y6()[ddq.bn] = 40;
												c5x3.t.b.y6()[ddq.bm] = true;
											}
											e3l e3l = c5x3.GetAspect<e3l>();
											if (e3l == null)
											{
												e3l = new e3l(c5x3);
												c5x3.SetAspect<e3l>(e3l);
											}
											e3l.a.Add("tchortlingSurger");
											e3l.a();
											this.h = this.b();
											return;
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

	// Token: 0x06005123 RID: 20771 RVA: 0x00248C38 File Offset: 0x00246E38
	private int a(bool A_0, int A_1)
	{
		bu6 service = bpo.GetService<bu6>();
		int num;
		if (service != null)
		{
			switch (service.aq2())
			{
			default:
				num = 1;
				break;
			case GameDifficulty.Hard:
				num = cuo.a.Next(2, 4);
				break;
			case GameDifficulty.Dominating:
				num = cuo.a.Next(3, 6);
				break;
			}
		}
		else
		{
			num = 1;
		}
		int num2 = 0;
		if (!A_0)
		{
			num2 = num;
		}
		else
		{
			for (int i = 0; i < num; i++)
			{
				if (cuo.a.NextDouble() < 0.45 - (double)A_1 * 0.05)
				{
					num2++;
				}
			}
		}
		return num2;
	}

	// Token: 0x06005124 RID: 20772 RVA: 0x00248CE8 File Offset: 0x00246EE8
	private int b()
	{
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			switch (service.aq2())
			{
			case GameDifficulty.Easy:
				return 10;
			case GameDifficulty.Normal:
				return 5;
			case GameDifficulty.Hard:
				return 2;
			case GameDifficulty.Dominating:
				return 1;
			}
		}
		return 5;
	}

	// Token: 0x06005125 RID: 20773 RVA: 0x00248D30 File Offset: 0x00246F30
	private int a()
	{
		double num = 1.0;
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			switch (service.aq2())
			{
			case GameDifficulty.Easy:
				num = 0.5;
				break;
			case GameDifficulty.Normal:
				num = 1.0;
				break;
			case GameDifficulty.Hard:
				num = 1.75;
				break;
			case GameDifficulty.Dominating:
				num = 2.5;
				break;
			}
		}
		return (int)Math.Ceiling((double)this.g.Count * num);
	}

	// Token: 0x06005126 RID: 20774 RVA: 0x00248DC0 File Offset: 0x00246FC0
	private bool a(bm6 A_0, ak1 A_1)
	{
		return A_0 != null && A_0.ai() && A_0.a(A_1);
	}

	// Token: 0x04002139 RID: 8505
	private const string a = "tchortlingSurger";

	// Token: 0x0400213A RID: 8506
	private const string b = "TchortlingOriginWaypoint";

	// Token: 0x0400213B RID: 8507
	private static readonly string[] c = new string[]
	{
		"creatures\\TchortlingDevourer",
		"creatures\\TchortlingScanner",
		"creatures\\TchortlingSower"
	};

	// Token: 0x0400213C RID: 8508
	private double d;

	// Token: 0x0400213D RID: 8509
	private int e;

	// Token: 0x0400213E RID: 8510
	private bool f = true;

	// Token: 0x0400213F RID: 8511
	private List<string> g = new List<string>();

	// Token: 0x04002140 RID: 8512
	private int h;
}
