using System;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C1F RID: 3103
public sealed class cbr : jn
{
	// Token: 0x0600464E RID: 17998 RVA: 0x001CF3D0 File Offset: 0x001CD5D0
	public cbr() : base("dc_tchCaptive1", "creature\\characters\\support\\dc_tchCaptive1")
	{
	}

	// Token: 0x0600464F RID: 17999 RVA: 0x001CF3E4 File Offset: 0x001CD5E4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_dc_tchoristCaptives_toldToEscape", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("loc_dc_tchortistsEscaped", new int?(0)).Value > 0)
		{
			return "dc-tch";
		}
		return "dc-flo";
	}

	// Token: 0x06004650 RID: 18000 RVA: 0x001CF468 File Offset: 0x001CD668
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		ale aspect3 = A_0.GetAspect<ale>();
		e3l e3l = A_0.GetAspect<e3l>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "dc-flo", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("npc_dc_tchoristCaptives_toldToEscape", new bool?(false)).Value)
			{
				aspect.y6()[ddq.ay] = new bt4("TchortistsEscape");
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:dc_tchCaptive1");
			}
		}
		if (aspect2 != null)
		{
			if (string.Equals(A_2, "dc-tch", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_dc_tchoristCaptive1_armed", new bool?(false)).Value)
				{
					aspect2.aa().Defense.a(1000, null, null, false, false, false, null);
					xm xm = new xm();
					xm.na(10);
					xm.nc(15);
					cgd cgd = Enumerable.FirstOrDefault<coh>(xm.np()) as cgd;
					if (cgd != null)
					{
						cgd.Battery = (double)cgd.MaxBattery;
						aspect2.aa().Gear.h().a(cgd, true);
					}
					b2d b2d = new b2d();
					b2d.na(12);
					b2d.nc(17);
					b2d.d(60);
					foreach (coh coh in b2d.np())
					{
						if (coh is cd1)
						{
							euf.a(coh, null);
							aspect2.aa().Gear.j()[WeaponKey.Primary].b(coh as cd1);
						}
						else
						{
							aspect2.aa().Bag.z3(coh, true);
						}
					}
					A_1.r()["npc_dc_tchoristCaptive1_armed"] = true;
				}
				aspect2.aa().FactionId = "tchortists_deepCaverns";
				aspect2.aa().Name = "Tchortist Rassophore";
				A_0.q("Tchortist Rassophore");
			}
			else
			{
				aspect2.aa().FactionId = "tchortists_deepCaverns_captured";
			}
			if (e3l == null)
			{
				e3l = new e3l(A_0 as c5x);
				A_0.SetAspect<e3l>(e3l);
			}
			e3l.a.Add("dc-tch_sol");
			e3l.a();
		}
		if (aspect3 != null)
		{
			if (string.Equals(A_2, "dc-tch", StringComparison.OrdinalIgnoreCase))
			{
				aspect3.b = true;
				return;
			}
			aspect3.b = false;
		}
	}
}
