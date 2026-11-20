using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B35 RID: 2869
[eiz("FLS2")]
[Serializable]
public sealed class bck : cze, ISerializable
{
	// Token: 0x06004212 RID: 16914 RVA: 0x00199810 File Offset: 0x00197A10
	private bck(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004213 RID: 16915 RVA: 0x0019981C File Offset: 0x00197A1C
	public bck()
	{
	}

	// Token: 0x06004214 RID: 16916 RVA: 0x00199828 File Offset: 0x00197A28
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			string[] array = new string[]
			{
				"4727b5c3-2a52-41a3-a8c4-7cc201d1b8d8",
				"d5515cee-85f7-4782-a984-f41a7107dacb",
				"a163514f-6a95-49c9-9562-1b91ec3976af",
				"8cb814d9-2bcb-4b44-8055-232649ca803d",
				"160b2620-03e4-40fe-acf7-72989382ac4b"
			};
			for (int i = 0; i < array.Length; i++)
			{
				c5x c5x = new ar7(new Guid(array[i]), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<c3g>();
				}
			}
		}
	}
}
