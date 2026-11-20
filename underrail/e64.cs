using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B36 RID: 2870
[eiz("FLS1")]
[Serializable]
public sealed class e64 : cze, ISerializable
{
	// Token: 0x06004215 RID: 16917 RVA: 0x001998C8 File Offset: 0x00197AC8
	private e64(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004216 RID: 16918 RVA: 0x001998D4 File Offset: 0x00197AD4
	public e64()
	{
	}

	// Token: 0x06004217 RID: 16919 RVA: 0x001998DC File Offset: 0x00197ADC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				csd csd = aud.Zone.g("jumpIn");
				csd csd2 = aud.Zone.g("jumpOut");
				if (csd != null && csd2 != null)
				{
					float num = bnx.a(csd.Location.a(), A_0.aj().a());
					float num2 = bnx.a(csd2.Location.a(), A_0.aj().a());
					if (num > num2)
					{
						a0l.a(A_0 as c5x, "jumpIn", true);
						return;
					}
					a0l.a(A_0 as c5x, "jumpOut", true);
				}
			}
		}
	}
}
