using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001258 RID: 4696
[eiz("TWCHD")]
[Serializable]
public sealed class ddi : a7o, ISerializable
{
	// Token: 0x06006586 RID: 25990 RVA: 0x002B3838 File Offset: 0x002B1A38
	private ddi(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("TWCHD:T", typeof(EntityAspectReference<bdf, bdf>)) as EntityAspectReference<bdf, bdf>);
	}

	// Token: 0x06006587 RID: 25991 RVA: 0x002B3860 File Offset: 0x002B1A60
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("TWCHD:T", this.a);
	}

	// Token: 0x06006588 RID: 25992 RVA: 0x002B3874 File Offset: 0x002B1A74
	public ddi(bdf A_0)
	{
		this.a = new EntityAspectReference<bdf, bdf>(A_0);
	}

	// Token: 0x06006589 RID: 25993 RVA: 0x002B3888 File Offset: 0x002B1A88
	public e0b kn(aud A_0, b0b A_1, b0b A_2, amu A_3)
	{
		return e0b.b;
	}

	// Token: 0x0600658A RID: 25994 RVA: 0x002B388C File Offset: 0x002B1A8C
	public e0b ko(aud A_0, b0b A_1, ak1 A_2, amu A_3)
	{
		bool flag = false;
		c5x c5x = A_1 as c5x;
		if (this.a.ao().e().GetValueOrDefault() == l9.b)
		{
			flag = (!A_2.Formation.c(64L) || A_2.Formation.c(262308L));
		}
		else if (this.a.ao().e().GetValueOrDefault() == l9.c)
		{
			flag = (!A_2.Formation.c(524352L) || A_2.Formation.c(262308L));
		}
		else
		{
			l9? l = this.a.ao().e();
			l9 l2 = l9.a;
			if (l.GetValueOrDefault() == l2 & l != null)
			{
				flag = (A_2.Formation.c(4L) || A_2.Formation.c(32L) || (A_2.Formation.c(2L) && !A_2.Formation.c(128L)));
			}
		}
		if (flag)
		{
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.u();
				foreach (b0b b0b in A_2.c.Values)
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2.h.b != null)
					{
						c5x2.h.b.u();
					}
				}
			}
			return e0b.b;
		}
		return e0b.c;
	}

	// Token: 0x0600658B RID: 25995 RVA: 0x002B3A68 File Offset: 0x002B1C68
	public bjp kp(b0b A_0)
	{
		if (A_0.z != null)
		{
			return new bjp(new byte[]
			{
				2,
				5,
				1
			});
		}
		return null;
	}

	// Token: 0x0600658C RID: 25996 RVA: 0x002B3A94 File Offset: 0x002B1C94
	public bool? kq(b0b A_0)
	{
		return null;
	}

	// Token: 0x04002A42 RID: 10818
	private EntityAspectReference<bdf, bdf> a;
}
