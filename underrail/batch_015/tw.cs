using System;
using System.Runtime.Serialization;

// Token: 0x020016B2 RID: 5810
[eiz("ASSA")]
[Serializable]
public sealed class tw : a6k, ISerializable
{
	// Token: 0x06007EC6 RID: 32454 RVA: 0x003590C4 File Offset: 0x003572C4
	private tw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EC7 RID: 32455 RVA: 0x003590D0 File Offset: 0x003572D0
	public tw()
	{
	}

	// Token: 0x06007EC8 RID: 32456 RVA: 0x003590DC File Offset: 0x003572DC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				int num = 1;
				if (b.aa().GetSpecializationValue<ac6>(true) > 0)
				{
					num++;
				}
				cp7 cp = new cp7(d0u.b, num);
				cp.Stacks = num;
				b.aa().StatusEffects.a(cp, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
