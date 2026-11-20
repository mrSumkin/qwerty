using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x020008DE RID: 2270
[eiz("XPHWEBPP")]
[Serializable]
public class bd5 : c13, ISerializable
{
	// Token: 0x06003863 RID: 14435 RVA: 0x0014E6E4 File Offset: 0x0014C8E4
	private bd5(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003864 RID: 14436 RVA: 0x0014E6EC File Offset: 0x0014C8EC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003865 RID: 14437 RVA: 0x0014E6F0 File Offset: 0x0014C8F0
	public bd5()
	{
	}

	// Token: 0x06003866 RID: 14438 RVA: 0x0014E6FC File Offset: 0x0014C8FC
	public List<c5x> ok(string A_0, IEnumerable<csd> A_1)
	{
		List<c5x> result = new List<c5x>();
		if (A_1 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && this.a(serviceOrThrow.aqu(), serviceOrThrow.aqw(), A_0) && dqp.a(serviceOrThrow.aqw(), true, false))
			{
				bool a_ = false;
				bool a_2 = false;
				bu6 service = bpo.GetService<bu6>();
				if (service != null)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						a_ = (cuo.a.Next(0, 101) <= 10);
						a_2 = (cuo.a.Next(0, 101) <= 25);
					}
					else if (service.aq2() >= GameDifficulty.Hard)
					{
						a_ = (cuo.a.Next(0, 101) <= 5);
						a_2 = (cuo.a.Next(0, 101) <= 15);
					}
				}
				result = dqp.a((List<csd>)A_1, true, dqp.d(), a_, 0.5f, 0.5f, a_2, null);
			}
		}
		return result;
	}

	// Token: 0x06003867 RID: 14439 RVA: 0x0014E800 File Offset: 0x0014CA00
	private bool a(cyt A_0, c1a A_1, string A_2)
	{
		return (!A_1.y8().EndsWith("lab1") || A_0.r().GetPrimitivePropertyValue<bool>("loc_xphw_exobase_lab1_deploymentEnabled", new bool?(false)).Value) && (!A_1.y8().EndsWith("ent") || !A_2.Equals("deployMobile2") || A_0.r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_restrictedAccess", new bool?(false)).Value);
	}
}
