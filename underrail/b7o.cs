using System;
using System.Runtime.Serialization;
using Ouroboros.Common;

// Token: 0x02000C63 RID: 3171
[eiz("XPBLSJARF")]
[Serializable]
public sealed class b7o : IFunction<c5x, c5x, int>, ISerializable
{
	// Token: 0x06004758 RID: 18264 RVA: 0x001D71F0 File Offset: 0x001D53F0
	private b7o(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004759 RID: 18265 RVA: 0x001D71F8 File Offset: 0x001D53F8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600475A RID: 18266 RVA: 0x001D71FC File Offset: 0x001D53FC
	public b7o()
	{
	}

	// Token: 0x0600475B RID: 18267 RVA: 0x001D7208 File Offset: 0x001D5408
	public int wv(c5x A_0, c5x A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return 1;
		}
		double num = aw1.b(A_0, A_1);
		if (num >= 10.0)
		{
			return 100;
		}
		if (num <= 2.85)
		{
			return 1;
		}
		int num2 = Convert.ToInt32((num - 1.5) * 2.0);
		int num3 = Convert.ToInt32(Math.Pow(1.5, (double)num2));
		return 8 + num3;
	}
}
