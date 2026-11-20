using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000964 RID: 2404
[eiz("DCDC")]
[Serializable]
public sealed class cqe : bdw, ISerializable
{
	// Token: 0x06003A8A RID: 14986 RVA: 0x0015A8B8 File Offset: 0x00158AB8
	private cqe(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x0015A8C0 File Offset: 0x00158AC0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x0015A8C4 File Offset: 0x00158AC4
	public cqe()
	{
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x0015A8D0 File Offset: 0x00158AD0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			foreach (aud aud in A_0.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == aju.x)
					{
						c7j c7j = c5x.GetAspect<bim>() as c7j;
						if (c7j != null)
						{
							foreach (coh coh in c7j.ItemContainer.z2())
							{
								if (coh.Definition != null && coh.Definition.a5() == "cube")
								{
									c7j.ItemContainer.z5(coh);
									return;
								}
							}
						}
						amc aspect = c5x.GetAspect<amc>();
						if (aspect != null)
						{
							foreach (coh coh2 in aspect.aa().Bag.z2())
							{
								if (coh2.Definition != null && coh2.Definition.a5() == "cube")
								{
									aspect.aa().Bag.z5(coh2);
									return;
								}
							}
						}
					}
				}
				if (aud.y8() == "dc-tchb")
				{
					c5x c5x2 = new ar7(new Guid("66db6432-bd33-48fc-8418-f6ccfe7f683a"), aud).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("8c54569e-d4a4-43ac-bd20-0105f9fc41d4"), aud).ao() as c5x;
					if (c5x2 != null)
					{
						c5x2.w();
						c5x2.an();
					}
					if (c5x3 != null && c5x3.o.b != null)
					{
						c5x3.o.b.b = new Point(2, 0);
					}
				}
			}
		}
	}
}
