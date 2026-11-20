using System;
using System.Runtime.Serialization;

// Token: 0x0200091D RID: 2333
[eiz("CCRPSAG")]
[Serializable]
public sealed class cla : bdw, ISerializable
{
	// Token: 0x06003963 RID: 14691 RVA: 0x001535E0 File Offset: 0x001517E0
	private cla(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003964 RID: 14692 RVA: 0x001535E8 File Offset: 0x001517E8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003965 RID: 14693 RVA: 0x001535EC File Offset: 0x001517EC
	public cla()
	{
	}

	// Token: 0x06003966 RID: 14694 RVA: 0x001535F4 File Offset: 0x001517F4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_enterGauntlet");
			if (aud != null)
			{
				c5x c5x = A_1.v().b() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					c5x c5x2 = new ar7(new Guid("f15debf0-cd3a-4a99-b351-3db67aefe4e3"), aud).ao() as c5x;
					if (c5x2 != null)
					{
						c7j c7j = c5x2.s.b as c7j;
						if (c7j != null)
						{
							ke.a(c5x.h.b.aa(), c7j.ItemContainer, true, true);
						}
					}
				}
			}
		}
	}
}
