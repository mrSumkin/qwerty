using System;
using System.Runtime.Serialization;

// Token: 0x020011DE RID: 4574
[eiz("FPT")]
[Serializable]
public sealed class ebp : ya, ISerializable
{
	// Token: 0x06006220 RID: 25120 RVA: 0x002A7F34 File Offset: 0x002A6134
	private ebp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006221 RID: 25121 RVA: 0x002A7F40 File Offset: 0x002A6140
	public ebp()
	{
	}

	// Token: 0x06006222 RID: 25122 RVA: 0x002A7F4C File Offset: 0x002A614C
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			foreach (b0b b0b in base.Area.a(base.Location).c.Values)
			{
				eks eks = ((c5x)b0b).GetAspect<bim>() as eks;
				if (eks != null)
				{
					eks.a(c5x);
				}
			}
		}
	}
}
