using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000900 RID: 2304
[eiz("DUNWWDS")]
[Serializable]
public sealed class a79 : bdw, ISerializable
{
	// Token: 0x060038EF RID: 14575 RVA: 0x001518C4 File Offset: 0x0014FAC4
	private a79(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038F0 RID: 14576 RVA: 0x001518CC File Offset: 0x0014FACC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038F1 RID: 14577 RVA: 0x001518D0 File Offset: 0x0014FAD0
	public a79()
	{
	}

	// Token: 0x060038F2 RID: 14578 RVA: 0x001518DC File Offset: 0x0014FADC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && serviceOrThrow.aqu() != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"slaves"
				});
				int num = 0;
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					c5x.w();
					c5x.an();
					num++;
				}
				if (num != 0)
				{
					serviceOrThrow.aqu().r()["loc_dun_wasteWater_mindSlavesFreed"] = num;
				}
			}
		}
	}
}
