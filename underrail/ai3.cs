using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200146F RID: 5231
[eiz("GUJIA")]
[Serializable]
public sealed class ai3 : a6k, ISerializable
{
	// Token: 0x06007620 RID: 30240 RVA: 0x0031E894 File Offset: 0x0031CA94
	private ai3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007621 RID: 30241 RVA: 0x0031E8A0 File Offset: 0x0031CAA0
	public ai3()
	{
	}

	// Token: 0x06007622 RID: 30242 RVA: 0x0031E8AC File Offset: 0x0031CAAC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		bt1 bt = aln.a(base.vg().e());
		if (bt != null)
		{
			cze cze = null;
			if (bt.d() != null)
			{
				cze = (bt.d() as cze);
			}
			else if (!string.IsNullOrEmpty(bt.a()))
			{
				cze = ea5.a(bt.a());
			}
			if (cze != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				if (bt.k() != null)
				{
					foreach (Property property in bt.k().Properties)
					{
						if (property.Name != null)
						{
							dictionary[property.Name] = property.Value;
						}
					}
				}
				if (bt.l())
				{
					base.vg().e().a(true);
				}
				if (!string.IsNullOrEmpty(bt.c()))
				{
					c5x.c().a(bt.c());
				}
				cze.ym(base.vg().q(), c5x, dictionary);
			}
		}
		return dc4.c;
	}
}
