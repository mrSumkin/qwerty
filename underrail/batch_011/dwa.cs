using System;
using System.Runtime.Serialization;

// Token: 0x020016C3 RID: 5827
[eiz("STJSKIA")]
[Serializable]
public sealed class dwa : a6k
{
	// Token: 0x06007F00 RID: 32512 RVA: 0x0035B16C File Offset: 0x0035936C
	private dwa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F01 RID: 32513 RVA: 0x0035B178 File Offset: 0x00359378
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = this.fm() as c5x;
		if (c5x == null)
		{
			return dc4.e;
		}
		ar7 classPropertyValue = c5x.d().a().GetClassPropertyValue<ar7>(bah.c);
		if (classPropertyValue != null && classPropertyValue.ao() != null)
		{
			bdf aspect = classPropertyValue.ao().GetAspect<bdf>();
			if (aspect != null && aspect.f() != null && aspect.f().ao() == c5x)
			{
				aspect.r9(false);
			}
		}
		return dc4.e;
	}

	// Token: 0x06007F02 RID: 32514 RVA: 0x0035B1F8 File Offset: 0x003593F8
	public dwa()
	{
	}
}
