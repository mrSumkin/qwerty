using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001E5D RID: 7773
[eiz("OCC")]
[Serializable]
public sealed class lc : IComparer<aia>, ISerializable
{
	// Token: 0x0600AC41 RID: 44097 RVA: 0x003F9448 File Offset: 0x003F7648
	private lc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600AC42 RID: 44098 RVA: 0x003F9450 File Offset: 0x003F7650
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600AC43 RID: 44099 RVA: 0x003F9454 File Offset: 0x003F7654
	public static lc a()
	{
		return lc.a;
	}

	// Token: 0x0600AC44 RID: 44100 RVA: 0x003F945C File Offset: 0x003F765C
	public lc()
	{
	}

	// Token: 0x0600AC45 RID: 44101 RVA: 0x003F9464 File Offset: 0x003F7664
	public int Compare(aia x, aia y)
	{
		if ((x == null || x.Value == null) && y != null)
		{
			return -1;
		}
		if (x != null && (y == null || y.Value == null))
		{
			return 1;
		}
		if ((x == null || x.Value == null) && (y == null || y.Value == null))
		{
			return 0;
		}
		int num = x.Value.Order.CompareTo(y.Value.Order);
		if (num != 0)
		{
			return num;
		}
		int num2 = x.Value.Name.CompareTo(y.Value.Name);
		if (num2 != 0)
		{
			return num2;
		}
		return -1;
	}

	// Token: 0x04004033 RID: 16435
	private static lc a = new lc();
}
