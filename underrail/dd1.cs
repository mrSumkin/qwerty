using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000928 RID: 2344
[eiz("CCRA")]
[Serializable]
public sealed class dd1 : bdw, ISerializable
{
	// Token: 0x06003994 RID: 14740 RVA: 0x00154AB4 File Offset: 0x00152CB4
	private dd1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003995 RID: 14741 RVA: 0x00154ABC File Offset: 0x00152CBC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x00154AC0 File Offset: 0x00152CC0
	public dd1()
	{
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x00154ACC File Offset: 0x00152CCC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc-res");
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (aud != null && serviceOrThrow != null)
			{
				dxt.a(A_1, aud, "f33a2551-ac9b-4cf4-afcc-424c7752c672", "c6eb0c19-b185-4c29-aa1d-ed36524c5029");
				bool flag = new ar7(new Guid("eb464304-0ca7-4fd6-810e-a718fae366ce"), aud).ao() is c5x;
				serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_cc-res_acRepairCountdown", null);
				if (flag)
				{
					c7j c7j = new EntityAspectReference<c7j, bim>(aud, new Guid("16525c50-bca5-4933-8988-629e5347f629")).ao();
					if (c7j != null && !c7j.q())
					{
						c7j.d(true);
					}
				}
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("cc_ph_removedGraffiti", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("cc-res_removedOutsideGraffiti", new bool?(false)).Value;
				if (value && !value2)
				{
					c5x c5x = new ar7(new Guid("5d83302c-655d-4b06-b0fd-83840c20173b"), aud).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("23c9fe8e-5d63-4e49-9fda-df702b0c8967"), aud).ao() as c5x;
					foreach (c5x c5x3 in new c5x[]
					{
						c5x,
						c5x2
					})
					{
						c5x3.w();
						c5x3.an();
						serviceOrThrow.aqu().r()["cc-res_removedOutsideGraffiti"] = true;
					}
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_dun_llb4_diedRyl_settled", new bool?(false)).Value)
				{
					c5x c5x4 = new ar7(new Guid("0df349f9-7bd2-4698-a71c-49a73ec8851b"), aud).ao() as c5x;
					if (c5x4 != null)
					{
						c5x4.w();
						c5x4.an();
					}
				}
			}
		}
	}
}
