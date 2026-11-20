using System;
using System.Runtime.Serialization;

// Token: 0x020016D2 RID: 5842
[eiz("A65")]
[Serializable]
public sealed class bgd : a6k, ISerializable
{
	// Token: 0x06007F2F RID: 32559 RVA: 0x0035D628 File Offset: 0x0035B828
	private bgd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F30 RID: 32560 RVA: 0x0035D634 File Offset: 0x0035B834
	public bgd()
	{
	}

	// Token: 0x06007F31 RID: 32561 RVA: 0x0035D640 File Offset: 0x0035B840
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					d4n d4n = service.ahu(b.aa());
					if (d4n != null && (int)d4n.d > 0)
					{
						ajz a_ = new ajz((int)((double)((int)d4n.d) * enw.a(base.vg().e())));
						b.aa().StatusEffects.a(a_, false, false, false);
						d4n.b((int)d4n.d, false);
					}
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
