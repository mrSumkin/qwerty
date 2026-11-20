using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020009E5 RID: 2533
[eiz("XPHWEBCCO")]
[Serializable]
public sealed class cf6 : bdw, ISerializable
{
	// Token: 0x06003C93 RID: 15507 RVA: 0x00166E38 File Offset: 0x00165038
	private cf6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C94 RID: 15508 RVA: 0x00166E40 File Offset: 0x00165040
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C95 RID: 15509 RVA: 0x00166E44 File Offset: 0x00165044
	public cf6()
	{
	}

	// Token: 0x06003C96 RID: 15510 RVA: 0x00166E50 File Offset: 0x00165050
	public void av(c1a A_0, cyt A_1)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				"cryochamber"
			}))
			{
				cd0 aspect = b0b.GetAspect<cd0>();
				if (aspect != null)
				{
					aspect.b.X = 0;
				}
			}
			foreach (b0b b0b2 in addon.ab4(new string[]
			{
				"observableToRemove"
			}))
			{
				b0b2.w();
				b0b2.an();
			}
			b0b b0b3 = addon.ab5("observableToMove");
			if (b0b3 != null)
			{
				if (A_0.y8().Equals("xphw_exobase_med2"))
				{
					b0b3.Location = new Vector3(5.1f, 19.9f, 0.5f);
				}
				else
				{
					b0b3.Location = new Vector3(42.8f, 18.5f, 0.5f);
				}
				b0b3.ah();
			}
		}
	}
}
