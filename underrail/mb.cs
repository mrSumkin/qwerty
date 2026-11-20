using System;

// Token: 0x02000C0D RID: 3085
public sealed class mb : jn
{
	// Token: 0x06004603 RID: 17923 RVA: 0x001CA2A4 File Offset: 0x001C84A4
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004604 RID: 17924 RVA: 0x001CA2AC File Offset: 0x001C84AC
	public mb() : base("xpbl_todd", "creature\\characters\\xpbl\\Todd")
	{
	}

	// Token: 0x06004605 RID: 17925 RVA: 0x001CA2C4 File Offset: 0x001C84C4
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_todd_died", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("xpbl_ds3_acornTaken", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_resolved", new bool?(false)).Value)
		{
			string classPropertyValue = A_0.r().GetClassPropertyValue<string>("npc_xpbl_as_todd_finalDestination");
			if (classPropertyValue != null)
			{
				if (string.Equals(classPropertyValue, "expedition", StringComparison.OrdinalIgnoreCase))
				{
					if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
					{
						return "xpbl_e6";
					}
					return null;
				}
				else
				{
					if (string.Equals(classPropertyValue, "pirates", StringComparison.OrdinalIgnoreCase))
					{
						return "xpbl_g2";
					}
					if (string.Equals(classPropertyValue, "ferryman", StringComparison.OrdinalIgnoreCase))
					{
						return null;
					}
				}
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_goToSubmarine", new bool?(false)).Value || classPropertyValue == null || string.Equals(classPropertyValue, "submarine", StringComparison.OrdinalIgnoreCase))
			{
				return "xpbl_submarine";
			}
		}
		return null;
	}

	// Token: 0x06004606 RID: 17926 RVA: 0x001CA3F8 File Offset: 0x001C85F8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			string classPropertyValue = A_1.r().GetClassPropertyValue<string>("npc_xpbl_as_todd_finalDestination");
			if (classPropertyValue != null)
			{
				if (string.Equals(classPropertyValue, "expedition", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = asp.f6;
				}
				else if (string.Equals(classPropertyValue, "pirates", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = asp.fr;
				}
				else if (string.Equals(classPropertyValue, "ferryman", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = asp.gc;
				}
			}
		}
		bm6 aspect2 = A_0.GetAspect<bm6>();
		if (aspect2 != null && string.Equals("", "expedition", StringComparison.OrdinalIgnoreCase) && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_talkedInSubmarine", new bool?(false)).Value)
		{
			aspect2.y6()[ddq.bc] = "npc_xpbl_as_todd_talkedInSubmarine";
		}
	}
}
