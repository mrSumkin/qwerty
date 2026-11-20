using System;
using System.Collections.Generic;

// Token: 0x02000C1B RID: 3099
public sealed class bq3 : jn
{
	// Token: 0x06004642 RID: 17986 RVA: 0x001CE8D4 File Offset: 0x001CCAD4
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004643 RID: 17987 RVA: 0x001CE8DC File Offset: 0x001CCADC
	public bq3() : base("xpbl_ethan", "creature\\characters\\xpbl\\Ethan")
	{
	}

	// Token: 0x06004644 RID: 17988 RVA: 0x001CE8F4 File Offset: 0x001CCAF4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_revealed", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_angered", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value)
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_reachedHangingRat", new bool?(false)).Value)
			{
				A_0.r()["npc_xpbl_ethan_reachedHangingRat"] = true;
			}
			return "lux-b11";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value)
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_reachedHardcoreBar", new bool?(false)).Value)
			{
				A_0.r()["npc_xpbl_ethan_reachedHardcoreBar"] = true;
			}
			return "cc_bar";
		}
		return "StationAlpha-Level3";
	}

	// Token: 0x06004645 RID: 17989 RVA: 0x001CEA14 File Offset: 0x001CCC14
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				c4f c4f = new c4f();
				string str = "npc_xpbl_ethan_died";
				if (string.Equals(A_2, "StationAlpha-Level3", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = "southGateStation";
					aspect.ay().Clear();
					ekk ekk = new ekk();
					ekk.a("l5");
					ekk.a(new Guid?(new Guid("83cd7a34-f8e8-461d-af96-e3ac9622b1bc")));
					ekk.a()[ddq.bc] = "npc_sgs_arlene_EthansCase";
					aspect.ay().Add(ekk);
					if (c4f != null)
					{
						c4f.Properties[str + "_sgs"] = true;
						aspect.ay().Add(c4f);
						List<cze> list = aspect.ay();
						e2l e2l = new e2l();
						e2l.a("StationAlpha-Level3");
						e2l.a(new an4());
						list.Add(e2l);
					}
				}
				else if (string.Equals(A_2, "cc_bar", StringComparison.OrdinalIgnoreCase))
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_removedCommoner", new bool?(false)).Value)
					{
						A_1.a(new bw0(A_2.ToString(), new ap7(), 1));
						A_1.r()["npc_xpbl_ethan_removedCommoner"] = true;
					}
					aspect.aa().FactionId = "coreCity";
					if (c4f != null)
					{
						c4f.Properties[str + "_coreCity"] = true;
						aspect.ay().Clear();
						aspect.ay().Add(c4f);
						List<cze> list2 = aspect.ay();
						e2l e2l2 = new e2l();
						e2l2.a("cc_bar");
						e2l2.a(new an4());
						list2.Add(e2l2);
					}
				}
				else if (string.Equals(A_2, "lux-b11", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = "HangingRat_Bar";
					if (c4f != null)
					{
						c4f.Properties[str + "_hangingRat"] = true;
						aspect.ay().Clear();
						aspect.ay().Add(c4f);
						List<cze> list3 = aspect.ay();
						e2l e2l3 = new e2l();
						e2l3.a("lux-b11");
						e2l3.a(new an4());
						list3.Add(e2l3);
					}
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ethan_withoutMedallion", new bool?(false)).Value)
				{
					aspect.a("xpbl_etho");
					A_1.r()["npc_xpbl_ethan_old"] = true;
				}
			}
		}
	}
}
