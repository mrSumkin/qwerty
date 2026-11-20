using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008ED RID: 2285
[eiz("UPSETIF")]
[Serializable]
public sealed class qf : bdw, ISerializable
{
	// Token: 0x060038A1 RID: 14497 RVA: 0x0014F608 File Offset: 0x0014D808
	private qf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038A2 RID: 14498 RVA: 0x0014F610 File Offset: 0x0014D810
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038A3 RID: 14499 RVA: 0x0014F614 File Offset: 0x0014D814
	public qf()
	{
	}

	// Token: 0x060038A4 RID: 14500 RVA: 0x0014F620 File Offset: 0x0014D820
	public void av(c1a A_0, cyt A_1)
	{
		if (am9.c())
		{
			d60 addon = A_0.GetAddon<d60>();
			if (addon != null)
			{
				if (A_0.y8() == "up-ww")
				{
					if (new ar7(new Guid("3bfad328-52b6-47b3-a95b-7464abd5e513"), A_0.n("up-ww")).ao() is c5x)
					{
						return;
					}
					doq a_ = doq.a(Path.Combine(d5x.q(), "up-ww_l3") + ".uzl");
					A_0.a(a_, 1, null);
					using (List<b0b>.Enumerator enumerator = addon.ab4(new string[]
					{
						"уничтожена"
					}).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							b0b b0b = enumerator.Current;
							c5x c5x = (c5x)b0b;
							c5x.w();
							c5x.an();
						}
						return;
					}
				}
				bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_up_lunaticStairmaker_dead", new bool?(false)).Value;
				List<b0b> list = addon.ab4(new string[]
				{
					"lunaticStairmakerAudioSource"
				});
				if (!Enumerable.Any<b0b>(list) && !value)
				{
					string str = (A_0.y8() == "up1") ? "_l2" : "_l3";
					doq a_2 = doq.a(Path.Combine(d5x.q(), A_0.y8() + str) + ".uzl");
					A_0.a(a_2, 1, null);
					return;
				}
				if (Enumerable.Any<b0b>(list) && value)
				{
					foreach (b0b b0b2 in list)
					{
						c5x c5x2 = (c5x)b0b2;
						c5x2.w();
						c5x2.an();
					}
				}
			}
		}
	}
}
