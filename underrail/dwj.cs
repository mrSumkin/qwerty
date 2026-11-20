using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000937 RID: 2359
[eiz("CVWDWKAHG")]
[Serializable]
public sealed class dwj : bdw, ISerializable
{
	// Token: 0x060039D2 RID: 14802 RVA: 0x00155EF4 File Offset: 0x001540F4
	private dwj(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039D3 RID: 14803 RVA: 0x00155EFC File Offset: 0x001540FC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039D4 RID: 14804 RVA: 0x00155F00 File Offset: 0x00154100
	public dwj()
	{
	}

	// Token: 0x060039D5 RID: 14805 RVA: 0x00155F0C File Offset: 0x0015410C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cvw9");
		if (aud != null)
		{
			bool flag = false;
			bool flag2 = false;
			c5x c5x = new ar7(new Guid("788daa08-1ecb-49bf-bb83-f2cf4e4993fd"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("c015a6d9-6c22-41dc-96b3-2351f4b3b893"), aud).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				h? h = c5x.h.b.aa().f(asp.a);
				h h2 = h.a;
				if (h.GetValueOrDefault() == h2 & h != null)
				{
					flag = true;
					goto IL_A9;
				}
			}
			if (c5x == null)
			{
				flag = true;
			}
			IL_A9:
			foreach (d4n d4n in Enumerable.ToList<d4n>(bpo.GetService<d02>().ahl()))
			{
				if (d4n.b != null && d4n.b.aa().FactionId == asp.ej)
				{
					if (flag)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
					else
					{
						d4n.b.aa().a(null, null, false);
					}
					flag2 = true;
				}
			}
			if (c5x2 != null && c5x2.Location.X < 11f && c5x2.Location.Y > 26f)
			{
				if (!flag || (flag && flag2))
				{
					c5x2.w();
				}
				c5x2.an();
			}
		}
	}
}
