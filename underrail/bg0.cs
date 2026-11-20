using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020008FA RID: 2298
[eiz("CCGAUNT5")]
[Serializable]
public sealed class bg0 : bdw, ISerializable
{
	// Token: 0x060038D8 RID: 14552 RVA: 0x0015112C File Offset: 0x0014F32C
	private bg0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038D9 RID: 14553 RVA: 0x00151134 File Offset: 0x0014F334
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038DA RID: 14554 RVA: 0x00151138 File Offset: 0x0014F338
	public bg0()
	{
	}

	// Token: 0x060038DB RID: 14555 RVA: 0x00151144 File Offset: 0x0014F344
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
					"d522a119-ad3d-431a-b471-f7a7eb813f69",
					"b2887bbb-6f9c-4b5d-94df-d7139de1cd52",
					"7ef153c6-4d59-4761-9c77-d109c4866002",
					"0a801e5f-71e3-4768-954c-90f603a7ecdc"
				});
				List<csd> list = new List<csd>();
				foreach (csd item in Enumerable.Where<csd>(aud.Zone.Waypoints, new Func<csd, bool>(bg0.a.a.a)))
				{
					list.Add(item);
				}
				int num2 = 1;
				while (num2 <= Math.Min(21, 6 + num * 5) && list.Count != 0)
				{
					int index = cuo.a.Next(list.Count);
					csd csd = list[index];
					list.RemoveAt(index);
					string text = csd.Name.Substring(5);
					int num3;
					if (!string.IsNullOrWhiteSpace(text) && int.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out num3))
					{
						csd csd2 = aud.Zone.g("sto" + num3.ToString());
						if (csd2 != null)
						{
							c5x c5x = Enumerable.FirstOrDefault<b0b>(csd.Tile.c.Values) as c5x;
							if (c5x != null)
							{
								dpj dpj = new dpj(c5x);
								dpj.a(csd2.Tile.Location);
								c5x.SetAspect<dpj>(dpj);
							}
						}
					}
					num2++;
				}
			}
		}
	}

	// Token: 0x020008FB RID: 2299
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060038DE RID: 14558 RVA: 0x0015131C File Offset: 0x0014F51C
		internal bool a(csd A_0)
		{
			return A_0.Name.StartsWith("sfrom");
		}

		// Token: 0x04001B90 RID: 7056
		public static readonly bg0.a a = new bg0.a();

		// Token: 0x04001B91 RID: 7057
		public static Func<csd, bool> b;
	}
}
