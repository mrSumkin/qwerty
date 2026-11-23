using System;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x020008FF RID: 2303
[eiz("CCGAUNTFS")]
[Serializable]
public sealed class bzf : bdw, ISerializable
{
	// Token: 0x060038EB RID: 14571 RVA: 0x00151720 File Offset: 0x0014F920
	private bzf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038EC RID: 14572 RVA: 0x00151728 File Offset: 0x0014F928
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038ED RID: 14573 RVA: 0x0015172C File Offset: 0x0014F92C
	public bzf()
	{
	}

	// Token: 0x060038EE RID: 14574 RVA: 0x00151738 File Offset: 0x0014F938
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = Enumerable.FirstOrDefault<aud>(A_0.Areas);
			if (aud != null)
			{
				string[] array = new string[]
				{
					"64e6d833-a752-4d3d-bbe0-7c2e80c3ac1f",
					"5295a31b-084a-441c-88ef-8a3c89321859"
				};
				double[] array2 = dkr.e();
				for (int i = 0; i < 2; i++)
				{
					double num = array2[i];
					int j;
					int a_;
					if (num >= 1.0)
					{
						j = (int)(3.0 + 60.0 * (num - 1.0));
						a_ = 4 + i * 22;
					}
					else
					{
						j = (int)(num * 95.0);
						a_ = 32 + i * 2;
					}
					while (j >= 0)
					{
						ak1 ak = aud.b(j, a_);
						if (ak != null && !aw1.a(null, ak, false, null))
						{
							c5x c5x = vq.a("creature\\characters\\support\\cc_gauntletRunner" + (i + 1).ToString(), aud.Zone, new bt4(aud.y8(), ak.Location.a()), true);
							if (c5x != null)
							{
								c5x.VisualDirection = HorizontalDirection.East;
								c5x.t.b.y6()["LeverId"] = new Guid(array[i]);
								c5x.t.b.b("cc_gauntletRunner");
								c5x.t.b.c("cc_gauntletRunner");
								break;
							}
							break;
						}
						else
						{
							j--;
						}
					}
				}
			}
		}
	}
}
