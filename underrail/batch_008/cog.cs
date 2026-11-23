using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000942 RID: 2370
[eiz("XPBLLEARTD")]
[Serializable]
public sealed class cog : bdw, ISerializable
{
	// Token: 0x060039FE RID: 14846 RVA: 0x00156FD8 File Offset: 0x001551D8
	private cog(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x00156FE0 File Offset: 0x001551E0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x00156FE4 File Offset: 0x001551E4
	public cog()
	{
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x00156FF0 File Offset: 0x001551F0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			d60 addon = A_0.GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					"loc_" + A_0.y8() + "_aegisSecTroopers"
				});
				List<b0b> list2 = addon.ab4(new string[]
				{
					"loc_" + A_0.y8() + "_aegisJets"
				});
				bool flag = false;
				foreach (b0b b0b in list)
				{
					if (b0b != null)
					{
						b0b.w();
						b0b.an();
						flag = true;
					}
				}
				if (flag)
				{
					foreach (b0b b0b2 in list2)
					{
						if (b0b2 != null)
						{
							b0b2.w();
							b0b2.an();
						}
					}
				}
			}
		}
	}
}
