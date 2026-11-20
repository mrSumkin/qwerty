using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200095E RID: 2398
[eiz("SGSMBAT")]
[Serializable]
public sealed class anx : bdw, ISerializable
{
	// Token: 0x06003A72 RID: 14962 RVA: 0x0015A594 File Offset: 0x00158794
	private anx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A73 RID: 14963 RVA: 0x0015A59C File Offset: 0x0015879C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A74 RID: 14964 RVA: 0x0015A5A0 File Offset: 0x001587A0
	public anx()
	{
	}

	// Token: 0x06003A75 RID: 14965 RVA: 0x0015A5AC File Offset: 0x001587AC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
			bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("global_returnedCubeToFaceless", new bool?(false)).Value;
			bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("npc_dc_flo_agreeToReturnLora", new bool?(false)).Value;
			if (value && A_0 != null)
			{
				aud aud = A_0.n("sa6");
				if (aud != null)
				{
					c5x c5x = new ar7(new Guid("5b07c9dc-2aac-4478-9f9f-53a8948dc0aa"), aud).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("837572e9-ef62-4ba6-8837-176b22616e69"), aud).ao() as c5x;
					if (c5x != null)
					{
						c5x.w();
						c5x.an();
					}
					if (c5x2 != null)
					{
						c5x2.w();
						c5x2.an();
					}
					if (value3 && value2)
					{
						doq a_ = doq.a(Path.Combine(d5x.q(), "StationAlpha-Level6_l2") + ".uzl");
						aud.Zone.a(a_, 1, null);
					}
				}
			}
		}
	}
}
