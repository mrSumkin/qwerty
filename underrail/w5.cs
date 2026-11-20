using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B8D RID: 2957
[eiz("CCCITM")]
[Serializable]
public sealed class w5 : cze, ISerializable
{
	// Token: 0x06004362 RID: 17250 RVA: 0x001A5DD4 File Offset: 0x001A3FD4
	private w5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004363 RID: 17251 RVA: 0x001A5DE0 File Offset: 0x001A3FE0
	public w5()
	{
	}

	// Token: 0x06004364 RID: 17252 RVA: 0x001A5DEC File Offset: 0x001A3FEC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		c5x c5x2 = A_1 as c5x;
		if (c5x2 != null && c5x != null && c5x.h.b != null)
		{
			if (c5x.h.b.aa().BaseAbilities.Agility >= 8)
			{
				string a_;
				if (string.Equals(c5x.Area.y8(), "cc_tm2", StringComparison.OrdinalIgnoreCase))
				{
					a_ = "cc22";
				}
				else
				{
					a_ = "cc_tm";
				}
				a0l.a(new c2w(a_, "FromClimbing"));
				return;
			}
			if (c5x2.u.b != null)
			{
				c5x2.u.b.a("Подъём слишком крут для вас.", true, null, null);
			}
		}
	}
}
