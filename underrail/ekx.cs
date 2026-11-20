using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020008F7 RID: 2295
[eiz("CCGAUNT2")]
[Serializable]
public sealed class ekx : bdw, ISerializable
{
	// Token: 0x060038CB RID: 14539 RVA: 0x00150DE4 File Offset: 0x0014EFE4
	private ekx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038CC RID: 14540 RVA: 0x00150DEC File Offset: 0x0014EFEC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038CD RID: 14541 RVA: 0x00150DF0 File Offset: 0x0014EFF0
	public ekx()
	{
	}

	// Token: 0x060038CE RID: 14542 RVA: 0x00150DFC File Offset: 0x0014EFFC
	public void av(c1a A_0, cyt A_1)
	{
		int num = dkr.f();
		if (A_0 != null)
		{
			aud aud = Enumerable.FirstOrDefault<aud>(A_0.Areas);
			if (aud != null)
			{
				dkr.a(aud, new string[]
				{
					"1904bf51-f98b-4889-bcc6-1d7eac8afb78",
					"b4f302f4-728c-4d2a-a7b2-5ee06b56463a",
					"5f5c7d3d-5737-4873-bdb2-a0c9c896a9a2",
					"c6b73e5f-ccb5-4a57-82c8-d89dbcd6cdbf"
				});
				for (int i = 0; i < (num + 1) * 15; i++)
				{
					ak1 ak = this.a(aud);
					if (ak != null)
					{
						coh a_ = new d48(ez2.CreateDefinitonProvider<c4j>("traps\\bearTrap"));
						new buz().a(ak, a_, true, 60, null);
					}
				}
			}
		}
	}

	// Token: 0x060038CF RID: 14543 RVA: 0x00150E98 File Offset: 0x0014F098
	private ak1 a(aud A_0)
	{
		for (int i = 0; i < 100; i++)
		{
			Point point = new Point(cuo.a.Next(61), cuo.a.Next(61));
			if (point.X != 1)
			{
				ak1 ak = A_0.a(point);
				if (!aw1.a(null, ak, false, null) && ak.TriggerProxies.Count == 0 && ak.c.Values.Count > 0)
				{
					return ak;
				}
			}
		}
		return null;
	}
}
