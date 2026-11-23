using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008FC RID: 2300
[eiz("CCGAUNT6")]
[Serializable]
public sealed class dad : bdw, ISerializable
{
	// Token: 0x060038DF RID: 14559 RVA: 0x00151330 File Offset: 0x0014F530
	private dad(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038E0 RID: 14560 RVA: 0x00151338 File Offset: 0x0014F538
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038E1 RID: 14561 RVA: 0x0015133C File Offset: 0x0014F53C
	public dad()
	{
	}

	// Token: 0x060038E2 RID: 14562 RVA: 0x00151344 File Offset: 0x0014F544
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
					"1e2b4f22-7eb3-4946-9009-554fa58616ed",
					"f28a1d17-e32f-4bc7-8d8b-c476fd3d9a60",
					"3670675b-0ac9-4488-80d2-f5fede4275fe",
					"4223b99e-bd85-4d4e-ad4b-8c5376678666",
					"f1366a0f-1293-4877-89f6-48fc1fa3da97",
					"d930ef5c-5642-4412-bab8-ad188bf30581"
				});
				c5x c5x = new ar7(new Guid("fe6391a3-ff44-4a41-a185-dc29c54a15e5"), aud).ao() as c5x;
				if (c5x != null)
				{
					a3f aspect = c5x.GetAspect<a3f>();
					if (aspect != null)
					{
						int num2 = Math.Min(23, 6 + num * 6);
						aspect.a()["MaxBeetles"] = num2;
						aspect.a()["BeetlesSpawned"] = 0;
					}
					dm aspect2 = c5x.GetAspect<dm>();
					if (aspect2 != null)
					{
						aspect2.a(new int?(Math.Max(5000, 10000 - num * 1700)));
					}
				}
			}
		}
	}
}
