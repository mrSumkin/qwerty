using System;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000993 RID: 2451
[eiz("LUXHOG")]
[Serializable]
public sealed class dix : bdw, ISerializable
{
	// Token: 0x06003B48 RID: 15176 RVA: 0x0015F5B4 File Offset: 0x0015D7B4
	private dix(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B49 RID: 15177 RVA: 0x0015F5BC File Offset: 0x0015D7BC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B4A RID: 15178 RVA: 0x0015F5C0 File Offset: 0x0015D7C0
	public dix()
	{
	}

	// Token: 0x06003B4B RID: 15179 RVA: 0x0015F5CC File Offset: 0x0015D7CC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lux-b2");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lux-b2_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				c5x c5x = new ar7(new Guid("36fc0fa6-8aad-4333-bebb-3e1b669488bd"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("db5f3055-ba28-416c-9e5a-e868ca9cebe6"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("422f474c-a1eb-47a1-b463-459b5354d905"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("08bdd9cb-ca06-463a-a637-2a972e19068c"), aud).ao() as c5x;
				Point b = new Point(1, 0);
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					if (aspect != null)
					{
						aspect.b = b;
					}
				}
				if (c5x2 != null)
				{
					cd0 aspect2 = c5x2.GetAspect<cd0>();
					if (aspect2 != null)
					{
						aspect2.b = b;
					}
				}
				if (c5x3 != null)
				{
					cd0 aspect3 = c5x3.GetAspect<cd0>();
					if (aspect3 != null)
					{
						aspect3.b = b;
					}
				}
				if (c5x4 != null)
				{
					cd0 aspect4 = c5x4.GetAspect<cd0>();
					if (aspect4 != null)
					{
						aspect4.b = b;
					}
				}
			}
		}
	}
}
