using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000276 RID: 630
[eiz("ES")]
[Serializable]
public sealed class cx0 : IComparer<b0b>, ISerializable
{
	// Token: 0x06001279 RID: 4729 RVA: 0x0004D418 File Offset: 0x0004B618
	private cx0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x0004D420 File Offset: 0x0004B620
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x0004D424 File Offset: 0x0004B624
	public cx0()
	{
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x0004D42C File Offset: 0x0004B62C
	public static cx0 a()
	{
		if (cx0.a == null)
		{
			cx0.a = new cx0();
		}
		return cx0.a;
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x0004D44C File Offset: 0x0004B64C
	public int Compare(b0b x, b0b y)
	{
		if (x == y)
		{
			return 0;
		}
		int num = x.IsFloor ? -2 : (x.IsGround ? -1 : 0);
		int value = y.IsFloor ? -2 : (y.IsGround ? -1 : 0);
		int num2 = num.CompareTo(value);
		if (num2 != 0)
		{
			return num2;
		}
		num2 = x.h.CompareTo(y.h);
		if (num2 != 0)
		{
			return num2;
		}
		float num3 = x.Location.X + x.Size.X + x.Location.Y + x.Size.Y;
		float value2 = y.Location.X + y.Size.X + y.Location.Y + y.Size.Y;
		num2 = num3.CompareTo(value2);
		if (num2 != 0)
		{
			return num2;
		}
		num2 = x.Location.X.CompareTo(y.Location.X);
		if (num2 == 0)
		{
			return -1;
		}
		return num2;
	}

	// Token: 0x04000A39 RID: 2617
	private static cx0 a;
}
