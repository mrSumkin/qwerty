using System;
using System.Linq;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000EF0 RID: 3824
[e79("Xphw_GunslingerStrengthCheckAssist")]
public sealed class d59 : dgy
{
	// Token: 0x06004E53 RID: 20051 RVA: 0x0022C65C File Offset: 0x0022A85C
	public d59()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x.i.b.a(true, false);
				c5x c5x2 = new ar7(c29.a, c5x.Area).ao() as c5x;
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xphw_exobase_strengthCheck_orientation");
				string str = classPropertyValue;
				serviceOrThrow.aqu().r().RemoveProperty("loc_xphw_exobase_strengthCheck_orientation");
				if (!this.a(c5x2, Enumerable.FirstOrDefault<ak1>(c5x.l)))
				{
					str = this.a(classPropertyValue);
				}
				if (c5x2 != null && classPropertyValue != null)
				{
					c5x a_ = (cuo.a.Next(0, 2) == 0) ? c5x2 : c5x;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(c5x));
					s.a(new bt4("player_strength" + classPropertyValue));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(c5x2));
					s2.a(new bt4("gunslinger_strength" + str));
					s2.IsAsync = false;
					s2.a(true);
					array2[num2] = s2;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx = new egx();
					egx.a("Три, два, один...");
					array3[num3] = new ace(egx)
					{
						TargetRef = new ar7(a_)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx2 = new egx();
					egx2.a((cuo.a.Next(0, 2) == 0) ? "Ура!" : "Даёш!");
					array4[num4] = new ace(egx2)
					{
						TargetRef = new ar7(a_)
					};
					base.a(array4);
					btm[] array5 = new btm[1];
					int num5 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.OperateShort);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(c5x2));
					bb.b(1);
					array5[num5] = bb;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.OperateShort);
					bb2.a(atp.a);
					bb2.IsAsync = true;
					bb2.a(new ar7(c5x));
					bb2.b(1);
					array6[num6] = bb2;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new ace(this.a(c5x.Area))
						{
							TargetRef = new ar7(c5x)
						}
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					return;
				}
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(this.a(c5x.Area))
					{
						TargetRef = new ar7(c5x)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x06004E54 RID: 20052 RVA: 0x0022CA54 File Offset: 0x0022AC54
	private cze a(aud A_0)
	{
		if (A_0.Zone.y8().EndsWith("arm"))
		{
			crx crx = new crx();
			crx.a(bbo.b);
			crx.a(A_0.y8());
			crx.a(true);
			crx.b("WorkshopGate");
			return crx;
		}
		if (A_0.Zone.y8().EndsWith("lab2"))
		{
			b6r b6r = new b6r();
			b6r.a(bbo.b);
			b6r.b(A_0.y8());
			b6r.a(true);
			b6r.b(new Guid("d5e2eddd-90c9-40f5-9f04-3a1b0a56f8f9"));
			b6r.a(new Guid("df39b90d-e20b-41c9-925a-d34e4217aedb"));
			return b6r;
		}
		return null;
	}

	// Token: 0x06004E55 RID: 20053 RVA: 0x0022CB04 File Offset: 0x0022AD04
	private string a(string A_0)
	{
		if (A_0 == null)
		{
			return A_0;
		}
		if (A_0 == "North")
		{
			return "South";
		}
		if (A_0 == "South")
		{
			return "North";
		}
		if (A_0 == "East")
		{
			return "West";
		}
		if (!(A_0 == "West"))
		{
			throw new Exception("Не удаётся найти противоположную сторону. Возвращаемся к настройкам по умолчанию.");
		}
		return "East";
	}

	// Token: 0x06004E56 RID: 20054 RVA: 0x0022CB80 File Offset: 0x0022AD80
	private bool a(c5x A_0, ak1 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && serviceOrThrow.aqu().v().b().Zone.n(A_0.Area.y8()) != null && A_1 != null)
		{
			ale aspect = A_0.GetAspect<ale>();
			if (aspect != null)
			{
				fk fk = new fk(aspect, A_1, null, false, 0);
				fk.l();
				czp czp = fk.g();
				czp.n.a = false;
				czp.p = false;
				czp.q = false;
				d25 d = czp.l as d25;
				if (d == null)
				{
					d = new d25();
					czp.l = d;
				}
				d.b = false;
				d.c = false;
				c5w c5w = bpo.GetServiceOrThrow<wu>().aki(czp, aspect.a8().Playfield.PathProcessor, eso.d);
				c5w.au1();
				if (c5w.aus().Count / 4 < 16)
				{
					foreach (yz yz in c5w.aus())
					{
						if ((double)bnx.a(new Point((int)yz.a.a.X / 4, (int)yz.a.a.Y / 4), A_1.Location) < 2.0)
						{
							return true;
						}
					}
					return false;
				}
			}
		}
		return false;
	}
}
