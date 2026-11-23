using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B8B RID: 2955
[eiz("CCJTYJ")]
[Serializable]
public sealed class a45 : cze, ISerializable
{
	// Token: 0x0600435C RID: 17244 RVA: 0x001A5BAC File Offset: 0x001A3DAC
	private a45(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600435D RID: 17245 RVA: 0x001A5BB8 File Offset: 0x001A3DB8
	public a45()
	{
	}

	// Token: 0x0600435E RID: 17246 RVA: 0x001A5BC4 File Offset: 0x001A3DC4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().v().SpecialStates.g && serviceOrThrow.aqu().v().Skills.Get<a2n>().g() >= 90)
				{
					return;
				}
				if ((double)A_0.aj().Y < 20.5)
				{
					return;
				}
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_sewer_jookhelaTrappedYou", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_sewer_facedJookhela", new bool?(false)).Value;
				cd0 cd = new EntityAspectReference<cd0, cd0>(A_0.Area, new Guid("7dc38d0a-6b35-4950-ac74-c5e4a33e2248")).ao();
				if (!value && !value2 && cd != null && cd.b.X == 5)
				{
					serviceOrThrow.aqu().r()["loc_cc_sewer_jookhelaTrappedYou"] = true;
					bpo.GetServiceOrThrow<ps>().am3("Cc_JookhelaTrapsYou");
				}
			}
		}
	}
}
