using System;
using System.Diagnostics;

// Token: 0x020021FC RID: 8700
[bmq("1.0.0.11_AgronomyShroomLab", "1.0.0.11", "StationAlpha-Level8", false)]
public sealed class dyb : fg
{
	// Token: 0x0600CA51 RID: 51793 RVA: 0x00479EE0 File Offset: 0x004780E0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("3f9e64dc-3b89-48e4-a63a-a521bf06aa72"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("2de12727-1d51-4dac-bc30-d3de2edb70a0"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("ebaaca9b-df00-4e02-94fa-3b3d1a8a285a"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("6eaee7b8-f81b-40fc-906f-e83e3e0f0eb2"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			if (c5x != null)
			{
				c3g c3g = c5x.GetAspect<c3g>();
				if (c3g == null)
				{
					c3g = new c3g(c5x);
					c5x.SetAspect<c3g>(c3g);
				}
				c3g.d().Add(asp.f);
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null)
				{
					aspect.a(d1c.c);
					aspect.b(true);
					aspect.a(true);
					aspect.a(60);
					aspect.b("key.quintonsKey");
				}
			}
			if (c5x2 != null)
			{
				amc aspect2 = c5x2.GetAspect<amc>();
				if (aspect2 != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<a0z>("plot\\quintonsKey"));
					if (coh != null)
					{
						aspect2.aa().Bag.z3(coh, true);
					}
				}
				if (c5x2.GetAspect<e3l>() == null)
				{
					c5x2.SetAspect<e3l>(new e3l(c5x2)
					{
						a = 
						{
							"sgs_agro"
						}
					});
				}
			}
			if (c5x3 != null && c5x3.GetAspect<e3l>() == null)
			{
				c5x3.SetAspect<e3l>(new e3l(c5x3)
				{
					a = 
					{
						"sgs_agro"
					}
				});
			}
			if (c5x4 != null)
			{
				bm6 aspect3 = c5x4.GetAspect<bm6>();
				if (aspect3 != null)
				{
					aspect3.y6().RemoveProperty(ddq.ae);
					aspect3.y6()[ddq.ae] = new Guid("a37c4fad-82f2-4e72-bbc7-98fedf25e003");
				}
			}
			foreach (b0b b0b in A_1.n("StationAlpha-Level8").Entities)
			{
				c5x c5x5 = (c5x)b0b;
				if (c5x5 != null && c5x5.o.b != null && (c5x5.o.b.a == "Objects\\Natural\\CaveEarMushroomY" || c5x5.o.b.a == "Objects\\Natural\\CaveEarMushroomX" || c5x5.o.b.a == "Objects\\Natural\\RedDreamMushroom"))
				{
					if (c5x5.GetAspect<c3g>() == null)
					{
						c3g c3g2 = new c3g(c5x5);
						c5x5.SetAspect<c3g>(c3g2);
						c3g2.d().Add(asp.f);
					}
				}
				else if (c5x5 != null && c5x5.p.b != null && c5x5.p.b.a[0].a == "Objects\\Natural\\PsiBoosterMushroom" && c5x5.GetAspect<c3g>() == null)
				{
					c3g c3g3 = new c3g(c5x5);
					c5x5.SetAspect<c3g>(c3g3);
					c3g3.d().Add(asp.f);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
