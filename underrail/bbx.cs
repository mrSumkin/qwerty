using System;
using System.Runtime.Serialization;
using Ouroboros.Common;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C61 RID: 3169
[eiz("XPHWGSCARF")]
[Serializable]
public sealed class bbx : IFunction<c5x, c5x, int>, ISerializable
{
	// Token: 0x06004728 RID: 18216 RVA: 0x001D5F04 File Offset: 0x001D4104
	private bbx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004729 RID: 18217 RVA: 0x001D5F0C File Offset: 0x001D410C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600472A RID: 18218 RVA: 0x001D5F10 File Offset: 0x001D4110
	public bbx()
	{
	}

	// Token: 0x0600472B RID: 18219 RVA: 0x001D5F18 File Offset: 0x001D4118
	public int wv(c5x A_0, c5x A_1)
	{
		int num = 16;
		int val = 8;
		if (A_0 != null && A_1 != null)
		{
			bb2 bb = A_1.GetAspect<bim>() as bb2;
			if (bb != null)
			{
				num = bb.g();
			}
			c5x c5x = new ar7(c29.a, A_0.Area).ao() as c5x;
			if (c5x != null && d7o.a())
			{
				int val2 = c2h.a(c5x.h.b.aa(), BaseAbilityEnum.Strength);
				return num - Math.Min(val, val2);
			}
		}
		return num;
	}
}
