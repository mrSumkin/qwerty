using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008F9 RID: 2297
[eiz("CCGAUNT4")]
[Serializable]
public sealed class cke : bdw, ISerializable
{
	// Token: 0x060038D4 RID: 14548 RVA: 0x00151010 File Offset: 0x0014F210
	private cke(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038D5 RID: 14549 RVA: 0x00151018 File Offset: 0x0014F218
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038D6 RID: 14550 RVA: 0x0015101C File Offset: 0x0014F21C
	public cke()
	{
	}

	// Token: 0x060038D7 RID: 14551 RVA: 0x00151028 File Offset: 0x0014F228
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
					"fff2bb1e-5fc9-4f6f-a799-0aab2a89883b",
					"686819b5-ce0d-43e7-92c8-20c6d949d5cd",
					"9d206190-24e0-48a0-8dbe-1ebac2c3a907",
					"ac955169-01e6-4136-a081-60d84e2f3da3",
					"152ad3b2-710d-490a-bb86-8604f2b66435",
					"7977a3aa-4d8a-447e-8cf7-abab094ac86d",
					"3e65987f-c806-4426-83ab-33075cc3cd6b"
				});
				if (num > 0)
				{
					c5x c5x = new ar7(new Guid("cfbd1a15-0b7f-4a1c-a354-ed5ef0d4ef11"), aud).ao() as c5x;
					if (c5x != null)
					{
						t6 aspect = c5x.GetAspect<t6>();
						a3f aspect2 = c5x.GetAspect<a3f>();
						if (aspect2 != null && aspect != null)
						{
							double num2 = 1.0 - (double)num * 0.1;
							aspect.a((int)(10000.0 * num2));
							aspect2.a()["TransitionSpeed"] = (int)(200.0 * num2);
						}
					}
				}
			}
		}
	}
}
