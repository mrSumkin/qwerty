using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008F8 RID: 2296
[eiz("CCGAUNT3")]
[Serializable]
public sealed class dh3 : bdw, ISerializable
{
	// Token: 0x060038D0 RID: 14544 RVA: 0x00150F20 File Offset: 0x0014F120
	private dh3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038D1 RID: 14545 RVA: 0x00150F28 File Offset: 0x0014F128
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038D2 RID: 14546 RVA: 0x00150F2C File Offset: 0x0014F12C
	public dh3()
	{
	}

	// Token: 0x060038D3 RID: 14547 RVA: 0x00150F38 File Offset: 0x0014F138
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
					"09598c5a-f3e2-443a-8012-c681e1b8aafb",
					"836a6192-1b43-4bcd-aaee-f0dc521f3d3e",
					"1db4ad2e-5258-4467-bd91-d1f8e8e8f683",
					"92a879d7-570b-41a5-a320-695ddc346860",
					"40a11258-788e-49f4-b95a-a6320fc15f0b",
					"83b36d7b-8a95-4e67-bf1b-f53d82545e65",
					"6eeb6d6b-7f90-4fb1-b236-9a1b1f05205d",
					"377d1d26-1c8b-4f2a-a3f7-752e19e026a8",
					"c68436b4-7a69-456b-9a03-288333992418",
					"2c194543-4220-484f-9bec-0a31b2601977"
				});
				if (num > 0)
				{
					for (int i = 1; i <= Math.Min(11, (num + 1) * 4); i++)
					{
						csd csd = A_0.g("extraBur" + i.ToString());
						if (csd != null)
						{
							vq.a("creatures\\burrower", csd, false);
						}
					}
				}
			}
		}
	}
}
